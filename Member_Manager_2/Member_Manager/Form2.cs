using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using KjsLibrary;

namespace Member_Manager
{
    public partial class Form2 : Form
    {
        Form form1;
        Crud crud;
        DuplicatedFunction duplicatedFunction;
        SqlQuery sqlQuery;
        Button[] buttons;

        string memberId;
        public Form2(Form form1, string memberId, Crud crud, DuplicatedFunction duplicatedFunction, SqlQuery sqlQuery)
        {
            InitializeComponent();

            this.crud = crud;
            this.form1 = form1;
            this.duplicatedFunction = duplicatedFunction;

            this.memberId = memberId;

            this.sqlQuery = sqlQuery;

            this.buttons = new Button[] { this.buttonCreateMember, this.buttonReadMember, buttonUpdateMember, buttonDeleteMember, buttonReadChart, buttonReadStatistics };
        }


        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form1.Visible = true;
        }

        private void buttonCreateMember_Click(object sender, EventArgs e)
        {
            //오른쪽 4개 버튼 감추기
            duplicatedFunction.toggleButton(false, buttons);


            panelMain.Visible = true;

            Member member = new Member();
            Type type = typeof(Member);
            PropertyInfo[] propertyInfos = type.GetProperties();
            //label, textbox 생성
            duplicatedFunction.ListLabelAndText = duplicatedFunction.MakeLabelAndText(propertyInfos.Count(), member);
            //button text 변경
            List<string> listName = new List<string>();
            listName.Add("적용");
            listName.Add("닫기");
            duplicatedFunction.ListName = listName;

            //적용 버튼 콜백함수
            List<EventHandler> listEventHadler = new List<EventHandler>();

            listEventHadler.Add((s, args) =>
            {
                string[] values = { duplicatedFunction.ListLabelAndText[0].Item2.Text };
                string qeuryCreate = sqlQuery.InsertInto__Values_(SqlQuery.MEMBER);
                string qeuryReadMember = sqlQuery.SelectAllFrom_Where_(SqlQuery.MEMBER, values, "ID");
                string queryReadRowNum = sqlQuery.selectAllFrom_WhereRowNumSelect_RowNumFrom_(SqlQuery.MEMBER, SqlQuery.MAX);

                Member memberResult = crud.Read(qeuryReadMember, member);

                Member memberMaxRownum = crud.Read(queryReadRowNum, member);

                if (memberResult.Id != null)
                {
                    MessageBox.Show("아이디 중복 확인");
                    duplicatedFunction.listLabelAndTextClear();
                }
                else
                {
                    member = new Member()
                    {
                        Id = duplicatedFunction.ListLabelAndText[0].Item2.Text,
                        Password = duplicatedFunction.ListLabelAndText[1].Item2.Text,
                        Name = duplicatedFunction.ListLabelAndText[2].Item2.Text,
                        Phone = duplicatedFunction.ListLabelAndText[3].Item2.Text,
                        Email = duplicatedFunction.ListLabelAndText[4].Item2.Text,
                        Position = duplicatedFunction.ListLabelAndText[5].Item2.Text,
                        Rownum = memberMaxRownum.Rownum + 1
                    };
                    if (crud.Create(qeuryCreate, member) != -1)
                    {
                        MessageBox.Show("등록 확인");
                        panelMain.Controls.Clear();

                        Button[] buttonsResult = duplicatedFunction.toggleButton(true, buttons);
                        for (int i = 0; i < buttons.Count(); i++)
                        {
                            buttons[i] = buttonsResult[i];
                        }
                        panelMain.Visible = false;


                    }
                    else
                    {
                        MessageBox.Show("등록 실패");
                        duplicatedFunction.listLabelAndTextClear();
                    }
                }
            });

            //닫기 버튼 콜백함수
            listEventHadler.Add((s, args) =>
            {
                MessageBox.Show("창닫기 확인");
                panelMain.Controls.Clear();
                //오른쪽 4개 버튼드러내기
                duplicatedFunction.toggleButton(true, buttons);
                panelMain.Visible = false;
            });

            duplicatedFunction.ListEventHandler = listEventHadler;

            //버튼 생성
            duplicatedFunction.MakeButton(2);
            duplicatedFunction.panelAdd(panelMain);


        }

