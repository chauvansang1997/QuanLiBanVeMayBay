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
    public class SanBay_BUS
    {

        private static SanBay_BUS instance;


        public static SanBay_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanBay_BUS();
                return instance;
            }

        }
        private SanBay_BUS()
        {

        }
        public DataTable XemSanBay(DataGridView data,int _page,int _pageSize)
        {
            return SanBay_DAO.Instance.XemSanBay(_page,_pageSize);
        }
      
        public void ThemSanBay(string _sanBayDen,string _sanBayDi)
        {

        }

        public void XoaSanBay(string _maSanBay)
        {

        }

        public void LoadSanBayDi(ComboBox _sanbaydi)
        {
            List<SanBay> danhsachSBDi = SanBay_DAO.Instance.LoadSanBayDi();

            _sanbaydi.DataSource = danhsachSBDi;
            _sanbaydi.DisplayMember = "tenSanBay";
        }

        public void LoadSanBayDen(string _sanBayDi,ComboBox _sanBayDen)
        {
            List<SanBay> danhsachSBDen = SanBay_DAO.Instance.LoadSanBayDen(_sanBayDi);

            _sanBayDen.DataSource = danhsachSBDen;
            _sanBayDen.DisplayMember = "tenSanBay";
        }
    }
}
