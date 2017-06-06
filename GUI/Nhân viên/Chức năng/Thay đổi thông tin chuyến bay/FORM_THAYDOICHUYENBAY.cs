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
using System.Threading;
using Help_Fuction;

namespace GUI
{
    public partial class FORM_THAYDOICHUYENBAY : Form
    {
        private const int pageSize = 10;
        private int pageNumber;
        private int totalPage;

        private bool isClick = false;
        public FORM_THAYDOICHUYENBAY()
        {
            InitializeComponent();
            pageNumber = 1;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            isClick = true;
            string sanbaydi = cmbSanBayDi.Text;
            string sanbayden = cmbSanBayDen.Text;
            DateTime ngayKHTu = dtPKNgayKHTu.Value;
            DateTime ngayKHDen = dtPKNgayKHDen.Value;

            totalPage = ChuyenBay_BUS.DemChuyenBay(sanbaydi, sanbayden, ngayKHTu, ngayKHDen);

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);

            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();


            txtTotalPage.Text = totalPage.ToString();

            //dGVDachSanhCB.Columns.Clear();
            dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, ngayKHTu, ngayKHDen);
        }

        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKHDen.Value);
            }
            else
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
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
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKHDen.Value);
            }
            else
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
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
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKHDen.Value);
            }
            else
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
            }
        }

        private void btnLastPage_Click(object sender, EventArgs e)
        {
            pageNumber = totalPage;
            txtPageNumber.Text = pageNumber.ToString();
            if (isClick)
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(cmbSanBayDi.Text, cmbSanBayDen.Text, pageSize, pageNumber, dtPKNgayKHTu.Value, dtPKNgayKHDen.Value);
            }
            else
            {
                dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);
            }
        }

        private void btnThemSanBayTG_Click(object sender, EventArgs e)
        {
            if (dGVSanBayTG.Rows.Count == QuyDinh.SoSanBayTGToiDa)
            {
                string message = string.Format("Bạn chỉ được phép nhập tối đa {0} {1}", QuyDinh.SoSanBayTGToiDa, "sân bay trung gian");
                MessageBox.Show(message);
            }
            else
            {
                FORM_SANBAYTRUNGGIAN form = new FORM_SANBAYTRUNGGIAN(this.dGVSanBayTG);

                form.ShowDialog();


            }

        }

        private void btnXoaSanBayTG_Click(object sender, EventArgs e)
        {
            if (dGVSanBayTG.RowCount > 0 && dGVSanBayTG.SelectedRows.Count > 0)
            {
                dGVSanBayTG.Rows.Remove(dGVSanBayTG.SelectedRows[0]);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Init()
        {


            dGVSanBayTG.TopLeftHeaderCell.Value = "STT";
            dGVSanBayTG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
        }
        private void FORM_THAYDOICHUYENBAY_Load(object sender, EventArgs e)
        {

            Init();

            SanBay_BUS.LoadSanBay(cmbSanBayDi);


            totalPage = ChuyenBay_BUS.DemChuyenBay(null, null, null, null);

            totalPage = HelpFuction.TinhKichThuocTrang(totalPage, pageSize);


            txtTotalPage.Text = totalPage.ToString();


            dGVDanhSachCB.DataSource = ChuyenBay_BUS.TraCuuChuyenBay(null, null, pageSize, pageNumber, null, null);

            

            ThreadPool.QueueUserWorkItem(p =>
            {
                dGVSanBayTG.PerformSafely(() =>
                {
                    ChuyenBay_BUS.LoadDanhSachSanBayTG(dGVSanBayTG);
                });
            });

        }

        private void cmbSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = sender as ComboBox;
            try
            {
                SanBay sanbaydi = (SanBay)combobox.SelectedValue;
                SanBay_BUS.LoadSanBayDen(sanbaydi.MaSanBay, cmbSanBayDen);
            }
            catch (Exception err)
            {

                HelpFuction.Log(err);
            }
        }

        private void dGVSanBayTG_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.setRowNumber();
        }

        private void dGVSanBayTG_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgv.setRowNumber();
        }

        private void dGVDanhSachCB_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGV = sender as DataGridView;



            if (dataGV.SelectedRows.Count == 0)
            {


                dGVSanBayTG.DataSource = ChuyenBay_BUS.TraCuuSBTG("");
            }
            if (dataGV.SelectedRows.Count > 0)
            {

                dGVSanBayTG.Columns.Clear();
                dGVSanBayTG.DataSource = ChuyenBay_BUS.TraCuuSBTG(dataGV.SelectedRows[0].Cells[0].Value.ToString());

            }
        }
    }
}
