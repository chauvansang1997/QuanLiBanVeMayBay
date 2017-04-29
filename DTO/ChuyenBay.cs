using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChuyenBay
    {
        private string maCB;
        private string sanBayDi;
        private string sanBayDen;
        private TimeSpan thoiGianBay;
        private DateTime ngayGioKH;


        public string MaCB
        {
            get
            {
                return maCB;
            }
            set
            {
                maCB = value;
            }
        }
        public string SanBayDi
        {
            get
            {
                return sanBayDi;
            }
            set
            {
                sanBayDi = value;
            }
        }
        public string SanBayDen { get
            {
                return sanBayDen;
            }
            set
            {
                sanBayDen = value;
            }
        }
        public TimeSpan ThoiGianBay
        {
            get
            {
                return thoiGianBay;
            }
            set
            {
                thoiGianBay = value;
            }
        }
        public DateTime NgayGioKH
        {
            get
            {
                return ngayGioKH;
            }
            set
            {
                ngayGioKH = value;
            }
        }
        public ChuyenBay()
        {

        }
        public ChuyenBay(string macb,string sanbaydi,string sanbayden,TimeSpan thoigianbay,DateTime ngaygiokh)
        {
            MaCB = macb;
            SanBayDi = sanbaydi;
            SanBayDen = sanbayden;
            ThoiGianBay = thoigianbay;
            NgayGioKH = ngaygiokh;
        }

       
    }
}
