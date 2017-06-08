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
        public static bool ThayDoiMatKhau(string userName, string passWord)
        {
            return User_DAO.ThayDoiMatKhau(userName, passWord);
        }
        public static void Loaduser(string userName,string passWord)
        {
            User_DAO.LoadUser(userName,passWord);
        }
        public static int DangNhap(string _userName,string _password)
        {

            return User_DAO.DangNhap(_userName,_password);
        }
  
    }
}
