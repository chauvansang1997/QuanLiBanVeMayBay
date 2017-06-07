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
    public static class TuyenBay_DAO
    {
        public static int DemTuyenBay(string _sanBayDi,string _sanBayDen)
        {
            string query = "EXEC usp_DemTuyenBay @sanBayDi,@sanBayDen";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@sanBayDi",SqlDbType.VarChar){IsNullable=true,Value = _sanBayDi??(Object)DBNull.Value},

                new SqlParameter("@sanBayDen",SqlDbType.VarChar){IsNullable=true,Value = _sanBayDen??(Object)DBNull.Value},

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

                new SqlParameter("@pageSize",SqlDbType.Int){Value = pageSize },

                new SqlParameter("@pageNumber",SqlDbType.Int){Value = pageNumber},
            };

            try
            {
                return Dataprovider.ExcuteQuery(query, parameters.ToArray());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                Help_Fuction.HelpFuction.Log(err);
            }

            return null;
        }
        public static bool ThemChuyenBay(string _sanBayDi,string _sanBayDen)
        {
            string query = "EXEC usp_ThemTuyenBay @sanBayDi,@sanBayDen";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@sanBayDi",SqlDbType.VarChar){ Value = _sanBayDi },

                new SqlParameter("@sanBayDen",SqlDbType.VarChar){ Value = _sanBayDen },

            };

            try
            {
                if (Dataprovider.ExcuteNonQuery(query, parameters.ToArray())>0)
                {
                    return true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);

                Help_Fuction.HelpFuction.Log(err);

            }
            return false;
        }
    }
}