        private void buttonReadMember_Click(object sender, EventArgs e)
        {
            duplicatedFunction.toggleButton(false, buttons);

            //datagrid생성
            DataGridView dataGridViewMember = new DataGridView();
            dataGridViewMember.Location = new Point(0, 0);
            dataGridViewMember.Size = new Size(700, 300);

            DataGridView dataGridViewMemberHistory = new DataGridView();
            dataGridViewMemberHistory.Location = new Point(0, 300);
            dataGridViewMemberHistory.Size = new Size(700, 100);

            //0table(MEMBER)에서 모든 데이터 읽어 dataset에 할당
            DataSet dataSet = crud.ReadToGrid(sqlQuery.SelectAllFrom_(SqlQuery.MEMBER));

            // dataset의 정보 datagrid로 바인드
            dataGridViewMember.DataSource = dataSet.Tables[0];

            //datagrid의 cell클릭시 콜백함수
            dataGridViewMember.CellClick += (s, ea) => { dataGridViewMember_CellClick(s, ea); };

            //창닫기 버튼 생성 및 콜백함수
            Button btnCancle = new Button();
            btnCancle.Text = "창닫기";
            btnCancle.Location = new Point(700, 400);
            btnCancle.Click += (se, ev) =>
            {
                MessageBox.Show("창닫기 확인");
                panelMain.Controls.Clear();
                duplicatedFunction.toggleButton(true, buttons);
                panelMain.Visible = false;
            };


            panelMain.Controls.Add(dataGridViewMember);
            panelMain.Controls.Add(btnCancle);
            panelMain.Controls.Add(dataGridViewMemberHistory);

            panelMain.Visible = true;
        }


        private void dataGridViewMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridViewMember = sender as DataGridView;
            //key를 숫자로 하면 밀리지 않음
            //e로 row인덱스를 받음
            string[] values = { (string)(dataGridViewMember.Rows[e.RowIndex].Cells["ID"].Value) };
            string qeury = sqlQuery.SelectAllFrom_Where_(SqlQuery.MEMBERHISTORY, values, "MEMBERID");
            DataSet dataSet = crud.ReadToGrid(qeury);

            DataGridView dataGridViewMemberHistory = new DataGridView();
            dataGridViewMemberHistory.Location = new Point(0, 300);
            dataGridViewMemberHistory.Size = new Size(700, 100);

