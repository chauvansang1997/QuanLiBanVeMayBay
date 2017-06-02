using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /// Hủy phiêu đặt chỗ
        /// </summary>
        /// <param name="_maPhieuDatCho"></param>
        /// <returns></returns>
        public bool HuyPhieuDatCho(string _maPhieuDatCho)
        {
            return PhieuDatCho_DAO.Instance.HuyPhieuDatCho(_maPhieuDatCho);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_tenKhachHang"></param>
        /// <param name="_cmnd"></param>
        /// <param name="_soDienThoai"></param>
        /// <param name="_maChuyenBay"></param>
        /// <param name="_hangVe"></param>
        /// <param name="_giaTien"></param>
        /// <param name="_ngayGioDat"></param>
        /// <returns></returns>
        public bool LapPhieuDatCho(string _tenKhachHang, string _cmnd, string _soDienThoai, string _maChuyenBay,string _hangVe,int _giaTien,DateTime _ngayGioDat)
        {
            PhieuDatCho phieudatcho = new PhieuDatCho()
            {
                TenHanhKhach = _tenKhachHang,
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
        /// 
        /// </summary>
        /// <param name="_tenKhachHang"></param>
        /// <param name="_cmnd"></param>
        /// <param name="_maPhieuDatCho"></param>
        /// <param name="_maChuyenBay"></param>
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
    }
}
