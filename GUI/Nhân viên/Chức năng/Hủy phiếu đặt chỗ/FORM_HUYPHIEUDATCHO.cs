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
    public partial class FORM_HUYPHIEUDATCHO : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;

        private bool isClick = false;
        public FORM_HUYPHIEUDATCHO()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Search_icon1;
            pageNumber = 1;

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            isClick = true;


            totalPage = PhieuDatCho_BUS.Instance.Dem;

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);

            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();


            txtTotalPage.Text = totalPage.ToString();

            //dGVDachSanhCB.Columns.Clear();
            dGVDachSanhCB.DataSource = TraCuu_BUS.Instance.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, ngayKHTu, ngayKHDen);
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDachSanhCB.DataSource = ChuyenBay_BUS.Instance.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKhDen.Value);
            }
            else
            {
                dGVDachSanhCB.DataSource = ChuyenBay_BUS.Instance.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
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
                dGVDachSanhCB.DataSource = ChuyenBay_BUS.Instance.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKhDen.Value);
            }
            else
            {
                dGVDachSanhCB.DataSource = ChuyenBay_BUS.Instance.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
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
                dGVDachSanhCB.DataSource = ChuyenBay_BUS.Instance.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKhDen.Value);
            }
            else
            {
                dGVDachSanhCB.DataSource = ChuyenBay_BUS.Instance.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDachSanhCB.DataSource = ChuyenBay_BUS.Instance.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKhDen.Value);
            }
            else
            {
                dGVDachSanhCB.DataSource = ChuyenBay_BUS.Instance.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
