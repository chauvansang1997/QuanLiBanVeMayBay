using DTO;
using Help_Fuction;
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
    public static class NhanVien_DAO
    {
     
        public static bool SuaThongTinNhanVien(NhanVien _nhanvien)
        {

            string query = " EXEC usp_SuaThongTinNhanVien @maNhanVien,@tenNhanVien,@CMND,@soDT,@diaChi";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {

                new SqlParameter("@tenNhanVien",SqlDbType.NVarChar){IsNullable=true ,Value = _nhanvien.TenNV??(Object)DBNull.Value },

                new SqlParameter("@CMND",SqlDbType.VarChar){IsNullable=true ,Value = _nhanvien.CMND??(Object)DBNull.Value },

                new SqlParameter("@soDT",SqlDbType.VarChar){IsNullable=true ,Value = _nhanvien.SoDT??(Object)DBNull.Value },

                new SqlParameter("@maNhanVien",SqlDbType.VarChar){Value = _nhanvien.MaNV },

                new SqlParameter("@diaChi",SqlDbType.NVarChar){IsNullable=true ,Value=_nhanvien.DiaChi?? (Object)DBNull.Value},


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
                MessageBox.Show(err.Message);
                HelpFuction.Log(err);

            }
            return false;
        } 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_nhanvien"></param>
        /// <returns></returns>
        public static bool ThemNhanVien(NhanVien _nhanvien)
        {
            string query = " EXEC usp_ThemNhanVien @tenNhanVien,@CMND,@soDT,@loaiNV,@diaChi";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {

                new SqlParameter("@tenNhanVien",SqlDbType.NVarChar){Value = _nhanvien.TenNV },

                new SqlParameter("@CMND",SqlDbType.VarChar){Value = _nhanvien.CMND },

                new SqlParameter("@soDT",SqlDbType.VarChar){Value = _nhanvien.SoDT },

                new SqlParameter("@loaiNV",SqlDbType.VarChar){Value = _nhanvien.LoaiNhanVien },

                new SqlParameter("@diaChi",SqlDbType.NVarChar){Value=_nhanvien.DiaChi?? (Object)DBNull.Value},


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
                MessageBox.Show(err.Message);
                HelpFuction.Log(err);
               
            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<NhanVien> LoadNhanVien()
        {
            string query = " EXEC usp_LoadNhanVien";

            //Lấy dữ liệu lên
            DataTable table = Dataprovider.ExcuteQuery(query);

            //Chuyển Table thành List gồm có tên sân bay đi  và tên sân bay đến
            List<NhanVien> danhsachNV = table.AsEnumerable().ToList().ConvertAll(x =>
                 new NhanVien() {TenNV= x[1].ToString(),CMND=x[0].ToString() });


            return danhsachNV;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_nhanVien"></param>
        /// <returns></returns>
        public static int DemSoNhanVien(NhanVien _nhanVien)
        {

            string query = "EXEC usp_DemNhanVien @TenNhanVien,@CMND";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {

                new SqlParameter("@tenNhanVien",SqlDbType.NVarChar){IsNullable=true,Value = _nhanVien.TenNV?? (Object)DBNull.Value},

                new SqlParameter("@CMND",SqlDbType.VarChar){IsNullable=true,Value=_nhanVien.CMND?? (Object)DBNull.Value},


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
            string query = "EXEC usp_TraCuuNhanVien @tenNhanVien,@CMND,@pageSize,@pageNumber";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {

                new SqlParameter("@tenNhanVien",SqlDbType.NVarChar){IsNullable=true,Value = _nhanVien.TenNV?? (Object)DBNull.Value},

                new SqlParameter("@CMND",SqlDbType.VarChar){IsNullable=true,Value=_nhanVien.CMND?? (Object)DBNull.Value},


                new SqlParameter("@pageSize",SqlDbType.VarChar){Value=pageSize},

                new SqlParameter("@pageNumber",SqlDbType.VarChar){Value=pageNumber},
            };

            DataTable danhsachNV = Dataprovider.ExcuteQuery(query, parameters.ToArray());

            return danhsachNV;
        }
    }
}
