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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataTable LoadDanhSachHangGhe()
        {
            return ChuyenBay_DAO.Instance.LoadDanhSachHangGhe();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_sanBayDi"></param>
        /// <param name="_sanBayDen"></param>
        /// <param name="_giaVe"></param>
        /// <param name="_thoiGianBay"></param>
        /// <param name="_ngayGioKH"></param>
        /// <param name="_danhSachHangGhe"></param>
        /// <returns></returns>
        public bool NhanLichChuyenBay(string _sanBayDi,string _sanBayDen,int _giaVe,int _thoiGianBay,DateTime _ngayGioKH, DataGridView _danhSachHangGhe)
        {

                ChuyenBay chuyenbay = new ChuyenBay()
                {
                    SanBayDen = _sanBayDen,
                    SanBayDi = _sanBayDi,
                    GiaVe = _giaVe,
                    ThoiGianBay = _thoiGianBay,
                    NgayGioKH = _ngayGioKH,

                };
                return ChuyenBay_DAO.Instance.NhanLichCB(chuyenbay);

           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_maChuyenBay"></param>
        /// <param name="_ngayGioKH"></param>
        /// <param name="_danhSachHangGhe"></param>
        /// <returns></returns>
        public bool ThayDoiChuyenBay(string _maChuyenBay,DateTime _ngayGioKH, DataGridView _danhSachHangGhe)
        {
           

                ChuyenBay chuyenbay = new ChuyenBay()
                {
                    NgayGioKH = _ngayGioKH,

                };

                return ChuyenBay_DAO.Instance.ThayDoiChuyenBay(_maChuyenBay, chuyenbay);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> LoadMaCB()
        {
            return ChuyenBay_DAO.Instance.LoadMaCB();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_sanBayDi"></param>
        /// <param name="_sanBayDen"></param>
        /// <param name="_ngayKHTu"></param>
        /// <param name="_ngayKHDen"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="_maChyenBay"></param>
        /// <returns></returns>
        public DataTable TraCuuSoGhe(string _maChyenBay)
        {
            return ChuyenBay_DAO.Instance.TraCuuSoGhe(_maChyenBay);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_maChuyenBay"></param>
        /// <returns></returns>
        public DataTable TraCuuSBTG(string _maChuyenBay)
        {
            return ChuyenBay_DAO.Instance.TraCuuSanBayTG(_maChuyenBay);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_maChyenBay"></param>
        /// <returns></returns>
        public bool HuyChuyenBay(string _maChyenBay)
        {
            return ChuyenBay_DAO.Instance.HuyChuyenBay(_maChyenBay);
        }

    }
}
