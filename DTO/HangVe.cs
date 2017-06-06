using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangVe
    {
        private string maHangVe;
        private string tenHangVe;

        private static int soLuongHangVe;

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

        public string TenHangVe
        {
            get
            {
                return tenHangVe;
            }

            set
            {
                tenHangVe = value;
            }
        }

        public static int SoLuongHangVe
        {
            get
            {
                return soLuongHangVe;
            }

            set
            {
                soLuongHangVe = value;
            }
        }
    }
}
