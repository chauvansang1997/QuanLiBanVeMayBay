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
    public partial class FORM_QUANLYTUYENBAY : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;

        private bool isClick = false;
        public FORM_QUANLYTUYENBAY()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDanhSachSB.DataSource = SanBay_BUS.TimSanBay(cmbTenSanBay.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDanhSachSB.DataSource = SanBay_BUS.TimSanBay(null, pageSize, pageNumber);
            }
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (pageNumber - 1 == 0)
            {
                pageNumber = 1;
            }
            else
            {
                --pageNumber;
            }
            txtPageNumber.Text = pageNumber.ToString();

            if (isClick)
            {
                dGVDanhSachSB.DataSource = SanBay_BUS.TimSanBay(cmbTenSanBay.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDanhSachSB.DataSource = SanBay_BUS.TimSanBay(null, pageSize, pageNumber);
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (pageNumber + 1 > totalPage)
            {
                pageNumber = 1;
            }
            else
            {
                ++pageNumber;
            }
            txtPageNumber.Text = pageNumber.ToString();

            if (isClick)
            {
                dGVDanhSachSB.DataSource = SanBay_BUS.TimSanBay(cmbTenSanBay.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDanhSachSB.DataSource = SanBay_BUS.TimSanBay(null, pageSize, pageNumber);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {

            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();

            if (isClick)
            {
                dGVDanhSachSB.DataSource = SanBay_BUS.TimSanBay(cmbTenSanBay.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDanhSachSB.DataSource = SanBay_BUS.TimSanBay(null, pageSize, pageNumber);
            }
        }

        private void FORM_QUANLYTUYENBAY_Load(object sender, EventArgs e)
        {

        }
    }
}
