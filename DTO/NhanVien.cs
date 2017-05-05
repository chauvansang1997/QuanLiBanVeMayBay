using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NhanVien
    {
        string tenNV;
        string maNV;
        string cmnd;
        string soDT;
        string diaChi;

        public string TenNV
        {
            get
            {
                return tenNV;
            }

            set
            {
                tenNV = value;
            }
        }

        public string MaNV
        {
            get
            {
                return maNV;
            }

            set
            {
                maNV = value;
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

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }
        public NhanVien()
        {

        }
        public NhanVien(string _tenNV,string _maNV,string _cmnd,string _soDT)
        {
            TenNV = _tenNV;
            MaNV = _maNV;
            CMND = _cmnd;
            SoDT = _soDT;
        }
    }
}
