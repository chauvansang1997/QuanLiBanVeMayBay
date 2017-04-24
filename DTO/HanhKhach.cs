using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HanhKhach
    {
        private string name;
        private string maHK;
        private string diaChi;
        private string soDT;
        private string cmnd;
        public string Name { get => name; set => name = value; }
        public string MaHK { get => maHK; set => maHK = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string CMND { get => cmnd; set => cmnd = value; }

        public HanhKhach()
        {

        }
        public HanhKhach(string name,string cmnd,string mahk,string diachi,string sodt)
        {
            Name = name;
            CMND = cmnd;
            MaHK = mahk;
            DiaChi = diachi;
            SoDT = sodt;
        }
    }
}
