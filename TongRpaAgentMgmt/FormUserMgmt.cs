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

namespace TongRpaAgentMgmt
{
    public partial class FormUserMgmt : Form
    {
        public FormUserMgmt()
        {
            InitializeComponent();
        }

        private void FormUserMgmt_Load(object sender, EventArgs e)
        {
            initUpdEditGroupBox();
            editGroupBox.Visible = false;
        }
        // 사용자검색
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            searchUser();

        }

        //검색
        private void searchUser()
        {
            string url = "http://"+ConnectionConstants.HostName+":18080/userList";
            String jsonStr = HttpUtil.RequestHttp(url);
            ParseUserJson(jsonStr);// listview에 출력
        }

        private void initListView()
        {
            editGroupBox.Visible = false;
            UserListView.Clear();
            UserListView.Columns.Clear();
            UserListView.View = View.Details;
            // Add columns
            UserListView.Columns.Add("아이디", 100, HorizontalAlignment.Left);
            UserListView.Columns.Add("이름", 100, HorizontalAlignment.Left);
            UserListView.Columns.Add("챗봇연동키", 100, HorizontalAlignment.Left);
            UserListView.Columns.Add("사용자구분", 100, HorizontalAlignment.Left);
            UserListView.Columns.Add("등록자", 100, HorizontalAlignment.Left);
            UserListView.Columns.Add("등록일시", 200, HorizontalAlignment.Left);
            UserListView.Columns.Add("수정일시", 200, HorizontalAlignment.Left);
        }
        private void ParseUserJson(String json)
        {
            initListView();
            JArray array = JArray.Parse(json);


            foreach (JObject itemObj in array)
            {
                ListViewItem lvt = new ListViewItem();
                lvt.Text = itemObj["user_id"].ToString();
                lvt.SubItems.Add(itemObj["user_nm"].ToString());
                lvt.SubItems.Add(itemObj["chbot_key"].ToString());
                lvt.SubItems.Add(itemObj["user_typ"].ToString());
                lvt.SubItems.Add(itemObj["reg_user"].ToString());
                lvt.SubItems.Add(itemObj["reg_dtm"].ToString());
                lvt.SubItems.Add(itemObj["upd_dtm"].ToString());

                UserListView.Items.Add(lvt);
            }


        }

        private void UserListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserListView.FocusedItem != null)
            {

          
                int selectedIndex = UserListView.FocusedItem.Index;
                int i = 0;
                edtUserID.Text = UserListView.Items[selectedIndex].SubItems[i++].Text;
                edtUserNm.Text = UserListView.Items[selectedIndex].SubItems[i++].Text;
                edtChbotKey.Text = UserListView.Items[selectedIndex].SubItems[i++].Text;
                edtUserTyp.SelectedItem = UserListView.Items[selectedIndex].SubItems[i++].Text;
                edtRegUser.Text = UserListView.Items[selectedIndex].SubItems[i++].Text;
                edtRegDtm.Text = UserListView.Items[selectedIndex].SubItems[i++].Text;
                edtUpdDtm.Text = UserListView.Items[selectedIndex].SubItems[i++].Text;

                editGroupBox.Visible = true;
            }
        }
        //신규등록버튼
        private void NewUserBtn_Click(object sender, EventArgs e)
        {
            initNewEditGroupBox();

        }

        private void initNewEditGroupBox()
        {
            edtUserID.Text = ""; edtUserID.ReadOnly = false;
            edtUserNm.Text = "";
            edtChbotKey.Text = "";


            edtUserTyp.Items.Clear();
            edtUserTyp.Items.Add("USR");
            edtUserTyp.Items.Add("MGR");

            edtRegUser.Text = ""; edtRegUser.ReadOnly = false;
            edtRegDtm.Text = "";
            edtUpdDtm.Text = "";

            editGroupBox.Text = "신규등록";

            editGroupBox.Visible = true;

        }

        //사용자 저장
        private void userSaveBtn_Click(object sender, EventArgs e)
        {
            String MsgTitle = "신규등록하시겠습니까?";

            string url = "http://"+ConnectionConstants.HostName+":18080/";
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
                string param = "userId=" + edtUserID.Text;
                param += "&userNm=" + edtUserNm.Text;
                param += "&chbotKey=" + edtChbotKey.Text;
                param += "&userTyp=" + edtUserTyp.Text;
                param += "&regUser=" + edtRegUser.Text;

                url = url + apiname + "?" + param;
                String jsonStr = HttpUtil.RequestHttp(url);

                JObject jboj = JObject.Parse(jsonStr);
                int i = 0;
                bool result = int.TryParse(jboj["result_cnt"].ToString(), out i);
                if (i > 0)
                {
                    searchUser();

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

                string url = "http://"+ConnectionConstants.HostName+":18080/";
                string apiname = "deleteUser";
                string param = "userId=" + edtUserID.Text;



                url = url + apiname + "?" + param;
                String jsonStr = HttpUtil.RequestHttp(url);

                JObject jboj = JObject.Parse(jsonStr);
                int i = 0;
                bool result = int.TryParse(jboj["result_cnt"].ToString(), out i);
                if (i > 0)
                {
                    initUpdEditGroupBox();
                    searchUser();

                }
                else
                {
                    MessageBox.Show("삭제실패했어요.");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

           
        }

        private void initUpdEditGroupBox()
        {
            edtUserID.Text = ""; edtUserID.ReadOnly = true;
            edtUserNm.Text = "";
            edtChbotKey.Text = "";

            edtUserTyp.Items.Clear();
            edtUserTyp.Items.Add("USR");
            edtUserTyp.Items.Add("MGR");

            edtRegUser.Text = ""; edtRegUser.ReadOnly = true;
            edtRegDtm.Text = "";
            edtUpdDtm.Text = "";

            editGroupBox.Text = "정보수정";

      
        }
    }
}
