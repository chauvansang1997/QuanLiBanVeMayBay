using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class TuyenBay_BUS
    {
        public static int DemTuyenBay(string _sanBayDi,string _sanBayDen)
        {
            return TuyenBay_DAO.DemTuyenBay(_sanBayDi, _sanBayDen);
        }
        public static DataTable TimTuyenBay(string _sanBayDi, string _sanBayDen, int pageSize, int pageNumber)
        {
            return TuyenBay_DAO.TimTuyenBay(_sanBayDi, _sanBayDen, pageSize, pageNumber);
        }

        public static bool ThemTuyenBay(string _sanBayDi, string _sanBayDen)
        {
            return TuyenBay_DAO.ThemChuyenBay(_sanBayDi, _sanBayDen);
        }
    }
}
