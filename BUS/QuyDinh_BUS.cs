using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public static class QuyDinh_BUS
    {
        public static void LoadQuyDinh()
        {
            DataRow row= QuyDinh_DAO.LoadQuyDinh();

            QuyDinh.SoLuongHangVe = row.Field<int>("SoLuongHangVe");

            QuyDinh.SoLuongSanBay = row.Field<int>("SoLuongSanBay");

            QuyDinh.ThoiGianBayToiThieu = row.Field<int>("ThoiGianBayToiThieu");

            QuyDinh.ThoiGianChamNhatDatVe = row.Field<int>("ThoiGianChamNhatDatVe");

            QuyDinh.ThoiGianChamNhatHuyVe = row.Field<int>("ThoiGianChamNhatHuyVe");

            QuyDinh.ThoiGianDungToiDa = row.Field<int>("ThoiGianDungToiDa");

            QuyDinh.ThoiGianDungToiThieu = row.Field<int>("ThoiGianDungToiThieu");
            
        }

        public static bool ThayDoiQuyDinhCB()
        {
            return QuyDinh_DAO.ThayDoiQuyDinhChuyenBay();
        }

        public static bool ThayDoiQuyDinhVe()
        {
            return QuyDinh_DAO.ThayDoiQuyDinhVe();
        }

        public static bool ThayDoiQuyDinhSanBay()
        {
            return QuyDinh_DAO.ThayDoiQuyDinhSanBay();
        }
    }
}
