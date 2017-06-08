using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculate_YearAndMonth_InCome
{
    class Program
    {
        
        [DllImport("Kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();
        [DllImport("User32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd,int  cmdShow);

        static void Main(string[] args)
        {
            RegisTry_Help REG = new RegisTry_Help();
            IntPtr hWnd = GetConsoleWindow();
            if (hWnd != IntPtr.Zero)
            {
                ShowWindow(hWnd, 0);
            }
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
