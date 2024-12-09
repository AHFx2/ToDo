using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Logic
{
    public class clsTaskLogic
    {


        enum enMode { Add, Update };
        enMode Mode;

        public int TaskID { get; set; }
        public string TaskName { get; set; }

        public string TaskDescription { get; set; }
        public bool Important { get; set; }
        public bool Urgent { get; set; }


        public clsTaskLogic()
        {
            this.TaskID = -1;
            this.TaskName = string.Empty;
            this.TaskDescription = string.Empty;
            this.Important = false;
            this.Urgent = false;
            Mode = enMode.Add;
        }

        public clsTaskLogic(int TaskID ,string TaskName, string TaskDescription, bool Important, bool Urgent)
        {
            this.TaskID = TaskID;
            this.TaskName = TaskName;
            this.TaskDescription = TaskDescription;
            this.Important = Important;
            this.Urgent = Urgent;
            Mode = enMode.Update;
        }

        private bool _AddTask()
        {
            this.TaskID = Data.clsTaskData.AddTask(this.TaskName ,this.TaskDescription, this.Important, this.Urgent);
            return this.TaskID != -1;
        }

        public static DataTable GetTasks()
        {
            return Data.clsTaskData.GetTasks();
        }

        public bool Save()
        {
            switch (this.Mode) { 
            
                case enMode.Add:
                    if (_AddTask()) {
                        Mode = enMode.Update;
                        return true;
                    }
                    return false;   


                case enMode.Update:
                    return false;


                default:
                    return false;
            }
        }
    }
}
