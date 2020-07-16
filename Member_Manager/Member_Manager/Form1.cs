using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Member_Manager
{
    public partial class Form1 : Form
    {
        Crud<Person> crud;
        string adminId;

        public Form1()
        {
            InitializeComponent();
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\2klab\OneDrive\2kd\Projects_c#\Member_Manager\Member_Manager\DatabaseMember.mdf;Integrated Security=True";
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sktlrkan\OneDrive\2kd\Projects_c#\Member_Manager\Member_Manager\DatabaseMember.mdf;Integrated Security=True";
            crud = new Crud<Person>(connectionString);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string queryRead = "SELECT * FROM ADMIN WHERE ID=" + textBoxId.Text;
            Admin admin = new Admin
            {
                Id = textBoxId.Text
            };
            Admin adminResult = crud.Read<Admin>(queryRead, admin);

            if (adminResult != null && adminResult.Id == textBoxId.Text && adminResult.Password == textBoxPassword.Text)
            {
                adminId = adminResult.Id;
                this.Visible = false;
                Form2 form2 = new Form2(this, adminId, crud);
                form2.Show();
            }
            else
            {
                MessageBox.Show("로그인 불가");
            }
            textBoxId.Text = "";
            textBoxPassword.Text = "";

        }

        private void buttonCreateAdmin_Click(object sender, EventArgs e)
        {
            panelCreate.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label labelId = new Label();
            Label labelPassword = new Label();
            Label labelName = new Label();
            Label labelPosition = new Label();
            labelId.Text = "Id";
            labelPassword.Text = "Password";
            labelName.Text = "Name";
            labelPosition.Text = "Position";
            labelId.Location = new Point(0, 0);
            labelPassword.Location = new Point(0, 30);
            labelName.Location = new Point(0, 60);
            labelPosition.Location = new Point(0, 90);


            TextBox textBoxNewId = new TextBox();
            TextBox textBoxNewPassword = new TextBox();
            TextBox textBoxNewName = new TextBox();
            TextBox textBoxNewPosition = new TextBox();
            textBoxNewId.Location = new Point(100, 0);
            textBoxNewPassword.Location = new Point(100, 30);
            textBoxNewName.Location = new Point(100, 60);
            textBoxNewPosition.Location = new Point(100, 90);

            Button btnCreate = new Button();
            btnCreate.Text = "관리자등록";
            btnCreate.Location = new Point(300, 60);
            btnCreate.Click += (se, ev) =>
            {
                string qeuryCreate = "INSERT INTO [ADMIN] (ID, PASSWORD, POSITION, LASTLOGIN, LASTLOGOUT, NAME) VALUES (@ID, @PASSWORD, @POSITION, @LASTLOGIN, @LASTLOGOUT, @NAME)";
                string qeuryRead = "SELECT * FROM ADMIN WHERE ID=" + textBoxNewId.Text + "";

                Person admin = new Admin()
                {
                    Id = textBoxNewId.Text,
                    Password = textBoxNewPassword.Text,
                    Position = textBoxNewPosition.Text,
                    LastLogin = "",
                    LastLogout = "",
                    Name = textBoxNewName.Text
                };
                Admin adminResult = crud.Read<Admin>(qeuryRead, (Admin)admin);

                if (adminResult != null)
                {
                    MessageBox.Show("아이디 중복 확인");
                    textBoxNewId.Text = "";
                    textBoxNewPassword.Text = "";
                    textBoxNewPosition.Text = "";
                    textBoxNewName.Text = "";
                }
                else
                {
                    if (crud.Create(qeuryCreate, admin) != -1)
                    {
                        MessageBox.Show("등록 확인");
                        panelCreate.Visible = false;


                    }
                    else
                    {
                        MessageBox.Show("등록 실패");
                        panelCreate.Visible = false;
                    }
                    textBoxNewId.Text = "";
                    textBoxNewPassword.Text = "";
                    textBoxNewPosition.Text = "";
                    textBoxNewName.Text = "";
                }

                

            };

            Button btnCancle = new Button();
            btnCancle.Text = "창닫기";
            btnCancle.Location = new Point(300, 90);
            btnCancle.Click += (se, ev) =>
            {
                MessageBox.Show("창닫기 확인");
                panelCreate.Visible = false;
                textBoxNewId.Text = "";
                textBoxNewPassword.Text = "";
                textBoxNewPosition.Text = "";
                textBoxNewName.Text = "";
            };


            panelCreate.Controls.Add(textBoxNewId);
            panelCreate.Controls.Add(textBoxNewPassword);
            panelCreate.Controls.Add(textBoxNewName);
            panelCreate.Controls.Add(textBoxNewPosition);
            panelCreate.Controls.Add(labelId);
            panelCreate.Controls.Add(labelPassword);
            panelCreate.Controls.Add(labelName);
            panelCreate.Controls.Add(labelPosition);
            panelCreate.Controls.Add(btnCreate);
            panelCreate.Controls.Add(btnCancle);
        }


    }


    public class Crud<Person>
    {
        SqlConnection conn;
        private string connectionString;

        public Crud(string connectionString)
        {
            this.connectionString = connectionString;
            conn = new SqlConnection(connectionString);
        }

        public int Create(string query, Person person)
        {
            Admin admin = person as Admin;
            Member member = person as Member;
            int result = -1;

            using (SqlCommand sqlCmd = new SqlCommand(query, conn))
            {
                string[] columns = query.Substring(query.IndexOf("@")).Replace(" ", "").Split(',');
                columns[columns.Count() - 1] = columns[columns.Count() - 1].Substring(0, columns[columns.Count() - 1].Length - 1);
                List<string> values = new List<string>();
                if (admin != null && member == null)
                {
                    values.Add(admin.Id);
                    values.Add(admin.Password);
                    values.Add(admin.Position);
                    values.Add(admin.LastLogin);
                    values.Add(admin.LastLogout);
                    values.Add(admin.Name);
                }
                else
                {
                    values.Add(member.Id);
                    values.Add(member.Name);
                    values.Add(member.AdminId);
                }
                for (int i = 0; i < columns.Count(); i++)
                {
                    sqlCmd.Parameters.AddWithValue(columns[i], values[i]);
                }
                conn.Open();
                SqlTransaction sqlTran = conn.BeginTransaction();
                sqlCmd.Transaction = sqlTran;
                try
                {


                    result = sqlCmd.ExecuteNonQuery();
                    sqlTran.Commit();

                    conn.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    sqlTran.Rollback();
                    conn.Close();

                }

            }



            Console.WriteLine("Create");
            return result;

        }
        public T Read<T>(string query, T person) where T: class
        {
            Admin admin = person as Admin;
            Member member = person as Member;
            try
            {
                using (SqlCommand sqlCmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = sqlCmd.ExecuteReader();
                    if (admin != null && member == null)
                    {

                        admin = null;
                        while (reader.Read())
                            admin = new Admin
                            {
                                Id = reader.GetString(0),
                                Password = reader.GetString(1),
                                Position = reader.GetString(2),
                                LastLogin = reader.GetString(3),
                                LastLogout = reader.GetString(4),
                                Name = reader.GetString(5)
                            };
                        reader.Close();
                        conn.Close();
                        return admin as T;

                    }
                    else
                    {
                        member = null;
                        while (reader.Read())
                            member = new Member
                            {
                                Id = reader.GetString(0),
                                Name = reader.GetString(1),
                                AdminId = reader.GetString(2)
                            };
                        reader.Close();
                        conn.Close();
                        return member as T;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                conn.Close();
            }

            Console.WriteLine("Read");
            return default(T);


        }
        public List<Member> ReadAll(string query)
        {

            List<Member> list = null;
            try
            {
                using (SqlCommand sqlCmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = sqlCmd.ExecuteReader())
                    {
                        list = new List<Member>();

                        while (reader.Read())
                            list.Add(new Member
                            {
                                Id = reader.GetString(0),
                                Name = reader.GetString(1),
                                AdminId = reader.GetString(2)
                            });
                    }
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                conn.Close();
            }

            Console.WriteLine("ReadAll");
            return list;


        }

        public int Update(string query, Member member)
        {
            int result = -1;

            using (SqlCommand sqlCmd = new SqlCommand(query, conn))
            {
                string[] columns = { "@ID", "@NAME", "@ADMINID"};
                string[] values = { member.Id, member.Name, member.AdminId};
                for (int i = 0; i < columns.Count(); i++)
                {
                    sqlCmd.Parameters.AddWithValue(columns[i], values[i]);
                }
                conn.Open();
                SqlTransaction sqlTran = conn.BeginTransaction();
                sqlCmd.Transaction = sqlTran;
                try
                {


                    result = sqlCmd.ExecuteNonQuery();
                    sqlTran.Commit();

                    conn.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    sqlTran.Rollback();
                    conn.Close();

                }

            }



            Console.WriteLine("Update");
            return result;
        }
        public int Delete(string query, Member member) 
        {
            int result = -1;

            using (SqlCommand sqlCmd = new SqlCommand(query, conn))
            {
                string[] columns = { "@ID"};
                string[] values = { member.Id};
                for (int i = 0; i < columns.Count(); i++)
                {
                    sqlCmd.Parameters.AddWithValue(columns[i], values[i]);
                }
                conn.Open();
                SqlTransaction sqlTran = conn.BeginTransaction();
                sqlCmd.Transaction = sqlTran;
                try
                {


                    result = sqlCmd.ExecuteNonQuery();
                    sqlTran.Commit();

                    conn.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    sqlTran.Rollback();
                    conn.Close();

                }

            }



            Console.WriteLine("Delete");
            return result;
        }
    }

    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }

    }

    public class Admin : Person
    {
        public string Password { get; set; }
        public string Position { get; set; }
        public string LastLogin { get; set; }
        public string LastLogout { get; set; }



    }

    public class Member : Person
    {
        public string AdminId { get; set; }

    }

}
