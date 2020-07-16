using System.Windows.Forms;

namespace MemberBarcode
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonUpdateMember = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxActivity = new System.Windows.Forms.TextBox();
            this.textBoxWriting = new System.Windows.Forms.TextBox();
            this.textBoxPoint = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBarcode = new System.Windows.Forms.TabPage();
            this.buttonDbSelectAll = new System.Windows.Forms.Button();
            this.buttonDbSelect = new System.Windows.Forms.Button();
            this.textBoxDbSelect = new System.Windows.Forms.TextBox();
            this.comboBoxColumn = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonFromFile = new System.Windows.Forms.Button();
            this.buttonToDb = new System.Windows.Forms.Button();
            this.buttonToFile = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxInfo3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxInfo2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxInfo1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKinds = new System.Windows.Forms.ComboBox();
            this.textBoxInfoAll = new System.Windows.Forms.TextBox();
            this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxUpdatePosition = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBoxUpdateId = new System.Windows.Forms.TextBox();
            this.buttonUpdateCancle = new System.Windows.Forms.Button();
            this.buttonUpdatePanelUpdate = new System.Windows.Forms.Button();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBoxUpdateEmail = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBoxUpdatePhone = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBoxUpdateName = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBoxUpdatePassword = new System.Windows.Forms.TextBox();
            this.tabPageReadBarcode = new System.Windows.Forms.TabPage();
            this.comboBoxChart = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBarcodeKind = new System.Windows.Forms.Button();
            this.buttonRegistrationDate = new System.Windows.Forms.Button();
            this.buttonProductName = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageMemberHistory = new System.Windows.Forms.TabPage();
            this.dataGridViewMemberHistory = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageBarcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            this.panelUpdate.SuspendLayout();
            this.tabPageReadBarcode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageMemberHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Location = new System.Drawing.Point(854, 57);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(100, 42);
            this.buttonLogout.TabIndex = 10;
            this.buttonLogout.Text = "로그아웃";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonUpdateMember
            // 
            this.buttonUpdateMember.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonUpdateMember.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUpdateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateMember.Location = new System.Drawing.Point(730, 57);
            this.buttonUpdateMember.Name = "buttonUpdateMember";
            this.buttonUpdateMember.Size = new System.Drawing.Size(100, 42);
            this.buttonUpdateMember.TabIndex = 11;
            this.buttonUpdateMember.Text = "정보수정";
            this.buttonUpdateMember.UseVisualStyleBackColor = false;
            this.buttonUpdateMember.Click += new System.EventHandler(this.buttonUpdateMember_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxActivity);
            this.panel3.Controls.Add(this.textBoxWriting);
            this.panel3.Controls.Add(this.textBoxPoint);
            this.panel3.Controls.Add(this.textBoxId);
            this.panel3.Location = new System.Drawing.Point(473, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 39);
            this.panel3.TabIndex = 12;
            // 
            // textBoxActivity
            // 
            this.textBoxActivity.BackColor = System.Drawing.Color.White;
            this.textBoxActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxActivity.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxActivity.Location = new System.Drawing.Point(390, 8);
            this.textBoxActivity.Name = "textBoxActivity";
            this.textBoxActivity.ReadOnly = true;
            this.textBoxActivity.Size = new System.Drawing.Size(123, 23);
            this.textBoxActivity.TabIndex = 16;
            this.textBoxActivity.Text = "Activity";
            // 
            // textBoxWriting
            // 
            this.textBoxWriting.BackColor = System.Drawing.Color.White;
            this.textBoxWriting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWriting.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxWriting.Location = new System.Drawing.Point(261, 8);
            this.textBoxWriting.Name = "textBoxWriting";
            this.textBoxWriting.ReadOnly = true;
            this.textBoxWriting.Size = new System.Drawing.Size(123, 23);
            this.textBoxWriting.TabIndex = 15;
            this.textBoxWriting.Text = "Writing";
            // 
            // textBoxPoint
            // 
            this.textBoxPoint.BackColor = System.Drawing.Color.White;
            this.textBoxPoint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPoint.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxPoint.Location = new System.Drawing.Point(132, 10);
            this.textBoxPoint.Name = "textBoxPoint";
            this.textBoxPoint.ReadOnly = true;
            this.textBoxPoint.Size = new System.Drawing.Size(123, 23);
            this.textBoxPoint.TabIndex = 14;
            this.textBoxPoint.Text = "Point";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.White;
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxId.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxId.Location = new System.Drawing.Point(3, 8);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(123, 23);
            this.textBoxId.TabIndex = 13;
            this.textBoxId.Text = "UserId";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("굴림", 20F);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(206, 31);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "UserBarcodeP";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBarcode);
            this.tabControl1.Controls.Add(this.tabPageReadBarcode);
            this.tabControl1.Controls.Add(this.tabPageMemberHistory);
            this.tabControl1.Location = new System.Drawing.Point(12, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(973, 405);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPageBarcode
            // 
            this.tabPageBarcode.Controls.Add(this.buttonDbSelectAll);
            this.tabPageBarcode.Controls.Add(this.buttonDbSelect);
            this.tabPageBarcode.Controls.Add(this.textBoxDbSelect);
            this.tabPageBarcode.Controls.Add(this.comboBoxColumn);
            this.tabPageBarcode.Controls.Add(this.dataGridView1);
            this.tabPageBarcode.Controls.Add(this.buttonClear);
            this.tabPageBarcode.Controls.Add(this.buttonFromFile);
            this.tabPageBarcode.Controls.Add(this.buttonToDb);
            this.tabPageBarcode.Controls.Add(this.buttonToFile);
            this.tabPageBarcode.Controls.Add(this.buttonCreate);
            this.tabPageBarcode.Controls.Add(this.label2);
            this.tabPageBarcode.Controls.Add(this.label8);
            this.tabPageBarcode.Controls.Add(this.label9);
            this.tabPageBarcode.Controls.Add(this.label10);
            this.tabPageBarcode.Controls.Add(this.label11);
            this.tabPageBarcode.Controls.Add(this.label12);
            this.tabPageBarcode.Controls.Add(this.textBoxInfo3);
            this.tabPageBarcode.Controls.Add(this.label7);
            this.tabPageBarcode.Controls.Add(this.textBoxInfo2);
            this.tabPageBarcode.Controls.Add(this.label6);
            this.tabPageBarcode.Controls.Add(this.textBoxInfo1);
            this.tabPageBarcode.Controls.Add(this.label5);
            this.tabPageBarcode.Controls.Add(this.textBoxDate);
            this.tabPageBarcode.Controls.Add(this.label4);
            this.tabPageBarcode.Controls.Add(this.textBoxName);
            this.tabPageBarcode.Controls.Add(this.label3);
            this.tabPageBarcode.Controls.Add(this.label1);
            this.tabPageBarcode.Controls.Add(this.comboBoxKinds);
            this.tabPageBarcode.Controls.Add(this.textBoxInfoAll);
            this.tabPageBarcode.Controls.Add(this.pictureBoxBarcode);
            this.tabPageBarcode.Controls.Add(this.panelUpdate);
            this.tabPageBarcode.Font = new System.Drawing.Font("굴림", 12F);
            this.tabPageBarcode.Location = new System.Drawing.Point(4, 22);
            this.tabPageBarcode.Name = "tabPageBarcode";
            this.tabPageBarcode.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBarcode.Size = new System.Drawing.Size(965, 379);
            this.tabPageBarcode.TabIndex = 0;
            this.tabPageBarcode.Text = "바코드";
            this.tabPageBarcode.UseVisualStyleBackColor = true;
            // 
            // buttonDbSelectAll
            // 
            this.buttonDbSelectAll.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonDbSelectAll.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDbSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDbSelectAll.Location = new System.Drawing.Point(714, 288);
            this.buttonDbSelectAll.Name = "buttonDbSelectAll";
            this.buttonDbSelectAll.Size = new System.Drawing.Size(100, 50);
            this.buttonDbSelectAll.TabIndex = 56;
            this.buttonDbSelectAll.Text = " 전체 DB 조회";
            this.buttonDbSelectAll.UseVisualStyleBackColor = false;
            this.buttonDbSelectAll.Click += new System.EventHandler(this.buttonDbSelectAll_Click);
            // 
            // buttonDbSelect
            // 
            this.buttonDbSelect.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonDbSelect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDbSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDbSelect.Location = new System.Drawing.Point(838, 288);
            this.buttonDbSelect.Name = "buttonDbSelect";
            this.buttonDbSelect.Size = new System.Drawing.Size(100, 50);
            this.buttonDbSelect.TabIndex = 55;
            this.buttonDbSelect.Text = "DB검색";
            this.buttonDbSelect.UseVisualStyleBackColor = false;
            this.buttonDbSelect.Click += new System.EventHandler(this.buttonDbSelect_Click);
            // 
            // textBoxDbSelect
            // 
            this.textBoxDbSelect.Location = new System.Drawing.Point(838, 246);
            this.textBoxDbSelect.Name = "textBoxDbSelect";
            this.textBoxDbSelect.Size = new System.Drawing.Size(100, 26);
            this.textBoxDbSelect.TabIndex = 54;
            // 
            // comboBoxColumn
            // 
            this.comboBoxColumn.FormattingEnabled = true;
            this.comboBoxColumn.Items.AddRange(new object[] {
            "바코드 종류",
            "상품명",
            "등록일",
            "정보1",
            "정보2",
            "정보3"});
            this.comboBoxColumn.Location = new System.Drawing.Point(714, 248);
            this.comboBoxColumn.Name = "comboBoxColumn";
            this.comboBoxColumn.Size = new System.Drawing.Size(100, 24);
            this.comboBoxColumn.TabIndex = 53;
            this.comboBoxColumn.Text = "선택";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(617, 131);
            this.dataGridView1.TabIndex = 52;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Location = new System.Drawing.Point(714, 166);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(224, 50);
            this.buttonClear.TabIndex = 51;
            this.buttonClear.Text = "화면 정리";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonFromFile
            // 
            this.buttonFromFile.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonFromFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFromFile.Location = new System.Drawing.Point(838, 83);
            this.buttonFromFile.Name = "buttonFromFile";
            this.buttonFromFile.Size = new System.Drawing.Size(100, 50);
            this.buttonFromFile.TabIndex = 50;
            this.buttonFromFile.Text = "파일 읽기";
            this.buttonFromFile.UseVisualStyleBackColor = false;
            this.buttonFromFile.Click += new System.EventHandler(this.buttonFromFile_Click);
            // 
            // buttonToDb
            // 
            this.buttonToDb.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonToDb.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonToDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToDb.Location = new System.Drawing.Point(714, 83);
            this.buttonToDb.Name = "buttonToDb";
            this.buttonToDb.Size = new System.Drawing.Size(100, 50);
            this.buttonToDb.TabIndex = 49;
            this.buttonToDb.Text = "DB저장";
            this.buttonToDb.UseVisualStyleBackColor = false;
            this.buttonToDb.Click += new System.EventHandler(this.buttonToDb_Click);
            // 
            // buttonToFile
            // 
            this.buttonToFile.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonToFile.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToFile.Location = new System.Drawing.Point(838, 17);
            this.buttonToFile.Name = "buttonToFile";
            this.buttonToFile.Size = new System.Drawing.Size(100, 50);
            this.buttonToFile.TabIndex = 48;
            this.buttonToFile.Text = "파일저장";
            this.buttonToFile.UseVisualStyleBackColor = false;
            this.buttonToFile.Click += new System.EventHandler(this.buttonToFile_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonCreate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Location = new System.Drawing.Point(714, 17);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(100, 50);
            this.buttonCreate.TabIndex = 15;
            this.buttonCreate.Text = "생성";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "정보3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(344, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "정보2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "정보1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 44;
            this.label10.Text = "등록일";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(344, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "상품명";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(344, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 16);
            this.label12.TabIndex = 42;
            this.label12.Text = "바코드 종류";
            // 
            // textBoxInfo3
            // 
            this.textBoxInfo3.Location = new System.Drawing.Point(460, 149);
            this.textBoxInfo3.Name = "textBoxInfo3";
            this.textBoxInfo3.Size = new System.Drawing.Size(100, 26);
            this.textBoxInfo3.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 40;
            // 
            // textBoxInfo2
            // 
            this.textBoxInfo2.Location = new System.Drawing.Point(460, 122);
            this.textBoxInfo2.Name = "textBoxInfo2";
            this.textBoxInfo2.Size = new System.Drawing.Size(100, 26);
            this.textBoxInfo2.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(362, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 38;
            // 
            // textBoxInfo1
            // 
            this.textBoxInfo1.Location = new System.Drawing.Point(460, 95);
            this.textBoxInfo1.Name = "textBoxInfo1";
            this.textBoxInfo1.Size = new System.Drawing.Size(100, 26);
            this.textBoxInfo1.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 36;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(460, 68);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 26);
            this.textBoxDate.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 34;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(460, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 26);
            this.textBoxName.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 31;
            // 
            // comboBoxKinds
            // 
            this.comboBoxKinds.FormattingEnabled = true;
            this.comboBoxKinds.Items.AddRange(new object[] {
            "Code39",
            "ITF",
            "Code128",
            "Data metrix",
            "QR코드"});
            this.comboBoxKinds.Location = new System.Drawing.Point(460, 15);
            this.comboBoxKinds.Name = "comboBoxKinds";
            this.comboBoxKinds.Size = new System.Drawing.Size(100, 24);
            this.comboBoxKinds.TabIndex = 30;
            // 
            // textBoxInfoAll
            // 
            this.textBoxInfoAll.Location = new System.Drawing.Point(6, 190);
            this.textBoxInfoAll.Name = "textBoxInfoAll";
            this.textBoxInfoAll.Size = new System.Drawing.Size(231, 26);
            this.textBoxInfoAll.TabIndex = 28;
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBarcode.Location = new System.Drawing.Point(6, 6);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(231, 169);
            this.pictureBoxBarcode.TabIndex = 4;
            this.pictureBoxBarcode.TabStop = false;
            // 
            // panelUpdate
            // 
            this.panelUpdate.Controls.Add(this.textBox2);
            this.panelUpdate.Controls.Add(this.textBoxUpdatePosition);
            this.panelUpdate.Controls.Add(this.textBox7);
            this.panelUpdate.Controls.Add(this.textBoxUpdateId);
            this.panelUpdate.Controls.Add(this.buttonUpdateCancle);
            this.panelUpdate.Controls.Add(this.buttonUpdatePanelUpdate);
            this.panelUpdate.Controls.Add(this.textBox17);
            this.panelUpdate.Controls.Add(this.textBox15);
            this.panelUpdate.Controls.Add(this.textBoxUpdateEmail);
            this.panelUpdate.Controls.Add(this.textBox9);
            this.panelUpdate.Controls.Add(this.textBoxUpdatePhone);
            this.panelUpdate.Controls.Add(this.textBox11);
            this.panelUpdate.Controls.Add(this.textBoxUpdateName);
            this.panelUpdate.Controls.Add(this.textBox5);
            this.panelUpdate.Controls.Add(this.textBoxUpdatePassword);
            this.panelUpdate.Location = new System.Drawing.Point(262, -4);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(440, 367);
            this.panelUpdate.TabIndex = 57;
            this.panelUpdate.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox2.Location = new System.Drawing.Point(83, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(123, 23);
            this.textBox2.TabIndex = 35;
            this.textBox2.Text = "Position";
            // 
            // textBoxUpdatePosition
            // 
            this.textBoxUpdatePosition.BackColor = System.Drawing.Color.White;
            this.textBoxUpdatePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUpdatePosition.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxUpdatePosition.Location = new System.Drawing.Point(229, 248);
            this.textBoxUpdatePosition.Name = "textBoxUpdatePosition";
            this.textBoxUpdatePosition.Size = new System.Drawing.Size(123, 30);
            this.textBoxUpdatePosition.TabIndex = 34;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox7.Location = new System.Drawing.Point(83, 67);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(123, 23);
            this.textBox7.TabIndex = 33;
            this.textBox7.Text = "User Id";
            // 
            // textBoxUpdateId
            // 
            this.textBoxUpdateId.BackColor = System.Drawing.Color.White;
            this.textBoxUpdateId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUpdateId.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxUpdateId.Location = new System.Drawing.Point(229, 67);
            this.textBoxUpdateId.Name = "textBoxUpdateId";
            this.textBoxUpdateId.Size = new System.Drawing.Size(123, 30);
            this.textBoxUpdateId.TabIndex = 32;
            // 
            // buttonUpdateCancle
            // 
            this.buttonUpdateCancle.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonUpdateCancle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUpdateCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateCancle.Location = new System.Drawing.Point(262, 297);
            this.buttonUpdateCancle.Name = "buttonUpdateCancle";
            this.buttonUpdateCancle.Size = new System.Drawing.Size(100, 50);
            this.buttonUpdateCancle.TabIndex = 31;
            this.buttonUpdateCancle.Text = "취소";
            this.buttonUpdateCancle.UseVisualStyleBackColor = false;
            this.buttonUpdateCancle.Click += new System.EventHandler(this.buttonUpdateCancle_Click);
            // 
            // buttonUpdatePanelUpdate
            // 
            this.buttonUpdatePanelUpdate.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonUpdatePanelUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUpdatePanelUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdatePanelUpdate.Location = new System.Drawing.Point(64, 297);
            this.buttonUpdatePanelUpdate.Name = "buttonUpdatePanelUpdate";
            this.buttonUpdatePanelUpdate.Size = new System.Drawing.Size(100, 50);
            this.buttonUpdatePanelUpdate.TabIndex = 18;
            this.buttonUpdatePanelUpdate.Text = "변경";
            this.buttonUpdatePanelUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdatePanelUpdate.Click += new System.EventHandler(this.buttonUpdatePanelUpdate_Click);
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.White;
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox17.Location = new System.Drawing.Point(164, 17);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(123, 23);
            this.textBox17.TabIndex = 30;
            this.textBox17.Text = "회원정보 변경";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.White;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox15.Location = new System.Drawing.Point(83, 212);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(123, 23);
            this.textBox15.TabIndex = 27;
            this.textBox15.Text = "Email";
            // 
            // textBoxUpdateEmail
            // 
            this.textBoxUpdateEmail.BackColor = System.Drawing.Color.White;
            this.textBoxUpdateEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUpdateEmail.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxUpdateEmail.Location = new System.Drawing.Point(229, 212);
            this.textBoxUpdateEmail.Name = "textBoxUpdateEmail";
            this.textBoxUpdateEmail.Size = new System.Drawing.Size(123, 30);
            this.textBoxUpdateEmail.TabIndex = 26;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox9.Location = new System.Drawing.Point(83, 176);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(123, 23);
            this.textBox9.TabIndex = 25;
            this.textBox9.Text = "Phone";
            // 
            // textBoxUpdatePhone
            // 
            this.textBoxUpdatePhone.BackColor = System.Drawing.Color.White;
            this.textBoxUpdatePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUpdatePhone.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxUpdatePhone.Location = new System.Drawing.Point(229, 176);
            this.textBoxUpdatePhone.Name = "textBoxUpdatePhone";
            this.textBoxUpdatePhone.Size = new System.Drawing.Size(123, 30);
            this.textBoxUpdatePhone.TabIndex = 24;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.White;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox11.Location = new System.Drawing.Point(83, 140);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(123, 23);
            this.textBox11.TabIndex = 23;
            this.textBox11.Text = "Name";
            // 
            // textBoxUpdateName
            // 
            this.textBoxUpdateName.BackColor = System.Drawing.Color.White;
            this.textBoxUpdateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUpdateName.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxUpdateName.Location = new System.Drawing.Point(229, 140);
            this.textBoxUpdateName.Name = "textBoxUpdateName";
            this.textBoxUpdateName.Size = new System.Drawing.Size(123, 30);
            this.textBoxUpdateName.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox5.Location = new System.Drawing.Point(83, 104);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(123, 23);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "Password";
            // 
            // textBoxUpdatePassword
            // 
            this.textBoxUpdatePassword.BackColor = System.Drawing.Color.White;
            this.textBoxUpdatePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUpdatePassword.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxUpdatePassword.Location = new System.Drawing.Point(229, 104);
            this.textBoxUpdatePassword.Name = "textBoxUpdatePassword";
            this.textBoxUpdatePassword.Size = new System.Drawing.Size(123, 30);
            this.textBoxUpdatePassword.TabIndex = 20;
            // 
            // tabPageReadBarcode
            // 
            this.tabPageReadBarcode.Controls.Add(this.comboBoxChart);
            this.tabPageReadBarcode.Controls.Add(this.button3);
            this.tabPageReadBarcode.Controls.Add(this.button2);
            this.tabPageReadBarcode.Controls.Add(this.button1);
            this.tabPageReadBarcode.Controls.Add(this.buttonBarcodeKind);
            this.tabPageReadBarcode.Controls.Add(this.buttonRegistrationDate);
            this.tabPageReadBarcode.Controls.Add(this.buttonProductName);
            this.tabPageReadBarcode.Controls.Add(this.chart1);
            this.tabPageReadBarcode.Location = new System.Drawing.Point(4, 22);
            this.tabPageReadBarcode.Name = "tabPageReadBarcode";
            this.tabPageReadBarcode.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageReadBarcode.Size = new System.Drawing.Size(965, 359);
            this.tabPageReadBarcode.TabIndex = 3;
            this.tabPageReadBarcode.Text = "바코드 조회";
            this.tabPageReadBarcode.UseVisualStyleBackColor = true;
            // 
            // comboBoxChart
            // 
            this.comboBoxChart.Font = new System.Drawing.Font("굴림", 15F);
            this.comboBoxChart.FormattingEnabled = true;
            this.comboBoxChart.Items.AddRange(new object[] {
            "Column",
            "Pie",
            "FastLine",
            "Area",
            "Bar"});
            this.comboBoxChart.Location = new System.Drawing.Point(642, 15);
            this.comboBoxChart.Name = "comboBoxChart";
            this.comboBoxChart.Size = new System.Drawing.Size(100, 28);
            this.comboBoxChart.TabIndex = 31;
            this.comboBoxChart.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.PowderBlue;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(536, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 20;
            this.button3.Text = "Info3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.PowderBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(430, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 19;
            this.button2.Text = "Info2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(324, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 18;
            this.button1.Text = "Info1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBarcodeKind
            // 
            this.buttonBarcodeKind.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonBarcodeKind.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonBarcodeKind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBarcodeKind.Location = new System.Drawing.Point(6, 6);
            this.buttonBarcodeKind.Name = "buttonBarcodeKind";
            this.buttonBarcodeKind.Size = new System.Drawing.Size(100, 50);
            this.buttonBarcodeKind.TabIndex = 17;
            this.buttonBarcodeKind.Text = "바코드 종류";
            this.buttonBarcodeKind.UseVisualStyleBackColor = false;
            this.buttonBarcodeKind.Click += new System.EventHandler(this.buttonBarcodeKind_Click);
            // 
            // buttonRegistrationDate
            // 
            this.buttonRegistrationDate.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonRegistrationDate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRegistrationDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrationDate.Location = new System.Drawing.Point(218, 6);
            this.buttonRegistrationDate.Name = "buttonRegistrationDate";
            this.buttonRegistrationDate.Size = new System.Drawing.Size(100, 50);
            this.buttonRegistrationDate.TabIndex = 16;
            this.buttonRegistrationDate.Text = "등록일";
            this.buttonRegistrationDate.UseVisualStyleBackColor = false;
            this.buttonRegistrationDate.Click += new System.EventHandler(this.buttonRegistrationDate_Click);
            // 
            // buttonProductName
            // 
            this.buttonProductName.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonProductName.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductName.Location = new System.Drawing.Point(112, 6);
            this.buttonProductName.Name = "buttonProductName";
            this.buttonProductName.Size = new System.Drawing.Size(100, 50);
            this.buttonProductName.TabIndex = 15;
            this.buttonProductName.Text = "상품명";
            this.buttonProductName.UseVisualStyleBackColor = false;
            this.buttonProductName.Click += new System.EventHandler(this.buttonProductName_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Location = new System.Drawing.Point(6, 62);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chart1.Size = new System.Drawing.Size(953, 291);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPageMemberHistory
            // 
            this.tabPageMemberHistory.Controls.Add(this.dataGridViewMemberHistory);
            this.tabPageMemberHistory.Font = new System.Drawing.Font("굴림", 12F);
            this.tabPageMemberHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageMemberHistory.Name = "tabPageMemberHistory";
            this.tabPageMemberHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMemberHistory.Size = new System.Drawing.Size(965, 359);
            this.tabPageMemberHistory.TabIndex = 2;
            this.tabPageMemberHistory.Text = "회원 히스토리";
            this.tabPageMemberHistory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMemberHistory
            // 
            this.dataGridViewMemberHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMemberHistory.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewMemberHistory.Name = "dataGridViewMemberHistory";
            this.dataGridViewMemberHistory.RowTemplate.Height = 23;
            this.dataGridViewMemberHistory.Size = new System.Drawing.Size(953, 347);
            this.dataGridViewMemberHistory.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonUpdateMember);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageBarcode.ResumeLayout(false);
            this.tabPageBarcode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.tabPageReadBarcode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageMemberHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMemberHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion
        private Button buttonLogout;
        private Button buttonUpdateMember;
        private Panel panel3;
        private TextBox textBoxActivity;
        private TextBox textBoxWriting;
        private TextBox textBoxPoint;
        private TextBox textBoxId;
        private TextBox textBox1;
        private TabControl tabControl1;
        private TabPage tabPageMemberHistory;
        private TabPage tabPageBarcode;
        private TextBox textBoxInfo3;
        private Label label7;
        private TextBox textBoxInfo2;
        private Label label6;
        private TextBox textBoxInfo1;
        private Label label5;
        private TextBox textBoxDate;
        private Label label4;
        private TextBox textBoxName;
        private Label label3;
        private Label label1;
        private ComboBox comboBoxKinds;
        private TextBox textBoxInfoAll;
        private PictureBox pictureBoxBarcode;
        private Button buttonClear;
        private Button buttonFromFile;
        private Button buttonToDb;
        private Button buttonToFile;
        private Button buttonCreate;
        private Label label2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button buttonDbSelect;
        private TextBox textBoxDbSelect;
        private ComboBox comboBoxColumn;
        private DataGridView dataGridView1;
        private TabPage tabPageReadBarcode;
        private Button buttonDbSelectAll;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonBarcodeKind;
        private Button buttonRegistrationDate;
        private Button buttonProductName;
        private Panel panelUpdate;
        private Button buttonUpdateCancle;
        private Button buttonUpdatePanelUpdate;
        private TextBox textBox17;
        private TextBox textBox15;
        private TextBox textBoxUpdateEmail;
        private TextBox textBox9;
        private TextBox textBoxUpdatePhone;
        private TextBox textBox11;
        private TextBox textBoxUpdateName;
        private TextBox textBox5;
        private TextBox textBoxUpdatePassword;
        private TextBox textBox7;
        private TextBox textBoxUpdateId;
        private TextBox textBox2;
        private TextBox textBoxUpdatePosition;
        private ComboBox comboBoxChart;
        private DataGridView dataGridViewMemberHistory;
    }
}

