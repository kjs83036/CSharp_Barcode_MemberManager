namespace Member_Manager
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain2 = new System.Windows.Forms.Panel();
            this.textBoxActivity = new System.Windows.Forms.TextBox();
            this.textBoxWriting = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPoint = new System.Windows.Forms.TextBox();
            this.buttonLogOut2 = new System.Windows.Forms.Button();
            this.buttonDeleteMember = new System.Windows.Forms.Button();
            this.buttonReadMember = new System.Windows.Forms.Button();
            this.buttonUpdateMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelMain2
            // 
            this.panelMain2.Location = new System.Drawing.Point(12, 12);
            this.panelMain2.Name = "panelMain2";
            this.panelMain2.Size = new System.Drawing.Size(761, 426);
            this.panelMain2.TabIndex = 11;
            this.panelMain2.Visible = false;
            // 
            // textBoxActivity
            // 
            this.textBoxActivity.Location = new System.Drawing.Point(521, 40);
            this.textBoxActivity.Name = "textBoxActivity";
            this.textBoxActivity.ReadOnly = true;
            this.textBoxActivity.Size = new System.Drawing.Size(100, 21);
            this.textBoxActivity.TabIndex = 19;
            // 
            // textBoxWriting
            // 
            this.textBoxWriting.Location = new System.Drawing.Point(370, 40);
            this.textBoxWriting.Name = "textBoxWriting";
            this.textBoxWriting.ReadOnly = true;
            this.textBoxWriting.Size = new System.Drawing.Size(100, 21);
            this.textBoxWriting.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "Activity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(66, 40);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(100, 21);
            this.textBoxId.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "Writing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "Point";
            // 
            // textBoxPoint
            // 
            this.textBoxPoint.Location = new System.Drawing.Point(215, 40);
            this.textBoxPoint.Name = "textBoxPoint";
            this.textBoxPoint.ReadOnly = true;
            this.textBoxPoint.Size = new System.Drawing.Size(100, 21);
            this.textBoxPoint.TabIndex = 15;
            // 
            // buttonLogOut2
            // 
            this.buttonLogOut2.Location = new System.Drawing.Point(678, 40);
            this.buttonLogOut2.Name = "buttonLogOut2";
            this.buttonLogOut2.Size = new System.Drawing.Size(95, 23);
            this.buttonLogOut2.TabIndex = 10;
            this.buttonLogOut2.Text = "로그아웃";
            this.buttonLogOut2.UseVisualStyleBackColor = true;
            this.buttonLogOut2.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonDeleteMember
            // 
            this.buttonDeleteMember.Location = new System.Drawing.Point(678, 219);
            this.buttonDeleteMember.Name = "buttonDeleteMember";
            this.buttonDeleteMember.Size = new System.Drawing.Size(95, 23);
            this.buttonDeleteMember.TabIndex = 9;
            this.buttonDeleteMember.Text = "회원 탈퇴";
            this.buttonDeleteMember.UseVisualStyleBackColor = true;
            this.buttonDeleteMember.Click += new System.EventHandler(this.buttonDeleteMember_Click);
            // 
            // buttonReadMember
            // 
            this.buttonReadMember.Location = new System.Drawing.Point(678, 190);
            this.buttonReadMember.Name = "buttonReadMember";
            this.buttonReadMember.Size = new System.Drawing.Size(95, 23);
            this.buttonReadMember.TabIndex = 7;
            this.buttonReadMember.Text = "히스토리 조회";
            this.buttonReadMember.UseVisualStyleBackColor = true;
            this.buttonReadMember.Click += new System.EventHandler(this.buttonReadMember_Click);
            // 
            // buttonUpdateMember
            // 
            this.buttonUpdateMember.Location = new System.Drawing.Point(678, 161);
            this.buttonUpdateMember.Name = "buttonUpdateMember";
            this.buttonUpdateMember.Size = new System.Drawing.Size(95, 23);
            this.buttonUpdateMember.TabIndex = 6;
            this.buttonUpdateMember.Text = "회원정보 변경";
            this.buttonUpdateMember.UseVisualStyleBackColor = true;
            this.buttonUpdateMember.Click += new System.EventHandler(this.buttonUpdateMember_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.panelMain2);
            this.Controls.Add(this.buttonLogOut2);
            this.Controls.Add(this.buttonDeleteMember);
            this.Controls.Add(this.buttonReadMember);
            this.Controls.Add(this.buttonUpdateMember);
            this.Controls.Add(this.textBoxActivity);
            this.Controls.Add(this.textBoxWriting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPoint);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain2;
        private System.Windows.Forms.Button buttonLogOut2;
        public System.Windows.Forms.Button buttonDeleteMember;
        public System.Windows.Forms.Button buttonReadMember;
        public System.Windows.Forms.Button buttonUpdateMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWriting;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxActivity;
        private System.Windows.Forms.Label label4;
    }
}