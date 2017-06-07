using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class TuyenBay_DAO
    {
        public static int DemTuyenBay(string _sanBayDi,string _sanBayDen)
        {
            string query = "EXEC usp_DemTuyenBay @sanBayDi,@sanBayDen";

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                new SqlParameter("@sanBayDi")
            };

        }
    }
}
