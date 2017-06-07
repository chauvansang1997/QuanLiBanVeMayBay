using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using Help_Fuction;

namespace GUI
{
    public partial class FORM_QUANLYSANBAY : Form
    {

        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;

        private bool isClick = false;
        public FORM_QUANLYSANBAY()
        {
            InitializeComponent();
           
        }


   

        private void btnFind_Click(object sender, EventArgs e)
        {
            
            bool check = false;
            foreach (var item in cmbTenSanBay.Items)
            {
                SanBay sanbay = item as SanBay;
                if (sanbay.TenSanBay == cmbTenSanBay.Text)
                {
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                MessageBox.Show("Bạn phải chọn tên sân bay trong danh sách");
                return;
            }

            isClick = true;

            totalPage = SanBay_BUS.DemSanBay(cmbTenSanBay.Text);

            txtTotalPage.Text = totalPage.ToString();

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);
            dGVDanhSachSB.DataSource = SanBay_BUS.TimSanBay(cmbTenSanBay.Text, pageSize, pageNumber);
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

        private void FORM_QUANLYSANBAY_Load(object sender, EventArgs e)
        {
            pageNumber = 1;
            totalPage = SanBay_BUS.DemSanBay(null);

            

            totalPage= HelpFuction.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();

            cmbTenSanBay.DataSource = SanBay_BUS.LoadSanBay();
            cmbTenSanBay.DisplayMember = "TenSanBay";
            cmbTenSanBay.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbTenSanBay.AutoCompleteSource = AutoCompleteSource.ListItems;

            dGVDanhSachSB.DataSource = SanBay_BUS.TimSanBay(null, pageSize, pageNumber);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FORM_THEMSANBAY form = new FORM_THEMSANBAY();
            form.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
