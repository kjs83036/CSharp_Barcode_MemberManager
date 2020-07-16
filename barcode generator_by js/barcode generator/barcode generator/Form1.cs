using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Runtime.InteropServices;
using System.Net.Http.Headers;
using ZXing;
using ZXing.QrCode;
using System.Runtime.Remoting.Messaging;
using ZXing.OneD;
using System.Xml.Schema;
using Microsoft.SqlServer.Server;
using System.Collections;
using ZXing.PDF417.Internal;
using ZXing.PDF417;
using System.Text.RegularExpressions;
using ZXing.Maxicode;
using ZXing.Rendering;

namespace barcode_generator
{


    public partial class Form1 : Form
    {

        public string Product_Name = "";                 //상품 명
        public string Registratin_Date = "";            //등록 일           
        public string info1 = "";                       //정보1 내용
        public string info2 = "";                       //정보2 내용
        public string info3 = "";                       //정보3 내용

        private static int sort = -1;

        static public string fileName;          //파일 명
        public string result = "";              //바코드 읽기 데이터
        Dictionary<string, string> dic = new Dictionary<string, string>();


        public Form1()
        {
            InitializeComponent();


        }


        //문자열을 utf-8로 인코딩(코드 수정하여 사용하지 않음)
        public static string  utf_8(string ut)
        {
            /*  byte[] bytes = Encoding.Default.GetBytes(ut);
              string utf_string = Encoding.UTF8.GetString(bytes);

              return utf_string;*/

            /*  System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
              byte[] utf_8 = utf8.GetBytes(ut);

              //utf-8을 string으로 변환
              string ut8_sting = "";
              foreach (byte b in utf_8)
              {
                  ut8_sting += "%" + string.Format("{0:X}", b);
              }

              return ut8_sting;*/

            string utf8string = string.Empty;

            //utf-16 바이트를 배열로 얻어옴
            byte[] utf16 = Encoding.Unicode.GetBytes(ut); ;

            //utf-16바이트 배열을 utf-8로 변환
            byte[] utf8byte = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, utf16);

            //utf8 byte 배열 내부에 utf 문자 추가
            for (int i = 0; i< utf8byte.Length; i++)
            {
                //char 형은 2바이트로 0과 함께 채워줌 
                byte[] utf8Container = new byte[2] { utf8byte[i], 0 };
                utf8string += BitConverter.ToChar(utf8Container, 0);
            }

            return utf8string;
        }

        // 숫자만 입력 받는 함수
        private string st_num(string text)
        {
           
            Regex regexnumber = new Regex(@"[0-9]");    //정규식 0~9 숫자만
            Boolean ismattch = regexnumber.IsMatch(text);

            //상품 명 박스의 값이 숫자가 아니면 /로 변경
            if (!ismattch)
            {
                text = "/";
            }


            return text;
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //콤보박스( 바코트 종류 선택)
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            
            
            if( cb.SelectedIndex==0)         //1D바코드(code39)
            {
                sort = 0;
                MessageBox.Show("숫자or 문자만(한글제외) 입력하세요");
                this.KeyPreview = true;
                if (this.ImeMode != ImeMode.Disable)                //영문 입력모드
                {
                    this.ImeMode = ImeMode.Disable;
                }
            }

            else if (cb.SelectedIndex == 1)       //ITF 바코드
            {
                sort = 1;
                MessageBox.Show("숫자만 입력 해주세요/ 문자는 /로 표시됩니다");
                this.KeyPreview = true;
                if (this.ImeMode != ImeMode.Disable)            //영문 입력 모드
                {
                    this.ImeMode = ImeMode.Disable;
                }
            }

            else if (cb.SelectedIndex == 2)       //code128 바코드
            {
                sort = 2;
                MessageBox.Show("한글을 제외하고 입력해주세요");
                this.KeyPreview = true;
                if (this.ImeMode != ImeMode.Disable)                //영문 입력 모드
                {
                    this.ImeMode = ImeMode.Disable;
                }
            }
            




            else if (cb.SelectedIndex==3)       //bataMetrix 바코드
            {
                sort = 3;
                MessageBox.Show("한글을 제외하고 입력해주세요");
                this.KeyPreview = true;
                if (this.ImeMode != ImeMode.Disable)
                {
                    this.ImeMode = ImeMode.Disable;
                }
            }

            
            else if (cb.SelectedIndex == 4)         //QR코드
            {
                sort = 4;
                this.KeyPreview = true;
                if (this.ImeMode != ImeMode.NoControl)              //한글 입력 가능 모드
                {
                    this.ImeMode = ImeMode.NoControl;
                }

            }



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //상품 명 text상자
        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            if (sort == 0)
            {

                txtProduct.ImeMode = ImeMode.Disable;
                txtProduct.MaxLength = 5;

            }

            else if(sort ==1)
            {
                st_num(txtProduct.Text);


            }



            else if (sort == 4)
            {

                txtProduct.ImeMode = ImeMode.NoControl;
                txtProduct.MaxLength = 200;
            }
            else if (sort != 4)
            {
                txtProduct.ImeMode = ImeMode.Disable;
                if (sort != 0)
                {
                    txtProduct.MaxLength = 200;
                }
            }



            Product_Name = txtProduct.Text;
        }


