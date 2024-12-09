using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace ToDo.Task
{
    public partial class frmAddUpdateTask : Form
    {
        enum enMode { Add, Update };
        enMode Mode;

        private bool _Important, _Urgent;
        private Logic.clsTaskLogic _Task = new Logic.clsTaskLogic();

        public frmAddUpdateTask(bool Important, bool Urgent)
        {
            _Important = Important;
            _Urgent = Urgent;
            Mode = enMode.Add;

            InitializeComponent();
        }

        public frmAddUpdateTask(int TaskID){ 
            
            InitializeComponent();
            Mode = enMode.Update;
        }
        private void txtTaskName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaskName.Text)) { 
            
                e.Cancel = true;
                txtTaskName.Focus();
                errorProvider1.SetError(txtTaskName, "this faild is required");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtTaskName, null);
            }
        }

        private void frmAddUpdateTask_Load(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                //load task data
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                _Task.TaskName = txtTaskName.Text;
                _Task.TaskDescription = txtTaskDescription.Text;
                _Task.Important = _Important;
                _Task.Urgent = _Urgent;

                if (_Task.Save()) { 
                    MessageBox.Show("Data Saved Succefully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Data Didn't Save Succefully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("The Failed With Red Icon(s) Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
