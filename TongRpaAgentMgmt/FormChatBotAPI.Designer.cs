namespace TongRpaAgentMgmt
{
    partial class FormChatBotAPI
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.JobListView = new System.Windows.Forms.ListView();
            this.UserAuthGrp = new System.Windows.Forms.GroupBox();
            this.btnUserCheck = new System.Windows.Forms.Button();
            this.txtChBotKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultUrl = new System.Windows.Forms.TextBox();
            this.실행결과 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.UserAuthGrp.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.실행결과);
            this.groupBox2.Controls.Add(this.txtResultUrl);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.JobListView);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.Color.Navy;
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(991, 342);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Job검색";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(867, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 25);
            this.button3.TabIndex = 13;
            this.button3.Text = "JOB실행";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(17, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "JOB검색";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // JobListView
            // 
            this.JobListView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.JobListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JobListView.FullRowSelect = true;
            this.JobListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.JobListView.HideSelection = false;
            this.JobListView.Location = new System.Drawing.Point(17, 59);
            this.JobListView.MultiSelect = false;
            this.JobListView.Name = "JobListView";
            this.JobListView.Size = new System.Drawing.Size(953, 225);
            this.JobListView.TabIndex = 11;
            this.JobListView.UseCompatibleStateImageBehavior = false;
            this.JobListView.View = System.Windows.Forms.View.Details;
            this.JobListView.SelectedIndexChanged += new System.EventHandler(this.JobListView_SelectedIndexChanged);
            // 
            // UserAuthGrp
            // 
            this.UserAuthGrp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.UserAuthGrp.Controls.Add(this.btnUserCheck);
            this.UserAuthGrp.Controls.Add(this.txtChBotKey);
            this.UserAuthGrp.Controls.Add(this.label1);
            this.UserAuthGrp.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UserAuthGrp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.UserAuthGrp.Location = new System.Drawing.Point(12, 12);
            this.UserAuthGrp.Name = "UserAuthGrp";
            this.UserAuthGrp.Size = new System.Drawing.Size(485, 81);
            this.UserAuthGrp.TabIndex = 23;
            this.UserAuthGrp.TabStop = false;
            this.UserAuthGrp.Text = "사용자인증";
            // 
            // btnUserCheck
            // 
            this.btnUserCheck.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUserCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserCheck.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUserCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUserCheck.Location = new System.Drawing.Point(370, 32);
            this.btnUserCheck.Name = "btnUserCheck";
            this.btnUserCheck.Size = new System.Drawing.Size(103, 25);
            this.btnUserCheck.TabIndex = 2;
            this.btnUserCheck.Text = "가입여부확인";
            this.btnUserCheck.UseVisualStyleBackColor = false;
            this.btnUserCheck.Click += new System.EventHandler(this.BtnUserCheck_Click);
            // 
            // txtChBotKey
            // 
            this.txtChBotKey.Location = new System.Drawing.Point(118, 32);
            this.txtChBotKey.Name = "txtChBotKey";
            this.txtChBotKey.Size = new System.Drawing.Size(246, 25);
            this.txtChBotKey.TabIndex = 1;
            this.txtChBotKey.Text = "01022311386";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ChatBot Key:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtUserEmail);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(530, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 81);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원가입";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(370, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "가입처리";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(118, 32);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(246, 25);
            this.txtUserEmail.TabIndex = 1;
            this.txtUserEmail.Text = "summy@daum.net";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "이메일정보:";
            // 
            // txtResultUrl
            // 
            this.txtResultUrl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtResultUrl.Enabled = false;
            this.txtResultUrl.Location = new System.Drawing.Point(83, 308);
            this.txtResultUrl.Name = "txtResultUrl";
            this.txtResultUrl.Size = new System.Drawing.Size(773, 22);
            this.txtResultUrl.TabIndex = 14;
            // 
            // 실행결과
            // 
            this.실행결과.AutoSize = true;
            this.실행결과.Location = new System.Drawing.Point(14, 311);
            this.실행결과.Name = "실행결과";
            this.실행결과.Size = new System.Drawing.Size(68, 13);
            this.실행결과.TabIndex = 15;
            this.실행결과.Text = "실행결과:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button4.Location = new System.Drawing.Point(862, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 25);
            this.button4.TabIndex = 16;
            this.button4.Text = "결과보기";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // FormChatBotAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 621);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UserAuthGrp);
            this.Controls.Add(this.groupBox2);
            this.Name = "FormChatBotAPI";
            this.Text = "챗봇 API 테스트";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.UserAuthGrp.ResumeLayout(false);
            this.UserAuthGrp.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView JobListView;
        private System.Windows.Forms.GroupBox UserAuthGrp;
        private System.Windows.Forms.Button btnUserCheck;
        private System.Windows.Forms.TextBox txtChBotKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtResultUrl;
        private System.Windows.Forms.Label 실행결과;
        private System.Windows.Forms.Button button4;
    }
}