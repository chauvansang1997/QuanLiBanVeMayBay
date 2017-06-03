using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class HangGhe
    {
        private int soGhe;
        private string maHangVe;
        private int maChuyenBay;

        public int SoGhe
        {
            get
            {
                return soGhe;
            }

            set
            {
                soGhe = value;
            }
        }

        public string MaHangVe
        {
            get
            {
                return maHangVe;
            }

            set
            {
                maHangVe = value;
            }
        }

        public int MaChuyenBay
        {
            get
            {
                return maChuyenBay;
            }

            set
            {
                maChuyenBay = value;
            }
        }
    }
}
