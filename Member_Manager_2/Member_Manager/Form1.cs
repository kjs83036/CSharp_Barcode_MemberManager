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

namespace Member_Manager
{
    public partial class Form1 : Form
    {
        string memberId;

        Crud crud;
        DuplicatedFunction duplicatedFunction;
        SqlQuery sqlQuery;


        public Form1()
        {
            InitializeComponent();


            //db연결 경로 조정할 것
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\2klab\OneDrive\2kd\Projects_c#\Member_Manager_2\Member_Manager\DatabaseMember.mdf;Integrated Security=True";
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sktlrkan\OneDrive\2kd\Projects_c#\Member_Manager\Member_Manager\DatabaseMember.mdf;Integrated Security=True";

            sqlQuery = new SqlQuery();
            crud = new Crud(connectionString, sqlQuery);
            this.duplicatedFunction = new DuplicatedFunction(crud, sqlQuery);


        }

        // 로그인
        private void button2_Click(object sender, EventArgs e)
        {
            panelCreate.Visible = true;
            //select * from member where id=txt;
            string[] values = { textBoxId.Text };
            string queryRead = sqlQuery.SelectAllFrom_Where_(SqlQuery.MEMBER, values, "ID");
            Member member = new Member
            {
                Id = textBoxId.Text
            };
            Member memberReadResult = crud.Read(queryRead, member);

            // id, password 확인
            if (memberReadResult.Id == textBoxId.Text && memberReadResult.Password == textBoxPassword.Text)
            {
                memberId = memberReadResult.Id;
                this.Visible = false;

                if (memberReadResult.Position != "admin")
                {
                    //일반 로그인
                    Form3 form3 = new Form3(this, memberId, crud, duplicatedFunction, sqlQuery);
                    form3.Show();
                }
                else
                {
                    //관리자 로그인
                    Form2 form2 = new Form2(this, memberId, crud, duplicatedFunction, sqlQuery);
                    form2.Show();
                }


            }
            else
            {
                MessageBox.Show("로그인 불가");
                panelCreate.Visible = false;
            }
            textBoxId.Text = "";
            textBoxPassword.Text = "";

        }

        //회원가입
        private void buttonCreateAdmin_Click(object sender, EventArgs e)
        {
            panelCreate.Visible = true;
            Member member = new Member();
            Type type = typeof(Member);
            PropertyInfo[] propertyInfos = type.GetProperties();
            //필드 수 만큼 label, text 생성
            duplicatedFunction.ListLabelAndText = duplicatedFunction.MakeLabelAndText(propertyInfos.Count(), member);

            List<string> listName = new List<string>();
            listName.Add("가입");
            listName.Add("닫기");
            duplicatedFunction.ListName = listName;

            List<EventHandler> listEventHadler = new List<EventHandler>();

            //콜백함수1
            listEventHadler.Add((s, args) =>
                {
                    string qeuryCreate = sqlQuery.InsertInto__Values_(SqlQuery.MEMBER);
                    string[] values = { duplicatedFunction.ListLabelAndText[0].Item2.Text };
                    string qeuryRead = sqlQuery.SelectAllFrom_Where_(SqlQuery.MEMBER, values, "ID");
                    string queryReadRowNum = sqlQuery.selectAllFrom_WhereRowNumSelect_RowNumFrom_(SqlQuery.MEMBER, SqlQuery.MAX);

                    Member memberMaxRownum = crud.Read(queryReadRowNum, member);

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

                    Member memberResult = crud.Read(qeuryRead, member);

                    if (memberResult.Id != null)
                    {
                        MessageBox.Show("아이디 중복 확인");
                        duplicatedFunction.listLabelAndTextClear();
                    }
                    else
                    {
                        if (crud.Create(qeuryCreate, member) != -1)
                        {
                            MessageBox.Show("등록 확인");
                            panelCreate.Visible = false;
                            panelCreate.Controls.Clear();


                        }
                        else
                        {
                            MessageBox.Show("등록 실패");
                            panelCreate.Visible = false;
                            duplicatedFunction.listLabelAndTextClear();
                        }
                    }
                });

            //콜백함수2
            listEventHadler.Add((s, args) =>
            {
                MessageBox.Show("창닫기 확인");
                panelCreate.Controls.Clear();
                //오른쪽 4개 버튼드러내기
                panelCreate.Visible = false;
            });

            duplicatedFunction.ListEventHandler = listEventHadler;

            //버튼 2개 생성(적용, 창닫기)
            duplicatedFunction.MakeButton(2);
            // 생성된 객체 panel에 붙임
            duplicatedFunction.panelAdd(panelCreate);
        }

    }

}
