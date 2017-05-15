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

        public int DemSoChuyenBay(string _sanBayDi,string _sanBayDen,string, DateTime _ngayKHTu,DateTime _ngayKHDen)
        {
            return 0;
        }

        public void XemChuyenBay(DataGridView _danhsachCB,DataGridView _danhsachSBTG,int pageSize,int pageNumber)
        {
            //data.DataSource = ChuyenBay_DAO.Instance.XemChuyenBay(pageNumber,pageNumber);
        }
        public void NhanLichChuyenBay()
        {

        }

        public List<string> LoadMaCB()
        {
            return ChuyenBay_DAO.Instance.LoadMaCB();
        }
    }
}
