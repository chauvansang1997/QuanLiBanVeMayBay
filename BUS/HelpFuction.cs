using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BUS
{
    public static class HelpFuction
    {
        /// <summary>
        /// Kiểm tra số điện thoại có hợp lệ
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool IsPhoneNumber(string phone_number)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(phone_number);
        }
        public static int TinhKichThuocTrang(int totalPage,int pageSize)
        {

            if (totalPage * 1.0 % pageSize > 1)
            {
                totalPage = (totalPage / pageSize) + 1;
            }
            else
            {
                totalPage = totalPage / pageSize;
            }
            if (totalPage == 0)
            {
                totalPage = 1;
            }

            return totalPage;
        }
        public static bool isContainsNumber(string str)
        {
            return Regex.IsMatch(str, @"\d");
        }

    }
}
