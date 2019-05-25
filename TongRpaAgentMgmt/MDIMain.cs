using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TongRpaCommon.Model;
using System.Configuration;
using TongRpaAgentMgmt.Login;

namespace TongRpaAgentMgmt
{

    public partial class MDIMain : Form
    {

        public MDIMain()
        {
            InitializeComponent();
            
        }




        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDIMain_Load(object sender, EventArgs e)
        {
            //로그인 폼 호출
            FormLogin flForm = new FormLogin();
            flForm.ShowDialog();

            // 로그인 성공
            if (Session.LoginUserInfo != null)
            {
                FormJobExecReqMon FUM = new FormJobExecReqMon();
                FUM.MdiParent = this;
                FUM.Show();
                FUM.WindowState = 0;
            }

        }
        //JOB 정보관리 폼 호출
        private void JobMgmtMenu_Click(object sender, EventArgs e)
        {
            FormJobMgmt FUM = new FormJobMgmt();
            if (!formIsExist(FUM.GetType()))
            {
                FUM.MdiParent = this;
                FUM.Show();
                FUM.WindowState = 0;
            }
        }
        //Agent정보관리 폼 호출
        private void AgentMgmtMenu_Click(object sender, EventArgs e)
        {
            FormAgentMgmt FUM = new FormAgentMgmt();
            if (!formIsExist(FUM.GetType()))
            {
                FUM.MdiParent = this;
                FUM.Show();
                FUM.WindowState = 0;
            }
        }
        //사용자 정보관리 폼 호출
        private void UserMgmtMenu_Click(object sender, EventArgs e)
        {
            FormUserMgmt FUM = new FormUserMgmt();
            if (!formIsExist(FUM.GetType()))
            {
                FUM.MdiParent = this;
                FUM.Show();
                FUM.WindowState = 0;
            }



        }

        private void JobReqMonMenu_Click(object sender, EventArgs e)
        {
           
            FormJobExecReqMon FUM = new FormJobExecReqMon();
            if (!formIsExist(FUM.GetType()))
            {
                FUM.MdiParent = this;
                FUM.Show();
                FUM.WindowState = 0;
            }
        }

        private void MenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MDIMain_Activated(object sender, EventArgs e)
        {
           
            User userInfo=Session.LoginUserInfo;
            if (userInfo != null)
                loginUserInfoSB.Text = "사용자 : " +userInfo.user_nm + "(" + userInfo.user_id + ")";
            else
                loginUserInfoSB.Text = "";
        }

        private void ApiTestMenu_Click(object sender, EventArgs e)
        {
            FormChatBotAPI FUM = new FormChatBotAPI();
            if (!formIsExist(FUM.GetType())){
                FUM.MdiParent = this;
                FUM.Show();
                FUM.WindowState = 0;
            }


        }

        private void MDIMain_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dr = MessageBox.Show("통선임RPA 관리자 프로그램을 종료할까요?", "통선임RPA 관리자", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                Application.ExitThread();
                Application.Exit();

            }
            else
            {
                e.Cancel = true;
            }
        }

        // 자식 폼 중복 여부
        private bool formIsExist(Type tp)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == tp)
                {
                    form.Activate();
                    return true;
                }
            }
            return false;
        }
    }
}
