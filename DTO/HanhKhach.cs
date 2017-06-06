using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HanhKhach
    {
        private string tenHanhKhach;
        private string maHanhKhach;
        private string diaChi;
        private string soDT;
        private string cmnd;
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
        public string MaHanhKhach
        {
            get
            {
                return maHanhKhach;
            }
            set
            {
                maHanhKhach = value;
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

        public HanhKhach()
        {

        }
        public HanhKhach(string name,string cmnd,string mahk,string diachi,string sodt)
        {
            TenHanhKhach = name;
            CMND = cmnd;
            MaHanhKhach = mahk;
            DiaChi = diachi;
            SoDT = sodt;
        }
    }
}
