namespace TongRpaAgentMgmt
{
    partial class MDIMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.InfoMgmtMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.UserMgmtMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.JobMgmtMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AgentMgmtMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MonitoringMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.JobReqMonMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ApiTestMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.loginUserInfoSB = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InfoMgmtMenu,
            this.MonitoringMenu,
            this.ApiTestMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip_ItemClicked);
            // 
            // InfoMgmtMenu
            // 
            this.InfoMgmtMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.UserMgmtMenu,
            this.JobMgmtMenu,
            this.AgentMgmtMenu});
            this.InfoMgmtMenu.Name = "InfoMgmtMenu";
            this.InfoMgmtMenu.ShowShortcutKeys = false;
            this.InfoMgmtMenu.Size = new System.Drawing.Size(67, 20);
            this.InfoMgmtMenu.Text = "정보관리";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(136, 6);
            // 
            // UserMgmtMenu
            // 
            this.UserMgmtMenu.Name = "UserMgmtMenu";
            this.UserMgmtMenu.Size = new System.Drawing.Size(139, 22);
            this.UserMgmtMenu.Text = "사용자 관리";
            this.UserMgmtMenu.Click += new System.EventHandler(this.UserMgmtMenu_Click);
            // 
            // JobMgmtMenu
            // 
            this.JobMgmtMenu.Name = "JobMgmtMenu";
            this.JobMgmtMenu.ShowShortcutKeys = false;
            this.JobMgmtMenu.Size = new System.Drawing.Size(139, 22);
            this.JobMgmtMenu.Text = "JOB 관리";
            this.JobMgmtMenu.Click += new System.EventHandler(this.JobMgmtMenu_Click);
            // 
            // AgentMgmtMenu
            // 
            this.AgentMgmtMenu.Name = "AgentMgmtMenu";
            this.AgentMgmtMenu.Size = new System.Drawing.Size(139, 22);
            this.AgentMgmtMenu.Text = "AGENT 관리";
            this.AgentMgmtMenu.Click += new System.EventHandler(this.AgentMgmtMenu_Click);
            // 
            // MonitoringMenu
            // 
            this.MonitoringMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JobReqMonMenu});
            this.MonitoringMenu.Name = "MonitoringMenu";
            this.MonitoringMenu.Size = new System.Drawing.Size(67, 20);
            this.MonitoringMenu.Text = "모니터링";
            // 
            // JobReqMonMenu
            // 
            this.JobReqMonMenu.Name = "JobReqMonMenu";
            this.JobReqMonMenu.Size = new System.Drawing.Size(198, 22);
            this.JobReqMonMenu.Text = "JOB요청 정보 모니터링";
            this.JobReqMonMenu.Click += new System.EventHandler(this.JobReqMonMenu_Click);
            // 
            // ApiTestMenu
            // 
            this.ApiTestMenu.Name = "ApiTestMenu";
            this.ApiTestMenu.Size = new System.Drawing.Size(73, 20);
            this.ApiTestMenu.Text = "API테스트";
            this.ApiTestMenu.Click += new System.EventHandler(this.ApiTestMenu_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginUserInfoSB});
            this.statusStrip.Location = new System.Drawing.Point(0, 543);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1027, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // loginUserInfoSB
            // 
            this.loginUserInfoSB.Name = "loginUserInfoSB";
            this.loginUserInfoSB.Size = new System.Drawing.Size(43, 17);
            this.loginUserInfoSB.Text = "사용자";
            // 
            // MDIMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 565);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.Name = "MDIMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "통선임 RPA 괸리자 시스템";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MDIMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIMain_FormClosing);
            this.Load += new System.EventHandler(this.MDIMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem InfoMgmtMenu;
        private System.Windows.Forms.ToolStripMenuItem JobMgmtMenu;
        private System.Windows.Forms.ToolStripMenuItem MonitoringMenu;
        private System.Windows.Forms.ToolStripMenuItem ApiTestMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem AgentMgmtMenu;
        private System.Windows.Forms.ToolStripMenuItem JobReqMonMenu;
        private System.Windows.Forms.ToolStripMenuItem UserMgmtMenu;
        private System.Windows.Forms.ToolStripStatusLabel loginUserInfoSB;
    }
}



