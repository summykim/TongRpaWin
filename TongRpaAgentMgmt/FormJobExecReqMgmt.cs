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
            string url = "http://" + ConnectionConstants.HostName + ":18080/jobExecReqList";
            string param = "agentId=" + agentId.Text;
            param += "&jobId=" + jobId.Text;
            param += "&jobStatus=" + jobStatus.Text;
            param += "&jobExecReqId=" + jobExecReqId.Text;
            
                        url = url + "?" + param;
            String jsonStr = HttpUtil.RequestHttp(url);
            ParseUserJson(jsonStr);// listview에 출력
        }

        private void initListView()
        {
            jobStatus.Items.Clear();
            jobStatus.Items.Add("REQ");
            jobStatus.Items.Add("ING");
            jobStatus.Items.Add("CMP");

            JobListView.Clear();
            JobListView.Columns.Clear();
            JobListView.View = View.Details;
            // Add columns
            JobListView.Columns.Add("아이디", 200, HorizontalAlignment.Left);
            JobListView.Columns.Add("Agent ID", 100, HorizontalAlignment.Left);
            JobListView.Columns.Add("JOB ID", 200, HorizontalAlignment.Left);
            JobListView.Columns.Add("실행상태", 100, HorizontalAlignment.Left);
            JobListView.Columns.Add("Agent상태", 100, HorizontalAlignment.Left);
            JobListView.Columns.Add("등록일시", 200, HorizontalAlignment.Left);
            JobListView.Columns.Add("수정일시", 200, HorizontalAlignment.Left);
        }
        private void ParseUserJson(String json)
        {
            initListView();
            JArray array = JArray.Parse(json);


            foreach (JObject itemObj in array)
            {
                ListViewItem lvt = new ListViewItem();
                lvt.Text = itemObj["exec_req_id"].ToString();
                lvt.SubItems.Add(itemObj["agent_id"].ToString());
                lvt.SubItems.Add(itemObj["job_id"].ToString());
                lvt.SubItems.Add(itemObj["job_status"].ToString());
                lvt.SubItems.Add(itemObj["agent_status"].ToString());
                lvt.SubItems.Add(itemObj["reg_dtm"].ToString());
                lvt.SubItems.Add(itemObj["upd_dtm"].ToString());

                JobListView.Items.Add(lvt);
            }


        }

    }
}
