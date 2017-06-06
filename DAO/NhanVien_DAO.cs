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
    public static class NhanVien_DAO
    {
     
        public static List<string> LoadNhanVien()
        {
            string query = "SELECT NV.TenNhanVien[Tên Nhân Viên]  FROM NHANVIEN NV ";

            //Lấy dữ liệu lên
            DataTable table = Dataprovider.ExcuteQuery(query);

            //Chuyển Table thành List gồm có tên sân bay đi  và tên sân bay đến
            List<string> danhsachNV = table.AsEnumerable().ToList().ConvertAll(x =>
                 x[0].ToString());


            return danhsachNV;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_nhanVien"></param>
        /// <returns></returns>
        public static int DemSoNhanVien(NhanVien _nhanVien)
        {

            string query = "EXEC DEM_NHAN_VIEN @MaNhanVien,@TenNhanVien,@SoDT,@CMND";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@MaNhanVien",SqlDbType.NVarChar){IsNullable=true,Value = _nhanVien.MaNV?? (Object)DBNull.Value},

                new SqlParameter("@TenNhanVien",SqlDbType.NVarChar){IsNullable=true,Value = _nhanVien.TenNV?? (Object)DBNull.Value},

                new SqlParameter("@CMND",SqlDbType.VarChar){IsNullable=true,Value=_nhanVien.CMND?? (Object)DBNull.Value},

                new SqlParameter("@SoDT",SqlDbType.VarChar){IsNullable=true,Value=_nhanVien.SoDT?? (Object)DBNull.Value},

            };
            try
            {
                return Convert.ToInt32(Dataprovider.ExcuteScalar(query, parameters.ToArray()));
            }
            catch (Exception)
            {
                return 0;

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_nhanVien"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        public static DataTable TraCuuNV(NhanVien _nhanVien, int pageSize, int pageNumber)
        {
            string query = "EXEC sp_TimNhanVien @MaNhanVien,@TenNhanVien,@SoDT,@CMND,@pageSize,@pageNumber";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@MaNhanVien",SqlDbType.NVarChar){IsNullable=true,Value = _nhanVien.MaNV?? (Object)DBNull.Value},

                new SqlParameter("@TenNhanVien",SqlDbType.NVarChar){IsNullable=true,Value = _nhanVien.TenNV?? (Object)DBNull.Value},

                new SqlParameter("@CMND",SqlDbType.VarChar){IsNullable=true,Value=_nhanVien.CMND?? (Object)DBNull.Value},

                new SqlParameter("@SoDT",SqlDbType.VarChar){IsNullable=true,Value=_nhanVien.SoDT?? (Object)DBNull.Value},

                new SqlParameter("@pageSize",SqlDbType.VarChar){Value=pageSize},

                new SqlParameter("@pageNumber",SqlDbType.VarChar){Value=pageNumber},
            };

            DataTable danhsachNV = Dataprovider.ExcuteQuery(query, parameters.ToArray());

            return danhsachNV;
        }
    }
}
