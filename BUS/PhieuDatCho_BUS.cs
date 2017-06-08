using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BUS
{
    public static class PhieuDatCho_BUS
    {

        public static event EventHandler<SqlException> LapPhieuDC_sqlException;
        /// <summary>
        /// Load phiếu đặt chỗ vào combobox
        /// </summary>
        /// <param name="_maPhieuatCho">danh sách phiếu đặt chỗ được load</param>
        public static void LoadPhieuDatCho(ComboBox _phieuDatCho)
        {
            
            _phieuDatCho.DataSource = PhieuDatCho_DAO.LoadPhieuDatCho();

        }

        /// <summary>
        /// Hủy phiêu đặt chỗ
        /// </summary>
        /// <param name="_maPhieuDatCho">mã phiếu đặt chỗ</param>
        /// <returns></returns>
        public static bool HuyPhieuDatCho(string _maPhieuDatCho)
        {
            return PhieuDatCho_DAO.HuyPhieuDatCho(_maPhieuDatCho);
        }
        /// <summary>
        /// Hủy phiếu đặt chổ
        /// </summary>
        /// <param name="_tenHanhKhach">tên hành khách</param>
        /// <param name="_cmnd">chứng minh nhân dân</param>
        /// <param name="_soDienThoai">số điện thoại</param>
        /// <param name="_maChuyenBay">mã chuyến bay</param>
        /// <param name="_hangVe">hạng vé</param>
        /// <param name="_giaTien">giá tiền</param>
        /// <param name="_ngayGioDat">ngày giờ đặt phiếu</param>
        /// <returns></returns>
        public static bool LapPhieuDatCho(string _tenHanhKhach, string _cmnd, string _soDienThoai, string _maChuyenBay,string _hangVe,DateTime _ngayGioDat)
        {
            PhieuDatCho phieudatcho = new PhieuDatCho()
            {
                TenHanhKhach = _tenHanhKhach,
                CMND = _cmnd,
                SoDT = _soDienThoai,
                HangVe = _hangVe,
                MaCB = _maChuyenBay,
                NgayGioDat = _ngayGioDat,
            };



            return PhieuDatCho_DAO.LapPhieuDatCho(phieudatcho);
        }
        /// <summary>
        /// Đếm số phiếu đặt chỗ
        /// </summary>
        /// <param name="_tenKhachHang">tên hành khách</param>
        /// <param name="_cmnd">chứng minh nhân dân</param>
        /// <param name="_maPhieuDatCho">mã phiếu đặt chỗ</param>
        /// <param name="_maChuyenBay">mã chuyến bay</param>
        /// <returns></returns>
        public static int DemPhieuDatCho(string _tenKhachHang,string _cmnd,string _maPhieuDatCho,string _maChuyenBay)
        {
            PhieuDatCho phieudatcho = new PhieuDatCho()
            {
                TenHanhKhach = _tenKhachHang,
                CMND = _cmnd,
                MaPhieuDatCho = _maPhieuDatCho,
                MaCB = _maChuyenBay,
            };
            return PhieuDatCho_DAO.DemPhieuDatCho(phieudatcho);
        }

        /// <summary>
        /// Tra cứu phiếu đặt chỗ
        /// </summary>
        /// <param name="_tenKhachHang">tên hành khách</param>
        /// <param name="_cmnd">chứng minh nhân dân</param>
        /// <param name="_maPhieuDatCho">mã phiếu đặt chỗ</param>
        /// <param name="_maChuyenBay">mã chuyến bay</param>
        /// <param name="pageSize">Kích thước trang cần load</param>
        /// <param name="pageNumber">số trang cần load</param>
        /// <returns></returns>
        public static DataTable TraCuuPhieuDatCho(string _tenKhachHang, string _cmnd, string _maPhieuDatCho, string _maChuyenBay,int pageSize,int pageNumber)
        {
            PhieuDatCho phieudattcho = new PhieuDatCho()
            {
                TenHanhKhach = _tenKhachHang,
                CMND = _cmnd,
                MaCB = _maChuyenBay,
                MaPhieuDatCho = _maPhieuDatCho
            };
            return PhieuDatCho_DAO.TraCuuPhieuDatCho(phieudattcho,pageSize,pageNumber);
        }
    }
}
