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
    public class User_DAO
    {
        private static User_DAO instance;

        public static User_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new User_DAO();
                return instance;
            }

        }
        public bool XemChuyenBay(string userName,string passWord)
        {


            string query = "Select * from DangNhap Where UserName=@UserName AND Password =@PassWord";
            

            List<SqlParameter> sqlParameter = new List<SqlParameter>()
            {
                new SqlParameter("@UserName",SqlDbType.Char){ SqlValue=userName},
                new SqlParameter("@PassWord",SqlDbType.Char){ SqlValue=passWord},
            };


            DataTable table = Dataprovider.Instance.ExcuteQuery(query, sqlParameter.ToArray());
            if (table.Rows.Count == 1)
            {
                return true;
            }
            return false;
        }
        public DataTable XemChuyenBay1(string userName, string passWord)
        {


            string query1 = "Select * from DangNhap " +
                           "Where UserName= " + userName + " AND " + " Password = " + passWord;
            string query = @"SELECT * FROM DangNhap where UserName = 'ChauVanSang' and Password = '1234' or 1 = 1";
            return Dataprovider.Instance.ExcuteQuery(query1);
            
        }
    }
}
