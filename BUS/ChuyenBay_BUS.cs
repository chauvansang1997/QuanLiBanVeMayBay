using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
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
        public void XemChuyenBay(DataGridView data)
        {
            data.DataSource = ChuyenBay_DAO.Instance.XemChuyenBay();
        }
    }
}
