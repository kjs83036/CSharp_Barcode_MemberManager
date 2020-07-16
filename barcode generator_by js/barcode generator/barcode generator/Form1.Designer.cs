namespace barcode_generator
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.labelProduct = new System.Windows.Forms.Label();
            this.registrationDate = new System.Windows.Forms.Label();
            this.inform1 = new System.Windows.Forms.Label();
            this.inform2 = new System.Windows.Forms.Label();
            this.inform3 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtinfo1 = new System.Windows.Forms.TextBox();
            this.txtinfo2 = new System.Windows.Forms.TextBox();
            this.txtinfo3 = new System.Windows.Forms.TextBox();
            this.picbarcode = new System.Windows.Forms.PictureBox();
            this.cbokinds = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRegistration = new System.Windows.Forms.TextBox();
            this.btn_read = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(217, 302);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 40);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(323, 302);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(88, 40);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // labelProduct
            // 
            this.labelProduct.AutoSize = true;
            this.labelProduct.Location = new System.Drawing.Point(265, 43);
            this.labelProduct.Name = "labelProduct";
            this.labelProduct.Size = new System.Drawing.Size(49, 12);
            this.labelProduct.TabIndex = 2;
            this.labelProduct.Text = "상품 명:";
            this.labelProduct.Click += new System.EventHandler(this.label1_Click);
            // 
            // registrationDate
            // 
            this.registrationDate.AutoSize = true;
            this.registrationDate.Location = new System.Drawing.Point(264, 96);
            this.registrationDate.Name = "registrationDate";
            this.registrationDate.Size = new System.Drawing.Size(49, 12);
            this.registrationDate.TabIndex = 3;
            this.registrationDate.Text = "등록 일:";
            this.registrationDate.Click += new System.EventHandler(this.registrationDate_Click);
            // 
            // inform1
            // 
            this.inform1.AutoSize = true;
            this.inform1.Location = new System.Drawing.Point(271, 149);
            this.inform1.Name = "inform1";
            this.inform1.Size = new System.Drawing.Size(39, 12);
            this.inform1.TabIndex = 4;
            this.inform1.Text = "정보1:";
            // 
            // inform2
            // 
            this.inform2.AutoSize = true;
            this.inform2.Location = new System.Drawing.Point(271, 191);
            this.inform2.Name = "inform2";
            this.inform2.Size = new System.Drawing.Size(39, 12);
            this.inform2.TabIndex = 5;
            this.inform2.Text = "정보2:";
            // 
            // inform3
            // 
            this.inform3.AutoSize = true;
            this.inform3.Location = new System.Drawing.Point(271, 233);
            this.inform3.Name = "inform3";
            this.inform3.Size = new System.Drawing.Size(39, 12);
            this.inform3.TabIndex = 6;
            this.inform3.Text = "정보3:";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(313, 37);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(98, 21);
            this.txtProduct.TabIndex = 8;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            this.txtProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduct_KeyPress);
            // 
            // txtinfo1
            // 
            this.txtinfo1.Location = new System.Drawing.Point(315, 144);
            this.txtinfo1.Name = "txtinfo1";
            this.txtinfo1.Size = new System.Drawing.Size(96, 21);
            this.txtinfo1.TabIndex = 10;
            this.txtinfo1.TextChanged += new System.EventHandler(this.txtinfo1_TextChanged);
            this.txtinfo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinfo1_KeyPress);
            // 
            // txtinfo2
            // 
            this.txtinfo2.Location = new System.Drawing.Point(315, 185);
            this.txtinfo2.Name = "txtinfo2";
            this.txtinfo2.Size = new System.Drawing.Size(96, 21);
            this.txtinfo2.TabIndex = 11;
            this.txtinfo2.TextChanged += new System.EventHandler(this.txtinfo2_TextChanged);
            this.txtinfo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinfo2_KeyPress);
            // 
            // txtinfo3
            // 
            this.txtinfo3.Location = new System.Drawing.Point(315, 228);
            this.txtinfo3.Name = "txtinfo3";
            this.txtinfo3.Size = new System.Drawing.Size(96, 21);
            this.txtinfo3.TabIndex = 12;
            this.txtinfo3.TextChanged += new System.EventHandler(this.txtinfo3_TextChanged);
            this.txtinfo3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinfo3_KeyPress);
            // 
            // picbarcode
            // 
            this.picbarcode.Location = new System.Drawing.Point(12, 98);
            this.picbarcode.Name = "picbarcode";
            this.picbarcode.Size = new System.Drawing.Size(226, 147);
            this.picbarcode.TabIndex = 13;
            this.picbarcode.TabStop = false;
            this.picbarcode.Click += new System.EventHandler(this.picbarcode_Click);
            // 
            // cbokinds
            // 
            this.cbokinds.FormattingEnabled = true;
            this.cbokinds.Items.AddRange(new object[] {
            "Code39   (1D)",
            "ITF   (1D)",
            "Code128  (1D)",
            "Data metrix  (2D)",
            "QR코드  (2D)"});
            this.cbokinds.Location = new System.Drawing.Point(12, 38);
            this.cbokinds.Name = "cbokinds";
            this.cbokinds.Size = new System.Drawing.Size(148, 20);
            this.cbokinds.TabIndex = 7;
            this.cbokinds.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "바코드";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "바코드 종류 선택";
            // 
            // txtRegistration
            // 
            this.txtRegistration.Location = new System.Drawing.Point(313, 91);
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.Size = new System.Drawing.Size(98, 21);
            this.txtRegistration.TabIndex = 9;
            this.txtRegistration.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtRegistration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegistration_KeyPress);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(109, 302);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(88, 40);
            this.btn_read.TabIndex = 16;
            this.btn_read.Text = "read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 367);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picbarcode);
            this.Controls.Add(this.txtinfo3);
            this.Controls.Add(this.txtinfo2);
            this.Controls.Add(this.txtinfo1);
            this.Controls.Add(this.txtRegistration);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.cbokinds);
            this.Controls.Add(this.inform3);
            this.Controls.Add(this.inform2);
            this.Controls.Add(this.inform1);
            this.Controls.Add(this.registrationDate);
            this.Controls.Add(this.labelProduct);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnClear);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picbarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.Label registrationDate;
        private System.Windows.Forms.Label inform1;
        private System.Windows.Forms.Label inform2;
        private System.Windows.Forms.Label inform3;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtinfo1;
        private System.Windows.Forms.TextBox txtinfo2;
        private System.Windows.Forms.TextBox txtinfo3;
        private System.Windows.Forms.PictureBox picbarcode;
        private System.Windows.Forms.ComboBox cbokinds;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRegistration;
        private System.Windows.Forms.Button btn_read;
    }
}

