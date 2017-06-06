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
    public static class User_BUS
    {
        
        public static bool DangNhap(string _userName,string _password)
        {

            return DAO.User_DAO.XemChuyenBay(_userName,_password);
        }
        public static DataTable DangNhap1(string txtUserName, string txtPassword)
        {

            return User_DAO.XemChuyenBay1(txtUserName,txtPassword);
        }
    }
}
