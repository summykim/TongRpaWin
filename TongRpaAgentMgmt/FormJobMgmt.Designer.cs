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
            this.editGroupBox = new System.Windows.Forms.GroupBox();
            this.edtJobData = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.edtJobTyp = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.userSaveBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.edtJobDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtJobNm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtJobID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJobId = new System.Windows.Forms.TextBox();
            this.cboUserList = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.NewBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.JobListView = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.edtJobTmout = new System.Windows.Forms.TextBox();
            this.editGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // editGroupBox
            // 
            this.editGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editGroupBox.Controls.Add(this.label6);
            this.editGroupBox.Controls.Add(this.edtJobTmout);
            this.editGroupBox.Controls.Add(this.edtJobData);
            this.editGroupBox.Controls.Add(this.btnTest);
            this.editGroupBox.Controls.Add(this.edtJobTyp);
            this.editGroupBox.Controls.Add(this.label11);
            this.editGroupBox.Controls.Add(this.CancelBtn);
            this.editGroupBox.Controls.Add(this.userSaveBtn);
            this.editGroupBox.Controls.Add(this.label8);
            this.editGroupBox.Controls.Add(this.label5);
            this.editGroupBox.Controls.Add(this.edtJobDesc);
            this.editGroupBox.Controls.Add(this.label4);
            this.editGroupBox.Controls.Add(this.edtJobNm);
            this.editGroupBox.Controls.Add(this.label3);
            this.editGroupBox.Controls.Add(this.edtJobID);
            this.editGroupBox.Location = new System.Drawing.Point(12, 350);
            this.editGroupBox.Name = "editGroupBox";
            this.editGroupBox.Size = new System.Drawing.Size(963, 289);
            this.editGroupBox.TabIndex = 16;
            this.editGroupBox.TabStop = false;
            this.editGroupBox.Text = "정보수정";
            // 
            // edtJobData
            // 
            this.edtJobData.Location = new System.Drawing.Point(81, 130);
            this.edtJobData.Multiline = true;
            this.edtJobData.Name = "edtJobData";
            this.edtJobData.Size = new System.Drawing.Size(733, 153);
            this.edtJobData.TabIndex = 33;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(835, 246);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(63, 26);
            this.btnTest.TabIndex = 32;
            this.btnTest.Text = "테스트";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // edtJobTyp
            // 
            this.edtJobTyp.FormattingEnabled = true;
            this.edtJobTyp.Location = new System.Drawing.Point(590, 20);
            this.edtJobTyp.Name = "edtJobTyp";
            this.edtJobTyp.Size = new System.Drawing.Size(224, 20);
            this.edtJobTyp.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(555, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "구분";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(835, 57);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(63, 26);
            this.CancelBtn.TabIndex = 23;
            this.CancelBtn.Text = "삭제";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click_1);
            // 
            // userSaveBtn
            // 
            this.userSaveBtn.Location = new System.Drawing.Point(835, 20);
            this.userSaveBtn.Name = "userSaveBtn";
            this.userSaveBtn.Size = new System.Drawing.Size(63, 26);
            this.userSaveBtn.TabIndex = 22;
            this.userSaveBtn.Text = "저장";
            this.userSaveBtn.UseVisualStyleBackColor = true;
            this.userSaveBtn.Click += new System.EventHandler(this.JobSaveBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "실행데이타";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "상세설명";
            // 
            // edtJobDesc
            // 
            this.edtJobDesc.Location = new System.Drawing.Point(81, 61);
            this.edtJobDesc.Name = "edtJobDesc";
            this.edtJobDesc.Size = new System.Drawing.Size(733, 21);
            this.edtJobDesc.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "Job명";
            // 
            // edtJobNm
            // 
            this.edtJobNm.Location = new System.Drawing.Point(319, 23);
            this.edtJobNm.Name = "edtJobNm";
            this.edtJobNm.Size = new System.Drawing.Size(194, 21);
            this.edtJobNm.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "JobId";
            // 
            // edtJobID
            // 
            this.edtJobID.Location = new System.Drawing.Point(81, 23);
            this.edtJobID.Name = "edtJobID";
            this.edtJobID.ReadOnly = true;
            this.edtJobID.Size = new System.Drawing.Size(189, 21);
            this.edtJobID.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtJobId);
            this.groupBox1.Controls.Add(this.cboUserList);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.NewBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.searchText);
            this.groupBox1.Controls.Add(this.BtnSearch);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(963, 43);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 42;
            this.label2.Text = "JobId:";
            // 
            // txtJobId
            // 
            this.txtJobId.Location = new System.Drawing.Point(243, 16);
            this.txtJobId.Name = "txtJobId";
            this.txtJobId.Size = new System.Drawing.Size(109, 21);
            this.txtJobId.TabIndex = 41;
            this.txtJobId.TextChanged += new System.EventHandler(this.TxtJobId_TextChanged);
            // 
            // cboUserList
            // 
            this.cboUserList.FormattingEnabled = true;
            this.cboUserList.Location = new System.Drawing.Point(417, 16);
            this.cboUserList.Name = "cboUserList";
            this.cboUserList.Size = new System.Drawing.Size(176, 20);
            this.cboUserList.TabIndex = 40;
            this.cboUserList.SelectedIndexChanged += new System.EventHandler(this.CboUserList_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(370, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 39;
            this.label12.Text = "사용자";
            this.label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(848, 12);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(87, 26);
            this.NewBtn.TabIndex = 38;
            this.NewBtn.Text = "신규등록";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 37;
            this.label1.Text = "검색어:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(67, 14);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(109, 21);
            this.searchText.TabIndex = 36;
            this.searchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(736, 11);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(87, 26);
            this.BtnSearch.TabIndex = 35;
            this.BtnSearch.Text = "검색";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.JobListView);
            this.groupBox2.Location = new System.Drawing.Point(11, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(964, 268);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Job목록";
            // 
            // JobListView
            // 
            this.JobListView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.JobListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JobListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.JobListView.FullRowSelect = true;
            this.JobListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.JobListView.HideSelection = false;
            this.JobListView.Location = new System.Drawing.Point(3, 17);
            this.JobListView.MultiSelect = false;
            this.JobListView.Name = "JobListView";
            this.JobListView.Size = new System.Drawing.Size(958, 248);
            this.JobListView.TabIndex = 11;
            this.JobListView.UseCompatibleStateImageBehavior = false;
            this.JobListView.View = System.Windows.Forms.View.Details;
            this.JobListView.SelectedIndexChanged += new System.EventHandler(this.JobListView_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 12);
            this.label6.TabIndex = 35;
            this.label6.Text = "타임아웃(초):";
            // 
            // edtJobTmout
            // 
            this.edtJobTmout.Location = new System.Drawing.Point(81, 88);
            this.edtJobTmout.Name = "edtJobTmout";
            this.edtJobTmout.Size = new System.Drawing.Size(67, 21);
            this.edtJobTmout.TabIndex = 34;
            // 
            // FormJobMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 651);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.editGroupBox);
            this.Name = "FormJobMgmt";
            this.Text = "Job 정보관리";
            this.Load += new System.EventHandler(this.FormJobMgmt_Load);
            this.editGroupBox.ResumeLayout(false);
            this.editGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox editGroupBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button userSaveBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtJobDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtJobNm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtJobID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox edtJobTyp;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TextBox edtJobData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJobId;
        private System.Windows.Forms.ComboBox cboUserList;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView JobListView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtJobTmout;
    }
}