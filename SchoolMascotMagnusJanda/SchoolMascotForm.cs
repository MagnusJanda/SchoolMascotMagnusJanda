using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMascotMagnusJanda
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void schoolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void magicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMagic.Text = "Orlando Magic";
        }

        private void celticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMagic.Text = "Boston Celtics";
        }

        private void nuggetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMagic.Text = "Denver Nuggets";
        }

        private void bucksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMagic.Text = "Milwakee Bucks";
        }

        private void raptorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMagic.Text = "Toronto Raptors";
        }

        private void lakersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMagic.Text = "LA Lakers";
        }

        private void clipppersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMagic.Text = "LA Clippers";
        }

        private void kingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMagic.Text = "Sacremento Kings";
        }

        private void sunsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMagic.Text = "Pheonix Suns";
        }

        private void hawksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMagic.Text = "Atlanta Hawks";
        }

        private void heatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMagic.Text = "Miami Heat";
        }

        private void hornetsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lblMagic.Text = "Charlotte Hornets";
        }

        private void rocketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMagic.Text = "Houston Rockets";
        }

        private void spursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblMagic.Text = "San Antonio Spurs";
        }
    }
}
