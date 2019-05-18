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

namespace TongRpaAgent
{
    public partial class agentForm : Form
    {

        public agentForm()
        {
            InitializeComponent();
        }

        private void StartAgent_Click(object sender, EventArgs e)
        {



            RabbitConsumer.Connect("agent.pc1.*");
            RabbitConsumer.ConsumeMessagesStart();

            BackgroundWorker bgAgentWorker = new BackgroundWorker();


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
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            Boolean isAgentAlive = true;
            int msg_cnt = 0;
            // Loop 
            while (isAgentAlive)
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

                    string msg= RabbitConsumer.getMessages();
                    if (msg != null)
                    {
                        worker.ReportProgress(++msg_cnt);
                        

                    }

                    System.Threading.Thread.Sleep(500);
                    // 스레드 진행상태 보고 - 이 메소드를 호출 시 위에서 
                    // bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged); 등록한 핸들러가 호출 됩니다.
                    //worker.ReportProgress((i * 10));
                }
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //바로 위에서 worker.ReportProgress((i * 10));호출 시 
            // bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged); 등록한 핸들러가 호출 된다고
            // 하였는데요.. 이 부분에서는 기존 Thread에서 처럼 Dispatcher를 이용하지 않아도 됩니다. 
            // 즉 아래처럼!!사용이 가능합니다.
            this.tbProgress.Text = (e.ProgressPercentage.ToString() + " 개 수신");

            // 기존의 Thread클래스에서 아래와 같이 UI 엘리먼트를 갱신하려면
            // Dispatcher.BeginInvoke(delegate() 
            // {
            //        this.tbProgress.Text = (e.ProgressPercentage.ToString() + "%");
            // )};
            //처럼 처리해야 할 것입니다. 그러나 바로 UI 엘리먼트를 업데이트 하고 있죠??
        }

        //스레드의 run함수가 종료될 경우 해당 핸들러가 호출됩니다.
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            //스레드가 종료한 이유(사용자 취소, 완료, 에러)에 맞쳐 처리하면 됩니다.s
            if ((e.Cancelled == true))
            {
                this.tbProgress.Text = "Canceled!";
            }

            else if (!(e.Error == null))
            {
                this.tbProgress.Text = ("Error: " + e.Error.Message);
            }

            else
            {
                this.tbProgress.Text = "Done!";
            }
        }


        private void MsgSend_Click(object sender, EventArgs e)
        {

            RabbitProducer.Connect();

            RabbitProducer.SendMessages("agent.result.pc1","에이전트 실행결과");
        }
    }
}
