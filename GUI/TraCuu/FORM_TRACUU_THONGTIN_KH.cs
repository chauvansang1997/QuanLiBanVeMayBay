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
    public partial class FORM_TRACUU_THONGTIN_KH : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        private bool isClick;

        public FORM_TRACUU_THONGTIN_KH()
        {
            InitializeComponent();
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            isClick = true;

            totalPage = HanhKhach_BUS.Instance.DemHanhKhach(cmbTenHK.Text,txtSoDT.Text,txtCMND.Text);

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);

            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();

           
            txtTotalPage.Text = totalPage.ToString();

            //dGVDachSanhCB.Columns.Clear();
            dGVDanhSachHK.DataSource = TraCuu_BUS.Instance.TraCuuHanhKhach(cmbTenHK.Text, txtCMND.Text, txtSoDT.Text,pageSize,pageNumber);
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {

        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {

        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {

        }

        private void dGVDanhSachHK_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
