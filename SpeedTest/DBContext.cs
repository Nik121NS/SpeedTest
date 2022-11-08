using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;

namespace SpeedTest
{
    internal static class DBContext
    {
        public static string getText(string sql)
        {
            string answer = "";
            DataTable dataTable = new DataTable();
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Desktop\\Учеба (Никита)\\Шарапов\\SpeedTest\\SpeedTest\\Database.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(@connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    
                    while (reader.Read()) 
                    {
                        object id = reader.GetValue(0);
                        object text = reader.GetValue(1);
                        answer = text.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return answer;
        }

        public static void setRecord(string nickName,int record)
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Desktop\\Учеба (Никита)\\Шарапов\\SpeedTest\\SpeedTest\\Database.mdf;Integrated Security=True";
            string sql = string.Format("INSERT INTO Players" +
                  "(Nickname,Record) VALUES(@nickName, @record)");
            using (SqlConnection conn = new SqlConnection(@connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.Parameters.AddWithValue("@nickName", nickName);
                    command.Parameters.AddWithValue("@record", record);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void fillTableFromBD(DataGridView dataGridView)
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\Desktop\\Учеба (Никита)\\Шарапов\\SpeedTest\\SpeedTest\\Database.mdf;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(@connString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Players", conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
