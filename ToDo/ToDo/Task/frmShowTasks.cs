using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDo.Task;
using ToDo.Properties;

namespace ToDo
{
    public partial class frmShowTasks : Form
    {
        private DataTable _dtTasks;
        string _Catagory;

        private bool _Important, _Urgent;
        public frmShowTasks(bool Important, bool Urgent)
        {
            InitializeComponent();
            _Important = Important;
            _Urgent = Urgent;
            
        }

        private void DetrminCatagory()
        {
            if (_Important) {

                if (_Urgent) { _Catagory = "Urgent and Important"; pbTasksIcon.Image = Properties.Resources.icons8_urgent_property_100; }
                else { _Catagory = "Not Urgent but Important"; pbTasksIcon.Image = Properties.Resources.Plan100; }
            }

            else
            {
                if (_Urgent) { _Catagory = "Urgent but Not Important"; pbTasksIcon.Image = Properties.Resources.icons8_delegate_100; }
                else { _Catagory = "Not Urgent And Not Important"; pbTasksIcon.Image = Properties.Resources.icons8_trush_100; }
            }
            _CenterLabelToPictureBox();

        }

        public void _LoadGridData(string Condition = "")
        {

            _dtTasks = Logic.clsTaskLogic.GetTasks();

            DataView dv = _dtTasks.DefaultView;

            if (Condition != "")
                dv.RowFilter = Condition;


            dgvTasks.Rows.Clear();
            foreach (DataRowView row in dv)
            {
                dgvTasks.Rows.Add(row["Task"], (row["TaskDecription"] == DBNull.Value)? "No Description :(" : row["TaskDecription"], _Catagory);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            frmAddUpdateTask AddNewTask = new frmAddUpdateTask(_Important, _Urgent);
            AddNewTask.ShowDialog();

            frmShowTasks_Load(null, null); 

        }

        private void pbTasksIcon_Click(object sender, EventArgs e)
        {

        }

        private void frmShowTasks_Load(object sender, EventArgs e)
        {
            DetrminCatagory();

            string _Condition = $"Important = {_Important} and Urgent = {_Urgent}";
            _LoadGridData(_Condition);
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _CenterLabelToPictureBox()
        {
            // Assuming `pictureBox1` is your PictureBox and `label1` is your Label.

            lblTitle.Text = _Catagory + " Tasks";
            int pictureLeft = pbTasksIcon.Left;
            int pictureTop = pbTasksIcon.Top;
            int pictureWidth = pbTasksIcon.Width;
            int pictureHeight = pbTasksIcon.Height;

            int labelWidth = lblTitle.Width;

            // Center the Label horizontally relative to the PictureBox
            lblTitle.Left = pictureLeft + (pictureWidth - labelWidth) / 2;

            // Position the Label below the PictureBox
            lblTitle.Top = pictureTop + pictureHeight + 10; // 10px spacing below the PictureBox
        }

      
    }
}
