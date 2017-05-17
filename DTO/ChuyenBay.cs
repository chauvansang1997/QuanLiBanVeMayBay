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
        private List<int> soGheCacHangVe;
        private string sanBayDi;
        private string sanBayDen;
        private int thoiGianBay;
        private int giaVe;

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
        public int ThoiGianBay
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

      

        public int GiaVe
        {
            get
            {
                return giaVe;
            }

            set
            {
                giaVe = value;
            }
        }

        public List<int> SoGheCacHangVe
        {
            get
            {
                return soGheCacHangVe;
            }

            set
            {
                soGheCacHangVe = value;
            }
        }

        public ChuyenBay()
        {

        }
 
    }
}
