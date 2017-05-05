using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class TraCuu_BUS
    {
        private static TraCuu_BUS instance;

        public static TraCuu_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TraCuu_BUS();
                return instance;
            }

        }
        void TraCuuNhanVien(string _tenNV,string _cmnd,string _maNV,string _soDT,DataGridView ThongTinNV)
        {
            NhanVien nhanvien = new NhanVien(_tenNV,_maNV,_cmnd,_soDT);

        }
        void TraCuuHanhKhach(string _tenNV, string _cmnd, string _maNV, string _soDT,string _diaChi, DataGridView ThongTinKH)
        {
            HanhKhach hanhkhach = new HanhKhach(_tenNV, _cmnd, _maNV, _diaChi, _soDT);
        }
        void TraCuuChuyenBay(string _sanBayDi, string _sanBayDen, string ngayKHTu, string _ngayKHDen,DataGridView ThongTinCB)
        {
            
        }
    }
}
