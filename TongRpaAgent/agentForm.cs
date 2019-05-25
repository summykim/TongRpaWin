using log4net;
using MqAgent;
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
using TongRpaCommon.Executor;
using TongRpaCommon.Model;
using TongRpaCommon.RabbitMq;
using TongRpaCommon.Utils;

namespace TongRpaAgent
{
    public partial class agentForm : Form
    {
        private ILog logger = LogManager.GetLogger(typeof(agentForm));
        BackgroundWorker bgAgentWorker;
        private static int msg_cnt = 0;
        public agentForm()
        {
            InitializeComponent();
            startAgent.Text = "START";

            if (logger.IsDebugEnabled)
            {
                logger.Debug(this.ToString() + " 인스턴스 생성");
            }


            // Mac 주소 조회
            MacAddr.Text = DeviceUtil.GetMacAddress();
            if (MacAddr.Text == "")
            {
                MessageBox.Show("네트워크에 연결된 Mac주소를 찾을수가 없네요.");
                this.Close();
                return;
            }
            logger.Debug("MacAddr :" + MacAddr.Text);

        }

        [Obsolete]
        private void StartAgent_Click(object sender, EventArgs e)
        {
            if (startAgent.Text == "STOP")
            {
                DialogResult dr=MessageBox.Show("통선임RPA를 중지할까요?", "통선임RPA", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                {
                    bgAgentWorker.CancelAsync();//백그라운드작업 취소
                    startAgent.Text = "START";

                    /* Mq 수신 시작 알림 */
                    MqSendHealthVo msVo = new MqSendHealthVo();
                    msVo.agent_id = AgentId.Text;
                    msVo.agent_status = "DOWN";
                    msVo.res_typ = "RES";
                    RabbitProducer.Connect();
                    RabbitProducer.MqSendMessages(AgentId.Text, msVo.toJson());
                    RabbitProducer.Disconnect();
                    logger.Info("agent_id : " + msVo.agent_id + " DOWN ..... ");



                }
                return;

            }




            // Agent ID  조회
            Agent aginfo= AgentService.getAgentInfo(MacAddr.Text);
            if (aginfo == null )
            {
                MessageBox.Show("Mac주소를 확인하세요");
                return;
            }

            AgentId.Text=aginfo.agent_id;
            logger.Debug(". :" + AgentId.Text);

            startMq(AgentId.Text);


        }

        [Obsolete]
        private void startMq(String ageintId)
        {
            RabbitConsumer.Connect(ageintId);
            RabbitConsumer.ConsumeMessagesStart(ageintId);

             bgAgentWorker = new BackgroundWorker();


            //ReportProgress메소드를 호출하기 위해서 반드시 true로 설정, false일 경우 ReportProgress메소드를 호출하면 exception 발생
            bgAgentWorker.WorkerReportsProgress = true;

            //스레드에서 취소 지원 여부
            bgAgentWorker.WorkerSupportsCancellation = true;

            //스레드가 run시에 호출되는 핸들러 등록
            bgAgentWorker.DoWork += new DoWorkEventHandler(bw_DoWork);


            // ReportProgress메소드 호출시 호출되는 핸들러 등록
            bgAgentWorker.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);


            // 스레드 완료(종료)시 호출되는 핸들러 동록
            bgAgentWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);

            bgAgentWorker.RunWorkerAsync();

            /* Mq 수신 시작 알림 */
            MqSendHealthVo msVo = new MqSendHealthVo();
            msVo.agent_id = ageintId;
            msVo.agent_status = "IDLE";
            msVo.res_typ ="RES";
            RabbitProducer.Connect();
            RabbitProducer.MqSendMessages(ageintId, msVo.toJson());
            RabbitProducer.Disconnect();
            logger.Info("agent_id : " + msVo.agent_id + " IDLE.. ");

            startAgent.Text = "STOP";
            this.Visible = false;
            trayIcon.Visible = true;
        }

        [Obsolete]
        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker worker = sender as BackgroundWorker;
            
