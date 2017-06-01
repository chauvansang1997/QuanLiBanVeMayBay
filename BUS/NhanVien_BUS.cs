using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

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
        public int DemSoNhanVien(string _tenNV, string _cmnd, string _maNV, string _soDT)
        {
            NhanVien nhanvien = new NhanVien(_tenNV, _maNV, _cmnd, _soDT);

            return NhanVien_DAO.Instance.DemSoNhanVien(nhanvien);
        }

    }
}
