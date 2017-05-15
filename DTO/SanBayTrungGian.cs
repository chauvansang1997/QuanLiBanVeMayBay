using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class SanBayTrungGian:SanBay
    {
        private int sTT;
        private int thoiGianDung;
        private string ghiChu;

        public int ThoiGianDung
        {
            get
            {
                return thoiGianDung;
            }

            set
            {
                thoiGianDung = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }

        public int STT
        {
            get
            {
                return sTT;
            }

            set
            {
                sTT = value;
            }
        }
    }
}
