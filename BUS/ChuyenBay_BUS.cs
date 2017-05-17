using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace BUS
{
    public class ChuyenBay_BUS
    {
        private  static ChuyenBay_BUS instance;

        public static ChuyenBay_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChuyenBay_BUS();
                return instance;
            }
           
        }
        private ChuyenBay_BUS()
        {

        }

        

        public bool NhanLichChuyenBay(string _sanBayDi,string _sanBayDen,int _giaVe,int _thoiGianBay,DateTime _ngayGioKH, List<int> _soGheCacHangVe)
        {
            ChuyenBay chuyenbay = new ChuyenBay()
            {
                SanBayDen = _sanBayDen,
                SanBayDi = _sanBayDi,
                GiaVe = _giaVe,
                ThoiGianBay = _thoiGianBay,
                NgayGioKH = _ngayGioKH,
                SoGheCacHangVe = _soGheCacHangVe,
                
            };
            return ChuyenBay_DAO.Instance.NhanLichCB(chuyenbay);
        }

        public bool ThayDoiChuyenBay(string _maChuyenBay,DateTime _ngayGioKH, List<int> _soGheCacHangVe)
        {
            ChuyenBay chuyenbay = new ChuyenBay()
            {
                NgayGioKH = _ngayGioKH,
                SoGheCacHangVe = _soGheCacHangVe,
            };

            return ChuyenBay_DAO.Instance.ThayDoiChuyenBay(_maChuyenBay, chuyenbay);
        }
        

        public List<string> LoadMaCB()
        {
            return ChuyenBay_DAO.Instance.LoadMaCB();
        }
    }
}
