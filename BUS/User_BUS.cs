using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class User_BUS
    {
        private User_BUS instance;

       public User_BUS Instance
       {
            get
            {
                if (instance == null)
                    instance = new User_BUS();
                return instance;
            }          
       }
        public void DangNhap(TextBox txtUserName,TextBox txtPassword)
        {

        }
    }
}
