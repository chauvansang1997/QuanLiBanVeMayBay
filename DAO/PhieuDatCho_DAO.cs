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
    }
}
