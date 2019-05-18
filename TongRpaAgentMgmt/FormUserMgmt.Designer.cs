namespace TongRpaAgentMgmt
{
    partial class FormUserMgmt
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
            this.UserListView = new System.Windows.Forms.ListView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TBUserNm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBUserID = new System.Windows.Forms.TextBox();
            this.editGroupBox = new System.Windows.Forms.GroupBox();
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
            this.edtChbotKey = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtUserNm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtUserID = new System.Windows.Forms.TextBox();
            this.NewUserBtn = new System.Windows.Forms.Button();
            this.edtUserTyp = new System.Windows.Forms.ComboBox();
            this.editGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserListView
            // 
            this.UserListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserListView.FullRowSelect = true;
            this.UserListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.UserListView.HideSelection = false;
            this.UserListView.Location = new System.Drawing.Point(12, 67);
            this.UserListView.MultiSelect = false;
            this.UserListView.Name = "UserListView";
            this.UserListView.Size = new System.Drawing.Size(963, 374);
            this.UserListView.TabIndex = 0;
            this.UserListView.UseCompatibleStateImageBehavior = false;
            this.UserListView.View = System.Windows.Forms.View.Details;
            this.UserListView.SelectedIndexChanged += new System.EventHandler(this.UserListView_SelectedIndexChanged);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(420, 31);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(87, 26);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "검색";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // TBUserNm
            // 
            this.TBUserNm.Location = new System.Drawing.Point(82, 35);
            this.TBUserNm.Name = "TBUserNm";
            this.TBUserNm.Size = new System.Drawing.Size(122, 21);
            this.TBUserNm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "사용자명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "아이디";
            // 
            // TBUserID
            // 
            this.TBUserID.Location = new System.Drawing.Point(278, 35);
            this.TBUserID.Name = "TBUserID";
            this.TBUserID.Size = new System.Drawing.Size(122, 21);
            this.TBUserID.TabIndex = 4;
            // 
            // editGroupBox
            // 
            this.editGroupBox.Controls.Add(this.edtUserTyp);
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
            this.editGroupBox.Controls.Add(this.edtChbotKey);
            this.editGroupBox.Controls.Add(this.label4);
            this.editGroupBox.Controls.Add(this.edtUserNm);
            this.editGroupBox.Controls.Add(this.label3);
            this.editGroupBox.Controls.Add(this.edtUserID);
            this.editGroupBox.Location = new System.Drawing.Point(25, 463);
            this.editGroupBox.Name = "editGroupBox";
            this.editGroupBox.Size = new System.Drawing.Size(950, 107);
            this.editGroupBox.TabIndex = 8;
            this.editGroupBox.TabStop = false;
            this.editGroupBox.Text = "편집";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(859, 65);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(63, 26);
            this.CancelBtn.TabIndex = 23;
            this.CancelBtn.Text = "삭제";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // userSaveBtn
            // 
            this.userSaveBtn.Location = new System.Drawing.Point(859, 26);
            this.userSaveBtn.Name = "userSaveBtn";
            this.userSaveBtn.Size = new System.Drawing.Size(63, 26);
            this.userSaveBtn.TabIndex = 22;
            this.userSaveBtn.Text = "저장";
            this.userSaveBtn.UseVisualStyleBackColor = true;
            this.userSaveBtn.Click += new System.EventHandler(this.userSaveBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(439, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "수정일시";
            // 
            // edtUpdDtm
            // 
            this.edtUpdDtm.Location = new System.Drawing.Point(503, 62);
            this.edtUpdDtm.Name = "edtUpdDtm";
            this.edtUpdDtm.ReadOnly = true;
            this.edtUpdDtm.Size = new System.Drawing.Size(122, 21);
            this.edtUpdDtm.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "등록일시";
            // 
            // edtRegDtm
            // 
            this.edtRegDtm.Location = new System.Drawing.Point(265, 62);
            this.edtRegDtm.Name = "edtRegDtm";
            this.edtRegDtm.ReadOnly = true;
            this.edtRegDtm.Size = new System.Drawing.Size(122, 21);
            this.edtRegDtm.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-2, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "등록자";
            // 
            // edtRegUser
            // 
            this.edtRegUser.Location = new System.Drawing.Point(57, 59);
            this.edtRegUser.Name = "edtRegUser";
            this.edtRegUser.ReadOnly = true;
            this.edtRegUser.Size = new System.Drawing.Size(122, 21);
            this.edtRegUser.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(664, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "사용자구분";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "챗봇연동키";
            // 
            // edtChbotKey
            // 
            this.edtChbotKey.Location = new System.Drawing.Point(503, 26);
            this.edtChbotKey.Name = "edtChbotKey";
            this.edtChbotKey.Size = new System.Drawing.Size(122, 21);
            this.edtChbotKey.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "사용자명";
            // 
            // edtUserNm
            // 
            this.edtUserNm.Location = new System.Drawing.Point(265, 23);
            this.edtUserNm.Name = "edtUserNm";
            this.edtUserNm.Size = new System.Drawing.Size(122, 21);
            this.edtUserNm.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "아이디";
            // 
            // edtUserID
            // 
            this.edtUserID.Location = new System.Drawing.Point(57, 20);
            this.edtUserID.Name = "edtUserID";
            this.edtUserID.ReadOnly = true;
            this.edtUserID.Size = new System.Drawing.Size(122, 21);
            this.edtUserID.TabIndex = 0;
            // 
            // NewUserBtn
            // 
            this.NewUserBtn.Location = new System.Drawing.Point(528, 31);
            this.NewUserBtn.Name = "NewUserBtn";
            this.NewUserBtn.Size = new System.Drawing.Size(87, 26);
            this.NewUserBtn.TabIndex = 9;
            this.NewUserBtn.Text = "신규등록";
            this.NewUserBtn.UseVisualStyleBackColor = true;
            this.NewUserBtn.Click += new System.EventHandler(this.NewUserBtn_Click);
            // 
            // edtUserTyp
            // 
            this.edtUserTyp.FormattingEnabled = true;
            this.edtUserTyp.Location = new System.Drawing.Point(735, 26);
            this.edtUserTyp.Name = "edtUserTyp";
            this.edtUserTyp.Size = new System.Drawing.Size(99, 20);
            this.edtUserTyp.TabIndex = 24;
            // 
            // FormUserMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 590);
            this.Controls.Add(this.NewUserBtn);
            this.Controls.Add(this.editGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBUserID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBUserNm);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.UserListView);
            this.Name = "FormUserMgmt";
            this.Text = "사용자관리";
            this.Load += new System.EventHandler(this.FormUserMgmt_Load);
            this.editGroupBox.ResumeLayout(false);
            this.editGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView UserListView;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TBUserNm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBUserID;
        private System.Windows.Forms.GroupBox editGroupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtUserID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtUpdDtm;
        private System.Windows.Forms.TextBox edtRegDtm;
        private System.Windows.Forms.TextBox edtRegUser;
        private System.Windows.Forms.TextBox edtChbotKey;
        private System.Windows.Forms.TextBox edtUserNm;
        private System.Windows.Forms.Button NewUserBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button userSaveBtn;
        private System.Windows.Forms.ComboBox edtUserTyp;
    }
}

