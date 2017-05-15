using DAO;
using System;
using System.Collections.Generic;
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
        public void XemSanBay(DataGridView data,int _page,int _pageSize)
        {
            data.DataSource = SanBay_DAO.Instance.XemSanBay(_page,_pageSize);
        }
      
        public void ThemSanBay(string _sanBayDen,string _sanBayDi)
        {

        }

        public void XoaSanBay(string _maSanBay)
        {

        }

        public List<string> LoadMSB()
        {
            return null;
        }
    }
}
