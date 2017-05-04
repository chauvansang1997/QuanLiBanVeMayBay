using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class VeDat
    {
        private string tenHanhKhach;
        private string soDT;
        private string maCB;
        private string cmnd;
        private int Giatien;
        private DateTime ngayGioDat;
        private string hangVe;

        public string TenHanhKhach
        {
            get
            {
                return tenHanhKhach;
            }

            set
            {
                tenHanhKhach = value;
            }
        }

        public string SoDT
        {
            get
            {
                return soDT;
            }

            set
            {
                soDT = value;
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

        public string CMND
        {
            get
            {
                return cmnd;
            }

            set
            {
                cmnd = value;
            }
        }

        public int Giatien1
        {
            get
            {
                return Giatien;
            }

            set
            {
                Giatien = value;
            }
        }

        public DateTime NgayGioDat
        {
            get
            {
                return ngayGioDat;
            }

            set
            {
                ngayGioDat = value;
            }
        }

        public string HangVe
        {
            get
            {
                return hangVe;
            }

            set
            {
                hangVe = value;
            }
        }

    }
}
