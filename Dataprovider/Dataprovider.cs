using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dataprovider
{
    class Dataprovider
    {
        private string connectionString = @"Data Source=.\sqlexpress;Initial Catalog=QuanLyBanVeMayBay;Integrated Security=True";

        private static Dataprovider instance;

        public static Dataprovider Instance
        {
            get
            {
                if (instance == null)
                    instance = new Dataprovider();
                return instance;
            }

            private set => instance = value;
        }

        private Dataprovider()
        {

        }
        public DataTable ExcuteQuery(string query,SqlParameter[] sqlparameters = null)
        {
            DataTable table = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddRange(sqlparameters);

                SqlDataAdapter adapter = new SqlDataAdapter(command);



                adapter.Fill(table);

                con.Close();
            }

            
            return table;
        }
        public int ExcuteNonQuery(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, con);

                
                con.Close();

                return command.ExecuteNonQuery();
            }

        }
        public int ExcuteScaler(string query)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, con);

                con.Close();

                return command.ex
            }
        }
    }
}
