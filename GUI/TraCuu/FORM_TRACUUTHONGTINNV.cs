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
    public partial class FORM_TRACUUTHONGTINNV : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;
        private bool isClick;

        public FORM_TRACUUTHONGTINNV()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Search_icon1;
            pageNumber = 1;
            dGVDanhSachNV.SelectionChanged += DGVDanhSachNV_SelectionChanged;
        }

        private void DGVDanhSachNV_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(cmbTenNV.Text, txtCMND.Text, pageSize, pageNumber);
            }
            catch (Exception)
            {
                
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            isClick = true;

            totalPage = NhanVien_BUS.DemSoNhanVien(cmbTenNV.Text, txtCMND.Text);

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);

            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();


            txtTotalPage.Text = totalPage.ToString();

            //dGVDachSanhCB.Columns.Clear();
            dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(cmbTenNV.Text, txtCMND.Text,pageSize,pageNumber);
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(cmbTenNV.Text, txtCMND.Text, pageSize, pageNumber);
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
                dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(cmbTenNV.Text, txtCMND.Text, pageSize, pageNumber);
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
                dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(cmbTenNV.Text, txtCMND.Text,  pageSize, pageNumber);
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
                dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(cmbTenNV.Text, txtCMND.Text, pageSize, pageNumber);
            }
            else
            {
                dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(null, null,  pageSize, pageNumber);
            }
        }

        private void txtPageNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToUInt32(txtPageNumber.Text) <= totalPage)
                {
                    pageNumber = (int)Convert.ToUInt32(txtPageNumber.Text);

                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                txtPageNumber.Text = pageNumber.ToString();
            }
        }

        private void txtSoDT_TextChanged(object sender, EventArgs e)
        {
            if (!HelpFuction.IsPhoneNumber(txtSoDT.Text))
            {
                errSODT.Icon = Properties.Resources.error_icon1;
                errSODT.SetError(txtSoDT, "Tài khoản chưa được điền");
            }
            else
            {
                errSODT.Clear();
            }
        }

        private void FORM_TRACUUTHONGTINNV_Load(object sender, EventArgs e)
        {

            totalPage = NhanVien_BUS.DemSoNhanVien(null,  null);

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);


            txtTotalPage.Text = totalPage.ToString();

            dGVDanhSachNV.Columns.Clear();
            dGVDanhSachNV.DataSource = NhanVien_BUS.TraCuuNhanVien(null, null,  pageSize, pageNumber);

            ThreadPool.QueueUserWorkItem((p) =>
            {
                cmbTenNV.PerformSafely(() =>
                {
                    
                    NhanVien_BUS.LoadNhanVien(cmbTenNV);
                });
            });
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            if (!HelpFuction.IsPhoneNumber(txtCMND.Text))
            {
                errSODT.Icon = Properties.Resources.error_icon1;
                errSODT.SetError(txtCMND, "Chứng minh nhân dân chỉ chứa số");
            }
            else
            {
                errSODT.Clear();
            }
        }

        private void dGVDanhSachNV_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView.RowCount == 0||e.ColumnIndex<0||e.RowIndex<0)
            {
                return;
            }
            
            DataGridViewCell cell =
               dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value != null)
            {
                cell.ToolTipText = cell.Value.ToString();



                //IWin32Window win = this;
                //System.Drawing.Point mousePosition = this.PointToClient(Cursor.Position);
                //toolTip1.Show(dataGridView[e.ColumnIndex, e.ColumnIndex].Value.ToString(), win, mousePosition);
            }
        }

        private void dGVDanhSachNV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }
    }
}
