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
            string query = "";
            while (true)
            {
                //Mỗi 1 phút kiểm tra xem có tới tháng tiếp theo chưa
                DateTime now = DateTime.Now;

                Thread.Sleep(60000);

                if (DateTime.Now.Month != now.Month)
                {
                    //DataProvider

                }
                            
            }
        }
    }
}
