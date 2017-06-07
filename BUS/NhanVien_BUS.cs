using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public static class NhanVien_BUS
    {
        public static bool SuaThongTinNhanVien(string _maNhanVien,string _tenNhanVien,string _cmnd,string _soDT,string _diaChi)
        {
            return NhanVien_DAO.SuaThongTinNhanVien(new NhanVien()
            {
                MaNV=_maNhanVien,
                TenNV=_tenNhanVien,
                CMND=_cmnd,
                SoDT=_soDT,
                DiaChi=_diaChi,
            });
        }
        public static bool ThemNhanVien(string _tenNhanVien,string _cmnd,string _soDT,string _loaiNV,string _diaChi)
        {
            return NhanVien_DAO.ThemNhanVien(new NhanVien()
            {
                CMND = _cmnd,
                TenNV=_tenNhanVien,
                SoDT=_soDT,
                LoaiNhanVien=_loaiNV,
                DiaChi=_diaChi,
            });
        } 
        public static void LoadNhanVien(ComboBox _nhanvien)
        {
            List<NhanVien> temp= NhanVien_DAO.LoadNhanVien();
            _nhanvien.DataSource = temp;
        }
        public static int DemSoNhanVien(string _tenNV, string _cmnd)
        {
            NhanVien nhanvien = new NhanVien() { CMND=_cmnd,TenNV=_tenNV };

            return NhanVien_DAO.DemSoNhanVien(nhanvien);
        }
        /// <summary>
        /// Tra cứu thông tin nhân viên
        /// </summary>
        /// <param name="_tenNV"></param>
        /// <param name="_cmnd"></param>
        /// <param name="_maNV"></param>
        /// <param name="_soDT"></param>
        /// <param name="_danhSachNV"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        public static  DataTable TraCuuNhanVien(string _tenNV, string _cmnd, int pageSize, int pageNumber)
        {
            NhanVien nhanvien = new NhanVien() { CMND=_cmnd,TenNV=_tenNV };
            return NhanVien_DAO.TraCuuNV(nhanvien, pageSize, pageNumber);
        }
    }
}
