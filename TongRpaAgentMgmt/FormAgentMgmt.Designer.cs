namespace TongRpaAgentMgmt
{
    partial class FormAgentMgmt
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
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.edtAgentUid = new System.Windows.Forms.TextBox();
            this.dellBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.edtUpdDtm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtRegDtm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtRegUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edtAgentDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtAgentNm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtAgentId = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.AgentListView = new System.Windows.Forms.ListView();
            this.edtAgentStatus = new System.Windows.Forms.ComboBox();
            this.editGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(856, 22);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(87, 26);
            this.NewBtn.TabIndex = 23;
            this.NewBtn.Text = "신규등록";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // editGroupBox
            // 
            this.editGroupBox.Controls.Add(this.edtAgentStatus);
            this.editGroupBox.Controls.Add(this.label13);
            this.editGroupBox.Controls.Add(this.label11);
            this.editGroupBox.Controls.Add(this.edtAgentUid);
            this.editGroupBox.Controls.Add(this.dellBtn);
            this.editGroupBox.Controls.Add(this.SaveBtn);
            this.editGroupBox.Controls.Add(this.label9);
            this.editGroupBox.Controls.Add(this.edtUpdDtm);
            this.editGroupBox.Controls.Add(this.label6);
            this.editGroupBox.Controls.Add(this.edtRegDtm);
            this.editGroupBox.Controls.Add(this.label7);
            this.editGroupBox.Controls.Add(this.edtRegUser);
            this.editGroupBox.Controls.Add(this.label5);
            this.editGroupBox.Controls.Add(this.edtAgentDesc);
            this.editGroupBox.Controls.Add(this.label4);
            this.editGroupBox.Controls.Add(this.edtAgentNm);
            this.editGroupBox.Controls.Add(this.label3);
            this.editGroupBox.Controls.Add(this.edtAgentId);
            this.editGroupBox.Location = new System.Drawing.Point(12, 373);
            this.editGroupBox.Name = "editGroupBox";
            this.editGroupBox.Size = new System.Drawing.Size(963, 181);
            this.editGroupBox.TabIndex = 22;
            this.editGroupBox.TabStop = false;
            this.editGroupBox.Text = "편집";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(574, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 30;
            this.label13.Text = "상태";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(573, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "UUID";
            // 
            // edtAgentUid
            // 
            this.edtAgentUid.Location = new System.Drawing.Point(624, 23);
            this.edtAgentUid.Name = "edtAgentUid";
            this.edtAgentUid.Size = new System.Drawing.Size(200, 21);
            this.edtAgentUid.TabIndex = 26;
            // 
            // dellBtn
            // 
            this.dellBtn.Location = new System.Drawing.Point(859, 65);
            this.dellBtn.Name = "dellBtn";
            this.dellBtn.Size = new System.Drawing.Size(63, 26);
            this.dellBtn.TabIndex = 23;
            this.dellBtn.Text = "삭제";
            this.dellBtn.UseVisualStyleBackColor = true;
            this.dellBtn.Click += new System.EventHandler(this.DellBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(859, 26);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(63, 26);
            this.SaveBtn.TabIndex = 22;
            this.SaveBtn.Text = "저장";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(477, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "수정일시";
            // 
            // edtUpdDtm
            // 
            this.edtUpdDtm.Location = new System.Drawing.Point(541, 126);
            this.edtUpdDtm.Name = "edtUpdDtm";
            this.edtUpdDtm.ReadOnly = true;
            this.edtUpdDtm.Size = new System.Drawing.Size(122, 21);
            this.edtUpdDtm.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "등록일시";
            // 
            // edtRegDtm
            // 
            this.edtRegDtm.Location = new System.Drawing.Point(303, 126);
            this.edtRegDtm.Name = "edtRegDtm";
            this.edtRegDtm.ReadOnly = true;
            this.edtRegDtm.Size = new System.Drawing.Size(122, 21);
            this.edtRegDtm.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "등록자";
            // 
            // edtRegUser
            // 
            this.edtRegUser.Location = new System.Drawing.Point(95, 123);
            this.edtRegUser.Name = "edtRegUser";
            this.edtRegUser.ReadOnly = true;
            this.edtRegUser.Size = new System.Drawing.Size(122, 21);
            this.edtRegUser.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "상세설명";
            // 
            // edtAgentDesc
            // 
            this.edtAgentDesc.Location = new System.Drawing.Point(69, 70);
            this.edtAgentDesc.Name = "edtAgentDesc";
            this.edtAgentDesc.Size = new System.Drawing.Size(479, 21);
            this.edtAgentDesc.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "agent명";
            // 
            // edtAgentNm
            // 
            this.edtAgentNm.Location = new System.Drawing.Point(360, 23);
            this.edtAgentNm.Name = "edtAgentNm";
            this.edtAgentNm.Size = new System.Drawing.Size(188, 21);
            this.edtAgentNm.TabIndex = 10;
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
            // edtAgentId
            // 
            this.edtAgentId.Location = new System.Drawing.Point(57, 20);
            this.edtAgentId.Name = "edtAgentId";
            this.edtAgentId.ReadOnly = true;
            this.edtAgentId.Size = new System.Drawing.Size(212, 21);
            this.edtAgentId.TabIndex = 0;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(749, 22);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(87, 26);
            this.BtnSearch.TabIndex = 19;
            this.BtnSearch.Text = "검색";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // AgentListView
            // 
            this.AgentListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgentListView.FullRowSelect = true;
            this.AgentListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AgentListView.HideSelection = false;
            this.AgentListView.Location = new System.Drawing.Point(12, 62);
            this.AgentListView.MultiSelect = false;
            this.AgentListView.Name = "AgentListView";
            this.AgentListView.Size = new System.Drawing.Size(963, 287);
            this.AgentListView.TabIndex = 18;
            this.AgentListView.UseCompatibleStateImageBehavior = false;
            this.AgentListView.View = System.Windows.Forms.View.Details;
            this.AgentListView.SelectedIndexChanged += new System.EventHandler(this.AgentListView_SelectedIndexChanged);
            // 
            // edtAgentStatus
            // 
            this.edtAgentStatus.FormattingEnabled = true;
            this.edtAgentStatus.Location = new System.Drawing.Point(624, 75);
            this.edtAgentStatus.Name = "edtAgentStatus";
            this.edtAgentStatus.Size = new System.Drawing.Size(111, 20);
            this.edtAgentStatus.TabIndex = 31;
            // 
            // FormAgentMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 570);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.editGroupBox);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.AgentListView);
            this.Name = "FormAgentMgmt";
            this.Text = "FormAgentMgmt";
            this.Load += new System.EventHandler(this.FormAgentMgmt_Load);
            this.editGroupBox.ResumeLayout(false);
            this.editGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.GroupBox editGroupBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox edtAgentUid;
        private System.Windows.Forms.Button dellBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edtUpdDtm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtRegDtm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtRegUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtAgentDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtAgentNm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtAgentId;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ListView AgentListView;
        private System.Windows.Forms.ComboBox edtAgentStatus;
    }
}