using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            frmShowTasks TasksList = new frmShowTasks(true, true);
            TasksList.ShowDialog();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            frmShowTasks TasksList = new frmShowTasks(true, false);
            TasksList.ShowDialog();
        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            frmShowTasks TasksList = new frmShowTasks(false, true);
            TasksList.ShowDialog();
        }

        private void btnEliminate_Click(object sender, EventArgs e)
        {
            frmShowTasks TasksList = new frmShowTasks(false, false);
            TasksList.ShowDialog();
        }
    }
}
