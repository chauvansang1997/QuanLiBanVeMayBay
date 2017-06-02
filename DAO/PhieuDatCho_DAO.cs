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
    public class PhieuDatCho_DAO
    {
        private static PhieuDatCho_DAO instance;

        public static PhieuDatCho_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuDatCho_DAO();
                return instance;
            }

        }
        /// <summary>
        /// Lập phiếu đặt chỗ
        /// </summary>
        /// <param name="_phieudatcho"></param>
        /// <returns></returns>
        public bool LapPhieuDatCho(PhieuDatCho _phieudatcho)
        {

            string query = "";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@TenHanhKhach",SqlDbType.NVarChar){Value =_phieudatcho.TenHanhKhach},

                new SqlParameter("@SoDT",SqlDbType.VarChar){Value =_phieudatcho.SoDT},

                new SqlParameter("@MaCB",SqlDbType.VarChar){Value =_phieudatcho.MaCB},

                new SqlParameter("@CMND",SqlDbType.VarChar){Value =_phieudatcho.CMND},

                new SqlParameter("@GiaTien",SqlDbType.Int){Value =_phieudatcho.GiaTien},

                new SqlParameter("@NgayDat",SqlDbType.DateTime){Value =_phieudatcho.NgayGioDat},

                new SqlParameter("@HangVe",SqlDbType.VarChar){Value =_phieudatcho.TenHanhKhach},

            };

            try
            {
                if (Dataprovider.Instance.ExcuteNonQuery(query, parameters.ToArray()) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
          

            
        }
        /// <summary>
        /// Hủy phiếu đặt chỗ
        /// </summary>
        /// <param name="_maPhieuDatCho">mã phiếu đặt chỗ</param>
        /// <returns></returns>
        public bool HuyPhieuDatCho(string _maPhieuDatCho)
        {
            string query = "";
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@maPhieuDatCho",SqlDbType.NVarChar){Value =_maPhieuDatCho},
            };
            try
            {
                if (Dataprovider.Instance.ExcuteNonQuery(query, parameters.ToArray()) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                return false;
            }
           

        }
        /// <summary>
        /// Dếm số phiếu đặt chỗ hiện tại
        /// </summary>
        /// <param name="_phieudatcho"></param>
        /// <returns></returns>
        public int DemPhieuDatCho(PhieuDatCho _phieudatcho)
        {
            string query = "";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@TenHanhKhach",SqlDbType.NVarChar){Value =_phieudatcho.TenHanhKhach??(Object)DBNull.Value,IsNullable=true},

                new SqlParameter("@MaPhieuDatCho",SqlDbType.VarChar){Value =_phieudatcho.MaPhieuDatCho??(Object)DBNull.Value,IsNullable=true},

                new SqlParameter("@MaCB",SqlDbType.VarChar){Value =_phieudatcho.MaCB??(Object)DBNull.Value,IsNullable=true},

                new SqlParameter("@CMND",SqlDbType.VarChar){Value =_phieudatcho.CMND??(Object)DBNull.Value,IsNullable=true},

            };
            try
            {
                return Convert.ToInt32(Dataprovider.Instance.ExcuteScalar(query, parameters.ToArray()));

            }
            catch (Exception)
            {
                return 0;
            }
        }

        /// <summary>
        /// Load phiếu đặt chỗ
        /// </summary>
        /// <returns></returns>
        public List<string> LoadPhieuDatCho()
        {
            string query = "SELECT MaPhieuDatCho FROM PHIEUDATCHO";

            try
            {
                DataTable table = Dataprovider.Instance.ExcuteQuery(query);

                return  table.AsEnumerable().ToList().ConvertAll(x => x[0].ToString());

            }
            catch (Exception)
            {
                return null;
                
            }
       
        }
        /// <summary>
        /// Tra cứu phiếu đặt chỗ
        /// </summary>
        /// <param name="_phieuDatCho"></param>
        /// <returns></returns>
        public DataTable TraCuuPhieuDatCho(PhieuDatCho _phieuDatCho,int pageSize,int pageNumber)
        {
            string query = "SELECT * FROM PHIEUDATCHO";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenHanhKhach",SqlDbType.NVarChar){IsNullable=true,Value=_phieuDatCho.TenHanhKhach??(Object)DBNull.Value},

                new SqlParameter("@CMND",SqlDbType.VarChar){IsNullable=true,Value=_phieuDatCho.CMND??(Object)DBNull.Value},

                new SqlParameter("@maChuyenBay",SqlDbType.VarChar){IsNullable=true,Value=_phieuDatCho.MaCB??(Object)DBNull.Value},

                new SqlParameter("@maPhieuDatCho",SqlDbType.VarChar){IsNullable=true,Value=_phieuDatCho.MaPhieuDatCho??(Object)DBNull.Value},

                new SqlParameter("@pageSize",SqlDbType.Int){Value=pageSize},

                new SqlParameter("@pageNumber",SqlDbType.Int){Value=pageNumber},
            };
            //Tránh lỗi kết nối cơ sở dữ liệu
            try
            {
                return Dataprovider.Instance.ExcuteQuery(query, parameters.ToArray());
            }
            catch (Exception)
            {
                return null;              
            }
        }
    }
}
