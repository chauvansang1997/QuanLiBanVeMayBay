using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using System.Data;

namespace BUS
{
    public class TraCuu_BUS
    {
        private static TraCuu_BUS instance;

        public static TraCuu_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TraCuu_BUS();
                return instance;
            }

        }

        /// <summary>
        /// Tra cứu thông tin nhân viên
        /// </summary>
        /// <param name="_tenNV"></param>
        /// <param name="_cmnd"></param>
        /// <param name="_maNV"></param>
        /// <param name="_soDT"></param>
        /// <param name="_danhSachNV"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        public DataTable TraCuuNhanVien(string _tenNV,string _cmnd,string _maNV,string _soDT,int pageSize, int pageNumber)
        {
            NhanVien nhanvien = new NhanVien(_tenNV,_maNV,_cmnd,_soDT);
            return TraCuu_DAO.Instance.TraCuuNV(nhanvien, pageSize, pageNumber);
        }

        /// <summary>
        /// Đếm số lượng nhân viên
        /// </summary>
        /// <param name="_tenNV"></param>
        /// <param name="_cmnd"></param>
        /// <param name="_maNV"></param>
        /// <param name="_soDT"></param>
        /// <param name="_danhSachNV"></param>
        /// <returns></returns>
       
        /// <summary>
        /// Tra cứu thông tin hành khách
        /// </summary>
        /// <param name="_tenNV"></param>
        /// <param name="_cmnd"></param>
        /// <param name="_soDT"></param>
        /// <param name="_danhsachKH"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        public DataTable TraCuuHanhKhach(string _tenNV, string _cmnd, string _soDT, int pageSize, int pageNumber)
        {
            HanhKhach hanhkhach = new HanhKhach() { Name=_tenNV,CMND=_cmnd,SoDT=_soDT};

            return TraCuu_DAO.Instance.TraCuuHK(hanhkhach,pageSize,pageNumber);
        }

        /// <summary>
        /// Đếm số lượng hành khách
        /// </summary>
        /// <param name="_tenNV"></param>
        /// <param name="_cmnd"></param>
        /// <param name="_soDT"></param>
        /// <param name="_danhsachKH"></param>
        /// <returns></returns>
      

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
        public DataTable TraCuuChuyenBay(string _sanBayDi, string _sanBayDen, int pageSize, int pageNumber,DateTime? _ngayKHTu, DateTime? _ngayKHDen)
        {
            ChuyenBay_TraCuu chuyenbay = new ChuyenBay_TraCuu() { SanBayDi=_sanBayDi,SanBayDen=_sanBayDen, NgayKHTu=_ngayKHTu,NgayKHDen=_ngayKHDen};

            //Bảng chứa thông tin chuyến bay và số ghế các hạng vé
            DataTable danhSachChuyenBay= TraCuu_DAO.Instance.TraCuuChuyenBay(chuyenbay, pageSize, pageNumber);

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
           return TraCuu_DAO.Instance.TraCuuSoGhe(_maChyenBay);
        }
        
        public DataTable TraCuuSBTG(string _maChuyenBay)
        {
            return TraCuu_DAO.Instance.TraCuuSanBayTG(_maChuyenBay);
        }

    }
}
