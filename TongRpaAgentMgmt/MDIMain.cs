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
    public partial class MDIMain : Form
    {
        private int childFormNumber = 0;

        public MDIMain()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "창 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }



        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void JOBToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MDIMain_Load(object sender, EventArgs e)
        {

        }
        //JOB 정보관리 폼 호출
        private void JobMgmtMenu_Click(object sender, EventArgs e)
        {
            FormJobMgmt FUM = new FormJobMgmt();
            FUM.MdiParent = this;
            FUM.Show();
            FUM.WindowState = 0;
        }
        //Agent정보관리 폼 호출
        private void AgentMgmtMenu_Click(object sender, EventArgs e)
        {
            FormAgentMgmt FUM = new FormAgentMgmt();
            FUM.MdiParent = this;
            FUM.Show();
            FUM.WindowState = 0;
        }
        //사용자 정보관리 폼 호출
        private void UserMgmtMenu_Click(object sender, EventArgs e)
        {
            FormUserMgmt FUM = new FormUserMgmt();
            FUM.MdiParent = this;
            FUM.Show();
            FUM.WindowState = 0;



        }

        private void JobReqMonMenu_Click(object sender, EventArgs e)
        {
            FormJobExecReqMon FUM = new FormJobExecReqMon();
            FUM.MdiParent = this;
            FUM.Show();
            FUM.WindowState = 0;
        }
    }
}
