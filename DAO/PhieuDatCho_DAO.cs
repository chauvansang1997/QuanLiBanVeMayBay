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
    public static class PhieuDatCho_DAO
    {

        public static event EventHandler<SqlException> LapPhieuDC_sqlException;
        public static event EventHandler<SqlException> HuyPhieuDC_sqlException;
        /// <summary>
        /// Lập phiếu đặt chỗ
        /// </summary>
        /// <param name="_phieudatcho"></param>
        /// <returns></returns>
        public static bool LapPhieuDatCho(PhieuDatCho _phieudatcho)
        {

            string query = "EXEC usp_NhapPhieuDatCho @maChuyenBay,@tenHanhKhach,@CMND,@SoDienThoai,@ngayDat,@maHangVe";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenHanhKhach",SqlDbType.NVarChar){Value =_phieudatcho.TenHanhKhach},

                new SqlParameter("@SoDienThoaiT",SqlDbType.VarChar){Value =_phieudatcho.SoDT},

                new SqlParameter("@maChuyenBay",SqlDbType.VarChar){Value =_phieudatcho.MaCB},

                new SqlParameter("@CMND",SqlDbType.VarChar){Value =_phieudatcho.CMND},

                new SqlParameter("@ngayDat",SqlDbType.DateTime){Value =_phieudatcho.NgayGioDat},

                new SqlParameter("@maHangVe",SqlDbType.VarChar){Value =_phieudatcho.TenHanhKhach},

                

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
            catch (SqlException err)
            {
                if (err.ErrorCode == 16)
                {
                    if (LapPhieuDC_sqlException != null)
                    {
                        LapPhieuDC_sqlException(null, err);
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
        /// <param name="_maPhieuDatCho">mã phiếu đặt chỗ</param>
        /// <returns></returns>
        public static bool HuyPhieuDatCho(string _maPhieuDatCho)
        {
            string query = "EXEC usp_HuyPhieuDatCho @maPhieuDatCho";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maPhieuDatCho",SqlDbType.NVarChar){Value =_maPhieuDatCho},
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
            catch(SqlException err)
            {
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
        /// Dếm số phiếu đặt chỗ hiện tại
        /// </summary>
        /// <param name="_phieudatcho"></param>
        /// <returns></returns>
        public static int DemPhieuDatCho(PhieuDatCho _phieudatcho)
        {
            string query = "EXEC usp_DemPhieuDatCho @tenHanhKhach,@CMND,@maChuyenBay,@maPhieuDatCho";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@TenHanhKhach",SqlDbType.NVarChar){Value =_phieudatcho.TenHanhKhach??(Object)DBNull.Value,IsNullable=true},

                new SqlParameter("@MaPhieuDatCho",SqlDbType.VarChar){Value =_phieudatcho.MaPhieuDatCho??(Object)DBNull.Value,IsNullable=true},

                new SqlParameter("@MaCB",SqlDbType.VarChar){Value =_phieudatcho.MaCB??(Object)DBNull.Value,IsNullable=true},

                new SqlParameter("@CMND",SqlDbType.VarChar){Value =_phieudatcho.CMND??(Object)DBNull.Value,IsNullable=true},

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
        /// Load phiếu đặt chỗ
        /// </summary>
        /// <returns></returns>
        public static List<string> LoadPhieuDatCho()
        {
            string query = "SELECT MaPhieuDatCho FROM PHIEUDATCHO";

            try
            {
                DataTable table = Dataprovider.ExcuteQuery(query);

                return  table.AsEnumerable().ToList().ConvertAll(x => x[0].ToString());

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
        /// <param name="_phieuDatCho"></param>
        /// <returns></returns>
        public static DataTable TraCuuPhieuDatCho(PhieuDatCho _phieuDatCho,int pageSize,int pageNumber)
        {
            string query = "EXEC usp_TraCuuPhieuDatCho @tenHanhKhach,@CMND,@maChuyenBay,@maPhieuDatCho,@pageSize,@pageNumber";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenHanhKhach",SqlDbType.NVarChar){ IsNullable=true,Value=_phieuDatCho.TenHanhKhach??(Object)DBNull.Value},

                new SqlParameter("@CMND",SqlDbType.VarChar){ IsNullable=true,Value=_phieuDatCho.CMND??(Object)DBNull.Value},

                new SqlParameter("@maChuyenBay",SqlDbType.VarChar){ IsNullable=true,Value=_phieuDatCho.MaCB??(Object)DBNull.Value},

                new SqlParameter("@maPhieuDatCho",SqlDbType.VarChar){ IsNullable=true,Value=_phieuDatCho.MaPhieuDatCho??(Object)DBNull.Value},

                new SqlParameter("@pageSize",SqlDbType.Int){ Value=pageSize},

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
