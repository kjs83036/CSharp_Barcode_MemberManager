using System.Windows.Forms;

namespace MemberBarcode
{
    partial class Form2
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCreate = new System.Windows.Forms.Panel();
            this.buttonDuplicationSelect = new System.Windows.Forms.Button();
            this.buttonCreateCancle = new System.Windows.Forms.Button();
            this.buttonCreatePanelCreate = new System.Windows.Forms.Button();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBoxCreateEmail = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBoxCreatePhone = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBoxCreateName = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBoxCreatePassword = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBoxCreateId = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCreateMember = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelMain.SuspendLayout();
            this.panelCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.panelCreate);
            this.panelMain.Controls.Add(this.textBox4);
            this.panelMain.Controls.Add(this.textBoxPassword);
            this.panelMain.Controls.Add(this.textBox2);
            this.panelMain.Controls.Add(this.textBoxId);
            this.panelMain.Controls.Add(this.buttonLogin);
            this.panelMain.Controls.Add(this.buttonCreateMember);
            this.panelMain.Location = new System.Drawing.Point(0, 103);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1003, 399);
            this.panelMain.TabIndex = 6;
            // 
            // panelCreate
            // 
            this.panelCreate.Controls.Add(this.buttonDuplicationSelect);
            this.panelCreate.Controls.Add(this.buttonCreateCancle);
            this.panelCreate.Controls.Add(this.buttonCreatePanelCreate);
            this.panelCreate.Controls.Add(this.textBox17);
            this.panelCreate.Controls.Add(this.textBox15);
            this.panelCreate.Controls.Add(this.textBoxCreateEmail);
            this.panelCreate.Controls.Add(this.textBox9);
            this.panelCreate.Controls.Add(this.textBoxCreatePhone);
            this.panelCreate.Controls.Add(this.textBox11);
            this.panelCreate.Controls.Add(this.textBoxCreateName);
            this.panelCreate.Controls.Add(this.textBox5);
            this.panelCreate.Controls.Add(this.textBoxCreatePassword);
            this.panelCreate.Controls.Add(this.textBox7);
            this.panelCreate.Controls.Add(this.textBoxCreateId);
            this.panelCreate.Location = new System.Drawing.Point(266, 17);
            this.panelCreate.Name = "panelCreate";
            this.panelCreate.Size = new System.Drawing.Size(440, 367);
            this.panelCreate.TabIndex = 8;
            this.panelCreate.Visible = false;
            // 
            // buttonDuplicationSelect
            // 
            this.buttonDuplicationSelect.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonDuplicationSelect.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDuplicationSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDuplicationSelect.Location = new System.Drawing.Point(319, 46);
            this.buttonDuplicationSelect.Name = "buttonDuplicationSelect";
            this.buttonDuplicationSelect.Size = new System.Drawing.Size(83, 30);
            this.buttonDuplicationSelect.TabIndex = 32;
            this.buttonDuplicationSelect.Text = "중복조회";
            this.buttonDuplicationSelect.UseVisualStyleBackColor = false;
            this.buttonDuplicationSelect.Click += new System.EventHandler(this.buttonDuplicationSelect_Click);
            // 
            // buttonCreateCancle
            // 
            this.buttonCreateCancle.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonCreateCancle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCreateCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateCancle.Location = new System.Drawing.Point(262, 297);
            this.buttonCreateCancle.Name = "buttonCreateCancle";
            this.buttonCreateCancle.Size = new System.Drawing.Size(100, 50);
            this.buttonCreateCancle.TabIndex = 31;
            this.buttonCreateCancle.Text = "취소";
            this.buttonCreateCancle.UseVisualStyleBackColor = false;
            this.buttonCreateCancle.Click += new System.EventHandler(this.buttonCreateCancle_Click);
            // 
            // buttonCreatePanelCreate
            // 
            this.buttonCreatePanelCreate.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonCreatePanelCreate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCreatePanelCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreatePanelCreate.Location = new System.Drawing.Point(64, 297);
            this.buttonCreatePanelCreate.Name = "buttonCreatePanelCreate";
            this.buttonCreatePanelCreate.Size = new System.Drawing.Size(100, 50);
            this.buttonCreatePanelCreate.TabIndex = 18;
            this.buttonCreatePanelCreate.Text = "회원가입";
            this.buttonCreatePanelCreate.UseVisualStyleBackColor = false;
            this.buttonCreatePanelCreate.Click += new System.EventHandler(this.buttonCreatePanelCreate_Click);
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
            this.textBox17.Text = "회원가입";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.White;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox15.Location = new System.Drawing.Point(35, 190);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(123, 23);
            this.textBox15.TabIndex = 27;
            this.textBox15.Text = "Email";
            // 
            // textBoxCreateEmail
            // 
            this.textBoxCreateEmail.BackColor = System.Drawing.Color.White;
            this.textBoxCreateEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreateEmail.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxCreateEmail.Location = new System.Drawing.Point(181, 190);
            this.textBoxCreateEmail.Name = "textBoxCreateEmail";
            this.textBoxCreateEmail.Size = new System.Drawing.Size(123, 30);
            this.textBoxCreateEmail.TabIndex = 26;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox9.Location = new System.Drawing.Point(35, 154);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(123, 23);
            this.textBox9.TabIndex = 25;
            this.textBox9.Text = "Phone";
            // 
            // textBoxCreatePhone
            // 
            this.textBoxCreatePhone.BackColor = System.Drawing.Color.White;
            this.textBoxCreatePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreatePhone.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxCreatePhone.Location = new System.Drawing.Point(181, 154);
            this.textBoxCreatePhone.Name = "textBoxCreatePhone";
            this.textBoxCreatePhone.Size = new System.Drawing.Size(123, 30);
            this.textBoxCreatePhone.TabIndex = 24;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.White;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox11.Location = new System.Drawing.Point(35, 118);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(123, 23);
            this.textBox11.TabIndex = 23;
            this.textBox11.Text = "Name";
            // 
            // textBoxCreateName
            // 
            this.textBoxCreateName.BackColor = System.Drawing.Color.White;
            this.textBoxCreateName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreateName.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxCreateName.Location = new System.Drawing.Point(181, 118);
            this.textBoxCreateName.Name = "textBoxCreateName";
            this.textBoxCreateName.Size = new System.Drawing.Size(123, 30);
            this.textBoxCreateName.TabIndex = 22;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.White;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox5.Location = new System.Drawing.Point(35, 82);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(123, 23);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = "Password";
            // 
            // textBoxCreatePassword
            // 
            this.textBoxCreatePassword.BackColor = System.Drawing.Color.White;
            this.textBoxCreatePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreatePassword.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxCreatePassword.Location = new System.Drawing.Point(181, 82);
            this.textBoxCreatePassword.Name = "textBoxCreatePassword";
            this.textBoxCreatePassword.Size = new System.Drawing.Size(123, 30);
            this.textBoxCreatePassword.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox7.Location = new System.Drawing.Point(35, 46);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(123, 23);
            this.textBox7.TabIndex = 19;
            this.textBox7.Text = "User Id";
            // 
            // textBoxCreateId
            // 
            this.textBoxCreateId.BackColor = System.Drawing.Color.White;
            this.textBoxCreateId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCreateId.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxCreateId.Location = new System.Drawing.Point(181, 46);
            this.textBoxCreateId.Name = "textBoxCreateId";
            this.textBoxCreateId.Size = new System.Drawing.Size(123, 30);
            this.textBoxCreateId.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox4.Location = new System.Drawing.Point(290, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(123, 23);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxPassword.Location = new System.Drawing.Point(436, 148);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(123, 30);
            this.textBoxPassword.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox2.Location = new System.Drawing.Point(290, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(123, 23);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "User Id";
            // 
            // textBoxId
            // 
            this.textBoxId.BackColor = System.Drawing.Color.White;
            this.textBoxId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxId.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxId.Location = new System.Drawing.Point(436, 94);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(123, 30);
            this.textBoxId.TabIndex = 14;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Location = new System.Drawing.Point(606, 138);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 50);
            this.buttonLogin.TabIndex = 13;
            this.buttonLogin.Text = "로그인";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCreateMember
            // 
            this.buttonCreateMember.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonCreateMember.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateMember.Location = new System.Drawing.Point(606, 82);
            this.buttonCreateMember.Name = "buttonCreateMember";
            this.buttonCreateMember.Size = new System.Drawing.Size(100, 50);
            this.buttonCreateMember.TabIndex = 12;
            this.buttonCreateMember.Text = "회원가입";
            this.buttonCreateMember.UseVisualStyleBackColor = false;
            this.buttonCreateMember.Click += new System.EventHandler(this.buttonCreateMember_Click);
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
            this.textBox1.Text = "LoginBarcodeP";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Form1";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelCreate.ResumeLayout(false);
            this.panelCreate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion
        private Panel panelMain;
        private TextBox textBox1;
        private Button buttonCreateMember;
        private Button buttonLogin;
        private TextBox textBox4;
        private TextBox textBoxPassword;
        private TextBox textBox2;
        private TextBox textBoxId;
        private Panel panelCreate;
        private Button buttonDuplicationSelect;
        private Button buttonCreateCancle;
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
    }
}