            if (dataSet.Tables.Count != 0)
            {
                dataGridViewMemberHistory.DataSource = dataSet.Tables[0];
                panelMain.Controls.RemoveAt(panelMain.Controls.Count -1);
                panelMain.Controls.Add(dataGridViewMemberHistory);
            }
            
            

        }

        private void buttonUpdateMember_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;

            //create와 거의 비슷하게 반복됨
            Member member = new Member();
            Type type = typeof(Member);
            PropertyInfo[] propertyInfos = type.GetProperties();
            duplicatedFunction.ListLabelAndText = duplicatedFunction.MakeLabelAndText(propertyInfos.Count(), member);

            List<string> listName = new List<string>();
            listName.Add("적용");
            listName.Add("닫기");
            duplicatedFunction.ListName = listName;


            List<EventHandler> listEventHadler = new List<EventHandler>();
            //적용 버튼의 콜백함수가 조금 다름
            listEventHadler.Add((s, args) =>
            {
                string queryupdate = sqlQuery.Update_Set_(SqlQuery.MEMBER);
                string[] values = { duplicatedFunction.ListLabelAndText[0].Item2.Text };
                string queryReadMember = sqlQuery.SelectAllFrom_Where_(SqlQuery.MEMBER, values, "ID");

                Member memberResult = crud.Read(queryReadMember, member);

                member = new Member
                {
                    Id = duplicatedFunction.ListLabelAndText[0].Item2.Text,
                    Password = duplicatedFunction.ListLabelAndText[1].Item2.Text,
                    Name = duplicatedFunction.ListLabelAndText[2].Item2.Text,
                    Phone = duplicatedFunction.ListLabelAndText[3].Item2.Text,
                    Email = duplicatedFunction.ListLabelAndText[4].Item2.Text,
                    Position = duplicatedFunction.ListLabelAndText[5].Item2.Text,
                    Rownum = memberResult.Rownum
                };


                if (memberResult.Id == null)
                {
                    MessageBox.Show("변경 불가");
                    duplicatedFunction.listLabelAndTextClear();
                }
                else
                {
                    if (crud.Update(queryupdate, member) != -1)
                    {
                        MessageBox.Show("변경 확인");
                        panelMain.Controls.Clear();
                        duplicatedFunction.toggleButton(true, buttons);
                        panelMain.Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("변경 실패");
                        duplicatedFunction.listLabelAndTextClear();
                    }
                }
            });
            //반복되는 닫기 콜백함수 리팩토링 필요
            listEventHadler.Add((s, args) =>
            {
                MessageBox.Show("창닫기 확인");
                panelMain.Controls.Clear();
                duplicatedFunction.toggleButton(true, buttons);
                panelMain.Visible = false;
            });

            duplicatedFunction.ListEventHandler = listEventHadler;

            duplicatedFunction.MakeButton(2);
            duplicatedFunction.panelAdd(panelMain);

        }

        private void buttonDeleteMember_Click(object sender, EventArgs e)
        {

            duplicatedFunction.toggleButton(false, buttons);

            Label labelId = new Label();
            labelId.Text = "Id";
            labelId.Location = new Point(0, 0);


            TextBox textBoxNewId = new TextBox();
            textBoxNewId.Location = new Point(100, 0);

            Button btnCreate = new Button();
            btnCreate.Text = "회원 삭제";
            btnCreate.Location = new Point(300, 0);

            //delete 콜백함수
            btnCreate.Click += (se, ev) =>
            {
                string qeuryDelete = sqlQuery.deleteFrom_Where_(SqlQuery.MEMBER);
                string[] values = { textBoxNewId.Text };
                string qeuryReadMember = sqlQuery.SelectAllFrom_Where_(SqlQuery.MEMBER, values, "ID");

                Member member = new Member
                {
                    Id = textBoxNewId.Text,
                };

                Member memberResult = crud.Read(qeuryReadMember, member);

                if (memberResult.Id == null)
                {
                    MessageBox.Show("삭제 불가");
                    textBoxNewId.Text = "";
                }
                else
                {
                    if (crud.Delete(qeuryDelete, member) != -1)
                    {
                        MessageBox.Show("삭제 확인");
                        panelMain.Controls.Clear();
                        duplicatedFunction.toggleButton(true, buttons);
                        panelMain.Visible = false;


                    }
                    else
                    {
                        MessageBox.Show("삭제 실패");
                        textBoxNewId.Text = "";
                    }
                }
            };

            //창닫기 여기는 duplicateFuction을 사용하지 않음
            Button btnCancle = new Button();
            btnCancle.Text = "창닫기";
            btnCancle.Location = new Point(300, 60);
            btnCancle.Click += (se, ev) =>
            {
                MessageBox.Show("창닫기 확인");
                panelMain.Controls.Clear();
                duplicatedFunction.toggleButton(true, buttons);
                panelMain.Visible = false;
            };


            panelMain.Controls.Add(textBoxNewId);
            panelMain.Controls.Add(labelId);
            panelMain.Controls.Add(btnCreate);
            panelMain.Controls.Add(btnCancle);

            panelMain.Visible = true;
        }




        private void buttonReadChart_Click(object sender, EventArgs e)
        {
            duplicatedFunction.toggleButton(false, buttons);

            //datagrid 생성
            DataGridView dataGridViewMember = new DataGridView();
            dataGridViewMember.Location = new Point(0, 0);
            dataGridViewMember.Size = new Size(700, 200);

            string qeuryReadAll = sqlQuery.SelectAllFrom_(SqlQuery.MEMBERHISTORY);
            DataSet dataSet = crud.ReadToGrid(qeuryReadAll);

            dataGridViewMember.DataSource = dataSet.Tables[0];

            //check컬럼생성
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.ValueType = typeof(bool);
            checkColumn.Name = "Chk";
            checkColumn.HeaderText = "CheckBox";
            dataGridViewMember.Columns.Add(checkColumn);
            List<string> memberIdList = new List<string>();


            //chart 생성
            Chart chart = new Chart();
            chart.Location = new Point(0, 200);
            chart.Size = new Size(700, 200);


            //chartarea추가 (이거없으면 차트 안보임)
            chart.ChartAreas.Add("Draw");

            //series에 데이터 할당
            chart.DataSource = dataSet;

            chart.Series.Add("x");
            //chart 타입변경
            chart.Series["x"].ChartType = SeriesChartType.Column;
            //x축
            chart.Series["x"].XValueMember = "MEMBERID";
            //y축
            chart.Series["x"].YValueMembers = "ACTIVITY";

            //dataset사용시 바인딩 필수
            chart.DataBind();

            //데이터 변경을 위한 listbox
            ListBox listBoxColumn = new ListBox();
            listBoxColumn.Items.Add("ACTIVITY");
            listBoxColumn.Items.Add("LASTLOGIN");
            listBoxColumn.Items.Add("LASTLOGOUT");

            listBoxColumn.Location = new Point(700, 100);
            //리스트 선택 바뀔 시 콜백함수
            listBoxColumn.SelectedIndexChanged += (se, ev) =>
            {
                string[] items = { "POINT", "WRITING", "ACTIVITY"};
                string item = listBoxColumn.Text;

                if (item == items[0])
                {
                    chart.Series["x"].YValueMembers = items[0];
                    chart.DataBind();
                }
                else if (item == items[1])
                {
                    chart.Series["x"].YValueMembers = items[1];
                    chart.DataBind();
                }
                else if (item == items[2])
                {
                    chart.Series["x"].YValueMembers = items[2];
                    chart.DataBind();
                }
            };


            // 차트 생성
            ListBox listBoxChat = new ListBox();
            listBoxChat.Items.Add("Column");
            listBoxChat.Items.Add("Pie");
            listBoxChat.Items.Add("FastLine");
            listBoxChat.Items.Add("Area");
            listBoxChat.Items.Add("Bar");
            listBoxChat.Location = new Point(700, 200);
            //차트 타입 변경을 위한 콜백
            listBoxChat.SelectedIndexChanged += (se, ev) =>
            {
                string[] items = { "Column", "Pie", "FastLine", "Area", "Bar" };
                string item = listBoxChat.SelectedItem.ToString();
                if (item == items[0])
                {
                    chart.Series["x"].ChartType = SeriesChartType.Column;
                }
                else if (item == items[1])
                {
                    chart.Series["x"].ChartType = SeriesChartType.Pie;
                }
                else if (item == items[2])
                {
                    chart.Series["x"].ChartType = SeriesChartType.FastLine;
                    chart.Series["x"].BorderWidth = 5;
                }
                else if (item == items[3])
                {
                    chart.Series["x"].ChartType = SeriesChartType.Area;
                }
                else if (item == items[4])
                {
                    chart.Series["x"].ChartType = SeriesChartType.Bar;
                }
            };

            //check박스 checked 이벤트 => 차트 변경
            dataGridViewMember.CellContentClick += (s, ev) =>
            {
                //체크가 true인지
                if ((bool)(dataGridViewMember.Rows[ev.RowIndex].Cells[0].EditedFormattedValue ?? false) == true)
                {
                    memberIdList.Add((string)dataGridViewMember.Rows[ev.RowIndex].Cells["MEMBERID"].Value);
                    Console.WriteLine("true");
                }
                else if ((bool)(dataGridViewMember.Rows[ev.RowIndex].Cells[0].EditedFormattedValue ?? false) == false)
                {
                    memberIdList.Remove((string)dataGridViewMember.Rows[ev.RowIndex].Cells["MEMBERID"].Value);
                    Console.WriteLine("false");
                }
                // 모든체크 해제시 원래의 dataset으로
                if (memberIdList.Count != 0)
                {
                    string querySelectWhere = sqlQuery.selectAllFrom_Where_In_(SqlQuery.MEMBERHISTORY, 5, memberIdList);
                    DataSet dataSetWhereMemberID = crud.ReadToGrid(querySelectWhere);

                    chart.DataSource = dataSetWhereMemberID;
                    chart.DataBind();
                }
                else
                {
                    chart.DataSource = dataSet;
                    chart.DataBind();
                }





            };


            //버튼 생성 --반복됨
            Button btnCancle = new Button();
            btnCancle.Text = "창닫기";
            btnCancle.Location = new Point(700, 400);
            btnCancle.Click += (se, ev) =>
            {
                MessageBox.Show("창닫기 확인");
                panelMain.Controls.Clear();
                duplicatedFunction.toggleButton(true, buttons);
                panelMain.Visible = false;
            };


            panelMain.Controls.Add(dataGridViewMember);
            panelMain.Controls.Add(btnCancle);
            panelMain.Controls.Add(listBoxColumn);
            panelMain.Controls.Add(listBoxChat);
            panelMain.Controls.Add(chart);

            panelMain.Visible = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxId.Text = memberId;
        }

        //통계 조회
        private void button1_Click(object sender, EventArgs e)
        {
            duplicatedFunction.toggleButton(false, buttons);

            //datagrid 생성
            DataGridView dataGridViewMemberHistory = new DataGridView();
            dataGridViewMemberHistory.Location = new Point(0, 0);
            dataGridViewMemberHistory.Size = new Size(700, 200);

            string qeuryReadAll = sqlQuery.SelectAllFrom_(SqlQuery.MEMBERHISTORY);
            DataSet dataSet = crud.ReadToGrid(qeuryReadAll);

            dataGridViewMemberHistory.DataSource = dataSet.Tables[0];

            //check컬럼생성
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.ValueType = typeof(bool);
            checkColumn.Name = "Chk";
            checkColumn.HeaderText = "CheckBox";
            dataGridViewMemberHistory.Columns.Add(checkColumn);

            Label sumLabel = new Label();
            sumLabel.Location = new Point(100, 400);
            sumLabel.Text = "sumClick";
            TextBox sumText = new TextBox();
            sumText.Location = new Point(200, 400);

            Label sumLabel2 = new Label();
            sumLabel2.Location = new Point(300, 400);
            sumLabel2.Text = "sumCheck";
            TextBox sumText2 = new TextBox();
            sumText2.Location = new Point(400, 400);

            ListBox listBoxColumn = new ListBox();
            listBoxColumn.Location = new Point(700, 300);
            listBoxColumn.Items.Add("POINT");
            listBoxColumn.Items.Add("WRITING");
            listBoxColumn.Items.Add("ACTIVITY");

            List<int> RowList = new List<int>();
            //클릭 콜백

            dataGridViewMemberHistory.CellClick += (s, ev) =>
            {
                int sum = 0;

                for(int i = 0; i < ev.ColumnIndex; i++)
                {
                    sum += Convert.ToInt32(dataGridViewMemberHistory.Rows[ev.RowIndex].Cells[i].Value);
                }
                for (int i = 0; i < ev.RowIndex + 1; i++)
                {
                    sum += Convert.ToInt32(dataGridViewMemberHistory.Rows[i].Cells[ev.ColumnIndex].Value);
                }

                sumText.Text = Convert.ToString(sum);

            };

            dataGridViewMemberHistory.CellContentClick += (s, ev) =>
            {
                

                //체크가 true인지
                if ((bool)(dataGridViewMemberHistory.Rows[ev.RowIndex].Cells[0].EditedFormattedValue ?? false) == true)
                {
                    RowList.Add(ev.RowIndex);
                }
                else if ((bool)(dataGridViewMemberHistory.Rows[ev.RowIndex].Cells[0].EditedFormattedValue ?? false) == false)
                {
                    RowList.Remove(ev.RowIndex);
                }
                string column = listBoxColumn.Text;

                sumText2.Text = "";
                int sum = 0;
                foreach ( var v in RowList)
                {
                    if (column != null && column != "")
                    {
                        sum += (int)dataGridViewMemberHistory.Rows[v].Cells[column].Value;
                    }
                    
                    
                }
                sumText2.Text = Convert.ToString(sum);

            };



            Button btnCancle = new Button();
            btnCancle.Text = "창닫기";
            btnCancle.Location = new Point(700, 400);
            btnCancle.Click += (se, ev) =>
            {
                MessageBox.Show("창닫기 확인");
                panelMain.Controls.Clear();
                duplicatedFunction.toggleButton(true, buttons);
                panelMain.Visible = false;
            };

            panelMain.Controls.Add(dataGridViewMemberHistory);
            panelMain.Controls.Add(sumLabel);
            panelMain.Controls.Add(sumText);
            panelMain.Controls.Add(sumLabel2);
            panelMain.Controls.Add(listBoxColumn);
            panelMain.Controls.Add(sumText2);
            panelMain.Controls.Add(btnCancle);

            panelMain.Visible = true;

        }

        private void buttonRead2_Click(object sender, EventArgs e)
        {
            duplicatedFunction.toggleButton(false, buttons);

            //datagrid 생성
            DataGridView dataGridView = new DataGridView();
            dataGridView.Location = new Point(0, 0);
            dataGridView.Size = new Size(700, 300);



            //테이블 선택 버튼

            List<string> listName = new List<string>();
            listName.Add("MEMBER");
            listName.Add("MEMBERHISTORY");
            duplicatedFunction.ListName = listName;


            ListBox listBoxTable = new ListBox();
            listBoxTable.Items.Add("MEMBER");
            listBoxTable.Items.Add("MEMBERHISTORY");
            listBoxTable.Location = new Point(700, 200);
            //테이블 변경을 위한 콜백
            listBoxTable.SelectedIndexChanged += (se, ev) =>
            {
                Member member = new Member();
                MemberHistory memberHistory = new MemberHistory();

                string queryReadMemberMaxRownum = sqlQuery.selectAllFrom_WhereRowNumSelect_RowNumFrom_(SqlQuery.MEMBER, SqlQuery.MAX);
                string queryReadMemberHistoryMaxRownum = sqlQuery.selectAllFrom_WhereRowNumSelect_RowNumFrom_(SqlQuery.MEMBERHISTORY, SqlQuery.MAX);

                Member memberMaxRownum = crud.Read(queryReadMemberMaxRownum, member);
                MemberHistory memberHistoryMaxRownum = crud.Read(queryReadMemberHistoryMaxRownum, memberHistory);


                string queryRead20 = "";

                if (listBoxTable.Text == "MEMBER")
                {
                    queryRead20 = sqlQuery.selectAllFrom_Where_Between_And_(SqlQuery.MEMBER, 6, memberMaxRownum.Rownum);
                }
                else if (listBoxTable.Text == "MEMBERHISTORY")
                {
                    queryRead20 = sqlQuery.selectAllFrom_Where_Between_And_(SqlQuery.MEMBERHISTORY, 6, memberHistoryMaxRownum.Rownum);
                }

                DataSet dataSet = crud.ReadToGrid(queryRead20);

                dataSet.Tables[0].DefaultView.Sort = "ROWNUM DESC";

                dataGridView.DataSource = dataSet.Tables[0];


            };

            //이동 버튼
            Button btnFirst = new Button();
            Button btnLast = new Button();
            Button btnNext = new Button();
            Button btnPrev = new Button();
            Button btnOneOfFive = new Button();
            Button btnTwoOfFive = new Button();
            Button btnThreeOfFive = new Button();
            Button btnFourOfFive = new Button();
            Button btnFiveOfFive = new Button();

            btnFirst.Text = "<<";
            btnLast.Text = ">>";
            btnNext.Text = ">";
            btnPrev.Text = "<";
            btnOneOfFive.Text = "1";
            btnTwoOfFive.Text = "2";
            btnThreeOfFive.Text = "3";
            btnFourOfFive.Text = "4";
            btnFiveOfFive.Text = "5";

            btnFirst.Size = new Size(30, 30);
            btnOneOfFive.Size = new Size(30, 30);
            btnTwoOfFive.Size = new Size(30, 30);
            btnThreeOfFive.Size = new Size(30, 30);
            btnFourOfFive.Size = new Size(30, 30);
            btnFiveOfFive.Size = new Size(30, 30);
            btnLast.Size = new Size(30, 30);
            btnNext.Size = new Size(30, 30);
            btnPrev.Size = new Size(30, 30);

            btnFirst.Location = new Point(200, 350);
            btnPrev.Location = new Point(230, 350);
            btnOneOfFive.Location = new Point(260, 350);
            btnTwoOfFive.Location = new Point(290, 350);
            btnThreeOfFive.Location = new Point(320, 350);
            btnFourOfFive.Location = new Point(350, 350);
            btnFiveOfFive.Location = new Point(380, 350);
            btnNext.Location = new Point(410, 350);
            btnLast.Location = new Point(440, 350);

            btnFirst.Click += (s, ev) => btn_Click(s, e);
            btnPrev.Click += (s, ev) => btn_Click(s, e);
            btnOneOfFive.Click += (s, ev) => btn_Click(s, e);
            btnTwoOfFive.Click += (s, ev) => btn_Click(s, e);
            btnThreeOfFive.Click += (s, ev) => btn_Click(s, e);
            btnFourOfFive.Click += (s, ev) => btn_Click(s, e);
            btnFiveOfFive.Click += (s, ev) => btn_Click(s, e);
            btnNext.Click += (s, ev) => btn_Click(s, e);
            btnLast.Click += (s, ev) => btn_Click(s, e);


            //닫기 버튼
            Button btnCancle = new Button();
            btnCancle.Text = "창닫기";
            btnCancle.Location = new Point(700, 400);
            btnCancle.Click += (se, ev) =>
            {
                MessageBox.Show("창닫기 확인");
                panelMain.Controls.Clear();
                duplicatedFunction.toggleButton(true, buttons);
                panelMain.Visible = false;
            };

            panelMain.Controls.Add(dataGridView);
            panelMain.Controls.Add(listBoxTable);
            panelMain.Controls.Add(btnCancle);

            panelMain.Controls.Add(btnFirst);
            panelMain.Controls.Add(btnLast);
            panelMain.Controls.Add(btnNext);
            panelMain.Controls.Add(btnPrev);
            panelMain.Controls.Add(btnOneOfFive);
            panelMain.Controls.Add(btnTwoOfFive);
            panelMain.Controls.Add(btnThreeOfFive);
            panelMain.Controls.Add(btnFourOfFive);
            panelMain.Controls.Add(btnFiveOfFive);

            panelMain.Visible = true;

            void btn_Click(object s, EventArgs ev)
            {
                Button button = s as Button;

                Member member = new Member();
                MemberHistory memberHistory = new MemberHistory();
                string queryReadMax;
                int maxRownum;
                int tableNumber;

                if (listBoxTable.Text == "MEMBER")
                {
                    tableNumber = 0;
                    queryReadMax = sqlQuery.selectAllFrom_WhereRowNumSelect_RowNumFrom_(SqlQuery.MEMBER, SqlQuery.MAX);
                    Member memberMaxRownum = crud.Read(queryReadMax, member);
                    maxRownum = memberMaxRownum.Rownum;

                }
                else
                {
                    tableNumber = 1;
                    queryReadMax = sqlQuery.selectAllFrom_WhereRowNumSelect_RowNumFrom_(SqlQuery.MEMBERHISTORY, SqlQuery.MAX);
                    MemberHistory memberHistoryMaxRownum = crud.Read(queryReadMax, memberHistory);
                    maxRownum = memberHistoryMaxRownum.Rownum;

                }

                

                



                string queryRead20 = "";

                if (button.Text == "<<" )
                {
                    //최상위 20
                    queryRead20 = sqlQuery.selectAllFrom_Where_Between_And_(tableNumber, 6, maxRownum);

                }
                else if (button.Text == ">>")
                {
                    //최하위 20
                    queryRead20 = sqlQuery.selectAllFrom_Where_Between_And_(tableNumber, 6, 20);
                }
                else if (button.Text == "<")
                {
                    //text가 6이상일떄만  버튼text -5
                    if (Convert.ToInt32(btnOneOfFive.Text) > 5)
                    {
                        btnOneOfFive.Text = Convert.ToString(Convert.ToInt32(btnOneOfFive.Text) - 5);
                        btnTwoOfFive.Text = Convert.ToString(Convert.ToInt32(btnTwoOfFive.Text) - 5);
                        btnThreeOfFive.Text = Convert.ToString(Convert.ToInt32(btnThreeOfFive.Text) - 5);
                        btnFourOfFive.Text = Convert.ToString(Convert.ToInt32(btnFourOfFive.Text) - 5);
                        btnFiveOfFive.Text = Convert.ToString(Convert.ToInt32(btnFiveOfFive.Text) - 5);
                    }
                    return;

                }
                else if (button.Text == ">")
                {
                    //maxrownum//5까지뿌리도록 버튼 text +5
                    if (Convert.ToInt32(btnFiveOfFive.Text) * 20 < maxRownum)
                    {
                        btnOneOfFive.Text = Convert.ToString(Convert.ToInt32(btnOneOfFive.Text) + 5);
                        btnTwoOfFive.Text = Convert.ToString(Convert.ToInt32(btnTwoOfFive.Text) + 5);
                        btnThreeOfFive.Text = Convert.ToString(Convert.ToInt32(btnThreeOfFive.Text) + 5);
                        btnFourOfFive.Text = Convert.ToString(Convert.ToInt32(btnFourOfFive.Text) + 5);
                        btnFiveOfFive.Text = Convert.ToString(Convert.ToInt32(btnFiveOfFive.Text) + 5);
                    }
                    return;
                }
                else
                {
                    int x = Convert.ToInt32(button.Text);
                    //버튼1 max - 19 ~ max
                    //버튼2 (max - 39) ~ (max - 20)
                    //...
                    //버튼x (max - x*20 -1) ~ (max - 20*(x-1))
                    //x가 maxrownum//5가 될때는 남은 만큼 처리
                    int page = maxRownum - 20 * (x - 1);
                    queryRead20 = sqlQuery.selectAllFrom_Where_Between_And_(tableNumber, 6, page);
                }


                
                DataSet dataSet = crud.ReadToGrid(queryRead20);

                dataSet.Tables[0].DefaultView.Sort = "ROWNUM DESC";

                dataGridView.DataSource = dataSet.Tables[0];
            }

        }
    }
}
