using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
namespace BUS
{
    public class NhanVien_BUS
    {
        private static NhanVien_BUS instance;


        public static NhanVien_BUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVien_BUS();
                return instance;
            }

        }
        private NhanVien_BUS()
        {

        }
        
        public void LoadNhanVien(ComboBox _nhanvien)
        {
            List<string> temp= NhanVien_DAO.Instance.LoadNhanVien();
            _nhanvien.DataSource = temp;

            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            data.AddRange(temp.ToArray());
            _nhanvien.AutoCompleteCustomSource = data;
        }

    }
}
