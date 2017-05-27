using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class VeDat_DAO
    {
        private static VeDat_DAO instance;

        public static VeDat_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new VeDat_DAO();
                return instance;
            }

        }

        public bool GhiNhanDatVe(VeDat _vedat)
        {

            string query = "Select * from CHUYENBAY where TenHanhKhach=@TenHanhKhach";

            //Tạo parameters tránh sql injection
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@TenHanhKhach",System.Data.SqlDbType.NVarChar){Value =_vedat.TenHanhKhach},

                new SqlParameter("@SoDT",System.Data.SqlDbType.VarChar){Value =_vedat.SoDT},

                new SqlParameter("@MaCB",System.Data.SqlDbType.VarChar){Value =_vedat.MaCB},

                new SqlParameter("@CMND",System.Data.SqlDbType.VarChar){Value =_vedat.CMND},

                new SqlParameter("@GiaTien",System.Data.SqlDbType.Int){Value =_vedat.GiaTien},

                new SqlParameter("@NgayDat",System.Data.SqlDbType.DateTime){Value =_vedat.NgayGioDat},

                new SqlParameter("@HangVe",System.Data.SqlDbType.VarChar){Value =_vedat.TenHanhKhach},

            };


            if (Dataprovider.Instance.ExcuteNonQuery(query, parameters.ToArray()) > 0)
            {
                return true;
            }

            return false;
        }
    }
}
