using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculate_YearAndMonth_InCome
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                //Mỗi 1 phút kiểm tra xem có tới tháng tiếp theo chưa
                DateTime now = DateTime.Now;

                Thread.Sleep(60000);

                if (DateTime.Now.Year != now.Year)
                {
                    DoanhThu.TinhDoanhThuNam(now.Year.ToString());

                    DoanhThu.CapNhatDoanhThuNam(DateTime.Now.Year.ToString());
                }

                if (DateTime.Now.Month != now.Month && DateTime.Now.Year == now.Year)
                {
                    DoanhThu.TinhDoanhThuThang(DateTime.Now.Month.ToString(),now.Year.ToString());

                }
               
                            
            }
        }
    }
}
