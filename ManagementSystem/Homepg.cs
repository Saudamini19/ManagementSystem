using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class Homepg : Form
    {
        public Homepg()
        {
            InitializeComponent();
        }

        private void addDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TrainingModule tmod = new TrainingModule();
            //tmod.Show();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainerDetails tdeet = new TrainerDetails();
            tdeet.Show();
        }

        private void updateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AssociateDetails adeet = new AssociateDetails();
            adeet.Show();
        }

        private void deleteDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BatchDetails bdeet = new BatchDetails();
            bdeet.Show();
        }

        private void associateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetAssociate geta = new GetAssociate();
            geta.Show();
        }

        private void batchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetBatch getb = new GetBatch();
            getb.Show();
        }

        private void trainerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetTrainer gett = new GetTrainer();
            gett.Show();
        }
    }
}
