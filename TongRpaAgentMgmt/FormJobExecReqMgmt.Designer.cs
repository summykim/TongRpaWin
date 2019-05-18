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
            this.label2 = new System.Windows.Forms.Label();
            this.jobId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.agentId = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.JobListView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.jobStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.jobExecReqId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "JOB";
            // 
            // jobId
            // 
            this.jobId.Location = new System.Drawing.Point(264, 14);
            this.jobId.Name = "jobId";
            this.jobId.Size = new System.Drawing.Size(122, 21);
            this.jobId.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "Agent";
            // 
            // agentId
            // 
            this.agentId.Location = new System.Drawing.Point(81, 14);
            this.agentId.Name = "agentId";
            this.agentId.Size = new System.Drawing.Size(122, 21);
            this.agentId.TabIndex = 18;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(882, 11);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(87, 26);
            this.BtnSearch.TabIndex = 17;
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
            this.JobListView.Location = new System.Drawing.Point(24, 57);
            this.JobListView.MultiSelect = false;
            this.JobListView.Name = "JobListView";
            this.JobListView.Size = new System.Drawing.Size(1194, 299);
            this.JobListView.TabIndex = 16;
            this.JobListView.UseCompatibleStateImageBehavior = false;
            this.JobListView.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "상태";
            // 
            // jobStatus
            // 
            this.jobStatus.FormattingEnabled = true;
            this.jobStatus.Location = new System.Drawing.Point(463, 15);
            this.jobStatus.Name = "jobStatus";
            this.jobStatus.Size = new System.Drawing.Size(121, 20);
            this.jobStatus.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "reqid";
            // 
            // jobExecReqId
            // 
            this.jobExecReqId.Location = new System.Drawing.Point(663, 16);
            this.jobExecReqId.Name = "jobExecReqId";
            this.jobExecReqId.Size = new System.Drawing.Size(122, 21);
            this.jobExecReqId.TabIndex = 24;
            // 
            // FormJobExecReqMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 649);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.jobExecReqId);
            this.Controls.Add(this.jobStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jobId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agentId);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.JobListView);
            this.Name = "FormJobExecReqMon";
            this.Text = "JOB실행요청 모니터링";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jobId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox agentId;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ListView JobListView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox jobStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jobExecReqId;
    }
}