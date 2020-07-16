using System.Windows.Forms;

namespace MemberBarcode
{
    partial class Form3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCreate = new System.Windows.Forms.TabPage();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonDuplicationSelect = new System.Windows.Forms.Button();
            this.textBoxCreateId = new System.Windows.Forms.TextBox();
            this.textBoxCreatePassword = new System.Windows.Forms.TextBox();
            this.buttonCreatePanelCreate = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBoxCreateName = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBoxCreateEmail = new System.Windows.Forms.TextBox();
            this.textBoxCreatePhone = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tabPageRead = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMemberMemberInformationColumn = new System.Windows.Forms.ComboBox();
            this.textBoxMemberSelect = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxPage = new System.Windows.Forms.TextBox();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFiveOfFive = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnThreeOfFive = new System.Windows.Forms.Button();
            this.btnFourOfFive = new System.Windows.Forms.Button();
            this.btnOneOfFive = new System.Windows.Forms.Button();
            this.btnTwoOfFive = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.dataGridViewRead = new System.Windows.Forms.DataGridView();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.buttonUpdateClear = new System.Windows.Forms.Button();
            this.comboBoxUpdatePosition = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.buttonUpdateRead = new System.Windows.Forms.Button();
            this.textBoxUpdateId = new System.Windows.Forms.TextBox();
            this.textBoxUpdatePassword = new System.Windows.Forms.TextBox();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBoxUpdateName = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBoxUpdateEmail = new System.Windows.Forms.TextBox();
            this.textBoxUpdatePhone = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.buttonDeleteClear = new System.Windows.Forms.Button();
            this.comboBoxDeletePosition = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.buttonDeleteRead = new System.Windows.Forms.Button();
            this.textBoxDeleteId = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.tabPageChart = new System.Windows.Forms.TabPage();
            this.dataGridViewChart = new System.Windows.Forms.DataGridView();
            this.comboBoxChart = new System.Windows.Forms.ComboBox();
            this.buttonChartPoint = new System.Windows.Forms.Button();
            this.buttonChartActivity = new System.Windows.Forms.Button();
            this.buttonChartWriting = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageCreate.SuspendLayout();
            this.tabPageRead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRead)).BeginInit();
            this.tabPageUpdate.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            this.tabPageChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "AdminBarcodeP";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageCreate);
            this.tabControl1.Controls.Add(this.tabPageRead);
            this.tabControl1.Controls.Add(this.tabPageUpdate);
            this.tabControl1.Controls.Add(this.tabPageDelete);
            this.tabControl1.Controls.Add(this.tabPageChart);
            this.tabControl1.Location = new System.Drawing.Point(15, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(973, 405);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPageCreate
            // 
            this.tabPageCreate.Controls.Add(this.comboBoxPosition);
            this.tabPageCreate.Controls.Add(this.textBox2);
            this.tabPageCreate.Controls.Add(this.textBox7);
            this.tabPageCreate.Controls.Add(this.buttonDuplicationSelect);
            this.tabPageCreate.Controls.Add(this.textBoxCreateId);
            this.tabPageCreate.Controls.Add(this.textBoxCreatePassword);
            this.tabPageCreate.Controls.Add(this.buttonCreatePanelCreate);
            this.tabPageCreate.Controls.Add(this.textBox5);
            this.tabPageCreate.Controls.Add(this.textBox17);
            this.tabPageCreate.Controls.Add(this.textBoxCreateName);
            this.tabPageCreate.Controls.Add(this.textBox15);
            this.tabPageCreate.Controls.Add(this.textBox11);
            this.tabPageCreate.Controls.Add(this.textBoxCreateEmail);
            this.tabPageCreate.Controls.Add(this.textBoxCreatePhone);
            this.tabPageCreate.Controls.Add(this.textBox9);
            this.tabPageCreate.Location = new System.Drawing.Point(4, 22);
            this.tabPageCreate.Name = "tabPageCreate";
            this.tabPageCreate.Size = new System.Drawing.Size(965, 379);
            this.tabPageCreate.TabIndex = 0;
            this.tabPageCreate.Text = "회원추가";
            this.tabPageCreate.UseVisualStyleBackColor = true;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.comboBoxPosition.Location = new System.Drawing.Point(449, 237);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(123, 20);
            this.comboBoxPosition.TabIndex = 35;
            this.comboBoxPosition.Text = "user";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox2.Location = new System.Drawing.Point(303, 237);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(123, 23);
            this.textBox2.TabIndex = 34;
            this.textBox2.Text = "Position";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox7.Location = new System.Drawing.Point(303, 57);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(123, 23);
            this.textBox7.TabIndex = 19;
            this.textBox7.Text = "User Id";
            // 
            // buttonDuplicationSelect
            // 
            this.buttonDuplicationSelect.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonDuplicationSelect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDuplicationSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDuplicationSelect.Location = new System.Drawing.Point(587, 57);
            this.buttonDuplicationSelect.Name = "buttonDuplicationSelect";
            this.buttonDuplicationSelect.Size = new System.Drawing.Size(83, 30);
            this.buttonDuplicationSelect.TabIndex = 32;
            this.buttonDuplicationSelect.Text = "중복조회";
            this.buttonDuplicationSelect.UseVisualStyleBackColor = false;
            this.buttonDuplicationSelect.Click += new System.EventHandler(this.buttonDuplicationSelect_Click_1);
            // 
            // textBoxCreateId
            // 
            this.textBoxCreateId.BackColor = System.Drawing.Color.White;
            this.textBoxCreateId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreateId.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxCreateId.Location = new System.Drawing.Point(449, 57);
            this.textBoxCreateId.Name = "textBoxCreateId";
            this.textBoxCreateId.Size = new System.Drawing.Size(123, 30);
            this.textBoxCreateId.TabIndex = 18;
            // 
            // textBoxCreatePassword
            // 
            this.textBoxCreatePassword.BackColor = System.Drawing.Color.White;
            this.textBoxCreatePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreatePassword.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxCreatePassword.Location = new System.Drawing.Point(449, 93);
            this.textBoxCreatePassword.Name = "textBoxCreatePassword";
            this.textBoxCreatePassword.Size = new System.Drawing.Size(123, 30);
            this.textBoxCreatePassword.TabIndex = 20;
            // 
            // buttonCreatePanelCreate
            // 
            this.buttonCreatePanelCreate.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonCreatePanelCreate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCreatePanelCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreatePanelCreate.Location = new System.Drawing.Point(455, 306);
            this.buttonCreatePanelCreate.Name = "buttonCreatePanelCreate";
            this.buttonCreatePanelCreate.Size = new System.Drawing.Size(100, 50);
            this.buttonCreatePanelCreate.TabIndex = 18;
            this.buttonCreatePanelCreate.Text = "회원추가";
            this.buttonCreatePanelCreate.UseVisualStyleBackColor = false;
            this.buttonCreatePanelCreate.Click += new System.EventHandler(this.buttonCreatePanelCreate_Click_1);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox5.Location = new System.Drawing.Point(303, 93);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(123, 23);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "Password";
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.White;
            this.textBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox17.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox17.Location = new System.Drawing.Point(432, 28);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(123, 23);
            this.textBox17.TabIndex = 30;
            this.textBox17.Text = "회원추가";
            // 
            // textBoxCreateName
            // 
            this.textBoxCreateName.BackColor = System.Drawing.Color.White;
            this.textBoxCreateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreateName.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxCreateName.Location = new System.Drawing.Point(449, 129);
            this.textBoxCreateName.Name = "textBoxCreateName";
            this.textBoxCreateName.Size = new System.Drawing.Size(123, 30);
            this.textBoxCreateName.TabIndex = 22;
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.White;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox15.Location = new System.Drawing.Point(303, 201);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(123, 23);
            this.textBox15.TabIndex = 27;
            this.textBox15.Text = "Email";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.White;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox11.Location = new System.Drawing.Point(303, 129);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(123, 23);
            this.textBox11.TabIndex = 23;
            this.textBox11.Text = "Name";
            // 
            // textBoxCreateEmail
            // 
            this.textBoxCreateEmail.BackColor = System.Drawing.Color.White;
            this.textBoxCreateEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreateEmail.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxCreateEmail.Location = new System.Drawing.Point(449, 201);
            this.textBoxCreateEmail.Name = "textBoxCreateEmail";
            this.textBoxCreateEmail.Size = new System.Drawing.Size(123, 30);
            this.textBoxCreateEmail.TabIndex = 26;
            // 
            // textBoxCreatePhone
            // 
            this.textBoxCreatePhone.BackColor = System.Drawing.Color.White;
            this.textBoxCreatePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreatePhone.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxCreatePhone.Location = new System.Drawing.Point(449, 165);
            this.textBoxCreatePhone.Name = "textBoxCreatePhone";
            this.textBoxCreatePhone.Size = new System.Drawing.Size(123, 30);
            this.textBoxCreatePhone.TabIndex = 24;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox9.Location = new System.Drawing.Point(303, 165);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(123, 23);
            this.textBox9.TabIndex = 25;
            this.textBox9.Text = "Phone";
            // 
            // tabPageRead
            // 
            this.tabPageRead.Controls.Add(this.button1);
            this.tabPageRead.Controls.Add(this.label1);
            this.tabPageRead.Controls.Add(this.comboBoxMemberMemberInformationColumn);
            this.tabPageRead.Controls.Add(this.textBoxMemberSelect);
            this.tabPageRead.Controls.Add(this.textBox3);
            this.tabPageRead.Controls.Add(this.textBoxPage);
            this.tabPageRead.Controls.Add(this.btnLast);
            this.tabPageRead.Controls.Add(this.btnFiveOfFive);
            this.tabPageRead.Controls.Add(this.btnNext);
            this.tabPageRead.Controls.Add(this.btnThreeOfFive);
            this.tabPageRead.Controls.Add(this.btnFourOfFive);
            this.tabPageRead.Controls.Add(this.btnOneOfFive);
            this.tabPageRead.Controls.Add(this.btnTwoOfFive);
            this.tabPageRead.Controls.Add(this.btnFirst);
            this.tabPageRead.Controls.Add(this.btnPrev);
            this.tabPageRead.Controls.Add(this.comboBoxTable);
            this.tabPageRead.Controls.Add(this.dataGridViewRead);
            this.tabPageRead.Location = new System.Drawing.Point(4, 22);
            this.tabPageRead.Name = "tabPageRead";
            this.tabPageRead.Size = new System.Drawing.Size(965, 379);
            this.tabPageRead.TabIndex = 1;
            this.tabPageRead.Text = "회원조회";
            this.tabPageRead.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PowderBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(894, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 25);
            this.button1.TabIndex = 18;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(624, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 48;
            this.label1.Text = "검색";
            // 
            // comboBoxMemberMemberInformationColumn
            // 
            this.comboBoxMemberMemberInformationColumn.FormattingEnabled = true;
            this.comboBoxMemberMemberInformationColumn.Items.AddRange(new object[] {
            "Id",
            "Name",
            "Phone",
            "Email",
            "Position"});
            this.comboBoxMemberMemberInformationColumn.Location = new System.Drawing.Point(659, 353);
            this.comboBoxMemberMemberInformationColumn.Name = "comboBoxMemberMemberInformationColumn";
            this.comboBoxMemberMemberInformationColumn.Size = new System.Drawing.Size(123, 20);
            this.comboBoxMemberMemberInformationColumn.TabIndex = 47;
            this.comboBoxMemberMemberInformationColumn.Text = "Id";
            // 
            // textBoxMemberSelect
            // 
            this.textBoxMemberSelect.Location = new System.Drawing.Point(788, 352);
            this.textBoxMemberSelect.Name = "textBoxMemberSelect";
            this.textBoxMemberSelect.Size = new System.Drawing.Size(100, 21);
            this.textBoxMemberSelect.TabIndex = 46;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("굴림", 12F);
            this.textBox3.Location = new System.Drawing.Point(332, 8);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(83, 19);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "테이블";
            // 
            // textBoxPage
            // 
            this.textBoxPage.BackColor = System.Drawing.Color.White;
            this.textBoxPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPage.Font = new System.Drawing.Font("굴림", 12F);
            this.textBoxPage.Location = new System.Drawing.Point(421, 323);
            this.textBoxPage.Name = "textBoxPage";
            this.textBoxPage.ReadOnly = true;
            this.textBoxPage.Size = new System.Drawing.Size(123, 19);
            this.textBoxPage.TabIndex = 14;
            this.textBoxPage.Text = "page";
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.White;
            this.btnLast.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Location = new System.Drawing.Point(587, 348);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(31, 29);
            this.btnLast.TabIndex = 45;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnFiveOfFive
            // 
            this.btnFiveOfFive.BackColor = System.Drawing.Color.White;
            this.btnFiveOfFive.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFiveOfFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiveOfFive.Location = new System.Drawing.Point(513, 348);
            this.btnFiveOfFive.Name = "btnFiveOfFive";
            this.btnFiveOfFive.Size = new System.Drawing.Size(31, 29);
            this.btnFiveOfFive.TabIndex = 44;
            this.btnFiveOfFive.Text = "5";
            this.btnFiveOfFive.UseVisualStyleBackColor = false;
            this.btnFiveOfFive.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(550, 348);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(31, 29);
            this.btnNext.TabIndex = 43;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnThreeOfFive
            // 
            this.btnThreeOfFive.BackColor = System.Drawing.Color.White;
            this.btnThreeOfFive.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThreeOfFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThreeOfFive.Location = new System.Drawing.Point(439, 348);
            this.btnThreeOfFive.Name = "btnThreeOfFive";
            this.btnThreeOfFive.Size = new System.Drawing.Size(31, 29);
            this.btnThreeOfFive.TabIndex = 42;
            this.btnThreeOfFive.Text = "3";
            this.btnThreeOfFive.UseVisualStyleBackColor = false;
            this.btnThreeOfFive.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnFourOfFive
            // 
            this.btnFourOfFive.BackColor = System.Drawing.Color.White;
            this.btnFourOfFive.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFourOfFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFourOfFive.Location = new System.Drawing.Point(476, 348);
            this.btnFourOfFive.Name = "btnFourOfFive";
            this.btnFourOfFive.Size = new System.Drawing.Size(31, 29);
            this.btnFourOfFive.TabIndex = 41;
            this.btnFourOfFive.Text = "4";
            this.btnFourOfFive.UseVisualStyleBackColor = false;
            this.btnFourOfFive.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnOneOfFive
            // 
            this.btnOneOfFive.BackColor = System.Drawing.Color.White;
            this.btnOneOfFive.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOneOfFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneOfFive.Location = new System.Drawing.Point(365, 348);
            this.btnOneOfFive.Name = "btnOneOfFive";
            this.btnOneOfFive.Size = new System.Drawing.Size(31, 29);
            this.btnOneOfFive.TabIndex = 40;
            this.btnOneOfFive.Text = "1";
            this.btnOneOfFive.UseVisualStyleBackColor = false;
            this.btnOneOfFive.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTwoOfFive
            // 
            this.btnTwoOfFive.BackColor = System.Drawing.Color.White;
            this.btnTwoOfFive.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTwoOfFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwoOfFive.Location = new System.Drawing.Point(402, 348);
            this.btnTwoOfFive.Name = "btnTwoOfFive";
            this.btnTwoOfFive.Size = new System.Drawing.Size(31, 29);
            this.btnTwoOfFive.TabIndex = 39;
            this.btnTwoOfFive.Text = "2";
            this.btnTwoOfFive.UseVisualStyleBackColor = false;
            this.btnTwoOfFive.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.White;
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Location = new System.Drawing.Point(291, 348);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(31, 29);
            this.btnFirst.TabIndex = 38;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(328, 348);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(31, 29);
            this.btnPrev.TabIndex = 37;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btn_Click);
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Items.AddRange(new object[] {
            "Member",
            "MemberInformation"});
            this.comboBoxTable.Location = new System.Drawing.Point(421, 7);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(123, 20);
            this.comboBoxTable.TabIndex = 36;
            this.comboBoxTable.Text = "Member";
            this.comboBoxTable.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridViewRead
            // 
            this.dataGridViewRead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRead.Location = new System.Drawing.Point(0, 33);
            this.dataGridViewRead.Name = "dataGridViewRead";
            this.dataGridViewRead.RowTemplate.Height = 23;
            this.dataGridViewRead.Size = new System.Drawing.Size(962, 284);
            this.dataGridViewRead.TabIndex = 0;
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.buttonUpdateClear);
            this.tabPageUpdate.Controls.Add(this.comboBoxUpdatePosition);
            this.tabPageUpdate.Controls.Add(this.textBox4);
            this.tabPageUpdate.Controls.Add(this.textBox6);
            this.tabPageUpdate.Controls.Add(this.buttonUpdateRead);
            this.tabPageUpdate.Controls.Add(this.textBoxUpdateId);
            this.tabPageUpdate.Controls.Add(this.textBoxUpdatePassword);
            this.tabPageUpdate.Controls.Add(this.buttonupdate);
            this.tabPageUpdate.Controls.Add(this.textBox12);
            this.tabPageUpdate.Controls.Add(this.textBox13);
            this.tabPageUpdate.Controls.Add(this.textBoxUpdateName);
            this.tabPageUpdate.Controls.Add(this.textBox16);
            this.tabPageUpdate.Controls.Add(this.textBox18);
            this.tabPageUpdate.Controls.Add(this.textBoxUpdateEmail);
            this.tabPageUpdate.Controls.Add(this.textBoxUpdatePhone);
            this.tabPageUpdate.Controls.Add(this.textBox21);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Size = new System.Drawing.Size(965, 379);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "회원변경";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateClear
            // 
            this.buttonUpdateClear.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonUpdateClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUpdateClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateClear.Location = new System.Drawing.Point(583, 300);
            this.buttonUpdateClear.Name = "buttonUpdateClear";
            this.buttonUpdateClear.Size = new System.Drawing.Size(100, 50);
            this.buttonUpdateClear.TabIndex = 51;
            this.buttonUpdateClear.Text = "화면정리";
            this.buttonUpdateClear.UseVisualStyleBackColor = false;
            this.buttonUpdateClear.Click += new System.EventHandler(this.buttonUpdateClear_Click);
            // 
            // comboBoxUpdatePosition
            // 
            this.comboBoxUpdatePosition.FormattingEnabled = true;
            this.comboBoxUpdatePosition.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.comboBoxUpdatePosition.Location = new System.Drawing.Point(445, 234);
            this.comboBoxUpdatePosition.Name = "comboBoxUpdatePosition";
            this.comboBoxUpdatePosition.Size = new System.Drawing.Size(123, 20);
            this.comboBoxUpdatePosition.TabIndex = 50;
            this.comboBoxUpdatePosition.Text = "user";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox4.Location = new System.Drawing.Point(299, 234);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(123, 23);
            this.textBox4.TabIndex = 49;
            this.textBox4.Text = "Position";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox6.Location = new System.Drawing.Point(299, 54);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(123, 23);
            this.textBox6.TabIndex = 38;
            this.textBox6.Text = "User Id";
            // 
            // buttonUpdateRead
            // 
            this.buttonUpdateRead.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonUpdateRead.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonUpdateRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateRead.Location = new System.Drawing.Point(583, 54);
            this.buttonUpdateRead.Name = "buttonUpdateRead";
            this.buttonUpdateRead.Size = new System.Drawing.Size(83, 30);
            this.buttonUpdateRead.TabIndex = 48;
            this.buttonUpdateRead.Text = "조회";
            this.buttonUpdateRead.UseVisualStyleBackColor = false;
            this.buttonUpdateRead.Click += new System.EventHandler(this.buttonUpdateRead_Click);
            // 
            // textBoxUpdateId
            // 
            this.textBoxUpdateId.BackColor = System.Drawing.Color.White;
            this.textBoxUpdateId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUpdateId.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxUpdateId.Location = new System.Drawing.Point(445, 54);
            this.textBoxUpdateId.Name = "textBoxUpdateId";
            this.textBoxUpdateId.Size = new System.Drawing.Size(123, 30);
            this.textBoxUpdateId.TabIndex = 36;
            // 
            // textBoxUpdatePassword
            // 
            this.textBoxUpdatePassword.BackColor = System.Drawing.Color.White;
            this.textBoxUpdatePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUpdatePassword.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxUpdatePassword.Location = new System.Drawing.Point(445, 90);
            this.textBoxUpdatePassword.Name = "textBoxUpdatePassword";
            this.textBoxUpdatePassword.Size = new System.Drawing.Size(123, 30);
            this.textBoxUpdatePassword.TabIndex = 39;
            // 
            // buttonupdate
            // 
            this.buttonupdate.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonupdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonupdate.Location = new System.Drawing.Point(451, 300);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(100, 50);
            this.buttonupdate.TabIndex = 37;
            this.buttonupdate.Text = "정보변경";
            this.buttonupdate.UseVisualStyleBackColor = false;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.White;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox12.Location = new System.Drawing.Point(299, 90);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(123, 23);
            this.textBox12.TabIndex = 40;
            this.textBox12.Text = "Password";
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.White;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox13.Location = new System.Drawing.Point(428, 25);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(123, 23);
            this.textBox13.TabIndex = 47;
            this.textBox13.Text = "회원변경";
            // 
            // textBoxUpdateName
            // 
            this.textBoxUpdateName.BackColor = System.Drawing.Color.White;
            this.textBoxUpdateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUpdateName.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxUpdateName.Location = new System.Drawing.Point(445, 126);
            this.textBoxUpdateName.Name = "textBoxUpdateName";
            this.textBoxUpdateName.Size = new System.Drawing.Size(123, 30);
            this.textBoxUpdateName.TabIndex = 41;
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.White;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox16.Location = new System.Drawing.Point(299, 198);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(123, 23);
            this.textBox16.TabIndex = 46;
            this.textBox16.Text = "Email";
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.White;
            this.textBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox18.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox18.Location = new System.Drawing.Point(299, 126);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(123, 23);
            this.textBox18.TabIndex = 42;
            this.textBox18.Text = "Name";
            // 
            // textBoxUpdateEmail
            // 
            this.textBoxUpdateEmail.BackColor = System.Drawing.Color.White;
            this.textBoxUpdateEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUpdateEmail.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxUpdateEmail.Location = new System.Drawing.Point(445, 198);
            this.textBoxUpdateEmail.Name = "textBoxUpdateEmail";
            this.textBoxUpdateEmail.Size = new System.Drawing.Size(123, 30);
            this.textBoxUpdateEmail.TabIndex = 45;
            // 
            // textBoxUpdatePhone
            // 
            this.textBoxUpdatePhone.BackColor = System.Drawing.Color.White;
            this.textBoxUpdatePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUpdatePhone.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxUpdatePhone.Location = new System.Drawing.Point(445, 162);
            this.textBoxUpdatePhone.Name = "textBoxUpdatePhone";
            this.textBoxUpdatePhone.Size = new System.Drawing.Size(123, 30);
            this.textBoxUpdatePhone.TabIndex = 43;
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.Color.White;
            this.textBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox21.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox21.Location = new System.Drawing.Point(299, 162);
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(123, 23);
            this.textBox21.TabIndex = 44;
            this.textBox21.Text = "Phone";
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.buttonDeleteClear);
            this.tabPageDelete.Controls.Add(this.comboBoxDeletePosition);
            this.tabPageDelete.Controls.Add(this.textBox8);
            this.tabPageDelete.Controls.Add(this.textBox10);
            this.tabPageDelete.Controls.Add(this.buttonDeleteRead);
            this.tabPageDelete.Controls.Add(this.textBoxDeleteId);
            this.tabPageDelete.Controls.Add(this.buttonDelete);
            this.tabPageDelete.Controls.Add(this.textBox22);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 22);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(965, 379);
            this.tabPageDelete.TabIndex = 3;
            this.tabPageDelete.Text = "회원삭제";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteClear
            // 
            this.buttonDeleteClear.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonDeleteClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDeleteClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteClear.Location = new System.Drawing.Point(574, 302);
            this.buttonDeleteClear.Name = "buttonDeleteClear";
            this.buttonDeleteClear.Size = new System.Drawing.Size(100, 50);
            this.buttonDeleteClear.TabIndex = 67;
            this.buttonDeleteClear.Text = "화면정리";
            this.buttonDeleteClear.UseVisualStyleBackColor = false;
            this.buttonDeleteClear.Click += new System.EventHandler(this.buttonDeleteClear_Click);
            // 
            // comboBoxDeletePosition
            // 
            this.comboBoxDeletePosition.FormattingEnabled = true;
            this.comboBoxDeletePosition.Items.AddRange(new object[] {
            "user",
            "admin"});
            this.comboBoxDeletePosition.Location = new System.Drawing.Point(436, 109);
            this.comboBoxDeletePosition.Name = "comboBoxDeletePosition";
            this.comboBoxDeletePosition.Size = new System.Drawing.Size(123, 20);
            this.comboBoxDeletePosition.TabIndex = 66;
            this.comboBoxDeletePosition.Text = "user";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox8.Location = new System.Drawing.Point(290, 105);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(123, 23);
            this.textBox8.TabIndex = 65;
            this.textBox8.Text = "Position";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.White;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox10.Location = new System.Drawing.Point(290, 56);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(123, 23);
            this.textBox10.TabIndex = 54;
            this.textBox10.Text = "User Id";
            // 
            // buttonDeleteRead
            // 
            this.buttonDeleteRead.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonDeleteRead.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDeleteRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteRead.Location = new System.Drawing.Point(574, 56);
            this.buttonDeleteRead.Name = "buttonDeleteRead";
            this.buttonDeleteRead.Size = new System.Drawing.Size(83, 30);
            this.buttonDeleteRead.TabIndex = 64;
            this.buttonDeleteRead.Text = "조회";
            this.buttonDeleteRead.UseVisualStyleBackColor = false;
            this.buttonDeleteRead.Click += new System.EventHandler(this.buttonDeleteRead_Click);
            // 
            // textBoxDeleteId
            // 
            this.textBoxDeleteId.BackColor = System.Drawing.Color.White;
            this.textBoxDeleteId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDeleteId.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxDeleteId.Location = new System.Drawing.Point(436, 56);
            this.textBoxDeleteId.Name = "textBoxDeleteId";
            this.textBoxDeleteId.Size = new System.Drawing.Size(123, 30);
            this.textBoxDeleteId.TabIndex = 52;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(442, 302);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 50);
            this.buttonDelete.TabIndex = 53;
            this.buttonDelete.Text = "삭제";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.Color.White;
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox22.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox22.Location = new System.Drawing.Point(419, 27);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(123, 23);
            this.textBox22.TabIndex = 63;
            this.textBox22.Text = "회원변경";
            // 
            // tabPageChart
            // 
            this.tabPageChart.Controls.Add(this.dataGridViewChart);
            this.tabPageChart.Controls.Add(this.comboBoxChart);
            this.tabPageChart.Controls.Add(this.buttonChartPoint);
            this.tabPageChart.Controls.Add(this.buttonChartActivity);
            this.tabPageChart.Controls.Add(this.buttonChartWriting);
            this.tabPageChart.Controls.Add(this.chart1);
            this.tabPageChart.Location = new System.Drawing.Point(4, 22);
            this.tabPageChart.Name = "tabPageChart";
            this.tabPageChart.Size = new System.Drawing.Size(965, 379);
            this.tabPageChart.TabIndex = 4;
            this.tabPageChart.Text = "차트조회";
            this.tabPageChart.UseVisualStyleBackColor = true;
            // 
            // dataGridViewChart
            // 
            this.dataGridViewChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChart.Location = new System.Drawing.Point(6, 72);
            this.dataGridViewChart.Name = "dataGridViewChart";
            this.dataGridViewChart.RowTemplate.Height = 23;
            this.dataGridViewChart.Size = new System.Drawing.Size(457, 291);
            this.dataGridViewChart.TabIndex = 40;
            this.dataGridViewChart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChart_CellContentClick);
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
            this.comboBoxChart.Location = new System.Drawing.Point(469, 25);
            this.comboBoxChart.Name = "comboBoxChart";
            this.comboBoxChart.Size = new System.Drawing.Size(100, 28);
            this.comboBoxChart.TabIndex = 39;
            this.comboBoxChart.Text = "Activity";
            this.comboBoxChart.SelectedIndexChanged += new System.EventHandler(this.comboBoxChart_SelectedIndexChanged);
            // 
            // buttonChartPoint
            // 
            this.buttonChartPoint.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonChartPoint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonChartPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChartPoint.Location = new System.Drawing.Point(6, 16);
            this.buttonChartPoint.Name = "buttonChartPoint";
            this.buttonChartPoint.Size = new System.Drawing.Size(100, 50);
            this.buttonChartPoint.TabIndex = 35;
            this.buttonChartPoint.Text = "Point";
            this.buttonChartPoint.UseVisualStyleBackColor = false;
            this.buttonChartPoint.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // buttonChartActivity
            // 
            this.buttonChartActivity.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonChartActivity.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonChartActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChartActivity.Location = new System.Drawing.Point(218, 16);
            this.buttonChartActivity.Name = "buttonChartActivity";
            this.buttonChartActivity.Size = new System.Drawing.Size(100, 50);
            this.buttonChartActivity.TabIndex = 34;
            this.buttonChartActivity.Text = "Activity";
            this.buttonChartActivity.UseVisualStyleBackColor = false;
            this.buttonChartActivity.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // buttonChartWriting
            // 
            this.buttonChartWriting.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonChartWriting.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonChartWriting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChartWriting.Location = new System.Drawing.Point(112, 16);
            this.buttonChartWriting.Name = "buttonChartWriting";
            this.buttonChartWriting.Size = new System.Drawing.Size(100, 50);
            this.buttonChartWriting.TabIndex = 33;
            this.buttonChartWriting.Text = "Writing";
            this.buttonChartWriting.UseVisualStyleBackColor = false;
            this.buttonChartWriting.Click += new System.EventHandler(this.buttonChart_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(469, 72);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chart1.Size = new System.Drawing.Size(490, 291);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxId);
            this.panel3.Location = new System.Drawing.Point(459, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 39);
            this.panel3.TabIndex = 16;
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
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Location = new System.Drawing.Point(858, 57);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(100, 42);
            this.buttonLogout.TabIndex = 17;
            this.buttonLogout.Text = "로그아웃";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageCreate.ResumeLayout(false);
            this.tabPageCreate.PerformLayout();
            this.tabPageRead.ResumeLayout(false);
            this.tabPageRead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRead)).EndInit();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            this.tabPageChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion
        private TextBox textBox1;
        private TabControl tabControl1;
        private Panel panel3;
        private TextBox textBoxId;
        private Button buttonLogout;
        private TabPage tabPageCreate;
        private TabPage tabPageRead;
        private TabPage tabPageUpdate;
        private TabPage tabPageDelete;
        private TabPage tabPageChart;
        private Button buttonDuplicationSelect;
        private Button buttonCreatePanelCreate;
        private TextBox textBox17;
        private TextBox textBox15;
        private TextBox textBoxCreateEmail;
        private TextBox textBox9;
        private TextBox textBoxCreatePhone;
        private TextBox textBox11;
        private TextBox textBoxCreateName;
        private TextBox textBox5;
        private TextBox textBoxCreatePassword;
        private TextBox textBox7;
        private TextBox textBoxCreateId;
        private ComboBox comboBoxPosition;
        private TextBox textBox2;
        private Button btnLast;
        private Button btnFiveOfFive;
        private Button btnNext;
        private Button btnThreeOfFive;
        private Button btnFourOfFive;
        private Button btnOneOfFive;
        private Button btnTwoOfFive;
        private Button btnFirst;
        private Button btnPrev;
        private ComboBox comboBoxTable;
        private DataGridView dataGridViewRead;
        private TextBox textBoxPage;
        private TextBox textBox3;
        private ComboBox comboBoxUpdatePosition;
        private TextBox textBox4;
        private TextBox textBox6;
        private Button buttonUpdateRead;
        private TextBox textBoxUpdateId;
        private TextBox textBoxUpdatePassword;
        private Button buttonupdate;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBoxUpdateName;
        private TextBox textBox16;
        private TextBox textBox18;
        private TextBox textBoxUpdateEmail;
        private TextBox textBoxUpdatePhone;
        private TextBox textBox21;
        private Button buttonUpdateClear;
        private Button buttonDeleteClear;
        private ComboBox comboBoxDeletePosition;
        private TextBox textBox8;
        private TextBox textBox10;
        private Button buttonDeleteRead;
        private TextBox textBoxDeleteId;
        private Button buttonDelete;
        private TextBox textBox22;
        private DataGridView dataGridViewChart;
        private ComboBox comboBoxChart;
        private Button buttonChartPoint;
        private Button buttonChartActivity;
        private Button buttonChartWriting;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label1;
        private ComboBox comboBoxMemberMemberInformationColumn;
        private TextBox textBoxMemberSelect;
        private Button button1;
    }
}

