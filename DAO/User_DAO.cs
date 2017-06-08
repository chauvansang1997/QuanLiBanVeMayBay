using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public static class User_DAO
    {
        
        public static int DangNhap(string userName,string passWord)
        {


            string query = " EXEC usp_DangNhap @userName,@matkhau";
            


            List<SqlParameter> sqlParameter = new List<SqlParameter>()
            {
                new SqlParameter("@userName",SqlDbType.Char){ SqlValue=userName},

                new SqlParameter("@matkhau",SqlDbType.Char){ SqlValue=passWord},

            };
            int temp=-1;
            try
            {
                object obj = Dataprovider.ExcuteScalar(query, sqlParameter.ToArray());
                if (obj != null)
                {
                    if ((bool)obj)
                    {
                        temp = 1;
                    }
                    else
                    {
                        temp = 0;
                    }
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
           
            
            return temp;
        }

    }
}
