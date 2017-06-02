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
    public class HanhKhach_BUS
    {

        private static HanhKhach_BUS instance;

        public static HanhKhach_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HanhKhach_BUS();
                return instance;
            }

        }

        private HanhKhach_BUS()
        {

        }

        public void LoadHanhKhach(ComboBox _hanhKhach)
        {
            List<string> danhsachHK= HanhKhach_DAO.Instance.LoadHanhKhach();
            _hanhKhach.DataSource = danhsachHK;
            AutoCompleteStringCollection temp = new AutoCompleteStringCollection();
            temp.AddRange(danhsachHK.ToArray());
            _hanhKhach.AutoCompleteCustomSource = temp;

        }

        public int DemHanhKhach(string _tenHanhKhach,string _soDT,string _CMND)
        {
            HanhKhach hanhkhach = new HanhKhach() { Name = _tenHanhKhach, CMND = _CMND, SoDT = _soDT };

            return HanhKhach_DAO.Instance.DemSoHanhKhach(hanhkhach);
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
        public DataTable TraCuuHanhKhach(string _tenNV, string _cmnd, string _soDT, int pageSize, int pageNumber)
        {
            HanhKhach hanhkhach = new HanhKhach() { Name = _tenNV, CMND = _cmnd, SoDT = _soDT };

            return HanhKhach_DAO.Instance.TraCuuHK(hanhkhach, pageSize, pageNumber);
        }
    }
}
