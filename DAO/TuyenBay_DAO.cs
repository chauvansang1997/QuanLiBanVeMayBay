using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class TuyenBay_DAO
    {
        public static int DemTuyenBay(string _sanBayDi,string _sanBayDen,int pageSize,int pageNumber)
        {
            string query = "EXEC usp_DemTuyenBay @sanBayDi,@sanBayDen,@pageSize,@pageNumber";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@sanBayDi",SqlDbType.VarChar){IsNullable=true,Value = _sanBayDi??(Object)DBNull.Value},

                new SqlParameter("@sanBayDen",SqlDbType.VarChar){IsNullable=true,Value = _sanBayDen??(Object)DBNull.Value},

                new SqlParameter("@pageSize",SqlDbType.Int){Value = _sanBayDen },

                new SqlParameter("@pageNumber",SqlDbType.Int){Value = _sanBayDen },
            };

            try
            {
                return (int)Dataprovider.ExcuteScalar(query, parameters.ToArray());
            }
            catch (Exception err)
            {

                Help_Fuction.HelpFuction.Log(err);
            }
            return 0;
        }
        public static DataTable TimTuyenBay(string _sanBayDi, string _sanBayDen, int pageSize, int pageNumber)
        {
            string query = "EXEC usp_TimTuyenBay @sanBayDi,@sanBayDen,@pageSize,@pageNumber";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@sanBayDi",SqlDbType.VarChar){IsNullable=true,Value = _sanBayDi??(Object)DBNull.Value},

                new SqlParameter("@sanBayDen",SqlDbType.VarChar){IsNullable=true,Value = _sanBayDen??(Object)DBNull.Value},

                new SqlParameter("@pageSize",SqlDbType.Int){Value = _sanBayDen },

                new SqlParameter("@pageNumber",SqlDbType.Int){Value = _sanBayDen },
            };

            try
            {
                return Dataprovider.ExcuteQuery(query, parameters.ToArray());
            }
            catch (Exception err)
            {

                Help_Fuction.HelpFuction.Log(err);
            }

            return null;
        }
        public 
    }
}
