using DTO;
using Help_Fuction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class VeDat_DAO
    {

        public static event EventHandler<SqlException> sqlException; 
        public static bool GhiNhanDatVe(VeDat _vedat)
        {

            string query = "EXEC  usp_NhapThongTinVe  @maChuyenBay,@tenHanhKhach,@CMND,@soDienThoai,@maHangVe ";

            //Tạo parameters tránh sql injection
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenHanhKhach",SqlDbType.NVarChar){ Value =_vedat.TenHanhKhach },

                new SqlParameter("@soDienThoai",SqlDbType.VarChar){ Value =_vedat.SoDT },

                new SqlParameter("@maChuyenBay",SqlDbType.VarChar){ Value =_vedat.MaCB },

                new SqlParameter("@CMND",SqlDbType.VarChar){ Value =_vedat.CMND },


                new SqlParameter("@maHangVe",SqlDbType.VarChar){ Value =_vedat.HangVe  },

            };

            try
                {
                if (Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0)
                {
                    return true;
                }

                return false;
            }
            catch (SqlException err)
            {
                if (err.ErrorCode == 16)
                {
                    if (sqlException != null)
                    {
                        sqlException(null, err);
                    }
                    
                }
                HelpFuction.Log(err);
                return false;
            }
            catch (Exception err)
            {
                HelpFuction.Log(err);
                return false;
            }
          
        }

        /// <summary>
        /// Hủy phiếu đặt chỗ
        /// </summary>
        /// <param name="_maVe">mã phiếu đặt chỗ</param>
        /// <returns></returns>
        public static bool HuyVe(string _maVe)
        {
            string query = "EXEC usp_HuyVe @maVe";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maVe",SqlDbType.VarChar){ Value =_maVe },
            };

            try
            {
                if (Dataprovider.ExcuteNonQuery(query, parameters.ToArray()) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {
                HelpFuction.Log(err);
                return false;
            }
        }

        /// <summary>
        /// Dếm số phiếu đặt chỗ hiện tại
        /// </summary>
        /// <param name="veDat"></param>
        /// <returns></returns>
        public static int DemVe(VeDat veDat)
        {
            string query = "EXEC usp_DemVeChuyenBay @tenHanhKhach,@CMND ,@maChuyenBay,@maVe";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenHanhKhach",SqlDbType.NVarChar){Value =veDat.TenHanhKhach??(Object)DBNull.Value,IsNullable=true},

                new SqlParameter("@maVe",SqlDbType.VarChar){Value =veDat.MaVe??(Object)DBNull.Value,IsNullable=true},

                new SqlParameter("@maChuyenBay",SqlDbType.VarChar){Value =veDat.MaCB??(Object)DBNull.Value,IsNullable=true},

                new SqlParameter("@CMND",SqlDbType.VarChar){Value =veDat.CMND??(Object)DBNull.Value,IsNullable=true},

            };
            try
            {
                return Convert.ToInt32(Dataprovider.ExcuteScalar(query, parameters.ToArray()));

            }
            catch (Exception err)
            {
                HelpFuction.Log(err);
                return 0;
            }
        }
        /// <summary>
        /// Load vé
        /// </summary>
        /// <returns></returns>
        public static List<string> LoadVe()
        {
            string query = "SELECT MaVe FROM Ve";

            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query);

                return table.AsEnumerable().ToList().ConvertAll(x => x[0].ToString());

            }
            catch (Exception err)
            {
                HelpFuction.Log(err);
                return null;

            }

        }
        /// <summary>
        /// Tra cứu phiếu đặt chỗ
        /// </summary>
        /// <param name="veDat"></param>
        /// <returns></returns>
        public static DataTable TraCuuVe(VeDat veDat, int pageSize, int pageNumber)
        {
            string query = "EXEC usp_TraCuuVe @tenHanhKhach,@CMND,@maChuyenBay,@maPhieuDatCho,@pageSize,@pageNumber";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenHanhKhach",SqlDbType.NVarChar){ IsNullable=true, Value=veDat.TenHanhKhach??(Object)DBNull.Value },

                new SqlParameter("@CMND",SqlDbType.VarChar){ IsNullable=true, Value=veDat.CMND??(Object)DBNull.Value },

                new SqlParameter("@maChuyenBay",SqlDbType.VarChar){ IsNullable=true, Value=veDat.MaCB??(Object)DBNull.Value },

                new SqlParameter("@maPhieuDatCho",SqlDbType.VarChar){ IsNullable=true, Value=veDat.MaVe??(Object)DBNull.Value },

                new SqlParameter("@pageSize",SqlDbType.Int){ Value=pageSize },

                new SqlParameter("@pageNumber",SqlDbType.Int){ Value=pageNumber },
            };
            //Tránh lỗi kết nối cơ sở dữ liệu
            try
            {
                return Dataprovider.ExcuteQuery(query, parameters.ToArray());
            }
            catch (Exception err)
            {
                HelpFuction.Log(err);

                return null;
            }
        }
    }
}
