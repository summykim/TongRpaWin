using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TongRpaAgentMgmt.Login;
using TongRpaCommon.ApiService;
using TongRpaCommon.Model;

namespace TongRpaAgentMgmt
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text.Length == 0)
            {
                MessageBox.Show("아이디를 입력하세요.");
                return;
            }
            else if (txtUserPwd.Text.Length == 0)
            {
                MessageBox.Show("패스워드를 입력하세요.");
                return;
            }

            User userInfo=UserService.Login(txtUserId.Text, txtUserPwd.Text);
            if (userInfo == null)
            {
                MessageBox.Show("아이디 또는 패스워드를 확인하세요.");
                return;
            }
            else{
                Session.LoginUserInfo = userInfo;

                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }
    }
}
