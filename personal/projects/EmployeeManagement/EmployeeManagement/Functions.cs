using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable Dt;
        private SqlDataAdapter Sda;
        private string ConnectionString;

        public Functions()
        {
            string oneDrivePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\OneDrive";
            string dbPath = oneDrivePath + @"\Работен плот\Valeri_work\ТУ\6semester\.NET_development\personal\projects\EmployeeManagement\EmployeeDB.mdf";
            ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbPath};Integrated Security=True;Connect Timeout=30";

            Con = new SqlConnection(ConnectionString);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }

        public DataTable GetData(string Query)
        {
            Dt = new DataTable();
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                Sda = new SqlDataAdapter(Query, Con);
                Sda.Fill(Dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            return Dt;
        }

        public int setData(string Query)
        {
            int count = 0;
            try
            {
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }

                Cmd.CommandText = Query;
                count = Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            return count;
        }
    }
}
