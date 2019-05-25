namespace TongRpaAgent
{
    partial class agentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agentForm));
            this.startAgent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MacAddr = new System.Windows.Forms.TextBox();
            this.AgentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatusBar = new System.Windows.Forms.TextBox();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openTrayForm = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTrayForm = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // startAgent
            // 
            this.startAgent.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.startAgent.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.startAgent.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.startAgent.Location = new System.Drawing.Point(52, 52);
            this.startAgent.Name = "startAgent";
            this.startAgent.Size = new System.Drawing.Size(169, 34);
            this.startAgent.TabIndex = 0;
            this.startAgent.Text = "시작";
            this.startAgent.UseVisualStyleBackColor = false;
            this.startAgent.Click += new System.EventHandler(this.StartAgent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mac:";
            // 
            // MacAddr
            // 
            this.MacAddr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MacAddr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MacAddr.Location = new System.Drawing.Point(52, 6);
            this.MacAddr.Name = "MacAddr";
            this.MacAddr.Size = new System.Drawing.Size(186, 14);
            this.MacAddr.TabIndex = 2;
            // 
            // AgentId
            // 
            this.AgentId.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AgentId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgentId.Location = new System.Drawing.Point(52, 26);
            this.AgentId.Name = "AgentId";
            this.AgentId.Size = new System.Drawing.Size(186, 14);
            this.AgentId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Agent:";
            // 
            // txtStatusBar
            // 
            this.txtStatusBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtStatusBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStatusBar.Location = new System.Drawing.Point(2, 92);
            this.txtStatusBar.Name = "txtStatusBar";
            this.txtStatusBar.Size = new System.Drawing.Size(263, 14);
            this.txtStatusBar.TabIndex = 6;
            this.txtStatusBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "통선임RPA";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openTrayForm,
            this.closeTrayForm});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(99, 48);
            // 
            // openTrayForm
            // 
            this.openTrayForm.Name = "openTrayForm";
            this.openTrayForm.Size = new System.Drawing.Size(98, 22);
            this.openTrayForm.Text = "열기";
            this.openTrayForm.Click += new System.EventHandler(this.OpenTrayForm_Click);
            // 
            // closeTrayForm
            // 
            this.closeTrayForm.Name = "closeTrayForm";
            this.closeTrayForm.Size = new System.Drawing.Size(98, 22);
            this.closeTrayForm.Text = "종료";
            this.closeTrayForm.Click += new System.EventHandler(this.CloseTrayForm_Click);
            // 
            // agentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(267, 104);
            this.Controls.Add(this.txtStatusBar);
            this.Controls.Add(this.AgentId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MacAddr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startAgent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "agentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "통선임 RPA Agent";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgentForm_FormClosing);
            this.Resize += new System.EventHandler(this.AgentForm_Resize);
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startAgent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MacAddr;
        private System.Windows.Forms.TextBox AgentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatusBar;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem openTrayForm;
        private System.Windows.Forms.ToolStripMenuItem closeTrayForm;
    }
}