        //등록 일 text상자
        private void textBox2_TextChanged(object sender, EventArgs e)   
        {
            if (sort == 0)      //code39 바코드 일때
            {

                txtRegistration.MaxLength = 10;
                txtRegistration.ImeMode = ImeMode.Disable;
                //Registratin_Date = utf_8(txtRegistration.Text);
               

            }

            else if (sort == 1)
            {
                st_num(txtProduct.Text);


            }

            else if (sort == 4 )
            {
                txtRegistration.ImeMode = ImeMode.NoControl;
                txtRegistration.MaxLength = 200;
            }
            else if (sort != 4  )        // QR코드를 제외한 바코드
            {
                txtRegistration.ImeMode = ImeMode.Disable;
                
                if (sort != 0)                // code39 바코드 제외
                {
                    txtRegistration.MaxLength = 200;
                   
                }
            }

         

            Registratin_Date = txtRegistration.Text;
        }

       /* private void btnCreate_MouseDown(object sender, MouseEventArgs e)
        {

            QRCode qr = new QRCode(ProductName, Registratin_Date, info1, info2, info3);

            qr.barcode_create(ProductName, Registratin_Date, info1, info2, info3);
        }*/


        //clear 버튼
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.btnClear = new System.Windows.Forms.Button();

            clear();
            
        }

        //clear 함수
        private void clear()
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

        private void registrationDate_Click(object sender, EventArgs e)
        {
            

        }

        
        //정보1 text박스
        private void txtinfo1_TextChanged(object sender, EventArgs e)          
        {
            
            if (sort == 0)                      //첫번째 바코드(code 39)
            {

                txtinfo1.MaxLength = 3;
                txtinfo1.ImeMode = ImeMode.Disable;       

            }
            else if (sort == 1)
            {
                st_num(txtProduct.Text);


            }

            else if (sort == 4 )             //두번째 바코드(QR코드)
            {

                txtinfo1.ImeMode = ImeMode.NoControl;
                txtinfo1.MaxLength = 200;
            }

            else if (sort != 4 )            // 나머지 바코드
            {
                txtinfo1.ImeMode = ImeMode.Disable; 

                if (sort != 0)              
                {
                    txtinfo1.MaxLength = 200;
                }
            }



            info1 = txtinfo1.Text;


        }


        //정보2 text박스
        private void txtinfo2_TextChanged(object sender, EventArgs e)         
        {
            if (sort == 0)
            {

                txtinfo2.MaxLength = 3;
                txtinfo2.ImeMode=ImeMode.Disable;
               

            }
            else if (sort == 1)
            {
                st_num(txtProduct.Text);
               

            }
            else if (sort == 4 )
            {

                txtinfo2.ImeMode = ImeMode.NoControl;
                txtinfo2.MaxLength = 200;
                
            }

            else if (sort != 4 )
            {
                txtinfo2.ImeMode = ImeMode.Disable;
               
               
                if (sort != 0)
                {
                    txtinfo2.MaxLength = 200;
                }
            }

         
            info2 = txtinfo2.Text;

        }


        //정보3 text박스
        private void txtinfo3_TextChanged(object sender, EventArgs e)          
        {
            if (sort == 0)
            {
              
                txtinfo3.MaxLength = 3;
                txtinfo3.ImeMode = ImeMode.Disable;
             
            }
           /* else if (sort == 1)
            {
                st_num(txtProduct.Text);


            }*/
            else if (sort == 4 )
            {
                txtinfo3.ImeMode = ImeMode.NoControl;
                txtinfo3.MaxLength = 200;
            }

            else if (sort != 4)
            {
                txtinfo3.ImeMode = ImeMode.Disable;
                
                if (sort != 0)
                {
                    txtinfo3.MaxLength = 200;
                }
            }
       
           
            info3 = txtinfo3.Text;
        }

        private void picbarcode_Click(object sender, EventArgs e)
        {

            

        }

        //콤보박스
        private void btnCreate_Click(object sender, EventArgs e)
        {


            if (sort == 0)                      //콤보박스에서 첫번째(code39)를 선택 했을때
            {
                try
                {
                    barcode_creation linear = new barcode_creation(Product_Name, Registratin_Date, info1, info2, info3);        //바코드 생성 클래스에 매개변수 전달하여 인스턴스 생성
                    //linear.linearcode();



                    SaveFileDialog dialog = new SaveFileDialog();                                                               //파일 저장 경로 입력
                    dialog.Title = "저장 경로를 지정하세요";

                    dialog.OverwritePrompt = true;
                    dialog.Filter = "JPEC File(*.jpg)|*.jpg |Bitmap File(*.bmp)|*.bmp |PNG File(*.png)|*.png";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Form1.fileName = dialog.FileName;

                    }
                    picbarcode.SizeMode = PictureBoxSizeMode.StretchImage;                                                      //픽쳐박스 중앙에 사진 생성
                    picbarcode.Image = linear.linearcode();
                    picbarcode.Image.Save(fileName);                                                                            //파일 저장

                }

                catch (Exception ee)                                          //저장 안될 시 예외처리                                                
                {

                    MessageBox.Show("한글이 포함되면 안되니다.not load the code39(1번째 바코드)");
                }



            }

           

            // 2번째(Code 93) 바코드 선택
            else if (sort == 1)
            {
                try
                {
                    barcode_creation rss = new barcode_creation(Product_Name, Registratin_Date, info1, info2, info3);


                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Title = "저장 경로를 지정하세요";

                    dialog.OverwritePrompt = true;
                    dialog.Filter = "JPEC File(*.jpg)|*.jpg |Bitmap File(*.bmp)|*.bmp |PNG File(*.png)|*.png";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        fileName = dialog.FileName;


                    }
                    picbarcode.SizeMode = PictureBoxSizeMode.StretchImage;
                    //picbarcode.Size = new Size(250, 250);
                    picbarcode.Image = rss.make_code93();
                    picbarcode.Image.Save(fileName);



                }

                catch (Exception ee)
                {
                    MessageBox.Show("not load the code_93(2번째 바코드)");
                }
            }


            // 3번째(code128) 바코드 선택
            else if (sort == 2)
            {
                try
                {
                    barcode_creation co128 = new barcode_creation(Product_Name, Registratin_Date, info1, info2, info3);
                    co128.Code_128();




                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Title = "저장 경로를 지정하세요";

                    dialog.OverwritePrompt = true;
                    dialog.Filter = "JPEC File(*.jpg)|*.jpg |Bitmap File(*.bmp)|*.bmp |PNG File(*.png)|*.png";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        fileName = dialog.FileName;


                    }
                    picbarcode.SizeMode = PictureBoxSizeMode.StretchImage;
                    //picbarcode.Size = new Size(250, 250);
                    picbarcode.Image = co128.Code_128();
                    picbarcode.Image.Save(fileName);



                }

                catch (Exception ee)
                {
                    MessageBox.Show("not load the code_128(3번째 바코드)");
                }
            }



            //4번째(bata Metrix) 바코드 선택
            else if (sort == 3)
            {
                try
                {
                    barcode_creation maxicode = new barcode_creation(Product_Name, Registratin_Date, info1, info2, info3);


                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Title = "저장 경로를 지정하세요";

                    dialog.OverwritePrompt = true;
                    dialog.Filter = "JPEC File(*.jpg)|*.jpg |Bitmap File(*.bmp)|*.bmp |PNG File(*.png)|*.png";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        fileName = dialog.FileName;


                    }
                    picbarcode.SizeMode = PictureBoxSizeMode.StretchImage;
                    //picbarcode.Size = new Size(250, 250);
                    picbarcode.Image = maxicode.make_DataMetrix();
                    picbarcode.Image.Save(fileName);



                }

                catch (Exception ee)
                {
                    MessageBox.Show("not load the code_128(4번째 바코드)");
                }
            }


           

            else if (sort == 4)                   //콤보박스에서 5번째(QR코드)를 선택 했을때
            {
                try
                {


                    barcode_creation bacoder = new barcode_creation(Product_Name, Registratin_Date, info1, info2, info3);                   //바코드 생성 클래스 객체 생성



                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.Title = "저장 경로를 지정하세요";

                    dialog.OverwritePrompt = true;
                    dialog.Filter = "JPEC File(*.jpg)|*.jpg |Bitmap File(*.bmp)|*.bmp |PNG File(*.png)|*.png";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        fileName = dialog.FileName;


                    }

                    picbarcode.SizeMode = PictureBoxSizeMode.StretchImage;
                    //picbarcode.Size = new Size(250, 250);
                    picbarcode.Image = bacoder.barcode_create();
                    picbarcode.Image.Save(fileName);


                }

                catch (Exception ee)
                {
                    MessageBox.Show("not load the qrcode(5번째 바코드)");
                }

            }


        }




        //바코드 읽기 버튼
        private void btn_read_Click(object sender, EventArgs e)
        {
            
            bar_read reader = new bar_read();                   //바코드 생성 클래스 인스턴스 생성
           
            
            var temp= reader.read_barcode();                    //바코드 read함수를 통해  (비트맵, text 값) 받아옴
            
           
            result = temp.Item2;                                // 읽어온 바코드 text 값 
            
            picbarcode.Image = temp.Item1;                      // 읽어온 이미지


            MessageBox.Show(result);

        }



        //상품 명 텍스트박스에서 키 눌렸을 때 입력 모드 변경
        private void txtProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            

            //QR코드 제외한 나머지 바코드 
            if (sort != 4)
            {
                if (txtProduct.ImeMode != ImeMode.Disable)      //영문 입력모드로 변경
                {
                    txtProduct.ImeMode = ImeMode.Disable;
                }
            }

            //QR코드 
            else if (sort == 4)
            {
                if (txtProduct.ImeMode != ImeMode.NoControl)    //한글 입력 가능모드로 변경
                {
                    txtProduct.ImeMode = ImeMode.NoControl;
                }
            }

            else if(sort ==1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
                if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }

            }
           

        }

        //등록 일 텍스트 박스에서 키가 눌렸을 때  입력 모드 변경
        private void txtRegistration_KeyPress(object sender, KeyPressEventArgs e)
        {
            //QR코드 제외한 나머지  바코드
            if (sort != 4 )
            {
                if (txtRegistration.ImeMode != ImeMode.Disable)
                {
                    txtRegistration.ImeMode = ImeMode.Disable;
                }
            }
            else if (sort == 4)
            {
                if (txtRegistration.ImeMode != ImeMode.NoControl)
                {
                    txtRegistration.ImeMode = ImeMode.NoControl;
                }
            }

        }

        //정보1 텍스트 박스에서 키가 눌렸을 때 입력 모드 변경

        private void txtinfo1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (sort != 4)
            {
                if (txtinfo1.ImeMode != ImeMode.Disable)
                {
                    txtinfo1.ImeMode = ImeMode.Disable;
                }
            }

            else if (sort == 4 )
            {
                if (txtinfo1.ImeMode != ImeMode.NoControl)
                {
                    txtinfo1.ImeMode = ImeMode.NoControl;
                }
            }
        }

        //정보2 텍스트 박스에서 기카 눌렸을 때 입력 모드 변경
        private void txtinfo2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (sort != 4 )
            {
                if (txtinfo2.ImeMode != ImeMode.Disable)
                {
                    txtinfo2.ImeMode = ImeMode.Disable;
                }
            }
            else if (sort == 4 )
            {
                if (txtinfo2.ImeMode != ImeMode.NoControl)
                {
                    txtinfo2.ImeMode = ImeMode.NoControl;
                }
            }
        }

        //정보3 텍스트 박스에서 키가 눌렸을 때 입력 모드로 변경
        private void txtinfo3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (sort != 4 )
            {
                if (txtinfo3.ImeMode != ImeMode.Disable)
                {
                    txtinfo3.ImeMode = ImeMode.Disable;
                }
            }
            else if (sort == 4 )
            {
                if (txtinfo3.ImeMode != ImeMode.NoControl)
                {
                    txtinfo3.ImeMode = ImeMode.NoControl;
                }
            }
        }

   





        

    }

    //  바코드만드는 class
    public class barcode_creation
    {
       
        
        private string product_name2;                       //제품 명
        string registration_date;                           //등록 일
        string info1;                                       //정보1
        string info2;                                       //정보2
        string info3;                                       //정보3

        public barcode_creation(string name, string date, string info1, string info2, string info3)                     // 변수 초기화
        {
            product_name2 = name;
            registration_date = date;
            this.info1 = info1;
            this.info2 = info2;
            this.info3 = info3;
        }

       





        // code39 바코드(1번째)
        public Bitmap linearcode()
        {

            ZXing.BarcodeWriter barcode = new ZXing.BarcodeWriter() { Format = ZXing.BarcodeFormat.CODE_39 };               //바코드 종류

            
            //barcode.Format = ZXing.BarcodeFormat.CODE_128;
            //barcode.Format = ZXing.BarcodeFormat.CODE_93;
          
            string strText = product_name2 + registration_date + info1 + info2 + info3;                                     //바코드 내용

            
            var qrcode = barcode.Write(Form1.utf_8(strText));                                                                            //파일 쓰기
            //Bitmap result1 = new Bitmap(qrcode);
            


            return qrcode;
            


        }

        //ITF (2번째 바코드)
        public Bitmap make_code93()
        {
            BarcodeWriter mk_code93 = new BarcodeWriter();


            mk_code93.Format = BarcodeFormat.CODABAR;
            mk_code93.Options.Margin = 10;
            mk_code93.Options.Height = 200;
            mk_code93.Options.Width = 200;

            string url = product_name2 + registration_date + info1 + info2 + info3;
            var pdf = mk_code93.Write(Form1.utf_8(url));
            Bitmap result = new Bitmap(pdf);


            return result;
        }

        //Code128 (3번째)
        public Bitmap Code_128()
        {


            BarcodeWriter co128 = new BarcodeWriter();
            co128.Format = BarcodeFormat.CODE_128;


            var url = product_name2 + registration_date + info1 + info2 + info3;
            var qrcode3 = co128.Write(Form1.utf_8(url));

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

            var url = product_name2 + registration_date + info1 + info2 + info3;
            var metrix1 = metrix.Write(Form1.utf_8(url));
            Bitmap result = new Bitmap(metrix1);
            

            return result;

        }


        //QR코드 생성  (5번째)
        public Bitmap barcode_create()
        {


            BarcodeWriter qrcode1 = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions { Width = 150, Height = 150 }

            };
            var url = product_name2 + registration_date + info1 + info2 + info3;
            var qrcode2 = qrcode1.Write(Form1.utf_8(url));
            Bitmap result2 = new Bitmap(qrcode2);




            return result2;
        }

    }


    // 바코드 읽기
    class bar_read
    {
        private string name3;
       


       /* public bar_read(string name, string date, string no1, string no2, string no3)
        {
            product_name3 = name;
            registration_date3 = date;
            info1 = no1;
            info2 = no2;
            info3 = no3;
        }*/

        public (Bitmap, string) read_barcode()
        {

            BarcodeReader reader = new BarcodeReader();
           

            //파일 불러오기
            OpenFileDialog ofd = new OpenFileDialog();
           
            
            ofd.Title = " 파일 읽기";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Form1.fileName = ofd.FileName;
            }

            var barcodeBitmap = (Bitmap)Image.FromFile(Form1.fileName);
           
            
            var result = reader.Decode(barcodeBitmap);                              //바코드 읽어옴
           
            
            name3 = result.Text;                                                    //바코드 내용
            

            return (barcodeBitmap, name3);                                          //바코드,내용 반환



        }



    }


}




