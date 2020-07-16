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
            string qeuryReadMemberHistory = sqlQuery.SelectAllFrom_Where_(SqlQuery.MEMBERHISTORY, values, "MEMBERID");
            memberHistory = crud.Read(qeuryReadMemberHistory, memberHistory);

            textBoxId.Text = memberId;
            textBoxPoint.Text = Convert.ToString(memberHistory.Point);
            textBoxWriting.Text = Convert.ToString(memberHistory.Writing);
            textBoxActivity.Text = Convert.ToString(memberHistory.Activity);
        }

        private void buttonUpdateMember_Click(object sender, EventArgs e)
        {
            panelMain2.Visible = true;

            // 라벨과 텍스트 및 버튼을 만들어 패널에 뿌려줌
            Member member = new Member();
            Type type = typeof(Member);
            PropertyInfo[] propertyInfos = type.GetProperties();
            duplicatedFunction.ListLabelAndText = duplicatedFunction.MakeLabelAndText(propertyInfos.Count(), member);

            List<string> listName = new List<string>();
            listName.Add("적용");
            listName.Add("닫기");
            duplicatedFunction.ListName = listName;

            string[] values = { memberId };
            // 조회결과 뿌려주기
            string qeuryReadMember = sqlQuery.SelectAllFrom_Where_(SqlQuery.MEMBER, values, "ID");

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
                string qeuryUpdate = sqlQuery.Update_Set_(SqlQuery.MEMBER);

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
                        panelMain2.Visible = false;


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
                panelMain2.Visible = false;
                panelMain2.Controls.Clear();
            });

            duplicatedFunction.ListEventHandler = listEventHadler;

            duplicatedFunction.MakeButton(2);
            duplicatedFunction.panelAdd(panelMain2);

            



        }

        private void buttonDeleteMember_Click(object sender, EventArgs e)
        {
            panelMain2.Visible = true;

            List<string> listName = new List<string>();
            listName.Add("적용");
            listName.Add("닫기");
            duplicatedFunction.ListName = listName;

            List<EventHandler> listEventHadler = new List<EventHandler>();

            listEventHadler.Add((s, args) =>
            {
                string qeuryDelete = sqlQuery.deleteFrom_Where_(SqlQuery.MEMBER);
                Member member = new Member();
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
                panelMain2.Visible = false;
                panelMain2.Controls.Clear();
            });

            duplicatedFunction.ListEventHandler = listEventHadler;

            duplicatedFunction.MakeButton(2);

            duplicatedFunction.panelAdd(panelMain2);
        }

        private void buttonReadMember_Click(object sender, EventArgs e)
        {
            panelMain2.Visible = true;

            DataGridView dataGridViewMember = new DataGridView();
            dataGridViewMember.Location = new Point(0, 0);
            dataGridViewMember.Size = new Size(700, 300);


            string qeuryReadAll = "SELECT * FROM MEMBERHISTORY WHERE MEMBERID=" + memberId;
            DataSet dataSet = crud.ReadToGrid(qeuryReadAll);

            dataGridViewMember.DataSource = dataSet.Tables[0];

            Button btnCancle = new Button();
            btnCancle.Text = "창닫기";
            btnCancle.Location = new Point(700, 400);
            btnCancle.Click += (se, ev) =>
            {
                MessageBox.Show("창닫기 확인");
                panelMain2.Controls.Clear();
                panelMain2.Visible = false;
            };


            panelMain2.Controls.Add(dataGridViewMember);
            panelMain2.Controls.Add(btnCancle);
        }

    }
}
