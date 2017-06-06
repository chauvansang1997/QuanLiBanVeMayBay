using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanBay
    {
        private string maSanBay;
        private string tenSanBay;
    

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

        public SanBay()
        {

        }
        public SanBay(string masanbay,string tensanbay)
        {
     
            MaSanBay = masanbay;
            TenSanBay = tensanbay;
        }
    }
}
