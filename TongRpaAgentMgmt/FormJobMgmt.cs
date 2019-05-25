
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
using TongRpaCommon.Executor;
using TongRpaCommon.Model;
using TongRpaCommon.Utils;

namespace TongRpaAgentMgmt
{
    public partial class FormJobMgmt : Form
    {
        public FormJobMgmt()
        {
            InitializeComponent();
        }

        private void FormJobMgmt_Load(object sender, EventArgs e)
        {
            initUpdEditGroupBox();
            editGroupBox.Visible = false;

            // 사용자 목록 넣기 
            List<User> usrList=UserService.getUserList("", "");
            for(int i=0;i< usrList.Count; i++)
            {
                User userInfo = usrList[i];
                cboUserList.Items.Add(userInfo.user_id + "(" + userInfo.user_nm+")");
                
            }
            cboUserList.SelectedIndex = 0;
        }

        // 사용자 코드 분리
        private string getSelectedUserId(string UserInfo)
        {
            string [] usrinfo=UserInfo.Split('(');
            return usrinfo[0];
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            searchJobList();
        }
        //검색
        private void searchJobList()
        {

            List<Job> jobList =JobService.getJobList(getSelectedUserId((string)cboUserList.SelectedItem),searchText.Text,txtJobId.Text );
            DrawListView(jobList);
        }

        //상세정보 초기화
        private void initUpdEditGroupBox()
        {
            edtJobID.Text = "";
            edtJobNm.Text = "";
            edtJobDesc.Text = "";

            edtJobTyp.Items.Clear();
            edtJobTyp.Items.Add("파이썬스크립트");
            edtJobTyp.Items.Add("REST_API");
            edtJobTyp.SelectedIndex = 0;
            edtJobData.Text = "";
            editGroupBox.Text = "정보수정";


        }

        private string getTypeCode(string code)
        {
            string resultStr = "";
            if (code == "RST") resultStr = "REST_API";
            else if (code == "PY") resultStr = "파이썬스크립트";
            else if (code == "파이썬스크립트") resultStr = "PY";
            else if (code == "REST_API") resultStr = "RST";

            return resultStr;
        }
        // Listveiw 초기화
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
            JobListView.Columns.Add("실행데이타", 0, HorizontalAlignment.Left);
            JobListView.Columns.Add("타임아웃", 50, HorizontalAlignment.Left);
            JobListView.Columns.Add("SEQ", 50, HorizontalAlignment.Left);
            JobListView.Columns.Add("등록자", 100, HorizontalAlignment.Left);
            JobListView.Columns.Add("등록일시", 200, HorizontalAlignment.Left);
            JobListView.Columns.Add("수정일시", 200, HorizontalAlignment.Left);
        }
        private void DrawListView(List<Job> jobList)
        {
            initListView();



            for (int i = 0; i < jobList.Count; i++)
            {
                Job info = jobList[i];
                ListViewItem lvt = new ListViewItem();
                lvt.Text = info.job_id;
                lvt.SubItems.Add(info.job_nm);
                lvt.SubItems.Add(info.job_desc);
                lvt.SubItems.Add(getTypeCode(info.job_typ));
                lvt.SubItems.Add(info.job_data);
                lvt.SubItems.Add(info.job_tmout);
                lvt.SubItems.Add(info.job_seq);
                lvt.SubItems.Add(info.reg_user);
                lvt.SubItems.Add(info.reg_dtm);
                lvt.SubItems.Add(info.upd_dtm);
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
                edtJobData.Text = JobListView.Items[selectedIndex].SubItems[i++].Text;
                edtJobTmout.Text = JobListView.Items[selectedIndex].SubItems[i++].Text;
                editGroupBox.Visible = true;
                editGroupBox.Text = "정보수정";
            }
        }

        // 스크립트 테스트
        private void BtnTest_Click(object sender, EventArgs e)
        {
            if (getTypeCode(edtJobTyp.Text)=="PY")// python 테스트
            {
                int timeout = 0;
                if(int.TryParse(edtJobTmout.Text,out timeout))
                {
                    timeout = timeout * 1000;
                }
                else
                {
                    timeout = 5000;
                }
                string result = AgentExecutor.Execute(getTypeCode(edtJobTyp.Text) ,edtJobData.Text, timeout);
                MessageBox.Show(result);


            }
            else if (getTypeCode(edtJobTyp.Text)=="RST")// http request 테스트
            {

            }
        }


        private void initNewEditGroupBox()
        {

            edtJobID.Text = "";
            edtJobNm.Text = "";
            edtJobDesc.Text = "";
            edtJobData.Text = "";
            editGroupBox.Text = "신규등록";

            editGroupBox.Visible = true;

        }

        //JOB 저장
        private void JobSaveBtn_Click(object sender, EventArgs e)
        {
            String MsgTitle = "신규등록하시겠습니까?";


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
                int checkI;
                bool result = int.TryParse(edtJobTmout.Text, out checkI); 
                if (!result)
                {
                    MessageBox.Show("타임아웃은 숫자를 입력해야합니다.");
                    edtJobTmout.Focus();
                    return;
                }

                Job jobInfo = new Job("");
                jobInfo.job_id = edtJobID.Text;
                jobInfo.job_nm = edtJobNm.Text;
                jobInfo.job_desc = edtJobDesc.Text;
                jobInfo.job_typ = getTypeCode(edtJobTyp.Text);
                jobInfo.job_data = edtJobData.Text;
                jobInfo.job_tmout = edtJobTmout.Text;
                jobInfo.auth_user = getSelectedUserId(cboUserList.Text);
                jobInfo.reg_user = Session.LoginUserInfo.user_id;


                int resultCnt = 0;
                if(apiname == "insertJob")
                {
                    resultCnt = JobService.InsertJob(jobInfo);
                }
                else
                {
                    resultCnt = JobService.updateJob(jobInfo);
                }
               

                if (resultCnt > 0)
                {

                    searchJobList();
                }
                else
                {
                    MessageBox.Show("실패했음");
                }
            }
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            initNewEditGroupBox();
        }


        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            String MsgTitle = "정말 삭제하실건가요?";
            MsgTitle = edtJobNm.Text + "의 정보를  " + MsgTitle;
            DialogResult dialogResult = MessageBox.Show(MsgTitle, "JOB", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Job jobInfo = new Job("");
                jobInfo.job_id = edtJobID.Text;
                int resultCnt= JobService.deleteJob(jobInfo);


                if (resultCnt > 0)
                {
                    initUpdEditGroupBox();
                    searchJobList();

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

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtJobId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void CboUserList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

 
    }
}
