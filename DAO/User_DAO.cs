using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
namespace DAO
{
    public static class User_DAO
    {
        public static bool ThayDoiMatKhau(string userName, string passWord)
        {
            string query = "EXEC usp_ThayDoiMatKhau @userName,@matkhau";

            List<SqlParameter> sqlParameter = new List<SqlParameter>()
            {
                new SqlParameter("@userName",SqlDbType.VarChar){ SqlValue=userName},

                new SqlParameter("@matkhau",SqlDbType.Char){ SqlValue=passWord},

            };
            return Dataprovider.ExcuteNonQuery(query, sqlParameter.ToArray()) > 0 ? true : false;
        }
        /// <summary>
        /// Load thông tin của người dùng hiện tại
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        public static void LoadUser(string userName,string passWord)
        {
            string query = "EXEC usp_LoadUser @userName,@matkhau";

            List<SqlParameter> sqlParameter = new List<SqlParameter>()
            {
                new SqlParameter("@userName",SqlDbType.VarChar){ SqlValue=userName},

                new SqlParameter("@matkhau",SqlDbType.VarChar){ SqlValue=passWord},

            };

            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query, sqlParameter.ToArray());
                DataRow row = table.Rows[0];
                User.UserName = row[0].ToString();
                User.Password = row[1].ToString();
                User.TenNhanVien = row[2].ToString();
                User.CMND = row[3].ToString();
                User.SoDienThoai = row[4].ToString();
                User.DiaChi = row[5].ToString();
            }
            catch (Exception)
            {

            }

        }
        /// <summary>
        /// Đăng nhập vào hệ thống
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="passWord"></param>
        /// <returns></returns>
        public static int DangNhap(string userName,string passWord)
        {


            string query = " EXEC usp_DangNhap @userName,@matkhau";
            


            List<SqlParameter> sqlParameter = new List<SqlParameter>()
            {
                new SqlParameter("@userName",SqlDbType.VarChar){ SqlValue=userName},

                new SqlParameter("@matkhau",SqlDbType.VarChar){ SqlValue=passWord},

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
