using DTO;
using System;
using System.Collections.Generic;
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
                new SqlParameter("@TenHanhKhach",System.Data.SqlDbType.NVarChar){Value =_phieudatcho.TenHanhKhach},

                new SqlParameter("@SoDT",System.Data.SqlDbType.VarChar){Value =_phieudatcho.SoDT},

                new SqlParameter("@MaCB",System.Data.SqlDbType.VarChar){Value =_phieudatcho.MaCB},

                new SqlParameter("@CMND",System.Data.SqlDbType.VarChar){Value =_phieudatcho.CMND},

                new SqlParameter("@GiaTien",System.Data.SqlDbType.Int){Value =_phieudatcho.GiaTien},

                new SqlParameter("@NgayDat",System.Data.SqlDbType.DateTime){Value =_phieudatcho.NgayGioDat},

                new SqlParameter("@HangVe",System.Data.SqlDbType.VarChar){Value =_phieudatcho.TenHanhKhach},

            };

            if (Dataprovider.Instance.ExcuteNonQuery(query, parameters.ToArray()) > 0)
            {
                return true;
            }

            return false;
        }
    }
}
