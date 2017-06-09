using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_YearAndMonth_InCome
{
    public static class PhieuDatChoHetHan
    {
        public static void HuyPhieuDatCho()
        {
            string query = "EXEC usp_HuyPhieuDatChoHetHan";
            try
            {
                DataProvider.Instance.ExcuteNonQuery(query);
            }
            catch (Exception)
            {

                
            }
        }
    }
}
