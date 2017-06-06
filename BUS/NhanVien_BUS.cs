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

        
        public static void LoadNhanVien(ComboBox _nhanvien)
        {
            List<string> temp= NhanVien_DAO.LoadNhanVien();
            _nhanvien.DataSource = temp;

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            data.AddRange(temp.ToArray());
            _nhanvien.AutoCompleteCustomSource = data;
        }
        public static int DemSoNhanVien(string _tenNV, string _cmnd, string _maNV, string _soDT)
        {
            NhanVien nhanvien = new NhanVien(_tenNV, _maNV, _cmnd, _soDT);

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
        public static  DataTable TraCuuNhanVien(string _tenNV, string _cmnd, string _maNV, string _soDT, int pageSize, int pageNumber)
        {
            NhanVien nhanvien = new NhanVien(_tenNV, _maNV, _cmnd, _soDT);
            return NhanVien_DAO.TraCuuNV(nhanvien, pageSize, pageNumber);
        }
    }
}
