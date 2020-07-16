namespace BarcodeByJS
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
            this.buttonLogout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKinds
            // 
            this.comboBoxKinds.FormattingEnabled = true;
            this.comboBoxKinds.Items.AddRange(new object[] {
            "Code39 (1D)",
            "ITF (1D)",
            "Code128 (1D)",
            "Data metrix (2D)",
            "QR코드 (2D)"});
            this.comboBoxKinds.Location = new System.Drawing.Point(503, 65);
            this.comboBoxKinds.Name = "comboBoxKinds";
            this.comboBoxKinds.Size = new System.Drawing.Size(100, 20);
            this.comboBoxKinds.TabIndex = 0;
            this.comboBoxKinds.SelectedIndexChanged += new System.EventHandler(this.comboBoxKinds_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "바코드 종류";
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.Location = new System.Drawing.Point(36, 65);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(355, 244);
            this.pictureBoxBarcode.TabIndex = 3;
            this.pictureBoxBarcode.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "상품명";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(503, 110);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 21);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(503, 160);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 21);
            this.textBoxDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "등록일";
            // 
            // textBoxInfo1
            // 
            this.textBoxInfo1.Location = new System.Drawing.Point(503, 218);
            this.textBoxInfo1.Name = "textBoxInfo1";
            this.textBoxInfo1.Size = new System.Drawing.Size(100, 21);
            this.textBoxInfo1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "정보1";
            // 
            // textBoxInfo2
            // 
            this.textBoxInfo2.Location = new System.Drawing.Point(503, 269);
            this.textBoxInfo2.Name = "textBoxInfo2";
            this.textBoxInfo2.Size = new System.Drawing.Size(100, 21);
            this.textBoxInfo2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(429, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "정보2";
            // 
            // textBoxInfo3
            // 
            this.textBoxInfo3.Location = new System.Drawing.Point(503, 316);
            this.textBoxInfo3.Name = "textBoxInfo3";
            this.textBoxInfo3.Size = new System.Drawing.Size(100, 21);
            this.textBoxInfo3.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "정보3";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(225, 349);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 32);
            this.buttonRead.TabIndex = 14;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(316, 349);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 32);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(36, 349);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 32);
            this.buttonCreate.TabIndex = 16;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(130, 349);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 32);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(164, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "바코드 입출력";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(598, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(75, 32);
            this.buttonLogout.TabIndex = 19;
            this.buttonLogout.Text = "로그아웃";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "창닫기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLogout);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
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
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button button1;
    }
}

