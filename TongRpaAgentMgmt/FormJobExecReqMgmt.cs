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
using TongRpaCommon.ApiService;
using TongRpaCommon.Config;
using TongRpaCommon.Model;
using TongRpaCommon.Utils;

namespace TongRpaAgentMgmt
{
    public partial class FormJobExecReqMon : Form
    {
        public FormJobExecReqMon()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            searchReqJob();
        }

        //검색
        private void searchReqJob()
        {

           List<JobExecReqVo> infoList = JobReqService.jobExecReqList(getSelectedAgentId(cboAgentId.Text), jobId.Text, jobExecReqId.Text, jobStatus.Text);
            drawListView(infoList);

        }

        private void initListView()
        {

            JobListView.Clear();
            JobListView.Columns.Clear();
            JobListView.View = View.Details;
            // Add columns
            JobListView.Columns.Add("아이디", 200, HorizontalAlignment.Left);
            JobListView.Columns.Add("Agent ID", 100, HorizontalAlignment.Left);
            JobListView.Columns.Add("JOB ID", 200, HorizontalAlignment.Left);
            JobListView.Columns.Add("실행상태", 100, HorizontalAlignment.Left);
            JobListView.Columns.Add("Agent상태", 100, HorizontalAlignment.Left);
            JobListView.Columns.Add("요청일시", 200, HorizontalAlignment.Left);
            JobListView.Columns.Add("실행일시", 200, HorizontalAlignment.Left);
            JobListView.Columns.Add("실행결과", 100, HorizontalAlignment.Left);
            JobListView.Columns.Add("실행결과데이터", 300, HorizontalAlignment.Left);
        }


        private void drawListView(List<JobExecReqVo> infoList)
        {
            initListView();

            for (int i = 0; i < infoList.Count; i++)
            {
                JobExecReqVo info = infoList[i];
                ListViewItem lvt = new ListViewItem();
                lvt.Text = info.exec_req_id;
                lvt.SubItems.Add(info.agent_id);
                lvt.SubItems.Add(info.job_id);
                lvt.SubItems.Add(info.job_status);
                lvt.SubItems.Add(info.agent_status);
                lvt.SubItems.Add(info.reg_user);
                lvt.SubItems.Add(info.reg_dtm);
                lvt.SubItems.Add(info.upd_dtm);
                JobListView.Items.Add(lvt);
            }



        }

        private void FormJobExecReqMon_Load(object sender, EventArgs e)
        {
            jobStatus.Items.Clear();
            jobStatus.Items.Add("REQ");
            jobStatus.Items.Add("ING");
            jobStatus.Items.Add("CMP");
            jobStatus.SelectedIndex = 0;


            // 사용자 목록 넣기 
            List<Agent> agntList = AgentService.getAgentList("", "");
            for (int i = 0; i < agntList.Count; i++)
            {
                Agent agntInfo = agntList[i];
                cboAgentId.Items.Add(agntInfo.agent_id + "(" + agntInfo.agent_nm + ")");

            }
            cboAgentId.SelectedIndex = 0;
        }

        // Agent 코드 분리
        private string getSelectedAgentId(string AgentInfo)
        {
            string[] info = AgentInfo.Split('(');
            return info[0];
        }
    }
}
