﻿using KjsLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ZXing;

namespace MemberBarcode
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        private string memberId;
        private Crud crud;
        private DuplicatedFunction duplicatedFunction;
        private SqlQuery sqlQuery;
        TextBox[] TextBoxesBarcode;
        TextBox[] TextBoxesUpdate;
        TextBox[] textBoxes;
        LjsLibrary ljsLibrary;
        string[] BarcodeColumns;
        string date;

        public Form1(Form2 form2, string memberId, Crud crud, DuplicatedFunction duplicatedFunction, SqlQuery sqlQuery)
        {
            InitializeComponent();
            this.form2 = form2;
            this.memberId = memberId;
            this.crud = crud;
            this.duplicatedFunction = duplicatedFunction;
            this.sqlQuery = sqlQuery;
            ljsLibrary = new LjsLibrary();
            this.textBoxes = new TextBox[] { textBoxName, textBoxInfo, textBoxInfoStocks, textBoxInfoPrice };
            this.TextBoxesBarcode = new TextBox[] { textBoxName, textBoxInfo, textBoxInfoStocks, textBoxInfoPrice };
            this.TextBoxesUpdate = new TextBox[] { textBoxUpdateId, textBoxUpdatePassword, textBoxUpdateName, textBoxUpdatePhone, textBoxUpdateEmail, textBoxUpdatePosition };
            this.BarcodeColumns = new string[] { "BarcodeKind", "ProductName", "RegistratinDate", "Info", "Stocks", "Price"};
            this.date = DateTime.Now.ToString();
        }

        //변경
        private void buttonUpdateMember_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = true;
            tabControl1.Visible = false;
            string[] values = { memberId };
            string qeuryReadMember = sqlQuery.SelectAllFrom_Where_("MEMBER", "ID", values);

            Member member = crud.Read(qeuryReadMember, new Member());

            textBoxUpdateId.Text = member.Id;
            textBoxUpdateId.ReadOnly = true;
            textBoxUpdateId.BackColor = Color.WhiteSmoke;
            textBoxUpdatePassword.Text = member.Password;
            textBoxUpdateName.Text = member.Name;
            textBoxUpdatePhone.Text = member.Phone;
            textBoxUpdateEmail.Text = member.Email;
            textBoxUpdatePosition.Text = member.Position;
            textBoxUpdatePosition.ReadOnly = true;
            textBoxUpdatePosition.BackColor = Color.WhiteSmoke;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 화면에 유저 정보를 보여주기 위함
            MemberInformation memberInformation = new MemberInformation();
            string[] values = { memberId };
            string qeuryReadMemberInformation = sqlQuery.SelectAllFrom_Where_("MEMBERInformation", "MEMBERID", values);
            memberInformation = crud.Read(qeuryReadMemberInformation, memberInformation);

            textBoxId.Text = memberId + "님";
            textBoxPoint.Text = "Point : " + Convert.ToString(memberInformation.Point);
            textBoxWriting.Text = " Writing : " + Convert.ToString(memberInformation.Writing);
            textBoxActivity.Text = "Activity : " + Convert.ToString(memberInformation.Activity);

            //차트에 xseries 추가    
            chart1.Series.Add("x");
            chart1.Series["x"].ChartType = SeriesChartType.Column;

            Legend legend = new Legend();
            legend.Name = "legend";
            chart1.Legends.Add(legend);
            chart1.Series["x"].Legend = "legend";
            chart1.Series["x"].LegendText = "legend";

            //회원 히스토리를 위함
            string qeuryReadAll = sqlQuery.SelectAllFrom_Where_("MEMBERInformation", "MEMBERID", values);
            DataSet dataSet = crud.ReadToGrid(qeuryReadAll);

            dataGridViewMemberInformation.DataSource = dataSet.Tables[0];
        }

        //취소
        private void buttonUpdateCancle_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = false;
            tabControl1.Visible = true;
            duplicatedFunction.textClearTextBox(TextBoxesUpdate);
        }

        //로그아웃
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form2.Visible = true;
        }

        //패널안 업데이트 변경
        private void buttonUpdatePanelUpdate_Click(object sender, EventArgs e)
        {
            string[] values = { memberId };
            string qeuryReadMember = sqlQuery.SelectAllFrom_Where_("MEMBER", "ID", values);
            string queryReadMemberHistoryMaxRownum = sqlQuery.selectAllFrom_WhereRowNumSelect_RowNumFrom_("MemberHistory", "Max");

            Member member = crud.Read(qeuryReadMember, new Member());
            MemberHistory memberHistory = crud.Read(queryReadMemberHistoryMaxRownum, new MemberHistory());

            string qeuryUpdate = sqlQuery.Update_Set_("MEMBER");

            member = new Member
            {
                Rownum = member.Rownum,
                Id = textBoxUpdateId.Text,
                Password = textBoxUpdatePassword.Text,
                Name = textBoxUpdateName.Text,
                Phone = textBoxUpdatePhone.Text,
                Email = textBoxUpdateEmail.Text,
                Position = textBoxUpdatePosition.Text,
                RegistrationDate = member.RegistrationDate
                
            };

            Member memberResult = crud.Read(qeuryReadMember, member);


            if (memberResult.Id == null)
            {
                MessageBox.Show("변경 불가");
                duplicatedFunction.listLabelAndTextClear();

            }
            else
            {
                if (crud.Update(qeuryUpdate, (Member)member) > -1)
                {
                    MessageBox.Show("변경 확인");
                    duplicatedFunction.textClearTextBox(TextBoxesUpdate);
                    buttonUpdateCancle_Click(sender, e);


                }
                else
                {
                    MessageBox.Show("변경 실패");
                    duplicatedFunction.textClearTextBox(TextBoxesUpdate);
                }
            }
        }

        //생성
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Regex regexnumber = new Regex(@"[0-9]");
            Boolean isStockNumber = regexnumber.IsMatch(textBoxInfoStocks.Text);
            Boolean isPriceNumber = regexnumber.IsMatch(textBoxInfoPrice.Text);
            if (comboBoxKinds.Text.Length > 0 && textBoxName.Text.Length > 0 && textBoxInfo.Text.Length > 0 && textBoxInfoStocks.Text.Length > 0 && textBoxInfoPrice.Text.Length > 0 && isStockNumber && isPriceNumber)
            {
                string bar = textBoxName.Text + textBoxInfo.Text + textBoxInfoStocks.Text + textBoxInfoPrice.Text;
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
                MessageBox.Show("입력필수 AND 재고, 가격은 숫자");
            }
        }

        //파일저장 & DB저장
        private void buttonToFile_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;

            //파일처리
            string path = textBoxPath.Text;
            string bar = textBoxName.Text + textBoxInfo.Text + textBoxInfoStocks.Text + textBoxInfoPrice.Text;
            if (path != "")
            {
                DirectoryInfo di = new DirectoryInfo(path);
                if (di.Exists == false)
                {
                    di.Create();
                }
            }
            else
            {
                MessageBox.Show("경로설정필수");
                return;
            }

            //DB처리
            string queryReadMaxRow = sqlQuery.selectAllFrom_WhereRowNumSelect_RowNumFrom_("Barcode", "MAX");

            Barcode barcode = new Barcode();
            barcode = crud.Read(queryReadMaxRow, barcode);

            if (comboBoxKinds.Text.Length > 0 && textBoxName.Text.Length > 0 && textBoxInfo.Text.Length > 0 && textBoxInfoStocks.Text.Length > 0 && textBoxInfoPrice.Text.Length > 0)
            {
                barcode.Rownum = barcode.Rownum + 1;
                barcode.BarcodeKind = comboBoxKinds.Text;
                barcode.ProductName = textBoxName.Text;
                barcode.Info = textBoxInfo.Text;
                barcode.Stocks = Convert.ToInt32(textBoxInfoStocks.Text);
                barcode.Price = Convert.ToInt32(textBoxInfoPrice.Text);
                barcode.Path = textBoxPath.Text;
                barcode.Data = bar;
                barcode.MemberId = memberId;
                barcode.RegistrationDate = date;
            }

            string queryInsert = sqlQuery.InsertInto__Values_(barcode);

            string fileName = path + bar + ".jpg";              //저장 위치

            string queryReadMemberInformation = sqlQuery.SelectAllFrom_Where_("MemberInformation", "MemberId", new string[] { memberId });
            MemberInformation memberinformation = crud.Read(queryReadMemberInformation, new MemberInformation());

            memberinformation.ChangedDate = DateTime.Today.ToString();
            memberinformation.Writing = memberinformation.Writing + 1;
            memberinformation.Do = "create";

            if (pictureBoxBarcode.Image != null && crud.Create(queryInsert, barcode) > 0)
            {
                pictureBoxBarcode.Image.Save(fileName);
                ljsLibrary.clear(textBoxName, textBoxInfo, textBoxInfoStocks, textBoxInfoPrice, textBoxInfoAll, pictureBoxBarcode);
                MessageBox.Show("성공");
            }
            else
            {
                MessageBox.Show("실패");
                ljsLibrary.clear(textBoxName, textBoxInfo, textBoxInfoStocks, textBoxInfoPrice, textBoxInfoAll, pictureBoxBarcode);
            }

        }


        //파일 읽기 및 DB읽기
        private void buttonFromFile_Click(object sender, EventArgs e)
        {
            //파일 읽기
            bar_read reader = new bar_read();                   //바코드 생성 클래스 인스턴스 생성
            string result = "";

            var temp = reader.read_barcode();                    //바코드 read함수를 통해  (비트맵, text 값) 받아옴

            if (temp.Item1 != null)
            {

                result = temp.Item2;                                // 읽어온 바코드 text 값 

                if (result == null || result == "")
                {
                    MessageBox.Show("바코드 정보 없음");
                    return;
                }

                pictureBoxBarcode.Image = temp.Item1;                 // 읽어온 이미지
                textBoxInfoAll.Text = result;
                //ljsLibrary.baReader(constr, temp.Item3, textBoxes);

            }

            //DB읽기
            string[] values = { result};
            string queryReadBarccode = sqlQuery.SelectAllFrom_Where_("Barcode", "Data", values);

            Barcode barcode = crud.Read(queryReadBarccode, new Barcode());
            

            if (barcode.ProductName != null)
            {
                comboBoxKinds.SelectedIndex = comboBoxKinds.FindString(barcode.BarcodeKind);
                textBoxName.Text = barcode.ProductName;
                textBoxInfo.Text = barcode.Info;
                textBoxInfoStocks.Text = barcode.Stocks.ToString();
                textBoxInfoPrice.Text = barcode.Price.ToString();
                textBoxPath.Text = barcode.Path;
                textBoxInfoAll.Text = barcode.Data;

                DataSet dataSet = crud.ReadToGrid(queryReadBarccode);

                dataGridView1.DataSource = dataSet.Tables[0];

                barcode_creation barcode_creation = new barcode_creation(barcode.Info + barcode.Stocks + barcode.Price);

                if (comboBoxKinds.Text == "Code39")                      //콤보박스에서 첫번째(code39)를 선택 했을때
                {
                    pictureBoxBarcode.Image = barcode_creation.linearcode();
                }

                // 2번째(Code 93) 바코드 선택
                else if (comboBoxKinds.Text == "ITF")
                {

                    pictureBoxBarcode.Image = barcode_creation.make_code93();
                }


                // 3번째(code128) 바코드 선택
                else if (comboBoxKinds.Text == "Code128")
                {
                    pictureBoxBarcode.Image = barcode_creation.Code_128();
                }



                //4번째(bata Metrix) 바코드 선택
                else if (comboBoxKinds.Text == "Data metrix")
                {
                    pictureBoxBarcode.Image = barcode_creation.make_DataMetrix();
                }
                else
                {
                    pictureBoxBarcode.Image = barcode_creation.barcode_create();
                }

            }
            else
            {
                MessageBox.Show("DB에 없는 QR코드");
            }
            
        }
        
        //클리어 정리
        private void buttonClear_Click(object sender, EventArgs e)
        {
            duplicatedFunction.textClearTextBox(TextBoxesBarcode);
            comboBoxColumn.Text = "";
            comboBoxKinds.Text = "";
            textBoxDbSelect.Text = "";
            textBoxPath.Text = "";
            pictureBoxBarcode.Image = null;
            textBoxInfoAll.Text = "";
            dataGridView1.DataSource = null;
        }

        //db 검색 모든결과
        private void buttonDbSelectAll_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                dataGridView1.CellClick += (s, ev) => datagridview_CellClick(s, ev);

                string query = sqlQuery.SelectAllFrom_Where_("Barcode", "MemberId", new string[] { memberId});

                DataSet dataSet = crud.ReadToGrid(query);

                dataGridView1.DataSource = dataSet.Tables?[0];
            }

        }
        //Db검색
        private void buttonDbSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView1 != null)
            {
                dataGridView1.CellClick += (s, ev) => datagridview_CellClick(s, ev);

                string column = "";
                if (comboBoxColumn.Text == "바코드 종류")
                {
                    column = "BarcodeKind";
                }
                else if (comboBoxColumn.Text == "상품명")
                {
                    column = "ProductName";
                }
                else if (comboBoxColumn.Text == "등록일")
                {
                    column = "RegistrationDate";
                }
                else if (comboBoxColumn.Text == "정보")
                {
                    column = "Info";
                }
                else if (comboBoxColumn.Text == "재고")
                {
                    column = "Stocks";
                }
                else if (comboBoxColumn.Text == "가격")
                {
                    column = "Price";
                }
                string[] values = { textBoxDbSelect.Text };
                string query = sqlQuery.SelectAllFrom_Where_("Barcode", column, values);

                DataSet dataSet = crud.ReadToGrid(query);
                if (dataSet.Tables.Count != 0)
                {
                    dataGridView1.DataSource = dataSet.Tables[0];

                }
            }

        }

        //데이터그리드 셀클릭 콜백
        private void datagridview_CellClick(object s, DataGridViewCellEventArgs e)
        {
            pictureBoxBarcode.Image = null;
            string info = "";
            if (e.RowIndex > 0 )
            {
                comboBoxKinds.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
            }

            //ProductName ~Price
            for (int i = 2; i < 6; i++)
            {
                info += dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString();
                textBoxes[i - 2].Text = dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString();

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

            //column index
            if (e.ColumnIndex == 6)
            {
                string path = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                Process.Start(path);
            }

        }

        //바코드 종류별 차트
        private void buttonBarcodeKind_Click(object sender, EventArgs e)
        {
            
            string queryReadWhere = sqlQuery.select_Count_From_Where_GroupBy_("Barcode", "MemberId" ,memberId, BarcodeColumns[0]);
            DataSet dataSetCount = crud.ReadToGrid(queryReadWhere);
            chart1.Series["x"].LegendText = "Count";
            duplicatedFunction.datasetToChart(chart1, dataSetCount, BarcodeColumns[0], "Count");
            if (comboBoxChart.SelectedItem.ToString() == "Pie")
            {
                chart1.Series["x"].ChartType = SeriesChartType.Pie;
                chart1.Series["x"].LegendText = "#PERCENT";
            }
        }
        //재고별
        private void button2_Click(object sender, EventArgs e)
        {
            string queryReadWhere = sqlQuery.select_From_Where_In(new string[] { "ProductName", "Stocks" },"Barcode",  "MemberId",new string[] { memberId} );
            DataSet dataSetCount = crud.ReadToGrid(queryReadWhere);
            chart1.Series["x"].LegendText = "재고";
            duplicatedFunction.datasetToChart(chart1, dataSetCount, "ProductName", "Stocks");
            if (comboBoxChart.SelectedItem.ToString() == "Pie")
            {
                chart1.Series["x"].ChartType = SeriesChartType.Pie;
                chart1.Series["x"].LegendText = "#PERCENT";
            }
        }
        //가격별
        private void button3_Click(object sender, EventArgs e)
        {
            string queryReadWhere = sqlQuery.select_From_Where_In(new string[] { "ProductName", "Price" }, "Barcode", "MemberId", new string[] { memberId });
            DataSet dataSetCount = crud.ReadToGrid(queryReadWhere);
            chart1.Series["x"].LegendText = "가격";
            duplicatedFunction.datasetToChart(chart1, dataSetCount, "ProductName", "Price");
            if (comboBoxChart.SelectedItem.ToString() == "Pie")
            {
                chart1.Series["x"].ChartType = SeriesChartType.Pie;
                chart1.Series["x"].LegendText = "#PERCENT";
            }
        }

        //차트 종류 변경
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] items = { "Column", "Pie", "FastLine", "Area", "Bar" };
            string item = comboBoxChart.SelectedItem.ToString();
            if (item == items[0])
            {
                chart1.Series["x"].ChartType = SeriesChartType.Column;
                chart1.DataBind();
            }
            else if (item == items[1])
            {
                chart1.Series["x"].ChartType = SeriesChartType.Pie;
                chart1.Series["x"].LegendText = "#PERCENT";
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

        private void buttonPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog forderBrowserDialog = new FolderBrowserDialog();
            if(forderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = forderBrowserDialog.SelectedPath + @"\";
            }
        }

        private void comboBoxKinds_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox.Text == "QR코드")
            {
                textBoxName.ImeMode = ImeMode.NoControl;
                textBoxInfo.ImeMode = ImeMode.NoControl;
                textBoxInfoStocks.ImeMode = ImeMode.NoControl;
                textBoxInfoPrice.ImeMode = ImeMode.NoControl;
            }
            else
            {
                textBoxName.ImeMode = ImeMode.Disable;
                textBoxInfo.ImeMode = ImeMode.Disable;
                textBoxInfoStocks.ImeMode = ImeMode.Disable;
                textBoxInfoPrice.ImeMode = ImeMode.Disable;
            }
            ljsLibrary.clear(textBoxName, textBoxInfo, textBoxInfoStocks, textBoxInfoPrice, textBoxInfoAll, pictureBoxBarcode);
        }
    }

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///

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


        public void clear(TextBox txtProduct, TextBox txtinfo1, TextBox txtinfo2, TextBox txtinfo3, TextBox textBoxInfoAll, PictureBox picbarcode)
        {


            txtProduct.Text = "";
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
            string sql2 = "SELECT Product_name,Registratin_Date,info1,info2,info3 FROM dbo.Barcode";
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
                        string sql = "insert into Barcode(Product_Name,Registratin_Date,info1,info2,info3) Values(@Product_Name,@Registratin_Date,@info1,@info2,@info3)";

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

            string sql = "SELECT * FROM dbo.Barcode WHERE Product_Name='" + substr1 + "'";

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

    //public class BarcodeInfo
    //{
    //    public int? Id { get; set; }
    //    public string BarcodeKind { get; set; }
    //    public string Product_Name { get; set; }
    //    public string Registratin_Date { get; set; }
    //    public string Info1 { get; set; }
    //    public string Info2 { get; set; }
    //    public string Info3 { get; set; }

    //    public string MemberId { get; set; }
    //    public string Path { get; set; }

    //    public string Data { get; set; }
    //}

}
