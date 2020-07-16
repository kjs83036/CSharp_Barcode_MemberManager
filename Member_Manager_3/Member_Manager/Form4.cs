using KjsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Member_Manager
{
    public partial class Form4 : Form
    {
        LjsLibrary ljsLibrary;
        List<TextBox> textBoxes;
        private Form3 form3;
        private string memberId;
        SqlQuery sqlQuery;
        Crud crud;


        public Form4(Form3 form3, string memberId, Crud crud, SqlQuery sqlQuery)
        {
            InitializeComponent();

            this.form3 = form3;
            this.memberId = memberId;


            ljsLibrary = new LjsLibrary();

            textBoxes = new List<TextBox>();

            this.textBoxes.Add(textBoxName);
            this.textBoxes.Add(textBoxDate);
            this.textBoxes.Add(textBoxInfo1);
            this.textBoxes.Add(textBoxInfo2);
            this.textBoxes.Add(textBoxInfo3);

            //this.constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\2klab\OneDrive\2kd\Projects_c#\Member_Manager_3\Member_Manager\BarcodeInfoDB.mdf;Integrated Security=True;Connect Timeout=30";

            this.sqlQuery = sqlQuery;
            this.crud = crud;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxId.Text = memberId;
        }

        //콜백함수 콤보박스 입력방식 변경
        private void comboBoxKinds_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox.Text == "QR코드")
            {
                textBoxName.ImeMode = ImeMode.NoControl;
                textBoxDate.ImeMode = ImeMode.NoControl;
                textBoxInfo1.ImeMode = ImeMode.NoControl;
                textBoxInfo2.ImeMode = ImeMode.NoControl;
                textBoxInfo3.ImeMode = ImeMode.NoControl;
            }
            else
            {
                textBoxName.ImeMode = ImeMode.Disable;
                textBoxDate.ImeMode = ImeMode.Disable;
                textBoxInfo1.ImeMode = ImeMode.Disable;
                textBoxInfo2.ImeMode = ImeMode.Disable;
                textBoxInfo3.ImeMode = ImeMode.Disable;
            }
            ljsLibrary.clear(textBoxName, textBoxDate, textBoxInfo1, textBoxInfo2, textBoxInfo3, textBoxInfoAll, pictureBoxBarcode);
        }

        //from file
        private void buttonRead_Click(object sender, EventArgs e)
        {
            bar_read reader = new bar_read();                   //바코드 생성 클래스 인스턴스 생성


            var temp = reader.read_barcode();                    //바코드 read함수를 통해  (비트맵, text 값) 받아옴

            if (temp.Item1 != null)
            {

                string result = temp.Item2;                                // 읽어온 바코드 text 값 

                if (result == null)
                {
                    MessageBox.Show("바코드 정보 없음");
                    return;
                }
                    
                pictureBoxBarcode.Image = temp.Item1;                 // 읽어온 이미지
                textBoxInfoAll.Text = result;
               //ljsLibrary.baReader(constr, temp.Item3, textBoxes);

            }
        }

        //clear
        private void buttonClear_Click(object sender, EventArgs e)
        {

            ljsLibrary.clear(textBoxName, textBoxDate, textBoxInfo1, textBoxInfo2, textBoxInfo3, textBoxInfoAll, pictureBoxBarcode);
        }

        //create
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (comboBoxKinds.Text.Length > 0 && textBoxName.Text.Length > 0 && textBoxDate.Text.Length > 0 && textBoxInfo1.Text.Length > 0 && textBoxInfo2.Text.Length > 0 && textBoxInfo3.Text.Length > 0)
            {
                string bar = textBoxName.Text + textBoxDate.Text + textBoxInfo1.Text + textBoxInfo2.Text + textBoxInfo3.Text;
                //byte[] bytes = Encoding.Default.GetBytes(bar);
                //bar = Encoding.UTF8.GetString(bytes);

                textBoxInfoAll.Text = bar;
                barcode_creation barcode = new barcode_creation(bar);        //바코드 생성 클래스에 매개변수 전달하여 인스턴스 생성

                pictureBoxBarcode.SizeMode = PictureBoxSizeMode.StretchImage;       //파일 저장                                               //픽쳐박스 중앙에 사진 생성

                if (comboBoxKinds.Text == "Code39")                      //콤보박스에서 첫번째(code39)를 선택 했을때
                {
                    pictureBoxBarcode.Image = barcode.linearcode();
                }

                // 2번째(Code 93) 바코드 선택
                else if (comboBoxKinds.Text == "ITF")
                {

                    Regex regexnumber = new Regex(@"[0-9]");
                    Boolean ismattch = regexnumber.IsMatch(bar);

                    //상품 명 박스의 값이 숫자가 아니면 ""로 변경
                    if (!ismattch)
                    {
                        foreach (var t in textBoxes)
                        {
                            t.Text = "";
                        }
                        MessageBox.Show("숫자만");
                        return;
                    }

                    pictureBoxBarcode.Image = barcode.make_code93();
                }


                // 3번째(code128) 바코드 선택
                else if (comboBoxKinds.Text == "Code128")
                {
                    pictureBoxBarcode.Image = barcode.Code_128();
                }



                //4번째(bata Metrix) 바코드 선택
                else if (comboBoxKinds.Text == "Data metrix")
                {
                    if (bar.Length < 7)
                    {
                        MessageBox.Show("길이 7자리 이상");
                        return;
                    }
                    pictureBoxBarcode.Image = barcode.make_DataMetrix();
                }




                else if (comboBoxKinds.Text == "QR코드")                   //콤보박스에서 5번째(QR코드)를 선택 했을때
                {
                    pictureBoxBarcode.Image = barcode.barcode_create();

                }

            }
            else
            {
                MessageBox.Show("입력필수");
            }



        }


        //To file
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string path = @"C:/barcode generator/";
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists == false)
            {
                di.Create();
            }


            string fileName = $@"C:/barcode generator/\{textBoxName.Text}.jpg";              //저장 위치

            if (pictureBoxBarcode.Image != null)
            {
                pictureBoxBarcode.Image.Save(fileName);
                MessageBox.Show("성공");
            }
            else
            {
                MessageBox.Show("실패-저장할 바코드 없음");
            }
                                                            //바코드 이미지 저장 

            //수정 요망
            //int result = ljsLibrary.insertDB(constr, textBoxes);
            //바코드 정보 저장
            //Console.WriteLine(result);
            //DataSet dt = ljsLibrary.GetDBTable(constr);


            //dataGridView1.DataSource = dt.Tables[0];
            //ljsLibrary.CloseDB(constr);
        }

        //창닫기
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("창닫기 확인");

            this.Visible = false;
            form3.Visible = true;
        }

        //Dbselect
        private void buttonBdSelect_Click(object sender, EventArgs e)
        {

            dataGridView1.CellClick += (s, ev) => datagridview_CellClick(s, ev);

            if (comboBoxColumn.Text !="선택")
            {
                string column = "";
                if (comboBoxColumn.Text == "바코드 종류")
                {
                    column = "BarcodeKind";
                }
                else if (comboBoxColumn.Text == "상품명")
                {
                    column = "Product_Name";
                }
                else if (comboBoxColumn.Text == "등록일")
                {
                    column = "Registratin_Date";
                }
                else if (comboBoxColumn.Text == "정보1")
                {
                    column = "Info1";
                }
                else if (comboBoxColumn.Text == "정보2")
                {
                    column = "Info2";
                }
                else if (comboBoxColumn.Text == "정보3")
                {
                    column = "Info3";
                }
                string[] values = { textBoxDbSelect.Text };
                string query = sqlQuery.SelectAllFrom_Where_("BarcodeInfo", column, values);

                DataSet dataSet = crud.ReadToGrid(query);

                dataGridView1.DataSource = dataSet.Tables[0];
            }
            
            

        }


        //insertdb
        private void buttonInsertToDb_Click(object sender, EventArgs e)
        {
            string queryReadId = "select * from barcodeinfo where id=(select max(id) from barcodeinfo)";

            BarcodeInfo barcodeInfo = new BarcodeInfo();

            if (comboBoxKinds.Text.Length > 0 && textBoxName.Text.Length > 0 && textBoxDate.Text.Length > 0 && textBoxInfo1.Text.Length > 0 && textBoxInfo2.Text.Length > 0 && textBoxInfo3.Text.Length > 0)
            {
                barcodeInfo = crud.Read(queryReadId, barcodeInfo);
                barcodeInfo.Id++;
                barcodeInfo.BarcodeKind = comboBoxKinds.Text;
                barcodeInfo.Product_Name = textBoxName.Text;
                barcodeInfo.Registratin_Date = textBoxDate.Text;
                barcodeInfo.Info1 = textBoxInfo1.Text;
                barcodeInfo.Info2 = textBoxInfo2.Text;
                barcodeInfo.Info3 = textBoxInfo3.Text;
                barcodeInfo.MemberId = memberId;
            }
            

            string queryInsert = sqlQuery.InsertInto__Values_(barcodeInfo);

            if (crud.Create(queryInsert, barcodeInfo) > 0)
            {
                MessageBox.Show("Db 추가 확인");
                ljsLibrary.clear(textBoxName, textBoxDate, textBoxInfo1, textBoxInfo2, textBoxInfo3, textBoxInfoAll, pictureBoxBarcode);
                //duplicatedFunction.toggleButton(true, buttons);

            }
            else
            {
                MessageBox.Show("Db 추가 실패");
                ljsLibrary.clear(textBoxName, textBoxDate, textBoxInfo1, textBoxInfo2, textBoxInfo3, textBoxInfoAll, pictureBoxBarcode);
            }

        }

        //cellclick 콜백
        private void datagridview_CellClick(object s, DataGridViewCellEventArgs e)
        {
            pictureBoxBarcode.Image = null;
            string info = "";
            TextBox[] textBoxes = { textBoxName, textBoxDate, textBoxInfo1, textBoxInfo2, textBoxInfo3};

            comboBoxKinds.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            for (int i = 2; i < 7; i++)
            {
                info += dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString();
                textBoxes[i-2].Text = dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString();

            }
            textBoxInfoAll.Text = info;

            barcode_creation barcode = new barcode_creation(info);        //바코드 생성 클래스에 매개변수 전달하여 인스턴스 생성

            pictureBoxBarcode.SizeMode = PictureBoxSizeMode.StretchImage;       //파일 저장                                               //픽쳐박스 중앙에 사진 생성

            if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "Code39")                      //콤보박스에서 첫번째(code39)를 선택 했을때
            {
                pictureBoxBarcode.Image = barcode.linearcode();
                
            }

            // 2번째(Code 93) 바코드 선택
            else if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "ITF")
            {

                pictureBoxBarcode.Image = barcode.make_code93();
            }

            // 3번째(code128) 바코드 선택
            else if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "Code128")
            {
                pictureBoxBarcode.Image = barcode.Code_128();
            }



            //4번째(bata Metrix) 바코드 선택
            else if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "Data metrix")
            {
                pictureBoxBarcode.Image = barcode.make_DataMetrix();
            }




            else if (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() == "QR코드")                   //콤보박스에서 5번째(QR코드)를 선택 했을때
            {
                pictureBoxBarcode.Image = barcode.barcode_create();

            }

        }


        //dbclear
        private void buttonDbClear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        //DbSelectAll
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.CellClick += (s, ev) => datagridview_CellClick(s, ev);

            string query = sqlQuery.SelectAllFrom_("BarcodeInfo");

            DataSet dataSet = crud.ReadToGrid(query);

            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }

    /////////////////////////재선스 라이브러리
    ///
    public class barcode_creation
    {
        public string strText;


        public barcode_creation(string str)
        {
            strText = str ?? "";
        }


        // code39 바코드(1번째)
        public Bitmap linearcode()
        {

            ZXing.BarcodeWriter barcode = new ZXing.BarcodeWriter() { Format = ZXing.BarcodeFormat.CODE_39 };               //바코드 종류
            barcode.Options.Margin = 10;

            //strText = product_name2 + registration_date + info1 + info2 + info3;                                     //바코드 내용

            ZXing.QrCode.QrCodeEncodingOptions options = new ZXing.QrCode.QrCodeEncodingOptions();


            var qrcode = barcode.Write(strText);                                                                            //파일 쓰기
            Bitmap result1 = new Bitmap(qrcode);


            return result1;


        }

        //ITF (2번째 바코드)
        public Bitmap make_code93()
        {
            BarcodeWriter mk_code93 = new BarcodeWriter();


            mk_code93.Format = BarcodeFormat.CODABAR;
            mk_code93.Options.Margin = 10;
            mk_code93.Options.Height = 100;
            mk_code93.Options.Width = 100;

            //strText= product_name2 + registration_date + info1 + info2 + info3;
            var pdf = mk_code93.Write(strText);
            Bitmap result = new Bitmap(pdf);


            return result;
        }

        //Code128 (3번째)
        public Bitmap Code_128()
        {


            BarcodeWriter co128 = new BarcodeWriter();
            co128.Format = BarcodeFormat.CODE_128;


            //strText = product_name2 + registration_date + info1 + info2 + info3;

            var qrcode3 = co128.Write(strText);
            Bitmap result3 = new Bitmap(qrcode3);

            return result3;

        }


        // DataMetrix  (4번째 바코드)
        public Bitmap make_DataMetrix()
        {
            BarcodeWriter metrix = new BarcodeWriter()
            {
                Format = BarcodeFormat.DATA_MATRIX

            };

            //strText= product_name2 + registration_date + info1 + info2 + info3;



            var metrix1 = metrix.Write(strText);
            Bitmap result = new Bitmap(metrix1);


            return result;

        }


        //QR코드 생성  (5번째)
        public Bitmap barcode_create()
        {
            BarcodeWriter qrcode1 = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new ZXing.QrCode.QrCodeEncodingOptions { Width = 150, Height = 150, CharacterSet = "UTF-8" }

            };
            
            //strText = product_name2 + registration_date + info1 + info2 + info3;
            var qrcode2 = qrcode1.Write(strText);
            Bitmap result2 = new Bitmap(qrcode2);


            return result2;
        }

    }


    // 바코드 읽기
    class bar_read
    {
        private string name3;
        private Bitmap barcodeBitmap;



        public (Bitmap, string, string) read_barcode()
        {

            BarcodeReader reader = new BarcodeReader();

            //파일 불러오기
            OpenFileDialog ofd = new OpenFileDialog();


            ofd.Title = " 파일 읽기";
            string fileName = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;


                barcodeBitmap = (Bitmap)Image.FromFile(fileName);


                var result = reader.Decode(barcodeBitmap);                              //바코드 읽어옴


                name3 = result?.Text;                                                    //바코드 내용

            }
            //else if(ofd.ShowDialog() == DialogResult.Cancel)
            //{
            //    return ("","");
            //}


            return (barcodeBitmap, name3, fileName);                                          //바코드,내용 반환



        }



    }

    class LjsLibrary
    {
        public static string utf_8(string ut)
        {

            //비어 있는 문자열을 utf8string 변수에 대입 
            string utf8string = string.Empty;

            //utf-16 바이트를 배열로 얻어옴( C#의 string 형은 기본 UTF-16 타입)
            byte[] utf16 = Encoding.Unicode.GetBytes(ut); ;

            //utf-16바이트 배열을 utf-8로 변환
            byte[] utf8byte = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, utf16);

            //utf8 byte 배열 내부에 utf 문자 추가
            for (int i = 0; i < utf8byte.Length; i++)
            {
                //char 형은 2바이트로 0과 함께 채워줌 
                byte[] utf8Container = new byte[2] { utf8byte[i], 0 };
                utf8string += BitConverter.ToChar(utf8Container, 0);
            }

            return utf8string;
        }


        public void clear(TextBox txtProduct, TextBox txtRegistration, TextBox txtinfo1, TextBox txtinfo2, TextBox txtinfo3, TextBox textBoxInfoAll, PictureBox picbarcode)
        {


            txtProduct.Text = "";
            txtRegistration.Text = "";
            txtinfo1.Text = "";
            txtinfo2.Text = "";
            txtinfo3.Text = "";
            textBoxInfoAll.Text = "";


            //picbarcode.Image.Dispose();
            //picbarcode.Refresh();

            //picbarcode.Image.Dispose();

            //**********************************************수정*************************//
            picbarcode.Image = null;
            picbarcode.Update();


            //**************************************************************************//
            //picbarcode.Invalidate();



        }

        public void CloseDB(string constr)
        {
            SqlConnection conn = new SqlConnection(constr);
            if (conn != null)
            {
                conn.Close();
            }
        }

        public DataSet GetDBTable(string constr)
        {

            SqlConnection conn = new SqlConnection(constr);

            conn.Open();
            string sql2 = "SELECT Product_name,Registratin_Date,info1,info2,info3 FROM dbo.BarcodeInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(sql2, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            //DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;


        }

        public int insertDB(string constr, List<TextBox> textboxs)
        {
            int result = -2;
            try
            {
                if (textboxs[0].Text != "")
                {
                    using (SqlConnection conn = new SqlConnection(constr))
                    {

                        conn.Open();
                        string sql = "insert into BarcodeInfo(Product_Name,Registratin_Date,info1,info2,info3) Values(@Product_Name,@Registratin_Date,@info1,@info2,@info3)";

                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.Add(new SqlParameter("@Product_Name", textboxs[0].Text));
                            cmd.Parameters.Add(new SqlParameter("@Registratin_Date", textboxs[1].Text));
                            cmd.Parameters.Add(new SqlParameter("@info1", textboxs[2].Text));
                            cmd.Parameters.Add(new SqlParameter("@info2", textboxs[3].Text));
                            cmd.Parameters.Add(new SqlParameter("@info3", textboxs[4].Text));

                            result = cmd.ExecuteNonQuery();

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("이미 상품 명이 존재 합니다" + ex);
            }

            return result;

        }

        public void baReader(string constr, string fileName, List<TextBox> buttons)
        {

            //string search1 = Form1.fileName;
            string search1 = Path.GetFileName(fileName);
            string[] substr = search1.Split('.');
            string substr1 = substr[0];

            string sql = "SELECT * FROM dbo.BarcodeInfo WHERE Product_Name='" + substr1 + "'";

            using (SqlConnection conn = new SqlConnection(constr))
            {
                conn.Open();



                SqlCommand cmd = new SqlCommand(sql, conn);

                //Product_name,Registratin_Date,info1,info2,info3

                //SqlDataReader rdr = cmd.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                ;
                DataSet ds = new DataSet();
                da.Fill(ds, "barcode_table");

                DataTable dtitem = ds.Tables[0];
                DataRow rwitem = dtitem.Rows?[0];




                buttons[0].Text = rwitem["Product_Name"].ToString();
                buttons[1].Text = rwitem["Registratin_Date"].ToString();
                buttons[2].Text = rwitem["info1"].ToString();
                buttons[3].Text = rwitem["info2"].ToString();
                buttons[4].Text = rwitem["info3"].ToString();





            }
        }

    }

    public class BarcodeInfo
    {
        public int Id { get; set; }
        public string BarcodeKind { get; set; }
        public string Product_Name { get; set; }
        public string Registratin_Date { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        public string Info3 { get; set; }

        public string MemberId { get; set; }
    }

}
