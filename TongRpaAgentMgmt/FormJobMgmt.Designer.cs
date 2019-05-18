namespace TongRpaAgentMgmt
{
    partial class FormJobMgmt
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
            this.NewBtn = new System.Windows.Forms.Button();
            this.editGroupBox = new System.Windows.Forms.GroupBox();
            this.edtJobTyp = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.edtJobSeq = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.edtAuthUser = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.userSaveBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.edtUpdDtm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtRegDtm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtRegUser = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edtJobDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtJobNm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtJobID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jobId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.JobListView = new System.Windows.Forms.ListView();
            this.label12 = new System.Windows.Forms.Label();
            this.authUser = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.edtJobData = new System.Windows.Forms.TextBox();
            this.editGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(817, 19);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(87, 26);
            this.NewBtn.TabIndex = 17;
            this.NewBtn.Text = "신규등록";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // editGroupBox
            // 
            this.editGroupBox.Controls.Add(this.edtJobData);
            this.editGroupBox.Controls.Add(this.btnTest);
            this.editGroupBox.Controls.Add(this.edtJobTyp);
            this.editGroupBox.Controls.Add(this.label13);
            this.editGroupBox.Controls.Add(this.edtJobSeq);
            this.editGroupBox.Controls.Add(this.label11);
            this.editGroupBox.Controls.Add(this.label10);
            this.editGroupBox.Controls.Add(this.edtAuthUser);
            this.editGroupBox.Controls.Add(this.CancelBtn);
            this.editGroupBox.Controls.Add(this.userSaveBtn);
            this.editGroupBox.Controls.Add(this.label9);
            this.editGroupBox.Controls.Add(this.edtUpdDtm);
            this.editGroupBox.Controls.Add(this.label6);
            this.editGroupBox.Controls.Add(this.edtRegDtm);
            this.editGroupBox.Controls.Add(this.label7);
            this.editGroupBox.Controls.Add(this.edtRegUser);
            this.editGroupBox.Controls.Add(this.label8);
            this.editGroupBox.Controls.Add(this.label5);
            this.editGroupBox.Controls.Add(this.edtJobDesc);
            this.editGroupBox.Controls.Add(this.label4);
            this.editGroupBox.Controls.Add(this.edtJobNm);
            this.editGroupBox.Controls.Add(this.label3);
            this.editGroupBox.Controls.Add(this.edtJobID);
            this.editGroupBox.Location = new System.Drawing.Point(11, 370);
            this.editGroupBox.Name = "editGroupBox";
            this.editGroupBox.Size = new System.Drawing.Size(963, 267);
            this.editGroupBox.TabIndex = 16;
            this.editGroupBox.TabStop = false;
            this.editGroupBox.Text = "편집";
            // 
            // edtJobTyp
            // 
            this.edtJobTyp.FormattingEnabled = true;
            this.edtJobTyp.Location = new System.Drawing.Point(706, 30);
            this.edtJobTyp.Name = "edtJobTyp";
            this.edtJobTyp.Size = new System.Drawing.Size(108, 20);
            this.edtJobTyp.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 12);
            this.label13.TabIndex = 30;
            this.label13.Text = "Seq";
            // 
            // edtJobSeq
            // 
            this.edtJobSeq.Location = new System.Drawing.Point(82, 240);
            this.edtJobSeq.Name = "edtJobSeq";
            this.edtJobSeq.ReadOnly = true;
            this.edtJobSeq.Size = new System.Drawing.Size(122, 21);
            this.edtJobSeq.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(671, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "구분";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "소유자";
            // 
            // edtAuthUser
            // 
            this.edtAuthUser.Location = new System.Drawing.Point(57, 203);
            this.edtAuthUser.Name = "edtAuthUser";
            this.edtAuthUser.Size = new System.Drawing.Size(122, 21);
            this.edtAuthUser.TabIndex = 24;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(859, 65);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(63, 26);
            this.CancelBtn.TabIndex = 23;
            this.CancelBtn.Text = "삭제";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click_1);
            // 
            // userSaveBtn
            // 
            this.userSaveBtn.Location = new System.Drawing.Point(859, 26);
            this.userSaveBtn.Name = "userSaveBtn";
            this.userSaveBtn.Size = new System.Drawing.Size(63, 26);
            this.userSaveBtn.TabIndex = 22;
            this.userSaveBtn.Text = "저장";
            this.userSaveBtn.UseVisualStyleBackColor = true;
            this.userSaveBtn.Click += new System.EventHandler(this.JobSaveBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(647, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "수정일시";
            // 
            // edtUpdDtm
            // 
            this.edtUpdDtm.Location = new System.Drawing.Point(711, 212);
            this.edtUpdDtm.Name = "edtUpdDtm";
            this.edtUpdDtm.ReadOnly = true;
            this.edtUpdDtm.Size = new System.Drawing.Size(122, 21);
            this.edtUpdDtm.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "등록일시";
            // 
            // edtRegDtm
            // 
            this.edtRegDtm.Location = new System.Drawing.Point(473, 212);
            this.edtRegDtm.Name = "edtRegDtm";
            this.edtRegDtm.ReadOnly = true;
            this.edtRegDtm.Size = new System.Drawing.Size(122, 21);
            this.edtRegDtm.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "등록자";
            // 
            // edtRegUser
            // 
            this.edtRegUser.Location = new System.Drawing.Point(265, 209);
            this.edtRegUser.Name = "edtRegUser";
            this.edtRegUser.ReadOnly = true;
            this.edtRegUser.Size = new System.Drawing.Size(122, 21);
            this.edtRegUser.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "실행데이타";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "상세설명";
            // 
            // edtJobDesc
            // 
            this.edtJobDesc.Location = new System.Drawing.Point(503, 26);
            this.edtJobDesc.Name = "edtJobDesc";
            this.edtJobDesc.Size = new System.Drawing.Size(122, 21);
            this.edtJobDesc.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Job명";
            // 
            // edtJobNm
            // 
            this.edtJobNm.Location = new System.Drawing.Point(265, 23);
            this.edtJobNm.Name = "edtJobNm";
            this.edtJobNm.Size = new System.Drawing.Size(122, 21);
            this.edtJobNm.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "JobId";
            // 
            // edtJobID
            // 
            this.edtJobID.Location = new System.Drawing.Point(57, 20);
            this.edtJobID.Name = "edtJobID";
            this.edtJobID.ReadOnly = true;
            this.edtJobID.Size = new System.Drawing.Size(122, 21);
            this.edtJobID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "JobKey";
            // 
            // jobId
            // 
            this.jobId.Location = new System.Drawing.Point(264, 16);
            this.jobId.Name = "jobId";
            this.jobId.Size = new System.Drawing.Size(122, 21);
            this.jobId.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "검색어";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(68, 16);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(122, 21);
            this.searchText.TabIndex = 12;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(709, 19);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(87, 26);
            this.BtnSearch.TabIndex = 11;
            this.BtnSearch.Text = "검색";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // JobListView
            // 
            this.JobListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JobListView.FullRowSelect = true;
            this.JobListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.JobListView.HideSelection = false;
            this.JobListView.Location = new System.Drawing.Point(12, 51);
            this.JobListView.MultiSelect = false;
            this.JobListView.Name = "JobListView";
            this.JobListView.Size = new System.Drawing.Size(963, 301);
            this.JobListView.TabIndex = 10;
            this.JobListView.UseCompatibleStateImageBehavior = false;
            this.JobListView.View = System.Windows.Forms.View.Details;
            this.JobListView.SelectedIndexChanged += new System.EventHandler(this.JobListView_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(437, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "소유자";
            // 
            // authUser
            // 
            this.authUser.Location = new System.Drawing.Point(484, 16);
            this.authUser.Name = "authUser";
            this.authUser.Size = new System.Drawing.Size(122, 21);
            this.authUser.TabIndex = 18;
            this.authUser.Text = "244128";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(859, 114);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(63, 26);
            this.btnTest.TabIndex = 32;
            this.btnTest.Text = "테스트";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // edtJobData
            // 
            this.edtJobData.Location = new System.Drawing.Point(91, 62);
            this.edtJobData.Multiline = true;
            this.edtJobData.Name = "edtJobData";
            this.edtJobData.Size = new System.Drawing.Size(723, 122);
            this.edtJobData.TabIndex = 33;
            // 
            // FormJobMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 651);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.authUser);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.editGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jobId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.JobListView);
            this.Name = "FormJobMgmt";
            this.Text = "Job 정보관리";
            this.Load += new System.EventHandler(this.FormJobMgmt_Load);
            this.editGroupBox.ResumeLayout(false);
            this.editGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.GroupBox editGroupBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox edtAuthUser;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button userSaveBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edtUpdDtm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtRegDtm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtRegUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtJobDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtJobNm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtJobID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jobId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ListView JobListView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox authUser;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox edtJobSeq;
        private System.Windows.Forms.ComboBox edtJobTyp;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox edtJobData;
    }
}