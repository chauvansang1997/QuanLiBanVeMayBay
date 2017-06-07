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
using Help_Fuction;
using DTO;

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
            FORM_THEMMOITUYENBAY form = new FORM_THEMMOITUYENBAY();
            form.ShowDialog();
            dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(null, null, pageSize, pageNumber);
            dGVDanhSachTB.Columns[1].Visible = false;
            dGVDanhSachTB.Columns[3].Visible = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            isClick = true;
            if (isClick)
            {
                string sanbaydi;
                string sanbayden;
                if(cmbSanBayDi.Text=="")
                {
                    sanbaydi = null;
                }
                else
                {
                    sanbaydi = cmbSanBayDi.Text;
                }
                if (cmbSanBayDen.Text == "")
                {
                    sanbayden = null;
                }
                else
                {
                    sanbayden = cmbSanBayDen.Text;
                }
                if (cmbSanBayDi.SelectedItem != null)
                {
                    SanBay sanbay = cmbSanBayDi.SelectedItem as SanBay;
                    sanbaydi = sanbay.MaSanBay;
                }
                if (cmbSanBayDen.SelectedItem != null)
                {
                    SanBay sanbay = cmbSanBayDen.SelectedItem as SanBay;
                    sanbayden = sanbay.MaSanBay;
                }
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(sanbaydi, sanbayden, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
            }
            else
            {
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(null, null, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
            }
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(cmbSanBayDi.Text,cmbSanBayDen.Text, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
            }
            else
            {
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(null,null, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
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
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
            }
            else
            {
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(null, null, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
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
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
            }
            else
            {
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(null, null, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {

            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();

            if (isClick)
            {
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
            }
            else
            {
                dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(null, null, pageSize, pageNumber);
                dGVDanhSachTB.Columns[1].Visible = false;
                dGVDanhSachTB.Columns[3].Visible = false;
            }
        }

        private void FORM_QUANLYTUYENBAY_Load(object sender, EventArgs e)
        {
            pageNumber = 1;
            totalPage = TuyenBay_BUS.DemTuyenBay(null,null);



            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);
            txtTotalPage.Text = totalPage.ToString();

             SanBay_BUS.LoadSanBayDi(cmbSanBayDi);
           

            dGVDanhSachTB.DataSource = TuyenBay_BUS.TimTuyenBay(null,null, pageSize, pageNumber);
            dGVDanhSachTB.Columns[1].Visible = false;
            dGVDanhSachTB.Columns[3].Visible = false;
        }

        private void cmbSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSanBayDi.SelectedItem != null)
            {
                SanBay sanbay = cmbSanBayDi.SelectedItem as SanBay;
                SanBay_BUS.LoadSanBayDen(sanbay.MaSanBay, cmbSanBayDen);
            }
        }
    }
}
