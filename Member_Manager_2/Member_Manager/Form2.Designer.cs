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
            this.buttonReadChart = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonReadStatistics = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRead2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateMember
            // 
            this.buttonCreateMember.Location = new System.Drawing.Point(713, 104);
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
            // buttonReadChart
            // 
            this.buttonReadChart.Location = new System.Drawing.Point(713, 249);
            this.buttonReadChart.Name = "buttonReadChart";
            this.buttonReadChart.Size = new System.Drawing.Size(75, 23);
            this.buttonReadChart.TabIndex = 6;
            this.buttonReadChart.Text = "차트 조회";
            this.buttonReadChart.UseVisualStyleBackColor = true;
            this.buttonReadChart.Click += new System.EventHandler(this.buttonReadChart_Click);
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(776, 426);
            this.panelMain.TabIndex = 7;
            this.panelMain.Visible = false;
            // 
            // buttonReadStatistics
            // 
            this.buttonReadStatistics.Location = new System.Drawing.Point(713, 278);
            this.buttonReadStatistics.Name = "buttonReadStatistics";
            this.buttonReadStatistics.Size = new System.Drawing.Size(75, 23);
            this.buttonReadStatistics.TabIndex = 8;
            this.buttonReadStatistics.Text = "통계 조회";
            this.buttonReadStatistics.UseVisualStyleBackColor = true;
            this.buttonReadStatistics.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(54, 447);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(100, 21);
            this.textBoxId.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Admin";
            // 
            // buttonRead2
            // 
            this.buttonRead2.Location = new System.Drawing.Point(713, 133);
            this.buttonRead2.Name = "buttonRead2";
            this.buttonRead2.Size = new System.Drawing.Size(75, 23);
            this.buttonRead2.TabIndex = 12;
            this.buttonRead2.Text = "회원 조회2";
            this.buttonRead2.UseVisualStyleBackColor = true;
            this.buttonRead2.Click += new System.EventHandler(this.buttonRead2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.buttonReadChart);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonUpdateMember);
            this.Controls.Add(this.buttonDeleteMember);
            this.Controls.Add(this.buttonReadMember);
            this.Controls.Add(this.buttonCreateMember);
            this.Controls.Add(this.buttonReadStatistics);
            this.Controls.Add(this.buttonRead2);
            this.Name = "Form2";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Panel panelMain;
        public System.Windows.Forms.Button buttonCreateMember;
        public System.Windows.Forms.Button buttonReadMember;
        public System.Windows.Forms.Button buttonDeleteMember;
        public System.Windows.Forms.Button buttonUpdateMember;
        public System.Windows.Forms.Button buttonReadChart;
        public System.Windows.Forms.Button buttonReadStatistics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button buttonRead2;
    }
}