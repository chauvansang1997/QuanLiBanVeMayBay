using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using System.Data;

namespace BUS
{
    public class User_BUS
    {
        private static User_BUS instance;

       public static User_BUS Instance
       {
            get
            {
                if (instance == null)
                    instance = new User_BUS();
                return instance;
            }          
       }
        public bool DangNhap(string _userName,string _password)
        {

            return DAO.User_DAO.Instance.XemChuyenBay(_userName,_password);
        }
        public DataTable DangNhap1(string txtUserName, string txtPassword)
        {

            return User_DAO.Instance.XemChuyenBay1(txtUserName,txtPassword);
        }
    }
}
