﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class PhieuDatCho
    {

        private string tenHanhKhach;
        private string soDT;
        private string maCB;
        private string cmnd;
        private int giaTien;
        private DateTime ngayGioDat;
        private string hangVe;
        private string maPhieuDatCho;
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

        public int GiaTien
        {
            get
            {
                return giaTien;
            }

            set
            {
                giaTien = value;
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

        public string MaPhieuDatCho
        {
            get
            {
                return maPhieuDatCho;
            }

            set
            {
                maPhieuDatCho = value;
            }
        }
    }
}
