using log4net;
using Newtonsoft.Json.Linq;
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
using TongRpaCommon.Config;
using TongRpaCommon.Model;
using TongRpaCommon.Utils;

namespace TongRpaAgentMgmt
{
    public partial class FormUserMgmt : Form
    {
        private ILog logger = LogManager.GetLogger(typeof(FormUserMgmt));
        public FormUserMgmt()
        {
            InitializeComponent();
        }

        private void FormUserMgmt_Load(object sender, EventArgs e)
        {
            initUpdEditGroupBox();
            editGroupBox.Visible = false;
        }

        //검색
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            logger.Debug(Session.LoginUserInfo.user_id);
            searchUser(txtUserID.Text, txtUserNm.Text);
        }
        //검색
        private void searchUser(string userId, string userNm)
        {
            List<User> userList=UserService.getUserList(userId, userNm);
            drawListView(userList);

        }

        //리스트뷰 초기화
        private void initListView()
        {
            editGroupBox.Visible = false;
            UserListView.Clear();
            UserListView.Columns.Clear();
            UserListView.View = View.Details;
            // Add columns
            UserListView.Columns.Add("아이디", 100, HorizontalAlignment.Left);
            UserListView.Columns.Add("이름", 100, HorizontalAlignment.Left);
            UserListView.Columns.Add("이메일", 200, HorizontalAlignment.Left);
            UserListView.Columns.Add("전화번호", 100, HorizontalAlignment.Left);
            UserListView.Columns.Add("챗봇연동키", 100, HorizontalAlignment.Left);
            UserListView.Columns.Add("사용자구분", 100, HorizontalAlignment.Left);
            UserListView.Columns.Add("등록자", 100, HorizontalAlignment.Left);
            UserListView.Columns.Add("등록일시", 200, HorizontalAlignment.Left);
            UserListView.Columns.Add("수정일시", 200, HorizontalAlignment.Left);
        }
        private void drawListView(List<User> userList)
        {
            initListView();


            for(int i=0; i< userList.Count;i++)
            {
                User info= userList[i];
                ListViewItem lvt = new ListViewItem();
                lvt.Text = info.user_id;
                lvt.SubItems.Add(info.user_nm);
                lvt.SubItems.Add(info.user_email);
                lvt.SubItems.Add(info.user_phone);
                lvt.SubItems.Add(info.chbot_key);
                lvt.SubItems.Add(getTypeCode(info.user_typ));
                lvt.SubItems.Add(info.reg_user);
                lvt.SubItems.Add(info.reg_dtm);
                lvt.SubItems.Add(info.upd_dtm);

                UserListView.Items.Add(lvt);
            }


        }

        private string  getTypeCode(string code )
        {
            string resultStr = "";
            if (code == "USR") resultStr = "사용자";
            else if (code == "ADM") resultStr = "관리자";
            else if (code == "관리자") resultStr = "ADM";
            else if (code == "사용자") resultStr = "USR";

            return resultStr;
        }
        // 사용자선택
        private void UserListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (UserListView.FocusedItem != null)
            {


                int selectedIndex = UserListView.FocusedItem.Index;
                int i = 0;
                edtUserID.Text = UserListView.Items[selectedIndex].SubItems[i++].Text;
                edtUserNm.Text = UserListView.Items[selectedIndex].SubItems[i++].Text;
                edtUserEmail.Text = UserListView.Items[selectedIndex].SubItems[i++].Text;
                edtUserPhone.Text = UserListView.Items[selectedIndex].SubItems[i++].Text;
                edtChbotKey.Text = UserListView.Items[selectedIndex].SubItems[i++].Text;
                edtUserTyp.SelectedItem = UserListView.Items[selectedIndex].SubItems[i++].Text;
                edtRegUser.Text = UserListView.Items[selectedIndex].SubItems[i++].Text;
                edtRegDtm.Text = UserListView.Items[selectedIndex].SubItems[i++].Text;
                edtUpdDtm.Text = UserListView.Items[selectedIndex].SubItems[i++].Text;
                editGroupBox.Text = "정보수정";
                editGroupBox.Visible = true;
            }
        }

        private void initUpdEditGroupBox()
        {
            edtUserID.Text = ""; edtUserID.ReadOnly = true;
            edtUserNm.Text = "";
            edtChbotKey.Text = "";
            edtUserPhone.Text = "";
            edtUserEmail.Text = "";

            edtUserTyp.Items.Clear();
            edtUserTyp.Items.Add("사용자");
            edtUserTyp.Items.Add("관리자");

            edtRegUser.Text = Session.LoginUserInfo.user_id; 
            edtRegDtm.Text = "";
            edtUpdDtm.Text = "";

            editGroupBox.Text = "정보수정";


        }
        //신규등록버튼
        private void NewUserBtn_Click_1(object sender, EventArgs e)
        {
            initNewEditGroupBox();

        }
        // 상세정보 그룹 초기화
        private void initNewEditGroupBox()
        {
            edtUserID.Text = ""; edtUserID.ReadOnly = false;
            edtUserNm.Text = "";
            edtChbotKey.Text = "";
            edtUserPhone.Text = "";
            edtUserEmail.Text = "";

            edtUserTyp.SelectedIndex = 0;

            edtRegUser.Text = Session.LoginUserInfo.user_id;
            edtRegDtm.Text = "";
            edtUpdDtm.Text = "";

            editGroupBox.Text = "신규등록";

            editGroupBox.Visible = true;

        }

        //사용자 저장
        private void userSaveBtn_Click(object sender, EventArgs e)
        {
            String MsgTitle = "신규등록하시겠습니까?";


            string apiname = "insertUser";
            if (editGroupBox.Text.Equals("정보수정"))
            {
                apiname = "updateUser";
                MsgTitle = "수정 하시겠습니까?";
            }
            
            MsgTitle = edtUserNm.Text + "님의 정보를  " + MsgTitle;
            DialogResult dialogResult = MessageBox.Show(MsgTitle, "사용자", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {



                User userInfo = new User("");
                userInfo.user_id = edtUserID.Text;
                userInfo.user_nm = edtUserNm.Text;
                userInfo.chbot_key = edtChbotKey.Text;
                userInfo.user_phone = edtUserPhone.Text;
                userInfo.user_email = edtUserEmail.Text;
                userInfo.user_typ = getTypeCode(edtUserTyp.Text);
                userInfo.reg_user = Session.LoginUserInfo.user_id;
                int result = 0;
                if (apiname== "updateUser")
                {
                    result = UserService.updateUser(userInfo);
                }
                else
                {
                    result = UserService.InsertUser(userInfo);
                }
                

                if (result > 0)
                {
                    searchUser(txtUserID.Text, txtUserNm.Text);

                }
                else
                {
                    MessageBox.Show("실패했음");
                }
            }
        }
        //신규사용자 등록작업 취소
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            String MsgTitle = "정말 삭제하실건가요?";
            MsgTitle= edtUserNm.Text + "를 "+ MsgTitle;
            DialogResult dialogResult = MessageBox.Show(MsgTitle, "사용자", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                User userInfo = new User("");
                userInfo.user_id = edtUserID.Text;
                int result = UserService.deleteUser(userInfo);

                if (result > 0)
                {
                    initUpdEditGroupBox();
                    searchUser(txtUserID.Text, txtUserNm.Text);

                }
                else
                {
                    MessageBox.Show("삭제실패했어요.");
                }
            }
          
           
        }

    }
}
