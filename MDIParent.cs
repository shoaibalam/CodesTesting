using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANUUFinance
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

      /*  private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        */
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

        private void sL1MasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSL1 objFrmSL1 = new frmSL1();
            objFrmSL1.ShowDialog();            
        }

        private void sL2MasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSL2 objFrmSL2 = new frmSL2();
            objFrmSL2.ShowDialog();
        }

        private void sL3MasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSL3 objFrmSL3 = new frmSL3();
            objFrmSL3.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bankMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBank objFrmBank = new frmBank();
            objFrmBank.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAccount objFrmAccount = new frmAccount();
            objFrmAccount.ShowDialog();
        }

        private void budgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBudget objFrmBudget = new frmBudget();
            objFrmBudget.ShowDialog();
        }

        private void billDespatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBillDespatch objFrmBillDespatch = new frmBillDespatch();
            objFrmBillDespatch.ShowDialog();
        }

        private void copyBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCloneDeptBudget objfrmCloneDeptBudget = new frmCloneDeptBudget();
            objfrmCloneDeptBudget.ShowDialog();
        }

        private void demonstrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDemonstration objFrmDemonstration = new frmDemonstration();
            objFrmDemonstration.ShowDialog();
        }
    }
}
