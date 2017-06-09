using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public static class HanhKhach_BUS
    {
        public static List<HanhKhach> LoadHanhKhach()
        {
           return HanhKhach_DAO.LoadHanhKhach();

            
        }
        /// <summary>
        /// Load những khách hàng có trong vé 
        /// </summary>
        /// <param name="_hanhKhach"></param>
        public static void LoadHanhKhachVe(ComboBox _hanhKhach)
        {
            List<HanhKhach> danhsachHK = HanhKhach_DAO.LoadHanhKhachVe();

            _hanhKhach.DataSource = danhsachHK;
            _hanhKhach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _hanhKhach.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        /// <summary>
        /// Load những khách hàng có trong phiếu đặt chổ
        /// </summary>
        /// <param name="_hanhKhach"></param>
        public static List<HanhKhach> LoadHanhKhachPDC()
        {
            
             return  HanhKhach_DAO.LoadHanhKhachPDC();

        }
        /// <summary>
        /// Đếm số khách hàng hiện tại
        /// </summary>
        /// <param name="_tenHanhKhach"></param>
        /// <param name="_soDT"></param>
        /// <param name="_CMND"></param>
        /// <returns></returns>
        public static int DemHanhKhach(string _tenHanhKhach,string _soDT,string _CMND)
        {
            HanhKhach hanhkhach = new HanhKhach() { TenHanhKhach = _tenHanhKhach, CMND = _CMND, SoDT = _soDT };

            return HanhKhach_DAO.DemSoHanhKhach(hanhkhach);
        }
        /// <summary>
        /// Tra cứu thông tin hành khách
        /// </summary>
        /// <param name="_tenNV"></param>
        /// <param name="_cmnd"></param>
        /// <param name="_soDT"></param>
        /// <param name="_danhsachKH"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageNumber"></param>
        public static DataTable TraCuuHanhKhach(string _tenNV, string _cmnd, string _soDT, int pageSize, int pageNumber)
        {
            HanhKhach hanhkhach = new HanhKhach() { TenHanhKhach = _tenNV, CMND = _cmnd, SoDT = _soDT };

            return HanhKhach_DAO.TraCuuHK(hanhkhach, pageSize, pageNumber);
        }

       
    }
}
