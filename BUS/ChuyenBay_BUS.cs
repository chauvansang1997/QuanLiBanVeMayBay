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

        

        public bool NhanLichChuyenBay(string _sanBayDi,string _sanBayDen,int _giaVe,int _thoiGianBay,DateTime _ngayGioKH, DataGridView _danhSachHangGhe)
        {
            try
            {
                List<int> _soGheCacHangVe = new List<int>();

                foreach (DataRow item in _danhSachHangGhe.Rows)
                {
                    _soGheCacHangVe.Add(Convert.ToInt32(item[1]));
                }

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
            catch (Exception )
            {
                return false;
            }
           
        }

        public bool ThayDoiChuyenBay(string _maChuyenBay,DateTime _ngayGioKH, DataGridView _danhSachHangGhe)
        {
            try
            {
                List<int> _soGheCacHangVe = new List<int>();

                foreach (DataRow item in _danhSachHangGhe.Rows)
                {
                    _soGheCacHangVe.Add(Convert.ToInt32(item[1]));
                }

                ChuyenBay chuyenbay = new ChuyenBay()
                {
                    NgayGioKH = _ngayGioKH,
                    SoGheCacHangVe = _soGheCacHangVe,
                };

                return ChuyenBay_DAO.Instance.ThayDoiChuyenBay(_maChuyenBay, chuyenbay);
            }
            catch (Exception)
            {
                return false;
                
            }
            
        }
        

        public List<string> LoadMaCB()
        {
            return ChuyenBay_DAO.Instance.LoadMaCB();
        }
        public int DemChuyenBay(string _sanBayDi, string _sanBayDen, DateTime? _ngayKHTu, DateTime? _ngayKHDen)
        {
       

            return ChuyenBay_DAO.Instance.DemSoChuyenBay( _sanBayDi,  _sanBayDen,  _ngayKHTu, _ngayKHDen);
        }

        /// <summary>
        /// Tra cứu thông tin chuyến bay
        /// </summary>
        /// <param name="_sanBayDi"> sân bay đi </param>
        /// <param name="_sanBayDen"> sân bay đến </param>
        /// <param name="_ngayKHTu"> ngày khởi hành từ </param>
        /// <param name="_ngayKHDen"> ngày khởi hành đến </param>
        /// <param name="_danhsachCB"> danh sách chuyến bay </param>
        /// <param name="pageSize"> kích thước của một trang </param>
        /// <param name="pageNumber"> trang hiện tại cần xuất </param>
        public DataTable TraCuuChuyenBay(string _sanBayDi, string _sanBayDen, int pageSize, int pageNumber, DateTime? _ngayKHTu, DateTime? _ngayKHDen)
        {


            //Bảng chứa thông tin chuyến bay và số ghế các hạng vé
            DataTable danhSachChuyenBay = ChuyenBay_DAO.Instance.TraCuuChuyenBay(_sanBayDi, _sanBayDen, _ngayKHTu, _ngayKHDen, pageSize, pageNumber);

            return danhSachChuyenBay;
        }

        /// <summary>
        /// Đếm số lượng chuyến bay
        /// </summary>
        /// <param name="_sanBayDi"></param>
        /// <param name="_sanBayDen"></param>
        /// <param name="_ngayKHTu"></param>
        /// <param name="_ngayKHDen"></param>
        /// <returns></returns>

        public DataTable TraCuuSoGhe(string _maChyenBay)
        {
            return ChuyenBay_DAO.Instance.TraCuuSoGhe(_maChyenBay);
        }

        public DataTable TraCuuSBTG(string _maChuyenBay)
        {
            return ChuyenBay_DAO.Instance.TraCuuSanBayTG(_maChuyenBay);
        }


        public bool HuyChuyenBay(string _maChyenBay)
        {
            return ChuyenBay_DAO.Instance.HuyChuyenBay(_maChyenBay);
        }

    }
}
