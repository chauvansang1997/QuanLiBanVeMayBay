using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class SanBay_DAO
    {

        public static int DemSanBay(string _tenSanBay)
        {
            string query = "EXEC usp_DemSanBay @tenSanBay";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenSanBay",SqlDbType.NVarChar){IsNullable=true,Value=_tenSanBay ??(Object)DBNull.Value },
            };

            try
            {
                return (int)Dataprovider.ExcuteScalar(query, parameters.ToArray());
            }
            catch (Exception err)
            {

                Help_Fuction.HelpFuction.Log(err);
            }
            return 0;
        }
        public static bool ThemSanBay(string _tenSanBay)
        {
            string query = "EXEC usp_ThemSanBay @tenSanBay";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenSanBay",SqlDbType.NVarChar){Value=_tenSanBay },
            };
            try
            {
                if (Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0)
                {
                    return true;
                }
            }
            catch (Exception err)
            {

                Help_Fuction.HelpFuction.Log(err);
            }
            return false;

        }
        public static DataTable TimSanBay(string _tenSanBay)
        {
            string query = "EXEC usp_TimSanBay @tenSanBay";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenSanBay",SqlDbType.NVarChar){IsNullable=true,Value=_tenSanBay ??(Object)DBNull.Value },
            };

            return Dataprovider.ExcuteQuery(query, parameters.ToArray()); 
        }
        
        public static DataTable XemSanBay(int _page,int _pageSize)
        {
            DataTable sanbay = new DataTable();

            int PreviousPageOffSet = (_page - 1) * _pageSize;

            StringBuilder query = new StringBuilder();
            query.AppendFormat("SELECT TOP {0} * FROM SANBAY WHERE MaSanBay NOT INT", _pageSize);
            query.AppendFormat("(SELECT TOP {0} MaSanBay FROM SANBAY ORDER BY MaSanBay)",PreviousPageOffSet);
            

            sanbay = Dataprovider.ExcuteQuery(query.ToString());
            return sanbay;
        }


        //public static bool XoaSanBay(string _maSanBay)
        //{
        //    string query="Delete SanBay when MaSanBay=@MaSanBay";
        //    List<SqlParameter> parameters = new List<SqlParameter>()
        //    {
        //        new SqlParameter("@MaSanBay",SqlDbType.VarChar){Value=_maSanBay}
        //    };

        //    if (Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0)
        //    {
        //        return false;
        //    }
        //    return false;
        //}

        /// <summary>
        /// Lấy danh sách các sân bay đi
        /// </summary>
        /// <returns></returns>
        public static List<SanBay> LoadSanBayDi()
        {
            //Câu truy vấn
            string query = "EXEC usp_LoadSanBayDi";

            //Lấy dữ liệu lên
            DataTable table = Dataprovider.ExcuteQuery(query);

            //Chuyển Table thành List gồm có tên sân bay đi  và tên sân bay đến
            List<SanBay> danhsachSBDi = table.AsEnumerable().ToList().ConvertAll(x => 
                 new SanBay(){TenSanBay=x[0].ToString(),MaSanBay=x[1].ToString()});
            

            return danhsachSBDi;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_sanBayDi"></param>
        /// <returns></returns>
        public static List<SanBay> LoadSanBayDen(string _sanBayDi)
        {
            //Câu truy vấn
            string query = "EXEC usp_LoadSanBayDen @SanBayDi";

            //Thêm parameter vào command tránh sql injection
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@SanBayDi",SqlDbType.VarChar){Value= _sanBayDi }
            };

            //Lấy dữ liệu lên
            DataTable table = Dataprovider.ExcuteQuery(query,parameters.ToArray());


            //Chuyển Table thành List gồm có tên sân bay đi  và tên sân bay đến
            List<SanBay> danhsachSBDen = table.AsEnumerable().ToList().ConvertAll(x =>
                new SanBay() { TenSanBay=x[0].ToString(),MaSanBay=x[1].ToString() });


            return danhsachSBDen;
        }
    }
}
