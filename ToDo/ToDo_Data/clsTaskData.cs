using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class clsTaskData
    {
        public static DataTable GetTasks()
        {
            DataTable TasksTable = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"select * from Tasks";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) { 
                    TasksTable.Load(reader);
                }

                reader.Close();
            }

            catch { return new DataTable(); }

            finally { connection.Close(); }

            return TasksTable;
        }

        public static int AddTask(string TaskName, string TaskDescription, bool Important, bool Urgent)
        {
            SqlConnection connection = new SqlConnection(clsDataSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[Tasks]
           ([Task]
           ,[TaskDecription]
           ,[Important]
           ,[Urgent]
           ,[IssueDate])
     VALUES
           (@Task
           ,@TaskDecription
           ,@Important
           ,@Urgent
           ,GETDATE());
            select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Task", TaskName);
            command.Parameters.AddWithValue("@TaskDecription", clsDataSettings.HandleEmptyStrings(TaskDescription));
            command.Parameters.AddWithValue("@Urgent", Convert.ToByte(Urgent));
            command.Parameters.AddWithValue("@Important", Convert.ToByte(Important));

            int TaskID = -1;
            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (int.TryParse(result.ToString(), out TaskID))
                {

                }


            }

            catch (Exception ex) { }

            finally { connection.Close(); }

            return TaskID;
        }
    }
}
