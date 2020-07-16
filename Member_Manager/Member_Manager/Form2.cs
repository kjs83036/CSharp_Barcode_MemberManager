using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Member_Manager
{
    public partial class Form2 : Form
    {
        Form form1;
        Crud<Person> crud;
        string adminId;
        public Form2(Form form1, string adminId, Crud<Person> crud)
        {
            InitializeComponent();
            this.crud = crud;
            this.form1 = form1;
            this.adminId = adminId;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form1.Visible = true;
        }

        private void buttonCreateMember_Click(object sender, EventArgs e)
        {
            hideButton();

            Label labelId = new Label();
            Label labelName = new Label();
            labelId.Text = "Id";
            labelName.Text = "Name";
            labelId.Location = new Point(0, 0);
            labelName.Location = new Point(0, 60);


            TextBox textBoxNewId = new TextBox();
            TextBox textBoxNewName = new TextBox();
            textBoxNewId.Location = new Point(100, 0);
            textBoxNewName.Location = new Point(100, 60);

            Button btnCreate = new Button();
            btnCreate.Text = "회원 등록";
            btnCreate.Location = new Point(300, 0);
            btnCreate.Click += (se, ev) =>
            {
                string qeuryCreate = "INSERT INTO [MEMBER] (ID, NAME, ADMINID) VALUES (@ID, @NAME, @ADMINID)";
                string qeuryReadMember = "SELECT * FROM MEMBER WHERE ID=" + textBoxNewId.Text;

                Person member = new Member
                {
                    Id = textBoxNewId.Text,
                    Name = textBoxNewName.Text,
                    AdminId = adminId
                };

                Member memberResult = crud.Read<Member>(qeuryReadMember, (Member)member);

                if (memberResult != null)
                {
                    MessageBox.Show("아이디 중복 확인");
                    textBoxNewId.Text = "";
                    textBoxNewName.Text = "";
                }
                else
                {
                    if (crud.Create(qeuryCreate, member) != -1)
                    {
                        MessageBox.Show("등록 확인");
                        panelMain.Controls.Clear();


                    }
                    else
                    {
                        MessageBox.Show("등록 실패");
                        textBoxNewId.Text = "";
                        textBoxNewName.Text = "";
                    }
                }
            };

            Button btnCancle = new Button();
            btnCancle.Text = "창닫기";
            btnCancle.Location = new Point(300, 60);
            btnCancle.Click += (se, ev) =>
            {
                MessageBox.Show("창닫기 확인");
                panelMain.Controls.Clear();
                revealButton();
            };


            panelMain.Controls.Add(textBoxNewId);
            panelMain.Controls.Add(textBoxNewName);
            panelMain.Controls.Add(labelId);
            panelMain.Controls.Add(labelName);
            panelMain.Controls.Add(btnCreate);
            panelMain.Controls.Add(btnCancle);
        }

        private void buttonReadMember_Click(object sender, EventArgs e)
        {
            hideButton();
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Location = new Point(0, 0);
            richTextBox.Size = new Size(200, 200);


            Button btnRead = new Button();
            btnRead.Text = "회원 조회";
            btnRead.Location = new Point(300, 0);
            btnRead.Click += (se, ev) =>
            {
                string qeuryReadAll = "SELECT * FROM MEMBER ";


                List<Member> member_list = crud.ReadAll(qeuryReadAll);

                foreach (var m in member_list)
                    richTextBox.Text += m.Id + " / " + m.Name + " / " + m.AdminId + "\n";

            };

            Button btnCancle = new Button();
            btnCancle.Text = "창닫기";
            btnCancle.Location = new Point(300, 60);
            btnCancle.Click += (se, ev) =>
            {
                MessageBox.Show("창닫기 확인");
                panelMain.Controls.Clear();
                revealButton();
            };


            panelMain.Controls.Add(richTextBox);
            panelMain.Controls.Add(btnRead);
            panelMain.Controls.Add(btnCancle);
        }

        private void buttonUpdateMember_Click(object sender, EventArgs e)
        {
            hideButton();
            Label labelId = new Label();
            Label labelName = new Label();
            Label labelAdminId = new Label();
            labelId.Text = "Id";
            labelName.Text = "Name";
            labelAdminId.Text = "AdminId";
            labelId.Location = new Point(0, 0);
            labelName.Location = new Point(0, 30);
            labelAdminId.Location = new Point(0, 60);


            TextBox textBoxNewId = new TextBox();
            TextBox textBoxNewName = new TextBox();
            TextBox textBoxNewAdminId = new TextBox();
            textBoxNewId.Location = new Point(100, 0);
            textBoxNewName.Location = new Point(100, 30);
            textBoxNewAdminId.Location = new Point(100, 60);

            Button btnCreate = new Button();
            btnCreate.Text = "회원 변경";
            btnCreate.Location = new Point(300, 0);
            btnCreate.Click += (se, ev) =>
            {
                string qeuryUpdate = "UPDATE [MEMBER] SET NAME=@NAME, ADMINID=@ADMINID WHERE ID=@ID";
                string qeuryReadMember = "SELECT * FROM MEMBER WHERE ID=" + textBoxNewId.Text;

                Person member = new Member
                {
                    Id = textBoxNewId.Text,
                    Name = textBoxNewName.Text,
                    AdminId = textBoxNewAdminId.Text
                };

                Member memberResult = crud.Read<Member>(qeuryReadMember, (Member)member);

                if (memberResult == null)
                {
                    MessageBox.Show("변경 불가");
                    textBoxNewId.Text = "";
                    textBoxNewName.Text = "";
                    textBoxNewAdminId.Text = "";
                }
                else
                {
                    if (crud.Update(qeuryUpdate, (Member)member) != -1)
                    {
                        MessageBox.Show("변경 확인");
                        panelMain.Controls.Clear();


                    }
                    else
                    {
                        MessageBox.Show("변경 실패");
                        textBoxNewId.Text = "";
                        textBoxNewName.Text = "";
                        textBoxNewAdminId.Text = "";
                    }
                }
            };

            Button btnCancle = new Button();
            btnCancle.Text = "창닫기";
            btnCancle.Location = new Point(300, 60);
            btnCancle.Click += (se, ev) =>
            {
                MessageBox.Show("창닫기 확인");
                panelMain.Controls.Clear();
                revealButton();
            };


            panelMain.Controls.Add(textBoxNewId);
            panelMain.Controls.Add(textBoxNewName);
            panelMain.Controls.Add(textBoxNewAdminId);
            panelMain.Controls.Add(labelId);
            panelMain.Controls.Add(labelName);
            panelMain.Controls.Add(labelAdminId);
            panelMain.Controls.Add(btnCreate);
            panelMain.Controls.Add(btnCancle);
        }

        private void buttonDeleteMember_Click(object sender, EventArgs e)
        {
            hideButton();
            Label labelId = new Label();
            labelId.Text = "Id";
            labelId.Location = new Point(0, 0);


            TextBox textBoxNewId = new TextBox();
            textBoxNewId.Location = new Point(100, 0);

            Button btnCreate = new Button();
            btnCreate.Text = "회원 삭제";
            btnCreate.Location = new Point(300, 0);
            btnCreate.Click += (se, ev) =>
            {
                string qeuryDelete = "DELETE FROM [MEMBER] WHERE ID=@ID";
                string qeuryReadMember = "SELECT * FROM MEMBER WHERE ID=" + textBoxNewId.Text;

                Person member = new Member
                {
                    Id = textBoxNewId.Text,
                };

                Member memberResult = crud.Read<Member>(qeuryReadMember, (Member)member);

                if (memberResult == null)
                {
                    MessageBox.Show("삭제 불가");
                    textBoxNewId.Text = "";
                }
                else
                {
                    if (crud.Delete(qeuryDelete, (Member)member) != -1)
                    {
                        MessageBox.Show("삭제 확인");
                        panelMain.Controls.Clear();


                    }
                    else
                    {
                        MessageBox.Show("삭제 실패");
                        textBoxNewId.Text = "";
                    }
                }
            };

            Button btnCancle = new Button();
            btnCancle.Text = "창닫기";
            btnCancle.Location = new Point(300, 60);
            btnCancle.Click += (se, ev) =>
            {
                MessageBox.Show("창닫기 확인");
                panelMain.Controls.Clear();
                revealButton();
            };


            panelMain.Controls.Add(textBoxNewId);
            panelMain.Controls.Add(labelId);
            panelMain.Controls.Add(btnCreate);
            panelMain.Controls.Add(btnCancle);
        }

        private void hideButton()
        {
            buttonCreateMember.Visible = false;
            buttonReadMember.Visible = false;
            buttonUpdateMember.Visible = false;
            buttonDeleteMember.Visible = false;
        }

        private void revealButton()
        {
            buttonCreateMember.Visible = true;
            buttonReadMember.Visible = true;
            buttonUpdateMember.Visible = true;
            buttonDeleteMember.Visible = true;
        }

        
    }
}
