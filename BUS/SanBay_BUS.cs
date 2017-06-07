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
    public static class SanBay_BUS
    {

        public static List<SanBay> LoadSanBay()
        {
            return SanBay_DAO.LoadSanBay();
        }
        public static int DemSanBay(string _tenSanBay)
        {
            return SanBay_DAO.DemSanBay(_tenSanBay);
        }
        public static bool ThemSanBay(string _tenSanBay)
        {
            return SanBay_DAO.ThemSanBay(_tenSanBay);
        }
        public static DataTable TimSanBay(string _tenSanBay,int pageSize,int pageNumber)
        {
            return SanBay_DAO.TimSanBay(_tenSanBay,pageSize,pageNumber);
        }
        public static DataTable XemSanBay(int _page,int _pageSize)
        {
            return SanBay_DAO.XemSanBay(_page,_pageSize);
        }
      

        public static void LoadSanBayDi(ComboBox _sanbaydi)
        {
            List<SanBay> danhsachSBDi = SanBay_DAO.LoadSanBayDi();

            _sanbaydi.DataSource = danhsachSBDi;
            _sanbaydi.DisplayMember = "tenSanBay";
           
            _sanbaydi.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _sanbaydi.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public static void LoadSanBayDen(string _sanBayDi,ComboBox _sanBayDen)
        {
            List<SanBay> danhsachSBDen = SanBay_DAO.LoadSanBayDen(_sanBayDi);

            _sanBayDen.DataSource = danhsachSBDen;
            _sanBayDen.DisplayMember = "tenSanBay";

            _sanBayDen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _sanBayDen.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}
