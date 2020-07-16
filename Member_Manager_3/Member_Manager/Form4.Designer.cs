namespace Member_Manager
{
    partial class Form4
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
            this.comboBoxKinds = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxInfo1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInfo2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxInfo3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxColumn = new System.Windows.Forms.ComboBox();
            this.buttonDbSelect = new System.Windows.Forms.Button();
            this.buttonInsertToDb = new System.Windows.Forms.Button();
            this.textBoxDbSelect = new System.Windows.Forms.TextBox();
            this.buttonDbClear = new System.Windows.Forms.Button();
            this.textBoxInfoAll = new System.Windows.Forms.TextBox();
            this.buttonDbSelectAll = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.comboBoxKinds.Location = new System.Drawing.Point(348, 60);
            this.comboBoxKinds.Name = "comboBoxKinds";
            this.comboBoxKinds.Size = new System.Drawing.Size(100, 20);
            this.comboBoxKinds.TabIndex = 0;
            this.comboBoxKinds.SelectedIndexChanged += new System.EventHandler(this.comboBoxKinds_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "바코드 종류";
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.Location = new System.Drawing.Point(36, 65);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(200, 150);
            this.pictureBoxBarcode.TabIndex = 3;
            this.pictureBoxBarcode.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "상품명";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(348, 86);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 21);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(348, 113);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 21);
            this.textBoxDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "등록일";
            // 
            // textBoxInfo1
            // 
            this.textBoxInfo1.Location = new System.Drawing.Point(348, 140);
            this.textBoxInfo1.Name = "textBoxInfo1";
            this.textBoxInfo1.Size = new System.Drawing.Size(100, 21);
            this.textBoxInfo1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "정보1";
            // 
            // textBoxInfo2
            // 
            this.textBoxInfo2.Location = new System.Drawing.Point(348, 167);
            this.textBoxInfo2.Name = "textBoxInfo2";
            this.textBoxInfo2.Size = new System.Drawing.Size(100, 21);
            this.textBoxInfo2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "정보2";
            // 
            // textBoxInfo3
            // 
            this.textBoxInfo3.Location = new System.Drawing.Point(348, 194);
            this.textBoxInfo3.Name = "textBoxInfo3";
            this.textBoxInfo3.Size = new System.Drawing.Size(100, 21);
            this.textBoxInfo3.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "정보3";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(568, 89);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(85, 21);
            this.buttonRead.TabIndex = 14;
            this.buttonRead.Text = "FromFile";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(568, 116);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(85, 20);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(475, 59);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(87, 20);
            this.buttonCreate.TabIndex = 16;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(475, 89);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(87, 20);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "ToFile";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(244, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "바코드 입출력";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "창닫기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(617, 155);
            this.dataGridView1.TabIndex = 21;
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
            this.comboBoxColumn.Location = new System.Drawing.Point(475, 162);
            this.comboBoxColumn.Name = "comboBoxColumn";
            this.comboBoxColumn.Size = new System.Drawing.Size(87, 20);
            this.comboBoxColumn.TabIndex = 22;
            this.comboBoxColumn.Text = "선택";
            // 
            // buttonDbSelect
            // 
            this.buttonDbSelect.Location = new System.Drawing.Point(568, 195);
            this.buttonDbSelect.Name = "buttonDbSelect";
            this.buttonDbSelect.Size = new System.Drawing.Size(85, 20);
            this.buttonDbSelect.TabIndex = 23;
            this.buttonDbSelect.Text = "DbSelect";
            this.buttonDbSelect.UseVisualStyleBackColor = true;
            this.buttonDbSelect.Click += new System.EventHandler(this.buttonBdSelect_Click);
            // 
            // buttonInsertToDb
            // 
            this.buttonInsertToDb.Location = new System.Drawing.Point(568, 60);
            this.buttonInsertToDb.Name = "buttonInsertToDb";
            this.buttonInsertToDb.Size = new System.Drawing.Size(85, 20);
            this.buttonInsertToDb.TabIndex = 24;
            this.buttonInsertToDb.Text = "InsertToDb";
            this.buttonInsertToDb.UseVisualStyleBackColor = true;
            this.buttonInsertToDb.Click += new System.EventHandler(this.buttonInsertToDb_Click);
            // 
            // textBoxDbSelect
            // 
            this.textBoxDbSelect.Location = new System.Drawing.Point(568, 162);
            this.textBoxDbSelect.Name = "textBoxDbSelect";
            this.textBoxDbSelect.Size = new System.Drawing.Size(85, 21);
            this.textBoxDbSelect.TabIndex = 25;
            // 
            // buttonDbClear
            // 
            this.buttonDbClear.Location = new System.Drawing.Point(475, 195);
            this.buttonDbClear.Name = "buttonDbClear";
            this.buttonDbClear.Size = new System.Drawing.Size(87, 20);
            this.buttonDbClear.TabIndex = 26;
            this.buttonDbClear.Text = "DbClear";
            this.buttonDbClear.UseVisualStyleBackColor = true;
            this.buttonDbClear.Click += new System.EventHandler(this.buttonDbClear_Click);
            // 
            // textBoxInfoAll
            // 
            this.textBoxInfoAll.Location = new System.Drawing.Point(36, 221);
            this.textBoxInfoAll.Name = "textBoxInfoAll";
            this.textBoxInfoAll.Size = new System.Drawing.Size(200, 21);
            this.textBoxInfoAll.TabIndex = 27;
            // 
            // buttonDbSelectAll
            // 
            this.buttonDbSelectAll.Location = new System.Drawing.Point(568, 222);
            this.buttonDbSelectAll.Name = "buttonDbSelectAll";
            this.buttonDbSelectAll.Size = new System.Drawing.Size(85, 20);
            this.buttonDbSelectAll.TabIndex = 28;
            this.buttonDbSelectAll.Text = "DbSelectAll";
            this.buttonDbSelectAll.UseVisualStyleBackColor = true;
            this.buttonDbSelectAll.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 12);
            this.label8.TabIndex = 29;
            this.label8.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(79, 24);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(100, 21);
            this.textBoxId.TabIndex = 30;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 403);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.buttonDbSelectAll);
            this.Controls.Add(this.textBoxInfoAll);
            this.Controls.Add(this.buttonDbClear);
            this.Controls.Add(this.textBoxDbSelect);
            this.Controls.Add(this.buttonInsertToDb);
            this.Controls.Add(this.buttonDbSelect);
            this.Controls.Add(this.comboBoxColumn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.textBoxInfo3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxInfo2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxInfo1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxBarcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxKinds);
            this.Name = "Form4";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKinds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxBarcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxInfo1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInfo2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxInfo3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxColumn;
        private System.Windows.Forms.Button buttonDbSelect;
        private System.Windows.Forms.Button buttonInsertToDb;
        private System.Windows.Forms.TextBox textBoxDbSelect;
        private System.Windows.Forms.Button buttonDbClear;
        private System.Windows.Forms.TextBox textBoxInfoAll;
        private System.Windows.Forms.Button buttonDbSelectAll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxId;
    }
}