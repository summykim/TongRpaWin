namespace TongRpaAgentMgmt
{
    partial class FormJobExecReqMon
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboAgentId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.jobExecReqId = new System.Windows.Forms.TextBox();
            this.jobStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jobId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.JobListView = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cboAgentId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.jobExecReqId);
            this.panel1.Controls.Add(this.jobStatus);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.jobId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Location = new System.Drawing.Point(24, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1241, 54);
            this.panel1.TabIndex = 26;
            // 
            // cboAgentId
            // 
            this.cboAgentId.BackColor = System.Drawing.SystemColors.MenuBar;
            this.cboAgentId.FormattingEnabled = true;
            this.cboAgentId.Location = new System.Drawing.Point(62, 18);
            this.cboAgentId.Name = "cboAgentId";
            this.cboAgentId.Size = new System.Drawing.Size(186, 20);
            this.cboAgentId.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(771, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 12);
            this.label4.TabIndex = 34;
            this.label4.Text = "ReqId :";
            // 
            // jobExecReqId
            // 
            this.jobExecReqId.BackColor = System.Drawing.SystemColors.MenuBar;
            this.jobExecReqId.Location = new System.Drawing.Point(822, 20);
            this.jobExecReqId.Name = "jobExecReqId";
            this.jobExecReqId.Size = new System.Drawing.Size(257, 21);
            this.jobExecReqId.TabIndex = 33;
            // 
            // jobStatus
            // 
            this.jobStatus.BackColor = System.Drawing.SystemColors.Menu;
            this.jobStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.jobStatus.FormattingEnabled = true;
            this.jobStatus.Location = new System.Drawing.Point(618, 19);
            this.jobStatus.Name = "jobStatus";
            this.jobStatus.Size = new System.Drawing.Size(121, 20);
            this.jobStatus.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(583, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 31;
            this.label3.Text = "상태:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "JOB:";
            // 
            // jobId
            // 
            this.jobId.BackColor = System.Drawing.SystemColors.MenuBar;
            this.jobId.Location = new System.Drawing.Point(288, 18);
            this.jobId.Name = "jobId";
            this.jobId.Size = new System.Drawing.Size(275, 21);
            this.jobId.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "Agent:";
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSearch.Location = new System.Drawing.Point(1095, 19);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(87, 26);
            this.BtnSearch.TabIndex = 26;
            this.BtnSearch.Text = "검색";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.JobListView);
            this.panel2.Location = new System.Drawing.Point(24, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1241, 645);
            this.panel2.TabIndex = 27;
            // 
            // JobListView
            // 
            this.JobListView.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.JobListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.JobListView.FullRowSelect = true;
            this.JobListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.JobListView.HideSelection = false;
            this.JobListView.Location = new System.Drawing.Point(21, 15);
            this.JobListView.MultiSelect = false;
            this.JobListView.Name = "JobListView";
            this.JobListView.Size = new System.Drawing.Size(1194, 627);
            this.JobListView.TabIndex = 17;
            this.JobListView.UseCompatibleStateImageBehavior = false;
            this.JobListView.View = System.Windows.Forms.View.Details;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            // 
            // FormJobExecReqMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 723);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormJobExecReqMon";
            this.Text = "JOB실행 모니터링";
            this.Load += new System.EventHandler(this.FormJobExecReqMon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboAgentId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jobExecReqId;
        private System.Windows.Forms.ComboBox jobStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jobId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView JobListView;
        private System.Windows.Forms.Timer timer1;
    }
}