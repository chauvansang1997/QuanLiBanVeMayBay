using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class Test_BUS
    {
        public static DataTable Test(string _tenSanBay)
        {
            string query = "'SELECT * FROM SANBAY WHERE dbo.fChuyenCoDauThanhKhongDau(TenSanBay) LIKE ''%''+'''+dbo.fChuyenCoDauThanhKhongDau(@TenSanBay)+'''+''%'''";

            DataTable table = Dataprovider.ExcuteQuery(query,new List<SqlParameter> { new SqlParameter("@TenSanBay", SqlDbType.NVarChar) { Value=_tenSanBay} }.ToArray());

            return table;
        }
    }
}
