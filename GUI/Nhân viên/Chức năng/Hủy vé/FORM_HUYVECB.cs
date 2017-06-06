using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FORM_HUYVECB : Form
    {
        public FORM_HUYVECB()
        {
            InitializeComponent();
          
        }

        private void LoadMaCB()
        {

        }

        private void FORM_HUYVECB_Load(object sender, EventArgs e)
        {
            HangVe_BUS.LoadHangVe(cmbMaVe);
            HanhKhach_BUS.LoadHanhKhachVe(cmbTenHanhKhach);
            cmbTenHanhKhach.DisplayMember = "TenHanhKhach";
            cmbTenHanhKhach.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTenHanhKhach.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbCMND.DataSource = cmbTenHanhKhach.DataSource;
            cmbCMND.DisplayMember = "CMND";
            cmbCMND.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCMND.AutoCompleteSource = AutoCompleteSource.ListItems;

            HangVe_BUS.LoadHangVe(cmbMaVe);

            ChuyenBay_BUS.LoadMaChuyenBay(cmbMaChuyenBay);
            cmbMaChuyenBay.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbMaChuyenBay.AutoCompleteSource = AutoCompleteSource.ListItems;

            VeDat_BUS.TraCuuVe(null, null, null, null, 10, 1);

        }

        /// <summary>
        /// Tìm phiếu đặt chỗ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnFristPage_Click(object sender, EventArgs e)
        {

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {

        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {

        }
    }
}