            // Loop 
            while (true)
            {
                
                
                //CancellationPending 속성이 true로 set되었다면(위에서 CancelAsync 메소드 호출 시 true로 set된다고 하였죠?
                if ((worker.CancellationPending == true))
                {
                    //루프를 break한다.(즉 스레드 run 핸들러를 벗어나겠죠)
                    e.Cancel = true;
                    break;
                }
                else
                {
                    //메시지 수신

                    MqRecvVo mrvo = RabbitConsumer.getRevcMessages();
                    if (mrvo != null)
                    {
                        logger.Debug("bw_DoWork req_typ : " + mrvo.req_typ);
                        worker.ReportProgress(0, mrvo);
                        

                    }

                    System.Threading.Thread.Sleep(500);

                }
            }
        }

        // Agent 업무처리
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            msg_cnt++;
            txtStatusBar.Text = msg_cnt + "건 처리중";
            MqRecvVo mrvo = (MqRecvVo)e.UserState;
            logger.Debug("ProgressChanged req_typ : " + mrvo.req_typ);
            if (mrvo.req_typ == "HLTH")
            {
                
                MqSendHealthVo msVo = new MqSendHealthVo();
                msVo.agent_id = mrvo.agent_id;
                msVo.agent_status = RabbitConsumer.AgentStatus;
                msVo.res_typ = mrvo.req_typ;
                RabbitProducer.Connect();
                RabbitProducer.MqSendMessages(mrvo.agent_id, msVo.toJson());
                RabbitProducer.Disconnect();
                logger.Debug("agent_id : " + msVo.agent_id);
            }
            else
            {
                //실행시작
                MqSendVo msVo = new MqSendVo();
                msVo.res_typ = "RLT";
                msVo.agent_id = mrvo.agent_id;
              
                msVo.agent_status = "BUSY";
                msVo.job_status = "ING";
                msVo.rlt_data = "";
                msVo.exec_req_id = mrvo.exec_req_id;
                logger.Debug("ProgressChanged exec start  : " + msVo.toJson());
                RabbitConsumer.AgentStatus = msVo.agent_status;
                logger.Debug("ProgressChanged AgentStatus : " + RabbitConsumer.AgentStatus);
                //상태변경
                RabbitProducer.Connect();
                RabbitProducer.MqSendMessages(mrvo.agent_id, msVo.toJson());
                RabbitProducer.Disconnect();
                // 작업실행
                String result= AgentExecutor.Execute(mrvo.req_typ, mrvo.req_data ,mrvo.job_tmout);

                msVo.agent_status = "IDLE";
                msVo.job_status = "CMP";
                msVo.rlt_data = result;
 
                logger.Debug("ProgressChanged exec result : " + msVo.toJson());
                RabbitConsumer.AgentStatus = msVo.agent_status;
                logger.Debug("ProgressChanged AgentStatus : " + RabbitConsumer.AgentStatus);
                //결과전송
                RabbitProducer.Connect();
                RabbitProducer.MqSendMessages(mrvo.agent_id, msVo.toJson());
                RabbitProducer.Disconnect();



            }
            txtStatusBar.Text = msg_cnt + "건 처리완료";
        }

        //스레드의 run함수가 종료될 경우 해당 핸들러가 호출됩니다.
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RabbitConsumer.DisConnect();
            logger.Info(" RabbitConsumer.DisConnect ");
        }

        // 폼 표시
        private void OpenTrayForm_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            trayIcon.Visible = false;
        }

        // agent 닫기 
        private void CloseTrayForm_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("통선임RPA 프로그램을 종료할까요?", "통선임RPA", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                Application.ExitThread();
                Application.Exit();
            }

        }

        // tray 표시
        private void AgentForm_Resize(object sender, EventArgs e)
        {
            this.Visible = false;
            trayIcon.Visible = true;
        }

        private void AgentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Visible = false;
                trayIcon.Visible = true;
            }
        }

        private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            trayIcon.Visible = false;
        }
    }
}
