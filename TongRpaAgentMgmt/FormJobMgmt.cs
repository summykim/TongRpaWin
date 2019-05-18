
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
using TongAgentUtil;

namespace TongRpaAgentMgmt
{
    public partial class FormJobMgmt : Form
    {
        public FormJobMgmt()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            searchJob();
        }
        //검색
        private void searchJob()
        {
            string url = "http://"+ConnectionConstants.HostName+":18080/jobList";
            string param = "searchText=" + searchText.Text;
            param += "&authUser=" + authUser.Text;
            param += "&jobId=" + jobId.Text;
            url = url + "?" + param;
            String jsonStr = HttpUtil.RequestHttp(url);
            ParseUserJson(jsonStr);// listview에 출력
        }

        private void initListView()
        {
            editGroupBox.Visible = false;
            JobListView.Clear();
            JobListView.Columns.Clear();
            JobListView.View = View.Details;
            // Add columns
            JobListView.Columns.Add("아이디", 100, HorizontalAlignment.Left);
            JobListView.Columns.Add("JOB명", 100, HorizontalAlignment.Left);
            JobListView.Columns.Add("상세설명", 100, HorizontalAlignment.Left);
            JobListView.Columns.Add("구분", 100, HorizontalAlignment.Left);
            JobListView.Columns.Add("SEQ", 100, HorizontalAlignment.Left);
            JobListView.Columns.Add("실행데이타", 100, HorizontalAlignment.Left);

            JobListView.Columns.Add("소유자", 100, HorizontalAlignment.Left);
            JobListView.Columns.Add("등록자", 100, HorizontalAlignment.Left);
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
                lvt.Text = itemObj["job_id"].ToString();
                lvt.SubItems.Add(itemObj["job_nm"].ToString());
                lvt.SubItems.Add(itemObj["job_desc"].ToString());
                lvt.SubItems.Add(itemObj["job_typ"].ToString());
                lvt.SubItems.Add(itemObj["job_seq"].ToString());
                lvt.SubItems.Add(itemObj["job_data"].ToString());
                lvt.SubItems.Add(itemObj["auth_user"].ToString());
                lvt.SubItems.Add(itemObj["reg_user"].ToString());
                lvt.SubItems.Add(itemObj["reg_dtm"].ToString());
                lvt.SubItems.Add(itemObj["upd_dtm"].ToString());

                JobListView.Items.Add(lvt);
            }


        }

        private void JobListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (JobListView.FocusedItem != null)
            {


                int selectedIndex = JobListView.FocusedItem.Index;
                int i = 0;
                edtJobID.Text = JobListView.Items[selectedIndex].SubItems[i++].Text;
                edtJobNm.Text = JobListView.Items[selectedIndex].SubItems[i++].Text;
                edtJobDesc.Text = JobListView.Items[selectedIndex].SubItems[i++].Text;
                edtJobTyp.SelectedItem = JobListView.Items[selectedIndex].SubItems[i++].Text;
                edtJobSeq.Text = JobListView.Items[selectedIndex].SubItems[i++].Text;
                edtJobData.Text = JobListView.Items[selectedIndex].SubItems[i++].Text;
                edtAuthUser.Text = JobListView.Items[selectedIndex].SubItems[i++].Text;

                edtRegUser.Text = JobListView.Items[selectedIndex].SubItems[i++].Text;
                edtRegDtm.Text = JobListView.Items[selectedIndex].SubItems[i++].Text;
                edtUpdDtm.Text = JobListView.Items[selectedIndex].SubItems[i++].Text;

                editGroupBox.Visible = true;
            }
        }


        private void initNewEditGroupBox()
        {

            edtJobID.Text = "";
            edtJobNm.Text = "";
            edtJobDesc.Text = "";
            edtJobTyp.Items.Clear();
            edtJobSeq.Text = "";
            edtJobData.Text = "";
            edtAuthUser.Text = "";

            edtRegUser.Text = ""; edtRegUser.ReadOnly = false;
            edtRegDtm.Text = "";
            edtUpdDtm.Text = "";

            editGroupBox.Text = "신규등록";

            editGroupBox.Visible = true;

        }

        //JOB 저장
        private void JobSaveBtn_Click(object sender, EventArgs e)
        {
            String MsgTitle = "신규등록하시겠습니까?";

            string url = "http://"+ ConnectionConstants.HostName + ":18080/";
            string apiname = "insertJob";
            if (editGroupBox.Text.Equals("정보수정"))
            {
                apiname = "updateJobInfo";
                MsgTitle = "수정 하시겠습니까?";
            }
            MsgTitle = edtJobNm.Text + "의 정보를  " + MsgTitle;
            DialogResult dialogResult = MessageBox.Show(MsgTitle, "JOB", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string param = "jobId=" + edtJobID.Text;
                param += "&jobNm=" + edtJobNm.Text;
                param += "&jobDesc=" + edtJobDesc.Text;
                param += "&jobTyp=" + edtJobTyp.Text;
                param += "&jobData=" + edtJobData.Text;
                param += "&authUser=" + edtAuthUser.Text;
                param += "&regUser=" + edtRegUser.Text;

                url = url + apiname + "?" + param;
                String jsonStr = HttpUtil.RequestHttp(url);

                JObject jboj = JObject.Parse(jsonStr);
                int i = 0;
                bool result = int.TryParse(jboj["result_cnt"].ToString(), out i);
                if (i > 0)
                {
                    searchJob();

                }
                else
                {
                    MessageBox.Show("실패했음");
                }
            }
        }


        private void initUpdEditGroupBox()
        {
            edtJobID.Text = ""; edtRegUser.ReadOnly = true;
            edtJobNm.Text = "";
            edtJobDesc.Text = "";

            edtJobTyp.Items.Clear();
            edtJobTyp.Items.Add("RST");
            edtJobTyp.Items.Add("PY");
            edtJobSeq.Text = "";
            edtJobData.Text = "";
            edtAuthUser.Text = "";

            edtRegUser.Text = ""; edtRegUser.ReadOnly = true;
            edtRegDtm.Text = "";
            edtUpdDtm.Text = "";

            editGroupBox.Text = "정보수정";


        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            initNewEditGroupBox();
        }

        private void FormJobMgmt_Load(object sender, EventArgs e)
        {
            initUpdEditGroupBox();
            editGroupBox.Visible = false;
        }

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            String MsgTitle = "정말 삭제하실건가요?";
            MsgTitle = edtJobNm.Text + "의 정보를  " + MsgTitle;
            DialogResult dialogResult = MessageBox.Show(MsgTitle, "JOB", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string url = "http://" + ConnectionConstants.HostName + ":18080/";
                string apiname = "deleteJob";
                string param = "jobId=" + edtJobID.Text;



                url = url + apiname + "?" + param;
                String jsonStr = HttpUtil.RequestHttp(url);

                JObject jboj = JObject.Parse(jsonStr);
                int i = 0;
                bool result = int.TryParse(jboj["result_cnt"].ToString(), out i);
                if (i > 0)
                {
                    initUpdEditGroupBox();
                    searchJob();

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

        private void BtnTest_Click(object sender, EventArgs e)
        {
            if (edtJobTyp.Text.Equals("PY"))// python 테스트
            {
                string result = AgentExecutor.DoPython("");
                MessageBox.Show(result);
             /*   String filePythonExePath = "C:\\Users\\summy\\AppData\\Local\\Programs\\Python\\Python37 - 32\\Python.exe";
                IMLSharpPython mlSharpPython = new MLSharpPython(filePythonExePath);

                string standardError;
                String result= mlSharpPython.ExecutePythonScript(edtJobData.Text ,  out standardError);
                if (string.IsNullOrEmpty(standardError))
                {


                    Console.WriteLine("result :"+result);
                     MessageBox.Show(result);

                }
                else
                {
                    Console.WriteLine(standardError);
                }
               */

            }
            else if (edtJobTyp.SelectedText.Equals("RST"))// http request 테스트
            {

            }
        }


    }
}
