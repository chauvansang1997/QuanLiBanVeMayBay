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

        public bool GhiNhanDatVe(string _tenHanhKhach, string _soDT, string _maCB, string _cmnd, int _giatien, DateTime _ngayGioDat, string _hangVe)
        {
            PhieuDatCho phieudatcho = new PhieuDatCho() { TenHanhKhach = _tenHanhKhach, CMND = _cmnd, GiaTien = _giatien, HangVe = _hangVe, MaCB = _maCB, NgayGioDat = _ngayGioDat, SoDT = _soDT };

            return VeDat_DAO.Instance.GhiNhanDatVe(phieudatcho);
        }
    }
}
