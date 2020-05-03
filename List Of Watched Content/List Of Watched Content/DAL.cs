using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace List_Of_Watched_Content
{
    class DAL
    {
        public static int ErrorCode;
        public static DataTable ExecCommand(string command)
        {
            string myConString =
                "server = 77.102.93.95; port = 3306; uid = content_data; pwd = 6ubAjOBex1Tod5mIwIniCEqA2EpaDa; database = content_data";
            MySqlConnection conn = new MySqlConnection();
            MySqlDataAdapter adapter;
            DataTable myTable = new DataTable();
            ErrorCode = -1; //Invalid State // Resets State

            try
            {
                conn.ConnectionString = myConString;
                conn.Open();

                adapter = new MySqlDataAdapter(command, conn);
                adapter.Fill(myTable);
            }
            catch (MySqlException ex)
            {
                //int errorcode = ex.Number;
                //MessageBox.Show($"Invalid Username {errorcode}"); //Only Use When FINDING specific codes
                ErrorCode = ex.Number;
                string ErrorMessage = ex.Message;
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show($"MySQL({ex.Number}) Undiagonsed Error Occured!");
                        break;
                    case 1044:
                        MessageBox.Show($"MySQL({ex.Number}) Access denied for user.");
                        break;
                    case 1062:
                        MessageBox.Show($"MySQL({ex.Number}) Duplicate.");
                        break;
                }
            }
            finally
            {
                conn.Close();
            }

            return myTable;
        }
    }
}
