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
    public partial class FormAgentMgmt : Form
    {
        public FormAgentMgmt()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            searchAgent();
        }
        //검색
        private void searchAgent()
        {
            string url = "http://" + ConnectionConstants.HostName + ":18080/agentList";

            String jsonStr = HttpUtil.RequestHttp(url);
            ParseUserJson(jsonStr);// listview에 출력
        }

        private void initListView()
        {
            editGroupBox.Visible = false;
            AgentListView.Clear();
            AgentListView.Columns.Clear();
            AgentListView.View = View.Details;
            // Add columns
            AgentListView.Columns.Add("아이디", 100, HorizontalAlignment.Left);
            AgentListView.Columns.Add("agent명", 100, HorizontalAlignment.Left);
            AgentListView.Columns.Add("상세설명", 100, HorizontalAlignment.Left);
            AgentListView.Columns.Add("UUID", 100, HorizontalAlignment.Left);
            AgentListView.Columns.Add("상태", 100, HorizontalAlignment.Left);
            AgentListView.Columns.Add("등록자", 100, HorizontalAlignment.Left);
            AgentListView.Columns.Add("등록일시", 200, HorizontalAlignment.Left);
            AgentListView.Columns.Add("수정일시", 200, HorizontalAlignment.Left);
        }
        private void ParseUserJson(String json)
        {
            initListView();
            JArray array = JArray.Parse(json);


            foreach (JObject itemObj in array)
            {
                ListViewItem lvt = new ListViewItem();
                lvt.Text = itemObj["agent_id"].ToString();
                lvt.SubItems.Add(itemObj["agent_nm"].ToString());
                lvt.SubItems.Add(itemObj["agent_desc"].ToString());
                lvt.SubItems.Add(itemObj["agent_uid"].ToString());
                lvt.SubItems.Add(itemObj["agent_status"].ToString());
                lvt.SubItems.Add(itemObj["reg_user"].ToString());
                lvt.SubItems.Add(itemObj["reg_dtm"].ToString());
                lvt.SubItems.Add(itemObj["upd_dtm"].ToString());

                AgentListView.Items.Add(lvt);
            }


        }

        private void AgentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AgentListView.FocusedItem != null)
            {


                int selectedIndex = AgentListView.FocusedItem.Index;
                int i = 0;
                edtAgentId.Text = AgentListView.Items[selectedIndex].SubItems[i++].Text;
                edtAgentNm.Text = AgentListView.Items[selectedIndex].SubItems[i++].Text;
                edtAgentDesc.Text = AgentListView.Items[selectedIndex].SubItems[i++].Text;
                edtAgentUid.Text = AgentListView.Items[selectedIndex].SubItems[i++].Text;
                edtAgentStatus.SelectedItem = AgentListView.Items[selectedIndex].SubItems[i++].Text;

                edtRegUser.Text = AgentListView.Items[selectedIndex].SubItems[i++].Text;
                edtRegDtm.Text = AgentListView.Items[selectedIndex].SubItems[i++].Text;
                edtUpdDtm.Text = AgentListView.Items[selectedIndex].SubItems[i++].Text;

                editGroupBox.Visible = true;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            saveAgent();
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            initNewEditGroupBox();
        }


        private void initNewEditGroupBox()
        {

            edtAgentId.Text = ""; edtAgentId.ReadOnly = false;
            edtAgentNm.Text = "";
            edtAgentDesc.Text = "";
            edtAgentUid.Text = "";
            edtAgentStatus.Items.Clear();
            edtAgentStatus.Items.Add("IDLE");
            edtAgentStatus.Items.Add("BUSY");
            edtAgentStatus.Items.Add("DOWN");

            edtRegUser.Text = ""; edtRegUser.ReadOnly = false;
            edtRegDtm.Text = "";
            edtUpdDtm.Text = "";

            editGroupBox.Text = "신규등록";

            editGroupBox.Visible = true;

        }

        //JOB 저장
        private void saveAgent()
        {
            String MsgTitle = "신규등록하시겠습니까?";

            string url = "http://" + ConnectionConstants.HostName + ":18080/";
            string apiname = "insertAgent";
            if (editGroupBox.Text.Equals("정보수정"))
            {
                apiname = "updateAgentInfo";
                MsgTitle = "수정 하시겠습니까?";
            }
            MsgTitle = edtAgentNm.Text + "의 정보를  " + MsgTitle;
            DialogResult dialogResult = MessageBox.Show(MsgTitle, "AgentPC", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string param = "agentId=" + edtAgentId.Text;
                param += "&agentNm=" + edtAgentNm.Text;
                param += "&agentDesc=" + edtAgentDesc.Text;
                param += "&agentUid=" + edtAgentUid.Text;
                param += "&agentStatus=" + edtAgentStatus.Text;
                param += "&regUser=" + edtRegUser.Text;

                url = url + apiname + "?" + param;
                String jsonStr = HttpUtil.RequestHttp(url);

                JObject jboj = JObject.Parse(jsonStr);
                int i = 0;
                bool result = int.TryParse(jboj["result_cnt"].ToString(), out i);
                if (i > 0)
                {
                    searchAgent();

                }
                else
                {
                    MessageBox.Show("실패했음");
                }
            }
        }


        private void initUpdEditGroupBox()
        {

            edtAgentId.Text = ""; edtRegUser.ReadOnly = true;
            edtAgentNm.Text = "";
            edtAgentDesc.Text = "";
            edtAgentUid.Text = "";

            edtAgentStatus.Items.Clear();
            edtAgentStatus.Items.Add("IDLE");
            edtAgentStatus.Items.Add("BUSY");
            edtAgentStatus.Items.Add("DOWN");
            edtRegUser.Text = ""; edtRegUser.ReadOnly = true;
            edtRegDtm.Text = "";
            edtUpdDtm.Text = "";

            editGroupBox.Text = "정보수정";


        }

        private void deleteAgent()
        {
            String MsgTitle = "정말 삭제하실건가요?";
            MsgTitle = edtAgentNm.Text + "의 정보를  " + MsgTitle;
            DialogResult dialogResult = MessageBox.Show(MsgTitle, "AgentPC", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string url = "http://" + ConnectionConstants.HostName + ":18080/";
                string apiname = "deleteAgent";
                string param = "agentId=" + edtAgentId.Text;



                url = url + apiname + "?" + param;
                String jsonStr = HttpUtil.RequestHttp(url);

                JObject jboj = JObject.Parse(jsonStr);
                int i = 0;
                bool result = int.TryParse(jboj["result_cnt"].ToString(), out i);
                if (i > 0)
                {
                    initUpdEditGroupBox();
                    searchAgent();

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

        private void FormAgentMgmt_Load(object sender, EventArgs e)
        {
            initUpdEditGroupBox();
            editGroupBox.Visible = false;
        }

        private void DellBtn_Click(object sender, EventArgs e)
        {
            deleteAgent();
        }
    }
}
