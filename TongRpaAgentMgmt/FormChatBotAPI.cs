using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using TongRpaCommon.ApiService;
using TongRpaCommon.Model;

namespace TongRpaAgentMgmt
{
    public partial class FormChatBotAPI : Form
    {


        public FormChatBotAPI()
        {
            InitializeComponent();
        }

        private void JobListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnUserCheck_Click(object sender, EventArgs e)
        {
           bool result= ChBotApiService.checkUser(txtChBotKey.Text);
            if (result)
            {
               DialogResult dr=  MessageBox.Show("로그인되었습니다.\n 가능한 JOB을 검색할까요?", "사용자인증", MessageBoxButtons.OKCancel);
                if(dr== DialogResult.OK)//검색실행
                {
                    jobSearch();
                }
            }
            else
            {
               MessageBox.Show("회원가입이 필요합니다..\n 이메일을 입력하시고 가입처리 버튼을 눌러주세요.", "회원가입");

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            jobSearch();
        }

        private void jobSearch()
        {
            List<Job> result = ChBotApiService.searchJobList(txtChBotKey.Text);
            DrawListView(result);
        }

        // Listveiw 초기화
        private void initListView()
        {

            JobListView.Clear();
            JobListView.Columns.Clear();
            JobListView.View = View.Details;
            // Add columns
            JobListView.Columns.Add("아이디", 0, HorizontalAlignment.Left);
            JobListView.Columns.Add("JOB명", 200, HorizontalAlignment.Left);
            JobListView.Columns.Add("상세설명",300, HorizontalAlignment.Left);
            JobListView.Columns.Add("구분", 100, HorizontalAlignment.Left);
            JobListView.Columns.Add("실행데이타",100, HorizontalAlignment.Left);

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
                lvt.SubItems.Add(info.job_typ);
                lvt.SubItems.Add(info.job_data);

                JobListView.Items.Add(lvt);
            }


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool result = ChBotApiService.userSignUp(txtChBotKey.Text,txtUserEmail.Text );
            if (result)
            {
               MessageBox.Show("회원가입 처리되었습니다.?", "회원가입");
 
            }
            else
            {
                MessageBox.Show("이메일정보가 존재하지 않습니다.", "회원가입");

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(JobListView.SelectedItems.Count == 0)//선태된 job 없으면
            {
                MessageBox.Show("실행할 JOB을 선택하세요.");
            }
            else
            {
                string jobId = JobListView.SelectedItems[0].Text;
                string resultUrl=ChBotApiService.jobExecReq(jobId);
                txtResultUrl.Text = resultUrl;
                if (resultUrl == "")
                {
                    MessageBox.Show("JOB 실행 요청에 실패했습니다..");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("JOB 실행 요청에 성공했습니다.\n 결과를 웹브라우저로 확인할까요?", "JOB 실행 요청", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)// 웹에 표시
                    {
                        callWebRequest(resultUrl);
                    }
                }
            }
        }

        private void callWebRequest(string url)
        {

            System.Diagnostics.Process.Start(url);

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            callWebRequest(txtResultUrl.Text);
        }
    }
}
