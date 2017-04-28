using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    class User_DAO
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
        public bool XemChuyenBay(TextBox userName,TextBox passWord)
        {
          

            string query = "Select * from USer " +
                            "Where UserName= "+userName.Text+"AND "+"Password= " +passWord.Text;

            if (Dataprovider.Dataprovider.Instance.ExcuteNonQuery(query) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
