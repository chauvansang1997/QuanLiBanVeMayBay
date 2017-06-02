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
    public class NhanVien_BUS
    {
        private static NhanVien_BUS instance;


        public static NhanVien_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVien_BUS();
                return instance;
            }

        }
        private NhanVien_BUS()
        {

        }
        
        public void LoadNhanVien(ComboBox _nhanvien)
        {
            List<string> temp= NhanVien_DAO.Instance.LoadNhanVien();
            _nhanvien.DataSource = temp;

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            data.AddRange(temp.ToArray());
            _nhanvien.AutoCompleteCustomSource = data;
        }
        public int DemSoNhanVien(string _tenNV, string _cmnd, string _maNV, string _soDT)
        {
            NhanVien nhanvien = new NhanVien(_tenNV, _maNV, _cmnd, _soDT);

            return NhanVien_DAO.Instance.DemSoNhanVien(nhanvien);
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
        public DataTable TraCuuNhanVien(string _tenNV, string _cmnd, string _maNV, string _soDT, int pageSize, int pageNumber)
        {
            NhanVien nhanvien = new NhanVien(_tenNV, _maNV, _cmnd, _soDT);
            return NhanVien_DAO.Instance.TraCuuNV(nhanvien, pageSize, pageNumber);
        }
    }
}
