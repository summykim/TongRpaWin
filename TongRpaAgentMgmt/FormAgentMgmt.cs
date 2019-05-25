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
    public partial class FormAgentMgmt : Form
    {
        public FormAgentMgmt()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            BtnSearch.Enabled = false;
            searchAgent();
            BtnSearch.Enabled = true;
        }
        //검색
        private void searchAgent()
        {
            List<Agent> agentList = AgentService.getAgentList("", "");
            drawListView(agentList);
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
        private void drawListView(List<Agent> agentList)
        {
            initListView();

            for (int i = 0; i < agentList.Count; i++)
            {
                Agent info = agentList[i];
                ListViewItem lvt = new ListViewItem();
                lvt.Text = info.agent_id;
                lvt.SubItems.Add(info.agent_nm);
                lvt.SubItems.Add(info.agent_desc);
                lvt.SubItems.Add(info.agent_uid);
                lvt.SubItems.Add(info.agent_status);
                lvt.SubItems.Add(info.reg_user);
                lvt.SubItems.Add(info.reg_dtm);
                lvt.SubItems.Add(info.upd_dtm);
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


                editGroupBox.Text = "정보수정";
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


            editGroupBox.Text = "신규등록";

            editGroupBox.Visible = true;

        }

        //JOB 저장
        private void saveAgent()
        {
            String MsgTitle = "신규등록하시겠습니까?";

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

                Agent agentInfo = new Agent("");

                agentInfo.agent_id = edtAgentId.Text;
                agentInfo.agent_nm = edtAgentNm.Text;
                agentInfo.agent_desc = edtAgentDesc.Text;
                agentInfo.agent_uid = edtAgentUid.Text;
                agentInfo.agent_status = edtAgentStatus.Text;
                agentInfo.reg_user = Session.LoginUserInfo.user_id; ;

                int resultCnt = 0;
                if (apiname == "insertAgent")
                {
                    resultCnt = AgentService.insertAgent(agentInfo);
                }
                else
                {
                    resultCnt = AgentService.updateAgent(agentInfo);
                }

                if (resultCnt > 0)
                {
                    searchAgent();

                }
                else
                {
                    MessageBox.Show("실패했어요.");
                }
            }
        }


        private void initUpdEditGroupBox()
        {

            edtAgentId.Text = "";
            edtAgentNm.Text = "";
            edtAgentDesc.Text = "";
            edtAgentUid.Text = "";

            edtAgentStatus.Items.Clear();
            edtAgentStatus.Items.Add("IDLE");
            edtAgentStatus.Items.Add("BUSY");
            edtAgentStatus.Items.Add("DOWN");
            edtAgentStatus.SelectedIndex = 0;

            editGroupBox.Text = "정보수정";


        }

        private void deleteAgent()
        {
            String MsgTitle = "정말 삭제하실건가요?";
            MsgTitle = edtAgentNm.Text + "의 정보를  " + MsgTitle;
            DialogResult dialogResult = MessageBox.Show(MsgTitle, "AgentPC", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Agent agentInfo = new Agent("");

                agentInfo.agent_id = edtAgentId.Text;
                int resultCnt = AgentService.deleteAgent(agentInfo);
                if (resultCnt > 0)
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
