using System;
using System.Collections.Generic;
using System.Data;
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
          

            string query = "Select * from DangNhap " +
                            "Where UserName= "+userName+" AND "+ " Password = " + passWord;
            string query1 =  @"SELECT * FROM DangNhap where UserName = 'ChauVanSang' and Password = '1234' or 1 = 1";
            if (Dataprovider.Dataprovider.Instance.ExcuteNonQuery(query1) > 0)
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
            return Dataprovider.Dataprovider.Instance.ExcuteQuery(query1);
            
        }
    }
}
