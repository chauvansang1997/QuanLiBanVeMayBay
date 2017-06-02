using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class PhieuDatCho_BUS
    {
        private static PhieuDatCho_BUS instance;

        public static PhieuDatCho_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhieuDatCho_BUS();
                return instance;
            }

        }
        /// <summary>
        /// Load phiếu đặt chỗ vào combobox
        /// </summary>
        /// <param name="_maPhieuatCho">danh sách phiếu đặt chỗ được load</param>
        public List<string> LoadPhieuDatCho()
        {
            return PhieuDatCho_DAO.Instance.LoadPhieuDatCho();
        }

        /// <summary>
        /// Hủy phiêu đặt chỗ
        /// </summary>
        /// <param name="_maPhieuDatCho">mã phiếu đặt chỗ</param>
        /// <returns></returns>
        public bool HuyPhieuDatCho(string _maPhieuDatCho)
        {
            return PhieuDatCho_DAO.Instance.HuyPhieuDatCho(_maPhieuDatCho);
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
        public bool LapPhieuDatCho(string _tenHanhKhach, string _cmnd, string _soDienThoai, string _maChuyenBay,string _hangVe,int _giaTien,DateTime _ngayGioDat)
        {
            PhieuDatCho phieudatcho = new PhieuDatCho()
            {
                TenHanhKhach = _tenHanhKhach,
                CMND = _cmnd,
                SoDT = _soDienThoai,
                HangVe = _hangVe,
                GiaTien = _giaTien,
                MaCB = _maChuyenBay,
                NgayGioDat = _ngayGioDat,
            };
            return PhieuDatCho_DAO.Instance.LapPhieuDatCho(phieudatcho);
        }
        /// <summary>
        /// Đếm số phiếu đặt chỗ
        /// </summary>
        /// <param name="_tenKhachHang">tên hành khách</param>
        /// <param name="_cmnd">chứng minh nhân dân</param>
        /// <param name="_maPhieuDatCho">mã phiếu đặt chỗ</param>
        /// <param name="_maChuyenBay">mã chuyến bay</param>
        /// <returns></returns>
        public int DemPhieuDatCho(string _tenKhachHang,string _cmnd,string _maPhieuDatCho,string _maChuyenBay)
        {
            PhieuDatCho phieudatcho = new PhieuDatCho()
            {
                TenHanhKhach = _tenKhachHang,
                CMND = _cmnd,
                MaPhieuDatCho = _maPhieuDatCho,
                MaCB = _maChuyenBay,
            };
            return PhieuDatCho_DAO.Instance.DemPhieuDatCho(phieudatcho);
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
        public DataTable TraCuuPhieuDatCho(string _tenKhachHang, string _cmnd, string _maPhieuDatCho, string _maChuyenBay,int pageSize,int pageNumber)
        {
            PhieuDatCho phieudattcho = new PhieuDatCho()
            {
                TenHanhKhach = _tenKhachHang,
                CMND = _cmnd,
                MaCB = _maChuyenBay,
                MaPhieuDatCho = _maPhieuDatCho
            };
            return PhieuDatCho_DAO.Instance.TraCuuPhieuDatCho(phieudattcho,pageSize,pageNumber);
        }
    }
}
