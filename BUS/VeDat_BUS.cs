using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public static class VeDat_BUS
    {

        public static event EventHandler<SqlException> sqlException;
        public static bool GhiNhanDatVe(string _tenHanhKhach, string _soDT, string _maCB,string _cmnd,string _hangVe)
        {
            VeDat vetdat = new VeDat() { TenHanhKhach=_tenHanhKhach,CMND=_cmnd,HangVe=_hangVe,MaCB=_maCB,SoDT=_soDT};

           
            VeDat_DAO.sqlException += sqlException;

            return VeDat_DAO.GhiNhanDatVe(vetdat);
        }

        public static DataTable TraCuuVe(string _tenKhachHang, string _cmnd, string _maVe, string _maChuyenBay, int pageSize, int pageNumber)
        {
            VeDat veDat = new VeDat()
            {
                TenHanhKhach = _tenKhachHang,
                CMND = _cmnd,
                MaCB = _maChuyenBay,
                MaVe = _maVe
            };
            return VeDat_DAO.TraCuuVe(veDat,pageSize,pageNumber);

        }

        public static bool HuyVe(string _maVe)
        {
            return VeDat_DAO.HuyVe(_maVe);
        } 
        public static int DemVe(string _tenKhachHang, string _cmnd, string _maVe, string _maChuyenBay)
        {

            return VeDat_DAO.DemVe(new VeDat()
            { 
                TenHanhKhach=_tenKhachHang,
                CMND=_cmnd,
                MaVe=_maVe,
                MaCB=_maChuyenBay
            }
            );
        }
    }
}
