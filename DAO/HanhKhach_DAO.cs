using DTO;
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
    public static class HanhKhach_DAO
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<string> LoadHanhKhach()
        {
            string query = "EXEC usp_LoadHanhKhach";

            DataTable table = Dataprovider.ExcuteQuery(query);

            //Chuyển Table thành List tên hành khách
            List<string> danhsachHK = table.AsEnumerable().ToList().ConvertAll(x =>
                 x[0].ToString());

            return danhsachHK;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<HanhKhach> LoadHanhKhachVe()
        {
            string query = "EXEC usp_LoadHKVe";

            DataTable table = Dataprovider.ExcuteQuery(query);

            //Chuyển Table thành List tên hành khách
            List<HanhKhach> danhsachHK = table.AsEnumerable().ToList().ConvertAll(x =>
               new HanhKhach() { TenHanhKhach = x[0].ToString(),CMND = x[1].ToString() });

            return danhsachHK;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<string> LoadHanhKhachPDC()
        {
            string query = "EXEC usp_LoadHKPhieuDatCho";

            DataTable table = Dataprovider.ExcuteQuery(query);

            //Chuyển Table thành List tên hành khách
            List<string> danhsachHK = table.AsEnumerable().ToList().ConvertAll(x =>
                 x[0].ToString());


            return danhsachHK;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_hanhKhach"></param>
        /// <returns></returns>
        public static int DemSoHanhKhach(HanhKhach _hanhKhach)
        {

            string query = "EXEC usp_DemHanhKhach @TenHanhKhach,@CMND ,@SoDienThoai";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@TenHanhKhach",SqlDbType.NVarChar){IsNullable=true,Value=_hanhKhach.TenHanhKhach?? (Object)DBNull.Value},

                new SqlParameter("@CMND",SqlDbType.VarChar){IsNullable=true,Value=_hanhKhach.CMND?? (Object)DBNull.Value},

                new SqlParameter("@SoDienThoai",SqlDbType.VarChar){IsNullable=true,Value=_hanhKhach.SoDT?? (Object)DBNull.Value},


            };


            try
            {
                return Convert.ToInt32(Dataprovider.ExcuteScalar(query, parameters.ToArray()));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Help_Fuction.HelpFuction.Log(err);
                return 0;

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_hanhKhach"></param>
        /// <returns></returns>
        public static DataTable TraCuuHK(HanhKhach _hanhKhach, int pageSize, int pageNumber)
        {
            string query = "EXEC usp_TimHanhKhach @TenKH,@CMND,@SoDT,@pageSize,@pageNumber";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@TenKH",SqlDbType.NVarChar){IsNullable=true,Value=_hanhKhach.TenHanhKhach?? (Object)DBNull.Value },

                new SqlParameter("@CMND",SqlDbType.VarChar){IsNullable=true,Value=_hanhKhach.CMND?? (Object)DBNull.Value},

                new SqlParameter("@SoDT",SqlDbType.VarChar){IsNullable=true,Value=_hanhKhach.SoDT ?? (Object)DBNull.Value},


                new SqlParameter("@pageSize",SqlDbType.VarChar){Value=pageSize},

                new SqlParameter("@pageNumber",SqlDbType.VarChar){Value=pageNumber},
            };

            DataTable danhsachKH = Dataprovider.ExcuteQuery(query, parameters.ToArray());

            return danhsachKH;
        }

    }
}
