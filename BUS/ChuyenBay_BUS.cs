using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
using System.Data;
using System.Drawing;

namespace BUS
{
    public static class ChuyenBay_BUS
    {

        public static bool HuyChuyenBay(string _maChuyenBay)
        {
            return ChuyenBay_DAO.HuyChuyenBay(_maChuyenBay);
        }
        /// <summary>
        /// Load ma chuyến bay trong form hủy vé
        /// </summary>
        /// <returns></returns>
        public static List<string> LoadChuyenBayVe()
        {
            return ChuyenBay_DAO.LoadMaChuyenBayVe();
        }

        public static List<string> LoadChuyenBayPDC()
        {
            return ChuyenBay_DAO.LoadMaChuyenBayPDC();
        }
        /// <summary>
        /// Xóa sân bay trung gian
        /// </summary>
        /// <param name="_maChuyenBay"></param>
        /// <returns></returns>
        public static bool XoaSanBayTrungGian(string _maChuyenBay)
        {
            return ChuyenBay_DAO.XoaSanBayTrungGian(_maChuyenBay);
        }
       /// <summary>
       /// Nhập chi tiết hạng ghế
       /// </summary>
       /// <param name="_maChuyenBay"></param>
       /// <param name="_maHangVe"></param>
       /// <param name="_soGhe"></param>
        public static void NhapChiTietHangGhe(string _maChuyenBay,string _maHangVe,int _soGhe)
        {
            HangGhe hangGhe = new HangGhe()
            {
                MaChuyenBay = _maChuyenBay,
                MaHangVe = _maHangVe,
                SoGhe = _soGhe
            };
            ChuyenBay_DAO.NhapChiTietHangGhe(hangGhe);
        }
        /// <summary>
        /// Nhập đơn giá
        /// </summary>
        /// <param name="_machuyenbay"></param>
        /// <param name="_dongia"></param>
        public static void NhapDonGia(string _machuyenbay, int _dongia)
        {
            ChuyenBay_DAO.NhapDonGia(_machuyenbay, _dongia);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_maChuyenBay"></param>
        /// <param name="_maSanBay"></param>
        /// <param name="_thoiGianDung"></param>
        /// <param name="_ghiChu"></param>
        public static void NhapChiTietChuyenBay(string _maChuyenBay,string _maSanBay,int _thoiGianDung,string _ghiChu)
        {
            ChuyenBay_DAO.NhapChiTietChuyenBay(new SanBayTrungGian()
            {
                MaChuyenBay = _maChuyenBay,
                MaSanBay = _maSanBay,
                ThoiGianDung = _thoiGianDung,
                GhiChu = _ghiChu
            });

        }

        /// <summary>
        /// Load san bay trung gian vao combobox
        /// </summary>
        public static void LoadDanhSachSanBayTG(ComboBox _dsSanBayTG, string _tenSanBay)
        {
            _dsSanBayTG.DataSource= ChuyenBay_DAO.LoadDanhSachSBTG(_tenSanBay);

            _dsSanBayTG.DisplayMember = "tenSanBay";
            _dsSanBayTG.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _dsSanBayTG.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        /// <summary>
        /// Load san bay trung gian vào datagridview
        /// </summary>
        /// <param name="dsSanBayTG"></param>
        /// <param name="_tenSanBay"></param>
        public static void LoadDanhSachSanBayTG(DataGridView dsSanBayTG)
        {
            dsSanBayTG.DataSource = ChuyenBay_DAO.LoadDanhSachSBTG();
           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static DataTable LoadDanhSachHangGhe()
        {
            DataTable table = ChuyenBay_DAO.LoadDanhSachHangGhe();
            table.Columns[1].ReadOnly = true;

            return table; 
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
        public static bool NhanLichChuyenBay(string _sanBayDi,string _sanBayDen,int _giaVe,int _thoiGianBay,DateTime _ngayGioKH,out string _maChuyenBay)
        {

         
            ChuyenBay chuyenbay = new ChuyenBay()
            {
                SanBayDi = _sanBayDi,
                SanBayDen = _sanBayDen,
                ThoiGianBay = _thoiGianBay,
                NgayGioKH = _ngayGioKH
            };

            return ChuyenBay_DAO.NhapLichCB(chuyenbay, out _maChuyenBay);

           
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_maChuyenBay"></param>
        /// <param name="_ngayGioKH"></param>
        /// <param name="_danhSachHangGhe"></param>
        /// <returns></returns>
        public static bool ThayDoiChuyenBay(string _maChuyenBay,DateTime _ngayGioKH, DataGridView _danhSachHangGhe)
        {
           

                ChuyenBay chuyenbay = new ChuyenBay()
                {
                    NgayGioKH = _ngayGioKH,

                };

                return ChuyenBay_DAO.ThayDoiChuyenBay(_maChuyenBay, chuyenbay);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static void LoadMaChuyenBay(ComboBox _chuyenbay)
        {
            _chuyenbay.DataSource= ChuyenBay_DAO.LoadMaChuyenBay();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_sanBayDi"></param>
        /// <param name="_sanBayDen"></param>
        /// <param name="_ngayKHTu"></param>
        /// <param name="_ngayKHDen"></param>
        /// <returns></returns>
        public static int DemChuyenBay(string _sanBayDi, string _sanBayDen, DateTime? _ngayKHTu, DateTime? _ngayKHDen)
        {
       

            return ChuyenBay_DAO.DemSoChuyenBay( _sanBayDi,  _sanBayDen,  _ngayKHTu, _ngayKHDen);
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
        public static DataTable TraCuuChuyenBay(string _sanBayDi, string _sanBayDen, int pageSize, int pageNumber, DateTime? _ngayKHTu, DateTime? _ngayKHDen)
        {


            //Bảng chứa thông tin chuyến bay và số ghế các hạng vé
            DataTable danhSachChuyenBay = ChuyenBay_DAO.TraCuuChuyenBay(_sanBayDi, _sanBayDen, _ngayKHTu, _ngayKHDen, pageSize, pageNumber);

            return danhSachChuyenBay;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_maChyenBay"></param>
        /// <returns></returns>
        public static DataTable TraCuuSoGhe(string _maChyenBay)
        {
            return ChuyenBay_DAO.TraCuuSoGhe(_maChyenBay);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_maChuyenBay"></param>
        /// <returns></returns>
        public static DataTable TraCuuSBTG(string _maChuyenBay)
        {
            return ChuyenBay_DAO.TraCuuSanBayTG(_maChuyenBay);
        }



    }
}
