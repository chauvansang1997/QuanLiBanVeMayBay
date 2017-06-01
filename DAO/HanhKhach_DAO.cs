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
    public class HanhKhach_DAO
    {
        private static HanhKhach_DAO instance;

        public static HanhKhach_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HanhKhach_DAO();
                return instance;
            }

        }

        private HanhKhach_DAO()
        {

        }

        public List<string> LoadHanhKhach()
        {
            string query = "SELECT TenHanhKhach FROM HANHKHACH";

            DataTable table = Dataprovider.Instance.ExcuteQuery(query);

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
        public int DemSoHanhKhach(HanhKhach _hanhKhach)
        {

            string query = "EXEC DEM_HANH_KHACH @TenHanhKhach,@CMND ,@SoDienThoai";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@TenHanhKhach",SqlDbType.NVarChar){Value=_hanhKhach.Name},

                new SqlParameter("@CMND",SqlDbType.VarChar){Value=_hanhKhach.CMND},

                new SqlParameter("@SoDienThoai",SqlDbType.VarChar){Value=_hanhKhach.SoDT},

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
