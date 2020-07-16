using KjsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MemberBarcode
{
    public partial class Form3 : Form
    {
        private Form2 form2;
        private string memberId;
        private Crud crud;
        private DuplicatedFunction duplicatedFunction;
        private SqlQuery sqlQuery;
        TextBox[] textBoxesCreate;
        TextBox[] textBoxesUpdate;
        Button[] pageButtons;
        List<string> memberIdList;


        public Form3(Form2 form2, string memberId, Crud crud, DuplicatedFunction duplicatedFunction, SqlQuery sqlQuery)
        {
            InitializeComponent();
            this.form2 = form2;
            this.memberId = memberId;
            this.crud = crud;
            this.duplicatedFunction = duplicatedFunction;
            this.sqlQuery = sqlQuery;
            this.textBoxesCreate = new TextBox[] { textBoxCreateId, textBoxCreatePassword, textBoxCreateName, textBoxCreatePhone, textBoxCreateEmail};
            this.pageButtons = new Button[] { btnFirst, btnLast, btnNext, btnPrev, btnOneOfFive, btnTwoOfFive, btnThreeOfFive, btnFourOfFive, btnFiveOfFive };
            this.textBoxesUpdate = new TextBox[] { textBoxUpdateId, textBoxUpdatePassword, textBoxUpdateName, textBoxUpdatePhone, textBoxUpdateEmail};

            this.memberIdList = new List<string>();

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form2.Visible = true;
        }

        private void buttonDuplicationSelect_Click_1(object sender, EventArgs e)
        {
            string[] values = { textBoxCreateId.Text };
            string qeuryRead = sqlQuery.SelectAllFrom_Where_("MEMBER", "ID", values);
            Member memberResult = crud.Read(qeuryRead, new Member());

            if (memberResult.Id != null)
            {
                MessageBox.Show("아이디 중복");
                textBoxCreateId.Text = "";

            }
            else
            {
                MessageBox.Show("아이디 사용가능");
            }
        }

        private void buttonCreatePanelCreate_Click_1(object sender, EventArgs e)
        {
            string qeuryCreate = sqlQuery.InsertInto__Values_(new Member());
            string qeuryCreateMemberHistory = sqlQuery.InsertInto__Values_(new MemberHistory());
            string[] values = { textBoxCreateId.Text };
            string qeuryRead = sqlQuery.SelectAllFrom_Where_("MEMBER", "ID", values);
            string queryReadRowNum = sqlQuery.selectAllFrom_WhereRowNumSelect_RowNumFrom_("MEMBER", SqlQuery.MAX);
            string queryReadRowNumMemberHistory = sqlQuery.selectAllFrom_WhereRowNumSelect_RowNumFrom_("MEMBERHISTORY", SqlQuery.MAX);

            Member memberMaxRownum = crud.Read(queryReadRowNum, new Member());
            MemberHistory memberMaxRownumMemberHistory = crud.Read(queryReadRowNumMemberHistory, new MemberHistory());

            Member member = new Member()
            {
                Id = textBoxesCreate[0].Text,
                Password = textBoxesCreate[1].Text,
                Name = textBoxesCreate[2].Text,
                Phone = textBoxesCreate[3].Text,
                Email = textBoxesCreate[4].Text,
                Position = comboBoxPosition.Text,
                Rownum = memberMaxRownum.Rownum + 1

            };

            Member memberResult = crud.Read(qeuryRead, member);

            MemberHistory memberHistory = new MemberHistory
            {
                Id = member.Id,
                RegisterDate = DateTime.Today.ToString(),
                Point = 10,
                Writing = 0,
                Activity = 0,
                MemberId = member.Id,
                Rownum = memberMaxRownumMemberHistory.Rownum + 1

            };

            if (memberResult.Id != null)
            {
                MessageBox.Show("아이디 중복 확인");
                duplicatedFunction.textClearTextBox(textBoxesCreate);
                comboBoxPosition.SelectedItem = null;

            }
            else
            {
                if ((crud.Create(qeuryCreate, member) > -1) && (crud.Create(qeuryCreateMemberHistory, memberHistory) > -1))
                {


                    MessageBox.Show("등록 확인");
                    duplicatedFunction.textClearTextBox(textBoxesCreate);
                    comboBoxPosition.SelectedItem = null;



                }
                else
                {
                    MessageBox.Show("등록 실패");
                    duplicatedFunction.textClearTextBox(textBoxesCreate);
                    comboBoxPosition.SelectedItem = null;
                }
            }

            duplicatedFunction.textClearTextBox(textBoxesCreate);
            comboBoxPosition.SelectedItem = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int maxRownum = 0;
            int maxPage;

            Member member = new Member();
            MemberHistory memberHistory = new MemberHistory();

            string queryReadMemberMaxRownum = sqlQuery.selectAllFrom_WhereRowNumSelect_RowNumFrom_("MEMBER", SqlQuery.MAX);
            string queryReadMemberHistoryMaxRownum = sqlQuery.selectAllFrom_WhereRowNumSelect_RowNumFrom_("MEMBERHISTORY", SqlQuery.MAX);

            Member memberMaxRownum = crud.Read(queryReadMemberMaxRownum, member);
            MemberHistory memberHistoryMaxRownum = crud.Read(queryReadMemberHistoryMaxRownum, memberHistory);

            
            string queryRead20 = "";

            if (comboBoxTable.Text == "MEMBER")
            {
                maxRownum = memberMaxRownum.Rownum;
                queryRead20 = sqlQuery.selectAllFrom_Where_Between_And_("MEMBER", 6, memberMaxRownum.Rownum);
            }
            else if (comboBoxTable.Text == "MEMBERHISTORY")
            {
                maxRownum = memberHistoryMaxRownum.Rownum;
                queryRead20 = sqlQuery.selectAllFrom_Where_Between_And_("MEMBERHISTORY", 6, memberHistoryMaxRownum.Rownum);
            }

            DataSet dataSet = crud.ReadToGrid(queryRead20);

            dataSet.Tables[0].DefaultView.Sort = "ROWNUM DESC";

            dataGridViewRead.DataSource = dataSet.Tables[0];

            btnOneOfFive.Text = "1";
            btnTwoOfFive.Text = "2";
            btnThreeOfFive.Text = "3";
            btnFourOfFive.Text = "4";
            btnFiveOfFive.Text = "5";

            

            foreach (var pb in pageButtons)
                pb.BackColor = Color.White;
            btnOneOfFive.BackColor = Color.Yellow;

            if (maxRownum % 20 == 0)
            {
                maxPage = maxRownum / 20;
            }
            else
            {
                maxPage = (int)(maxRownum / 20) + 1;
            }

            textBoxPage.Text = "1 page / " + Convert.ToString(maxPage) + " page";
        }

        void btn_Click(object s, EventArgs ev)
        {
            int maxRownum;
            int maxPage;

            Button button = s as Button;

            foreach (var pb in pageButtons)
                pb.BackColor = Color.White;

            button.BackColor = Color.Yellow;

            Member member = new Member();
            MemberHistory memberHistory = new MemberHistory();
            string queryReadMax;

            if (comboBoxTable.SelectedItem == null)
            {
                return;
            }

            if (comboBoxTable.Text == "MEMBER")
            {
                queryReadMax = sqlQuery.selectAllFrom_WhereRowNumSelect_RowNumFrom_("MEMBER", SqlQuery.MAX);
                Member memberMaxRownum = crud.Read(queryReadMax, member);
                maxRownum = memberMaxRownum.Rownum;

            }
            else
            {
                queryReadMax = sqlQuery.selectAllFrom_WhereRowNumSelect_RowNumFrom_("MEMBERHISTORY", SqlQuery.MAX);
                MemberHistory memberHistoryMaxRownum = crud.Read(queryReadMax, memberHistory);
                maxRownum = memberHistoryMaxRownum.Rownum;

            }

            if (maxRownum % 20 == 0)
            {
                maxPage = maxRownum / 20;
            }
            else
            {
                maxPage = (int)(maxRownum / 20) + 1;
            }


            string queryRead20 = "";

            if (button.Text == "<<")
            {
                //최상위 20
                queryRead20 = sqlQuery.selectAllFrom_Where_Between_And_(comboBoxTable.Text, 6, maxRownum);

            }
            else if (button.Text == ">>")
            {
                //최하위 20
                queryRead20 = sqlQuery.selectAllFrom_Where_Between_And_(comboBoxTable.Text, 6, 20);
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
                queryRead20 = sqlQuery.selectAllFrom_Where_Between_And_(comboBoxTable.Text, 6, page);
            }



            if (button.Text == ">>")
            {
                textBoxPage.Text = maxPage + " page / " + Convert.ToString(maxPage) + " page";
            }
            else if (button.Text == "<<")
            {
                textBoxPage.Text = "1 page / " + Convert.ToString(maxPage) + " page";
            }
            else
            {
                textBoxPage.Text = button.Text + " page / " + Convert.ToString(maxPage) + " page";
            }



            DataSet dataSet = crud.ReadToGrid(queryRead20);

            dataSet.Tables[0].DefaultView.Sort = "ROWNUM DESC";

            dataGridViewRead.DataSource = dataSet.Tables[0];
        }

        private void buttonUpdateRead_Click(object sender, EventArgs e)
        {
            string[] values = { textBoxUpdateId.Text };
            string qeuryRead = sqlQuery.SelectAllFrom_Where_("MEMBER", "ID", values);
            Member memberResult = crud.Read(qeuryRead, new Member());
            textBoxUpdateId.ReadOnly = true;
            textBoxUpdateId.BackColor = Color.WhiteSmoke;

            if (memberResult.Id != null)
            {
                textBoxUpdateId.Text = memberResult.Id;
                textBoxUpdatePassword.Text = memberResult.Password;
                textBoxUpdateName.Text = memberResult.Name;
                textBoxUpdatePhone.Text = memberResult.Phone;
                textBoxUpdateEmail.Text = memberResult.Email;
                comboBoxUpdatePosition.SelectedIndex = comboBoxPosition.FindString(memberResult.Position);
                MessageBox.Show("조회 완료");

            }
            else
            {
                MessageBox.Show("조회불가");
                textBoxUpdateId.Text = "";
            }
        }

        private void buttonupdate_Click(object sender, EventArgs e)
        {
            string queryupdate = sqlQuery.Update_Set_("MEMBER");
            string[] values = { textBoxUpdateId.Text };
            string queryReadMember = sqlQuery.SelectAllFrom_Where_("MEMBER", "ID", values);

            Member memberResult = crud.Read(queryReadMember, new Member());

            Member member = new Member
            {
                Id = textBoxUpdateId.Text,
                Password = textBoxUpdatePassword.Text,
                Name = textBoxUpdateName.Text,
                Phone = textBoxUpdatePhone.Text,
                Email = textBoxUpdateEmail.Text,
                Position = comboBoxUpdatePosition.Text,
                Rownum = memberResult.Rownum
            };


            if (memberResult.Id == null)
            {
                MessageBox.Show("변경 불가");
                duplicatedFunction.textClearTextBox(textBoxesUpdate);
                comboBoxUpdatePosition.Text = null;
            }
            else
            {
                if (crud.Update(queryupdate, member) != -1)
                {
                    MessageBox.Show("변경 확인");
                    duplicatedFunction.textClearTextBox(textBoxesUpdate);
                    //duplicatedFunction.toggleButton(true, buttons);
                    comboBoxUpdatePosition.Text = null;

                }
                else
                {
                    MessageBox.Show("변경 실패");
                    duplicatedFunction.textClearTextBox(textBoxesUpdate);
                    comboBoxUpdatePosition.Text = null;
                }
            }
        }

        private void buttonUpdateClear_Click(object sender, EventArgs e)
        {
            duplicatedFunction.textClearTextBox(textBoxesUpdate);
            comboBoxUpdatePosition.Text = null;
            textBoxUpdateId.ReadOnly = false;
            textBoxUpdateId.BackColor = Color.White;
        }

        private void buttonDeleteRead_Click(object sender, EventArgs e)
        {
            string[] values = { textBoxDeleteId.Text };
            string qeuryRead = sqlQuery.SelectAllFrom_Where_("MEMBER", "ID", values);
            Member memberResult = crud.Read(qeuryRead, new Member());

            if (memberResult.Id != null)
            {
                textBoxDeleteId.Text = memberResult.Id;
                comboBoxDeletePosition.SelectedIndex = comboBoxPosition.FindString(memberResult.Position);
                MessageBox.Show("조회 완료");

            }
            else
            {
                MessageBox.Show("조회불가");
                textBoxDeleteId.Text = "";
            }
        }

        private void buttonDeleteClear_Click(object sender, EventArgs e)
        {
            textBoxDeleteId.Text = "";
            comboBoxDeletePosition.Text = null;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string qeuryDelete = sqlQuery.deleteFrom_Where_("MEMBER");
            string[] values = { textBoxDeleteId.Text };
            string qeuryReadMember = sqlQuery.SelectAllFrom_Where_("MEMBER", "ID", values);

            Member member = new Member
            {
                Id = textBoxDeleteId.Text,
            };

            Member memberResult = crud.Read(qeuryReadMember, member);

            if (memberResult.Id == null)
            {
                MessageBox.Show("삭제 불가");
                textBoxDeleteId.Text = "";
                comboBoxDeletePosition.Text = null;
            }
            else
            {
                if (crud.Delete(qeuryDelete, member) != -1)
                {
                    MessageBox.Show("삭제 확인");
                    //duplicatedFunction.toggleButton(true, buttons);
                    textBoxDeleteId.Text = "";
                    comboBoxDeletePosition.Text = null;


                }
                else
                {

                    MessageBox.Show("삭제 실패");
                    textBoxDeleteId.Text = "";
                    comboBoxDeletePosition.Text = null;
                }
            }
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            textBoxId.Text = memberId + "님";

            string qeuryReadAll = sqlQuery.SelectAllFrom_("MEMBERHISTORY");
            DataSet dataSet = crud.ReadToGrid(qeuryReadAll);

            dataGridViewChart.DataSource = dataSet.Tables[0];

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.ValueType = typeof(bool);
            checkColumn.Name = "Chk";
            checkColumn.HeaderText = "CheckBox";
            dataGridViewChart.Columns.Insert(0, checkColumn);

            chart1.DataSource = dataSet;

            chart1.Series.Add("x");
            //chart 타입변경
            chart1.Series["x"].ChartType = SeriesChartType.Column;
            //x축
            chart1.Series["x"].XValueMember = "MEMBERID";

            chart1.Series["x"].YValueMembers = "ACTIVITY";

            chart1.DataBind();
        }

        public void buttonChart_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string[] items = { "Point", "Writing", "Activity" };
            string item = button.Text;

            if (item == items[0])
            {
                chart1.Series["x"].YValueMembers = items[0];
                chart1.DataBind();
            }
            else if (item == items[1])
            {
                chart1.Series["x"].YValueMembers = items[1];
                chart1.DataBind();
            }
            else if (item == items[2])
            {
                chart1.Series["x"].YValueMembers = items[2];
                chart1.DataBind();
            }
        }

        private void comboBoxChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] items = { "Column", "Pie", "FastLine", "Area", "Bar" };
            string item = comboBoxChart.SelectedItem.ToString();
            if (item == items[0])
            {
                chart1.Series["x"].ChartType = SeriesChartType.Column;
            }
            else if (item == items[1])
            {
                chart1.Series["x"].ChartType = SeriesChartType.Pie;
            }
            else if (item == items[2])
            {
                chart1.Series["x"].ChartType = SeriesChartType.FastLine;
                chart1.Series["x"].BorderWidth = 5;
            }
            else if (item == items[3])
            {
                chart1.Series["x"].ChartType = SeriesChartType.Area;
            }
            else if (item == items[4])
            {
                chart1.Series["x"].ChartType = SeriesChartType.Bar;
            }
        }


        private void dataGridViewChart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //체크가 true인지
            if ((bool)(dataGridViewChart.Rows[e.RowIndex].Cells[0].EditedFormattedValue ?? false) == true)
            {
                memberIdList.Add((string)dataGridViewChart.Rows[e.RowIndex].Cells["MEMBERID"].Value);
                Console.WriteLine("true");
            }
            else if ((bool)(dataGridViewChart.Rows[e.RowIndex].Cells[0].EditedFormattedValue ?? false) == false)
            {
                memberIdList.Remove((string)dataGridViewChart.Rows[e.RowIndex].Cells["MEMBERID"].Value);
                Console.WriteLine("false");
            }
            // 모든체크 해제시 원래의 dataset으로
            if (memberIdList.Count != 0)
            {
                string querySelectWhere = sqlQuery.selectAllFrom_Where_In_("MEMBERHISTORY", 5, memberIdList);
                DataSet dataSetWhereMemberID = crud.ReadToGrid(querySelectWhere);

                chart1.DataSource = dataSetWhereMemberID;
                chart1.DataBind();
            }
            else
            {
                string qeuryReadAll = sqlQuery.SelectAllFrom_("MEMBERHISTORY");
                DataSet dataSet = crud.ReadToGrid(qeuryReadAll);
                chart1.DataSource = dataSet;
                chart1.DataBind();
            }
        }

    }
}
