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
    public partial class Form3 : Form
    {
        private Form1 form1;
        private string memberId;
        private Crud crud;
        private DuplicatedFunction duplicatedFunction;
        SqlQuery sqlQuery;


        public Form3(Form1 form1, string memberId, Crud crud, DuplicatedFunction duplicatedFunction, SqlQuery sqlQuery)
        {
            InitializeComponent();

            this.form1 = form1;
            this.memberId = memberId;
            this.crud = crud;
            this.duplicatedFunction = duplicatedFunction;

            this.sqlQuery = sqlQuery;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form1.Visible = true;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MemberHistory memberHistory = new MemberHistory();
            string[] values = { memberId };
            string qeuryReadMemberHistory = sqlQuery.SelectAllFrom_Where_("MEMBERHISTORY", "MEMBERID", values);
            memberHistory = crud.Read(qeuryReadMemberHistory, memberHistory);

            textBoxId.Text = memberId;
            textBoxPoint.Text = Convert.ToString(memberHistory.Point);
            textBoxWriting.Text = Convert.ToString(memberHistory.Writing);
            textBoxActivity.Text = Convert.ToString(memberHistory.Activity);
        }


        //변경 업데이트
        private void buttonUpdateMember_Click(object sender, EventArgs e)
        {
            panelMain2.Controls.Clear();

            // 라벨과 텍스트 및 버튼을 만들어 패널에 뿌려줌
            Member member = new Member();
            Type type = typeof(Member);
            PropertyInfo[] propertyInfos = type.GetProperties();
            duplicatedFunction.ListLabelAndText = duplicatedFunction.MakeLabelAndText(propertyInfos.Count(), member, new Point(170, 40), new Point(270, 40));

            List<string> listName = new List<string>();
            listName.Add("적용");
            listName.Add("닫기");
            duplicatedFunction.ListName = listName;

            string[] values = { memberId };
            // 조회결과 뿌려주기
            string qeuryReadMember = sqlQuery.SelectAllFrom_Where_("MEMBER", "ID", values);

            member = crud.Read(qeuryReadMember, member);

            duplicatedFunction.ListLabelAndText[0].Item2.Text = member.Id;
            duplicatedFunction.ListLabelAndText[0].Item2.ReadOnly = true;
            duplicatedFunction.ListLabelAndText[1].Item2.Text = member.Password;
            duplicatedFunction.ListLabelAndText[2].Item2.Text = member.Name;
            duplicatedFunction.ListLabelAndText[3].Item2.Text = member.Phone;
            duplicatedFunction.ListLabelAndText[4].Item2.Text = member.Email;
            duplicatedFunction.ListLabelAndText[5].Item2.Text = member.Position;

            List<EventHandler> listEventHadler = new List<EventHandler>();

            // 업데이트 적용버튼
            listEventHadler.Add((s, args) =>
            {
                string qeuryUpdate = sqlQuery.Update_Set_("MEMBER");

                member = new Member
                {
                    Id = duplicatedFunction.ListLabelAndText[0].Item2.Text,
                    Password = duplicatedFunction.ListLabelAndText[1].Item2.Text,
                    Name = duplicatedFunction.ListLabelAndText[2].Item2.Text,
                    Phone = duplicatedFunction.ListLabelAndText[3].Item2.Text,
                    Email = duplicatedFunction.ListLabelAndText[4].Item2.Text,
                    Position = duplicatedFunction.ListLabelAndText[5].Item2.Text,
                    Rownum = member.Rownum
                };

                Member memberResult = crud.Read(qeuryReadMember, member);


                if (memberResult.Id == null)
                {
                    MessageBox.Show("변경 불가");
                    duplicatedFunction.listLabelAndTextClear();
                    
                }
                else
                {
                    if (crud.Update(qeuryUpdate, (Member)member) != -1)
                    {
                        MessageBox.Show("변경 확인");
                        panelMain2.Controls.Clear();


                    }
                    else
                    {
                        MessageBox.Show("변경 실패");
                        duplicatedFunction.listLabelAndTextClear();
                    }
                }


            });
            //창닫기 버튼
            listEventHadler.Add((s, args) =>
            {
                MessageBox.Show("창닫기 확인");
                panelMain2.Controls.Clear();
            });

            duplicatedFunction.ListEventHandler = listEventHadler;

            Point[] arrayPoint = { new Point(170, 250), new Point(270, 250) };
            duplicatedFunction.MakeButton(2, arrayPoint);
            duplicatedFunction.panelAdd(panelMain2);

            



        }

        //삭제 탈퇴
        private void buttonDeleteMember_Click(object sender, EventArgs e)
        {
            panelMain2.Controls.Clear();

            Member member = new Member();
            Type type = typeof(Member);
            PropertyInfo[] propertyInfos = type.GetProperties();
            //ID만 보여주고싶어서 한개만 만듬 ( 내부적으로 -1해버림)
            duplicatedFunction.ListLabelAndText = duplicatedFunction.MakeLabelAndText(2, member, new Point(170, 40), new Point(270, 40));

            duplicatedFunction.ListLabelAndText[0].Item2.Text = memberId;

            List<string> listName = new List<string>();
            listName.Add("적용");
            listName.Add("닫기");
            duplicatedFunction.ListName = listName;

            List<EventHandler> listEventHadler = new List<EventHandler>();

            listEventHadler.Add((s, args) =>
            {
                string qeuryDelete = sqlQuery.deleteFrom_Where_("MEMBER");
                member = new Member();
                member.Id = memberId;
                int result = crud.Delete(qeuryDelete, (Member)member);
                if (result != -1)
                {
                    MessageBox.Show("삭제 완료");
                    panelMain2.Controls.Clear();
                    buttonLogOut_Click(sender, e);


                }
                else
                {
                    Console.WriteLine(result);
                    MessageBox.Show("변경 실패");
                    duplicatedFunction.ListLabelAndText[1].Item2.Text = member.Password;
                    duplicatedFunction.ListLabelAndText[2].Item2.Text = member.Name;
                    duplicatedFunction.ListLabelAndText[3].Item2.Text = member.Phone;
                    duplicatedFunction.ListLabelAndText[4].Item2.Text = member.Email;
                    duplicatedFunction.ListLabelAndText[5].Item2.Text = member.Position;
                }
            });
            listEventHadler.Add((s, args) =>
            {
                MessageBox.Show("창닫기 확인");
                panelMain2.Controls.Clear();
            });

            duplicatedFunction.ListEventHandler = listEventHadler;

            Point[] arrayPoint = { new Point(170, 250), new Point(270, 250) };
            duplicatedFunction.MakeButton(2, arrayPoint);


            duplicatedFunction.panelAdd(panelMain2);
        }

        //히스토리
        private void buttonReadMember_Click(object sender, EventArgs e)
        {
            panelMain2.Controls.Clear();

            DataGridView dataGridViewMember = new DataGridView();
            dataGridViewMember.Location = new Point(0, 0);
            dataGridViewMember.Size = new Size(597, 400);


            string[] values = { memberId };
            string qeuryReadAll = sqlQuery.SelectAllFrom_Where_("MEMBERHISTORY", "MEMBERID", values);
            DataSet dataSet = crud.ReadToGrid(qeuryReadAll);

            dataGridViewMember.DataSource = dataSet.Tables[0];



            panelMain2.Controls.Add(dataGridViewMember);
        }

        private void buttonBarcode_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 form4 = new Form4(this, memberId, crud, sqlQuery);
            form4.Show();
        }

        //바코드 조회
        private void button1_Click(object sender, EventArgs e)
        {
            panelMain2.Controls.Clear();

            //duplicatedFunction.toggleButton(false, buttons);

            //datagrid 생성
            DataGridView dataGridViewBarcode = new DataGridView();
            dataGridViewBarcode.Location = new Point(0, 0);
            dataGridViewBarcode.Size = new Size(600, 180);

            string[] values = { memberId };
            string queryReadAll = sqlQuery.SelectAllFrom_Where_("BarcodeInfo", "MEMBERID", values);
            DataSet dataSet = crud.ReadToGrid(queryReadAll);

            dataGridViewBarcode.DataSource = dataSet.Tables[0];

            //check컬럼생성
            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.ValueType = typeof(bool);
            checkColumn.Name = "Chk";
            checkColumn.HeaderText = "CheckBox";
            dataGridViewBarcode.Columns.Add(checkColumn);

            //chart 생성
            Chart chart = new Chart();
            chart.Location = new Point(0, 200);
            chart.Size = new Size(500, 180);


            //chartarea추가 (이거없으면 차트 안보임)
            chart.ChartAreas.Add("Draw");

            //chart 타입변경
            chart.Series.Add("x");
            chart.Series["x"].ChartType = SeriesChartType.Column;


            //데이터 변경을 위한 listbox
            ListBox listBoxColumn = new ListBox();
            listBoxColumn.Items.Add("상품명");
            listBoxColumn.Items.Add("등록일");
            listBoxColumn.Items.Add("바코드 종류");

            listBoxColumn.Location = new Point(500, 180);
            //리스트 선택 바뀔 시 콜백함수
            listBoxColumn.SelectedIndexChanged += (se, ev) =>
            {
                string[] items = { "Product_Name", "Registratin_Date", "BarcodeKind" };
                string item = listBoxColumn.Text;

                

                //sring query = sqlQuery.selectCountallFrom_Where_("BarcodeInfo", item[0], )

                if (item == "상품명")
                {
                    string queryReadWhere = sqlQuery.select_Count_From_Where_GroupBy_("BarcodeInfo", memberId, items[0]);
                    DataSet dataSetCount = crud.ReadToGrid(queryReadWhere);
                    chart.DataSource = dataSetCount;

                    chart.Series["x"].XValueMember = items[0];
                    chart.Series["x"].YValueMembers = "Count";
                    chart.DataBind();
                }
                else if (item == "등록일")
                {
                    string queryReadWhere = sqlQuery.select_Count_From_Where_GroupBy_("BarcodeInfo", memberId, items[1]);
                    DataSet dataSetCount = crud.ReadToGrid(queryReadWhere);
                    chart.DataSource = dataSetCount;

                    chart.Series["x"].XValueMember = items[1];
                    chart.Series["x"].YValueMembers = "Count";
                    chart.DataBind();
                }
                else if (item == "바코드 종류")
                {
                    string queryReadWhere = sqlQuery.select_Count_From_Where_GroupBy_("BarcodeInfo", memberId, items[2]);
                    DataSet dataSetCount = crud.ReadToGrid(queryReadWhere);
                    chart.DataSource = dataSetCount;

                    chart.Series["x"].XValueMember = items[2];
                    chart.Series["x"].YValueMembers = "Count";
                    chart.DataBind();
                }
            };


            panelMain2.Controls.Add(dataGridViewBarcode);
            panelMain2.Controls.Add(listBoxColumn);
            panelMain2.Controls.Add(chart);
        }
    }
}
