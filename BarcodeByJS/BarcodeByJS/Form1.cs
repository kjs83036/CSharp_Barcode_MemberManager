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

namespace BarcodeByJS
{
    public partial class Form1 : Form
    {
        LjsLibrary ljsLibrary;
        List<TextBox> textBoxes;
        string constr;
        public Form1()
        {
            InitializeComponent();

            ljsLibrary = new LjsLibrary();

            textBoxes = new List<TextBox>();

            this.textBoxes.Add(textBoxName);
            this.textBoxes.Add(textBoxDate);
            this.textBoxes.Add(textBoxInfo1);
            this.textBoxes.Add(textBoxInfo2);
            this.textBoxes.Add(textBoxInfo3);

            this.constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\2klab\OneDrive\2kd\Projects_c#\BarcodeByJS\BarcodeByJS\BarcodeInfoDB.mdf";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxKinds_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox.Text == "QR코드 (2D)")
            {
                textBoxName.ImeMode = ImeMode.NoControl;
                textBoxDate.ImeMode = ImeMode.NoControl;
                textBoxInfo1.ImeMode = ImeMode.NoControl;
                textBoxInfo2.ImeMode = ImeMode.NoControl;
                textBoxInfo3.ImeMode = ImeMode.NoControl;
            }

            else if (comboBox.Text == "ITF (1D)")
            {
                textBoxName.ImeMode = ImeMode.Disable;
                textBoxDate.ImeMode = ImeMode.Disable;
                textBoxInfo1.ImeMode = ImeMode.Disable;
                textBoxInfo2.ImeMode = ImeMode.Disable;
                textBoxInfo3.ImeMode = ImeMode.Disable;

                
            }
            else
            {
                textBoxName.ImeMode = ImeMode.Disable;
                textBoxDate.ImeMode = ImeMode.Disable;
                textBoxInfo1.ImeMode = ImeMode.Disable;
                textBoxInfo2.ImeMode = ImeMode.Disable;
                textBoxInfo3.ImeMode = ImeMode.Disable;
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            bar_read reader = new bar_read();                   //바코드 생성 클래스 인스턴스 생성


            var temp = reader.read_barcode();                    //바코드 read함수를 통해  (비트맵, text 값) 받아옴

            if (temp.Item1 != null)
            {

                string result = temp.Item2;                                // 읽어온 바코드 text 값 


                pictureBoxBarcode.Image = temp.Item1;                      // 읽어온 이미지

                ljsLibrary.baReader(constr, temp.Item3, textBoxes);


            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

            ljsLibrary.clear(textBoxName, textBoxDate, textBoxInfo1, textBoxInfo2, textBoxInfo3, pictureBoxBarcode);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

            string bar = textBoxName.Text + textBoxDate.Text + textBoxInfo1.Text + textBoxInfo2.Text + textBoxInfo3.Text;
            barcode_creation barcode = new barcode_creation(bar);        //바코드 생성 클래스에 매개변수 전달하여 인스턴스 생성

            pictureBoxBarcode.SizeMode = PictureBoxSizeMode.StretchImage;       //파일 저장                                               //픽쳐박스 중앙에 사진 생성

            if (comboBoxKinds.Text == "Code39 (1D)")                      //콤보박스에서 첫번째(code39)를 선택 했을때
            {
                pictureBoxBarcode.Image = barcode.linearcode();
            }

            // 2번째(Code 93) 바코드 선택
            else if (comboBoxKinds.Text == "ITF (1D)")
            {

                Regex regexnumber = new Regex(@"[0-9]");
                Boolean ismattch = regexnumber.IsMatch(bar);

                //상품 명 박스의 값이 숫자가 아니면 ""로 변경
                if (!ismattch)
                {
                    foreach( var t in textBoxes)
                    {
                        t.Text = "";
                    }
                    MessageBox.Show("숫자만");
                    return;
                }

                pictureBoxBarcode.Image = barcode.make_code93();
            }


            // 3번째(code128) 바코드 선택
            else if (comboBoxKinds.Text == "Code128 (1D)")
            {
                pictureBoxBarcode.Image = barcode.Code_128();
            }



            //4번째(bata Metrix) 바코드 선택
            else if (comboBoxKinds.Text == "Data metrix (2D)")
            {
                if (bar.Length < 7)
                {
                    MessageBox.Show("길이 7자리 이상");
                    return;
                }
                pictureBoxBarcode.Image = barcode.make_DataMetrix();
            }




            else if (comboBoxKinds.Text == "QR코드 (2D)")                   //콤보박스에서 5번째(QR코드)를 선택 했을때
            {
                pictureBoxBarcode.Image = barcode.barcode_create();

            }


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string path = @"C:/barcode generator/";
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists == false)
            {
                di.Create();
            }


            string fileName = $@"C:\Users\2klab\OneDrive\2kd\Projects_c#\BarcodeByJS\{textBoxName.Text}.jpg";              //저장 위치

            pictureBoxBarcode.Image.Save(fileName);                                                //바코드 이미지 저장 

            int result = ljsLibrary.insertDB(constr, textBoxes);
            //바코드 정보 저장
            Console.WriteLine(result);
            //DataSet dt = ljsLibrary.GetDBTable(constr);


            //dataGridView1.DataSource = dt.Tables[0];
            ljsLibrary.CloseDB(constr);
        }
    }

    /////////////////////////재선스 라이브러리
    ///
    public class barcode_creation
    {
        public string strText;


        public barcode_creation(string str)
        {
            strText = str;
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
                Options = new ZXing.QrCode.QrCodeEncodingOptions { Width = 150, Height = 150 }

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


                name3 = result.Text;                                                    //바코드 내용

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


        public void clear(TextBox txtProduct, TextBox txtRegistration, TextBox txtinfo1, TextBox txtinfo2, TextBox txtinfo3, PictureBox picbarcode)
        {


            txtProduct.Text = "";
            txtRegistration.Text = "";
            txtinfo1.Text = "";
            txtinfo2.Text = "";
            txtinfo3.Text = "";


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
                DataRow rwitem = dtitem.Rows[0];




                buttons[0].Text = rwitem["Product_Name"].ToString();
                buttons[1].Text = rwitem["Registratin_Date"].ToString();
                buttons[2].Text = rwitem["info1"].ToString();
                buttons[3].Text = rwitem["info2"].ToString();
                buttons[4].Text = rwitem["info3"].ToString();





            }
        }

    }
}
