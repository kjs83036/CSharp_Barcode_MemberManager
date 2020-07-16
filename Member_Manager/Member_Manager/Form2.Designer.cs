namespace Member_Manager
{
    partial class Form2
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
            this.buttonCreateMember = new System.Windows.Forms.Button();
            this.buttonReadMember = new System.Windows.Forms.Button();
            this.buttonDeleteMember = new System.Windows.Forms.Button();
            this.buttonUpdateMember = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonCreateMember
            // 
            this.buttonCreateMember.Location = new System.Drawing.Point(713, 133);
            this.buttonCreateMember.Name = "buttonCreateMember";
            this.buttonCreateMember.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateMember.TabIndex = 0;
            this.buttonCreateMember.Text = "회원추가";
            this.buttonCreateMember.UseVisualStyleBackColor = true;
            this.buttonCreateMember.Click += new System.EventHandler(this.buttonCreateMember_Click);
            // 
            // buttonReadMember
            // 
            this.buttonReadMember.Location = new System.Drawing.Point(713, 162);
            this.buttonReadMember.Name = "buttonReadMember";
            this.buttonReadMember.Size = new System.Drawing.Size(75, 23);
            this.buttonReadMember.TabIndex = 1;
            this.buttonReadMember.Text = "회원 조회";
            this.buttonReadMember.UseVisualStyleBackColor = true;
            this.buttonReadMember.Click += new System.EventHandler(this.buttonReadMember_Click);
            // 
            // buttonDeleteMember
            // 
            this.buttonDeleteMember.Location = new System.Drawing.Point(713, 220);
            this.buttonDeleteMember.Name = "buttonDeleteMember";
            this.buttonDeleteMember.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteMember.TabIndex = 2;
            this.buttonDeleteMember.Text = "회원 삭제";
            this.buttonDeleteMember.UseVisualStyleBackColor = true;
            this.buttonDeleteMember.Click += new System.EventHandler(this.buttonDeleteMember_Click);
            // 
            // buttonUpdateMember
            // 
            this.buttonUpdateMember.Location = new System.Drawing.Point(713, 191);
            this.buttonUpdateMember.Name = "buttonUpdateMember";
            this.buttonUpdateMember.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateMember.TabIndex = 3;
            this.buttonUpdateMember.Text = "회원 변경";
            this.buttonUpdateMember.UseVisualStyleBackColor = true;
            this.buttonUpdateMember.Click += new System.EventHandler(this.buttonUpdateMember_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(713, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "로그아웃";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(42, 34);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(585, 349);
            this.panelMain.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonUpdateMember);
            this.Controls.Add(this.buttonDeleteMember);
            this.Controls.Add(this.buttonReadMember);
            this.Controls.Add(this.buttonCreateMember);
            this.Name = "Form2";
            this.Text = "Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateMember;
        private System.Windows.Forms.Button buttonReadMember;
        private System.Windows.Forms.Button buttonDeleteMember;
        private System.Windows.Forms.Button buttonUpdateMember;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Panel panelMain;
    }
}