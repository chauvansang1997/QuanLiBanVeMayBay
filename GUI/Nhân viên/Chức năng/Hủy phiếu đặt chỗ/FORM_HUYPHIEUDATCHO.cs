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
    public partial class FORM_HUYPHIEUDATCHO : Form
    {
        private const int pageSize = 10;

        private int pageNumber;

        private int totalPage;

        private bool isClick = false;

        private string maPhieuDatCho="";
        public FORM_HUYPHIEUDATCHO()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Search_icon1;
            pageNumber = 1;

        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            isClick = true;


            totalPage = PhieuDatCho_BUS.DemPhieuDatCho(cmbTenHanhKhach.Text, cmbCMND.Text, cmbPhieuDC.Text,cmbMaCB.Text);

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);

            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();


            txtTotalPage.Text = totalPage.ToString();

            //dGVDachSanhCB.Columns.Clear();
            dGVDSPDC.DataSource = PhieuDatCho_BUS.TraCuuPhieuDatCho(cmbTenHanhKhach.Text, cmbCMND.Text, cmbPhieuDC.Text, cmbMaCB.Text,pageSize,pageNumber);
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();

            if (isClick)
            {
                dGVDSPDC.DataSource = PhieuDatCho_BUS.TraCuuPhieuDatCho(cmbTenHanhKhach.Text, cmbCMND.Text, cmbPhieuDC.Text, cmbMaCB.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDSPDC.DataSource = PhieuDatCho_BUS.TraCuuPhieuDatCho(null, null, null, null, pageSize, pageNumber);
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
                dGVDSPDC.DataSource = PhieuDatCho_BUS.TraCuuPhieuDatCho(cmbTenHanhKhach.Text, cmbCMND.Text, cmbPhieuDC.Text, cmbMaCB.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDSPDC.DataSource = PhieuDatCho_BUS.TraCuuPhieuDatCho(null, null, null, null, pageSize, pageNumber);
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
                dGVDSPDC.DataSource = PhieuDatCho_BUS.TraCuuPhieuDatCho(cmbTenHanhKhach.Text, cmbCMND.Text, cmbPhieuDC.Text, cmbMaCB.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDSPDC.DataSource = PhieuDatCho_BUS.TraCuuPhieuDatCho(null, null, null, null, pageSize, pageNumber);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;

            txtPageNumber.Text = pageNumber.ToString();

            if (isClick)
            {
                dGVDSPDC.DataSource = PhieuDatCho_BUS.TraCuuPhieuDatCho(cmbTenHanhKhach.Text, cmbCMND.Text, cmbPhieuDC.Text, cmbMaCB.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDSPDC.DataSource = PhieuDatCho_BUS.TraCuuPhieuDatCho(null, null, null, null, pageSize, pageNumber);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (maPhieuDatCho != "")
            {
                if (PhieuDatCho_BUS.HuyPhieuDatCho(maPhieuDatCho))
                {
                    MessageBox.Show("Xóa thành công");
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FORM_HUYPHIEUDATCHO_Load(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(p =>
            {
                cmbPhieuDC.PerformSafely(() =>
                {
                    PhieuDatCho_BUS.LoadPhieuDatCho(cmbPhieuDC);
                });

            });
            
            ThreadPool.QueueUserWorkItem(p =>
            {
                cmbMaCB.PerformSafely(() =>
                {
                    ChuyenBay_BUS.LoadMaChuyenBay(cmbMaCB);
                });
            });
          

            ThreadPool.QueueUserWorkItem(p =>
            {
                cmbTenHanhKhach.PerformSafely(() =>
                {
                    HanhKhach_BUS.LoadHanhKhachPDC(cmbTenHanhKhach);
                });
            });
           
            totalPage = PhieuDatCho_BUS.DemPhieuDatCho(null, null, null, null);

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);


            txtTotalPage.Text = totalPage.ToString();


            dGVDSPDC.DataSource = PhieuDatCho_BUS.TraCuuPhieuDatCho(null, null, null, null, pageSize, pageNumber);
        }

        private void dGVDSPDC_SelectionChanged(object sender, EventArgs e)
        {
            if (dGVDSPDC.SelectedRows.Count > 0)
            {
                maPhieuDatCho = dGVDSPDC.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}
