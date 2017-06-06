using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public static class HangVe_BUS
    {
        public static void LoadTenHangVe(ComboBox _hangVe,string _tenHangVe)
        {
            _hangVe.DataSource = HangVe_DAO.LoadTenHangVe(_tenHangVe);
            _hangVe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _hangVe.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        public static void LoadHangVe(ComboBox _hangVe)
        {
            _hangVe.DataSource = HangVe_DAO.LoadHangVe();
            _hangVe.DisplayMember = "TenHangVe";
            _hangVe.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            _hangVe.AutoCompleteSource = AutoCompleteSource.ListItems;

        }
        public static int DemSoLuongHangVe()
        {
            return HangVe_DAO.DemSoLuongHangVe();
        }
    }
}
