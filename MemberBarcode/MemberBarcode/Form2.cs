using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KjsLibrary;

namespace MemberBarcode
{
    public partial class Form2 : Form
    {

        string memberId;

        Crud crud;
        DuplicatedFunction duplicatedFunction;
        SqlQuery sqlQuery;
        TextBox[] textBoxesLogin;
        TextBox[] textBoxesCreate;

        public Form2()
        {
            InitializeComponent();

            //db연결 경로 조정할 것
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\2klab\OneDrive\2kd\Projects_c#\MemberBarcode\DatabaseMember.mdf;Integrated Security=True;Connect Timeout=30";
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sktlrkan\OneDrive\2kd\Projects_c#\Member_Manager\Member_Manager\DatabaseMember.mdf;Integrated Security=True";

            sqlQuery = new SqlQuery();
            crud = new Crud(connectionString, sqlQuery);
            this.duplicatedFunction = new DuplicatedFunction(crud, sqlQuery);
            textBoxesLogin = new TextBox[] { textBoxId, textBoxPassword };
            textBoxesCreate = new TextBox[] { textBoxCreateId, textBoxCreatePassword, textBoxCreateName, textBoxCreatePhone, textBoxCreateEmail};


        }
        //로그인
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string[] values = { textBoxId.Text };
            string queryRead = sqlQuery.SelectAllFrom_Where_("MEMBER", "ID", values);
            Member memberReadResult = crud.Read(queryRead, new Member());

            // id, password 확인
            if (memberReadResult.Id == textBoxId.Text && memberReadResult.Password == textBoxPassword.Text)
            {
                memberId = memberReadResult.Id;
                this.Visible = false;

                if (memberReadResult.Position != "admin")
                {
                    //일반 로그인
                    Form1 form1 = new Form1(this, memberId, crud, duplicatedFunction, sqlQuery);
                    form1.Show();
                }
                else
                {
                    //관리자 로그인
                    Form3 form3 = new Form3(this, memberId, crud, duplicatedFunction, sqlQuery);
                    form3.Show();
                }


            }
            else
            {
                MessageBox.Show("로그인 불가");
                panelCreate.Visible = false;
            }
            duplicatedFunction.textClearTextBox(textBoxesLogin);
        }

        //중복조회
        private void buttonDuplicationSelect_Click(object sender, EventArgs e)
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

        //회원가입 창띄우기
        private void buttonCreateMember_Click(object sender, EventArgs e)
        {
            panelCreate.Visible = true;
            duplicatedFunction.textClearTextBox(textBoxesLogin);
        }

        //취소
        private void buttonCreateCancle_Click(object sender, EventArgs e)
        {
            panelCreate.Visible = false;
            duplicatedFunction.textClearTextBox(textBoxesCreate);
        }
        //회원가입 등록
        private void buttonCreatePanelCreate_Click(object sender, EventArgs e)
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
                Position = "user",
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
            }
            else
            {
                if ((crud.Create(qeuryCreate, member) > -1) && (crud.Create(qeuryCreateMemberHistory, memberHistory) > -1))
                {


                    MessageBox.Show("등록 확인");
                    duplicatedFunction.textClearTextBox(textBoxesCreate);



                }
                else
                {
                    MessageBox.Show("등록 실패");
                    duplicatedFunction.textClearTextBox(textBoxesCreate);
                }
            }

            panelCreate.Visible = false;
            duplicatedFunction.textClearTextBox(textBoxesCreate);
        }
    }
}
