using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class SanBay
    {
        private string maSanBay;
        private string tenSanBay;
        private string maCB;

        public string MaSanBay
        {
            get
            {
                return maSanBay;
            }
            set
            {
                maSanBay = value;
            }
        }
        public string TenSanBay
        {
            get
            {
                return tenSanBay;
            }
            set
            {
                tenSanBay = value;
            }
        }
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

        public SanBay()
        {

        }
        public SanBay(string masanbay,string tensanbay,string maCB = null)
        {
            MaCB = maCB;
            MaSanBay = masanbay;
            TenSanBay = tensanbay;
        }
    }
}
