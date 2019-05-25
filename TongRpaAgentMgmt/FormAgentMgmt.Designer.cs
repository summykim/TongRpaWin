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
            this.editGroupBox = new System.Windows.Forms.GroupBox();
            this.edtAgentStatus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.edtAgentUid = new System.Windows.Forms.TextBox();
            this.dellBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.edtAgentDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtAgentNm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtAgentId = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NewBtn = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgentListView = new System.Windows.Forms.ListView();
            this.editGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // editGroupBox
            // 
            this.editGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.editGroupBox.Controls.Add(this.edtAgentStatus);
            this.editGroupBox.Controls.Add(this.label13);
            this.editGroupBox.Controls.Add(this.label11);
            this.editGroupBox.Controls.Add(this.edtAgentUid);
            this.editGroupBox.Controls.Add(this.dellBtn);
            this.editGroupBox.Controls.Add(this.SaveBtn);
            this.editGroupBox.Controls.Add(this.label5);
            this.editGroupBox.Controls.Add(this.edtAgentDesc);
            this.editGroupBox.Controls.Add(this.label4);
            this.editGroupBox.Controls.Add(this.edtAgentNm);
            this.editGroupBox.Controls.Add(this.label3);
            this.editGroupBox.Controls.Add(this.edtAgentId);
            this.editGroupBox.Location = new System.Drawing.Point(12, 373);
            this.editGroupBox.Name = "editGroupBox";
            this.editGroupBox.Size = new System.Drawing.Size(963, 105);
            this.editGroupBox.TabIndex = 22;
            this.editGroupBox.TabStop = false;
            this.editGroupBox.Text = "편집";
            // 
            // edtAgentStatus
            // 
            this.edtAgentStatus.FormattingEnabled = true;
            this.edtAgentStatus.Location = new System.Drawing.Point(735, 20);
            this.edtAgentStatus.Name = "edtAgentStatus";
            this.edtAgentStatus.Size = new System.Drawing.Size(81, 20);
            this.edtAgentStatus.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(700, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 12);
            this.label13.TabIndex = 30;
            this.label13.Text = "상태";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "MAC주소:";
            // 
            // edtAgentUid
            // 
            this.edtAgentUid.Location = new System.Drawing.Point(501, 20);
            this.edtAgentUid.Name = "edtAgentUid";
            this.edtAgentUid.Size = new System.Drawing.Size(162, 21);
            this.edtAgentUid.TabIndex = 26;
            // 
            // dellBtn
            // 
            this.dellBtn.Location = new System.Drawing.Point(846, 58);
            this.dellBtn.Name = "dellBtn";
            this.dellBtn.Size = new System.Drawing.Size(63, 26);
            this.dellBtn.TabIndex = 23;
            this.dellBtn.Text = "삭제";
            this.dellBtn.UseVisualStyleBackColor = true;
            this.dellBtn.Click += new System.EventHandler(this.DellBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(846, 14);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(63, 26);
            this.SaveBtn.TabIndex = 22;
            this.SaveBtn.Text = "저장";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "상세설명:";
            // 
            // edtAgentDesc
            // 
            this.edtAgentDesc.Location = new System.Drawing.Point(73, 62);
            this.edtAgentDesc.Name = "edtAgentDesc";
            this.edtAgentDesc.Size = new System.Drawing.Size(743, 21);
            this.edtAgentDesc.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "agent명:";
            // 
            // edtAgentNm
            // 
            this.edtAgentNm.Location = new System.Drawing.Point(223, 20);
            this.edtAgentNm.Name = "edtAgentNm";
            this.edtAgentNm.Size = new System.Drawing.Size(188, 21);
            this.edtAgentNm.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "아이디:";
            // 
            // edtAgentId
            // 
            this.edtAgentId.Location = new System.Drawing.Point(57, 20);
            this.edtAgentId.Name = "edtAgentId";
            this.edtAgentId.ReadOnly = true;
            this.edtAgentId.Size = new System.Drawing.Size(83, 21);
            this.edtAgentId.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.NewBtn);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 35);
            this.panel1.TabIndex = 24;
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(846, 6);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(87, 26);
            this.NewBtn.TabIndex = 25;
            this.NewBtn.Text = "신규등록";
            this.NewBtn.UseVisualStyleBackColor = true;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(753, 6);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(87, 26);
            this.BtnSearch.TabIndex = 24;
            this.BtnSearch.Text = "검색";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AgentListView);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(963, 301);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "목록";
            // 
            // AgentListView
            // 
            this.AgentListView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AgentListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgentListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AgentListView.FullRowSelect = true;
            this.AgentListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.AgentListView.HideSelection = false;
            this.AgentListView.Location = new System.Drawing.Point(3, 17);
            this.AgentListView.MultiSelect = false;
            this.AgentListView.Name = "AgentListView";
            this.AgentListView.Size = new System.Drawing.Size(957, 281);
            this.AgentListView.TabIndex = 19;
            this.AgentListView.UseCompatibleStateImageBehavior = false;
            this.AgentListView.View = System.Windows.Forms.View.Details;
            this.AgentListView.SelectedIndexChanged += new System.EventHandler(this.AgentListView_SelectedIndexChanged);
            // 
            // FormAgentMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(991, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.editGroupBox);
            this.Name = "FormAgentMgmt";
            this.Text = "Agent PC 관리";
            this.Load += new System.EventHandler(this.FormAgentMgmt_Load);
            this.editGroupBox.ResumeLayout(false);
            this.editGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox editGroupBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox edtAgentUid;
        private System.Windows.Forms.Button dellBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtAgentDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtAgentNm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtAgentId;
        private System.Windows.Forms.ComboBox edtAgentStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView AgentListView;
    }
}