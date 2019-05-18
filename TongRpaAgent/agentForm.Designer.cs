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
            this.startAgent = new System.Windows.Forms.Button();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.msgSend = new System.Windows.Forms.Button();
            this.msgbox = new System.Windows.Forms.RichTextBox();
            this.tbProgress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // startAgent
            // 
            this.startAgent.Location = new System.Drawing.Point(76, 63);
            this.startAgent.Name = "startAgent";
            this.startAgent.Size = new System.Drawing.Size(164, 23);
            this.startAgent.TabIndex = 0;
            this.startAgent.Text = "MQ에이전트 시작";
            this.startAgent.UseVisualStyleBackColor = true;
            this.startAgent.Click += new System.EventHandler(this.StartAgent_Click);
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.ItemHeight = 12;
            this.listMessage.Location = new System.Drawing.Point(76, 108);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(257, 340);
            this.listMessage.TabIndex = 1;
            // 
            // msgSend
            // 
            this.msgSend.Location = new System.Drawing.Point(520, 88);
            this.msgSend.Name = "msgSend";
            this.msgSend.Size = new System.Drawing.Size(164, 23);
            this.msgSend.TabIndex = 2;
            this.msgSend.Text = "MQ메시지전송";
            this.msgSend.UseVisualStyleBackColor = true;
            this.msgSend.Click += new System.EventHandler(this.MsgSend_Click);
            // 
            // msgbox
            // 
            this.msgbox.Location = new System.Drawing.Point(520, 117);
            this.msgbox.Name = "msgbox";
            this.msgbox.Size = new System.Drawing.Size(237, 317);
            this.msgbox.TabIndex = 3;
            this.msgbox.Text = "테스트메시지전송\n테스트메시지 2";
            // 
            // tbProgress
            // 
            this.tbProgress.Location = new System.Drawing.Point(65, 12);
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.Size = new System.Drawing.Size(571, 32);
            this.tbProgress.TabIndex = 4;
            // 
            // agentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 569);
            this.Controls.Add(this.tbProgress);
            this.Controls.Add(this.msgbox);
            this.Controls.Add(this.msgSend);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.startAgent);
            this.Name = "agentForm";
            this.Text = "RPA Agent";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startAgent;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Button msgSend;
        private System.Windows.Forms.RichTextBox msgbox;
        private System.Windows.Forms.ProgressBar tbProgress;
    }
}

