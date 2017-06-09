using BUS;
using Help_Fuction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FORM_QUANLYNHANVIEN : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;

        private bool isClick = false;
        public FORM_QUANLYNHANVIEN()
        {
            InitializeComponent();
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {

            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(cmbTenNV.Text, cmbCMND.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(null, null, pageSize, pageNumber);
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
                dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(cmbTenNV.Text, cmbCMND.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(null, null, pageSize, pageNumber);
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
                dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(cmbTenNV.Text, cmbCMND.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(null, null, pageSize, pageNumber);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(cmbTenNV.Text, cmbCMND.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(null, null, pageSize, pageNumber);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            isClick = true;
            if (cmbCMND.SelectedItem == null)
            {
                MessageBox.Show("Chứng minh nhân dân của nhân viên không có trong danh sách");
                return;
            }
            if (cmbTenNV.SelectedItem == null)
            {
                MessageBox.Show("Tên nhân viên không có trong danh sách");
                return;
            }
            try
            {
                totalPage = NhanVien_BUS.DemSoNhanVien(cmbTenNV.Text, cmbCMND.Text);

                totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);


                txtTotalPage.Text = totalPage.ToString();
                dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(cmbTenNV.Text, cmbCMND.Text, pageSize, pageNumber);
            }
            catch (Exception)
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FORM_THEMNHANVIEN form = new FORM_THEMNHANVIEN();
            form.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dGVDanhSachNV.SelectedRows.Count > 0)
            {
                string manhanvien = dGVDanhSachNV.SelectedRows[0].Cells[0].Value.ToString();
                FORM_SUANHANVIEN form = new FORM_SUANHANVIEN(manhanvien);
                form.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void FORM_QUANLYNHANVIEN_Load(object sender, EventArgs e)
        {
            totalPage = NhanVien_BUS.DemSoNhanVien(null, null);

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);


            txtTotalPage.Text = totalPage.ToString();

            pageNumber = 1;
            dGVDanhSachNV.Columns.Clear();
            dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(null, null, pageSize, pageNumber);

            ThreadPool.QueueUserWorkItem((p) =>
            {
                cmbTenNV.PerformSafely(() =>
                {

                    NhanVien_BUS.LoadNhanVien(cmbTenNV);
                    cmbTenNV.DisplayMember = "TenNV";
                    cmbTenNV.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cmbTenNV.AutoCompleteSource = AutoCompleteSource.ListItems;

                    cmbCMND.DataSource = cmbTenNV.DataSource;
                    cmbCMND.DisplayMember = "CMND";
                    cmbCMND.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    cmbCMND.AutoCompleteSource = AutoCompleteSource.ListItems;
                });
            });
        }

   
    }
}
