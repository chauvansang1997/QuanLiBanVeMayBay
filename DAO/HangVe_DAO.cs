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
    public  static class HangVe_DAO
    {
        public static List<string> LoadTenHangVe(string _tenHangVe)
        {
            string query = "EXEC usp_LoadHangGhe @tenHangVe";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@tenHangVe",SqlDbType.NVarChar){ IsNullable=true,Value=_tenHangVe??(Object)DBNull.Value},
            };

            List<string> hangve = Dataprovider.ExcuteQuery(query,parameters.ToArray()).AsEnumerable().ToList().ConvertAll
                (x => x[0].ToString() );

            return hangve;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static List<HangVe> LoadHangVe()
        {
            string query = "EXEC usp_LoadHangVe";

            List<HangVe> hangve = Dataprovider.ExcuteQuery(query).AsEnumerable().ToList().ConvertAll
                (x => new HangVe { MaHangVe = x[0].ToString(), TenHangVe = x[1].ToString() });

            return hangve;
        }
          /// <summary>
          ///Đếm số hạng vé hiện tại
          /// </summary>
          /// <returns></returns>
        public static  int DemSoLuongHangVe()
        {
            string query = "EXEC usp_DemSoLuongHangVe";

            try
            {
                return (int)Dataprovider.ExcuteScalar(query);
            }
            catch (Exception err)
            {
                Help_Fuction.HelpFuction.Log(err);
                return 0;
            }
        }
    }
}
