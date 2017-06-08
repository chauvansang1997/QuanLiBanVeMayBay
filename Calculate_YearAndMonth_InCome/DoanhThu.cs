using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_YearAndMonth_InCome
{
    public static class DoanhThu
    {
        public static void TinhDoanhThuThang(string _thang,string _nam)
        {
            string query = " EXEC usp_CapNhatChiTietDoanhThu @Thang,@Nam";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@Thang",System.Data.SqlDbType.VarChar){Value =_thang },
                new SqlParameter("@Thang",System.Data.SqlDbType.VarChar){Value =_nam },
            };
            try
            {
                DataProvider.Instance.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception)
            {

         
            }
            
        }

        public static void TinhDoanhThuNam(string _nam)
        {
            string query = " EXEC usp_CapNhatDoanhThuThang @Nam";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@Nam",System.Data.SqlDbType.VarChar){Value =_nam },
            };
            try
            {
                DataProvider.Instance.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception)
            {

     
            }
           
        }

        public static void CapNhatDoanhThuNam(string _nam)
        {
            string query = " EXEC usp_CapNhatDoanhThuNam @Nam";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@Nam",System.Data.SqlDbType.VarChar){Value =_nam },
            };
            try
            {
                DataProvider.Instance.ExcuteNonQuery(query, parameters.ToArray());
            }
            catch (Exception)
            {

          
            }
           
        }
        
    }
}
