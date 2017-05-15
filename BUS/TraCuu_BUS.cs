using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
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
        public void TraCuuNhanVien(string _tenNV,string _cmnd,string _maNV,string _soDT,DataGridView _danhSachNV,int pageSize, int pageNumber)
        {
            NhanVien nhanvien = new NhanVien(_tenNV,_maNV,_cmnd,_soDT);

        }

        /// <summary>
        /// Đếm số lượng nhân viên
        /// </summary>
        /// <param name="_tenNV"></param>
        /// <param name="_cmnd"></param>
        /// <param name="_maNV"></param>
        /// <param name="_soDT"></param>
        /// <param name="_danhSachNV"></param>
        /// <returns></returns>
        public int DemSoNhanVien(string _tenNV, string _cmnd, string _maNV, string _soDT, DataGridView _danhSachNV)
        {
            NhanVien nhanvien = new NhanVien(_tenNV, _maNV, _cmnd, _soDT);

            return TraCuu_DAO.Instance.DemSoNhanVien(nhanvien);
        }

        /// <summary>
        /// Tra cứu thông tin hành khách
        /// </summary>
        /// <param name="_tenNV"></param>
        /// <param name="_cmnd"></param>
        /// <param name="_soDT"></param>
        /// <param name="_danhsachKH"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        public void TraCuuHanhKhach(string _tenNV, string _cmnd, string _soDT, DataGridView _danhsachKH, int pageSize, int pageNumber)
        {
            HanhKhach hanhkhach = new HanhKhach() { Name=_tenNV,CMND=_cmnd,SoDT=_soDT};
            _danhsachKH.DataSource = TraCuu_DAO.Instance.TraCuuHK(hanhkhach,pageSize,pageNumber);
        }

        /// <summary>
        /// Đếm số lượng hành khách
        /// </summary>
        /// <param name="_tenNV"></param>
        /// <param name="_cmnd"></param>
        /// <param name="_soDT"></param>
        /// <param name="_danhsachKH"></param>
        /// <returns></returns>
        public int DemSoHanhKhach(string _tenNV, string _cmnd, string _soDT, DataGridView _danhsachKH)
        {
            HanhKhach hanhkhach = new HanhKhach() { Name = _tenNV, CMND = _cmnd, SoDT = _soDT };

            return TraCuu_DAO.Instance.DemSoHanhKhach(hanhkhach);
        }

        /// <summary>
        /// Tra cứu thông tin chuyến bay
        /// </summary>
        /// <param name="_sanBayDi"></param>
        /// <param name="_sanBayDen"></param>
        /// <param name="_ngayKHTu"></param>
        /// <param name="_ngayKHDen"></param>
        /// <param name="_danhsachCB"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        public void TraCuuChuyenBay(string _sanBayDi, string _sanBayDen, DateTime _ngayKHTu, DateTime _ngayKHDen,DataGridView _danhsachCB,int pageSize,int pageNumber)
        {
            ChuyenBay_TraCuu chuyenbay = new ChuyenBay_TraCuu() { SanBayDi=_sanBayDi,SanBayDen=_sanBayDen, NgayKHTu=_ngayKHTu,NgayKHDen=_ngayKHDen};
            _danhsachCB.DataSource = TraCuu_DAO.Instance.TraCuuChuyenBay(chuyenbay, pageSize, pageNumber);
        }

        /// <summary>
        /// Đếm số lượng chuyến bay
        /// </summary>
        /// <param name="_sanBayDi"></param>
        /// <param name="_sanBayDen"></param>
        /// <param name="_ngayKHTu"></param>
        /// <param name="_ngayKHDen"></param>
        /// <param name="_danhsachCB"></param>
        /// <returns></returns>
        public int DemSoChuyenBay(string _sanBayDi, string _sanBayDen, DateTime _ngayKHTu, DateTime _ngayKHDen, DataGridView _danhsachCB)
        {
            ChuyenBay_TraCuu chuyenbay = new ChuyenBay_TraCuu() { SanBayDi = _sanBayDi, SanBayDen = _sanBayDen, NgayKHTu = _ngayKHTu, NgayKHDen = _ngayKHDen };

            return TraCuu_DAO.Instance.DemSoChuyenBay(chuyenbay);
        }

    }
}
