using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class VeDat_BUS
    {
        private static VeDat_BUS instance;

        public static VeDat_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new VeDat_BUS();
                return instance;
            }

        }

        public bool GhiNhanDatVe(string _tenHanhKhach, string _soDT, string _maCB,string _cmnd, int _giatien,string _hangVe)
        {
            VeDat vetdat = new VeDat() { TenHanhKhach=_tenHanhKhach,CMND=_cmnd,GiaTien=_giatien,HangVe=_hangVe,MaCB=_maCB,SoDT=_soDT};

            return VeDat_DAO.Instance.GhiNhanDatVe(vetdat);
        }

    }
}
