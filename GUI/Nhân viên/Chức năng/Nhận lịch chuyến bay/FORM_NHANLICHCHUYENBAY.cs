using BUS;

using DTO;
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
using Help_Fuction;
namespace GUI
{
    public partial class FORM_NHANLICHCHUYENBAY : Form
    {
        private DataTable danhSachThem;
        /// <summary>
        /// Contructor
        /// </summary>
        public FORM_NHANLICHCHUYENBAY()
        {
            InitializeComponent();

        }

 
        private void Init()
        {
            dgvDanhSachGhe.TopLeftHeaderCell.Value = "STT";
            dgvDanhSachGhe.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;

            dGVSanBayTG.TopLeftHeaderCell.Value = "STT";
            dGVSanBayTG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;


            dGVChuyenBayThem.TopLeftHeaderCell.Value = "STT";
            dGVChuyenBayThem.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
        }
        /// <summary>
        /// Sự kiện load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FORM_NHANLICHCHUYENBAY_Load(object sender, EventArgs e)
        {
            txtGiaVe.Text = "1000000";
            txtThoiGianBay.Text = QuyDinh.ThoiGianBayToiThieu.ToString();

            danhSachThem = new DataTable();
            DataColumn column = new DataColumn("Mã Chuyến Bay");
            danhSachThem.Columns.Add(column);

            dGVChuyenBayThem.DataSource = danhSachThem;

            Init();
            
            
            HangVe.SoLuongHangVe = HangVe_BUS.DemSoLuongHangVe();

            SanBay_BUS.LoadSanBayDi(cmbSanBayDi);

            //Load thông tin vào danh sách hạng ghế
            dgvDanhSachGhe.Columns.Clear();
            dgvDanhSachGhe.DataSource = ChuyenBay_BUS.LoadDanhSachHangGhe();

            //Tạo luồng khác, load vào danh sách các sân bay trung gian
            ThreadPool.QueueUserWorkItem(p =>
            {
                dGVSanBayTG.PerformSafely(() =>
                {
                    ChuyenBay_BUS.LoadDanhSachSanBayTG(dGVSanBayTG);

                });
            });

        }

        /// <summary>
        /// Sự kiện nhấn nút thêm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {

            //Kiểm tra sân bay đi có chứa trong danh sách sân bay không

            bool check = false;
            if (txtThoiGianBay.Text == ""||txtGiaVe.Text=="")
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin");
                return;
            }
            
            foreach (var item in cmbSanBayDi.Items)
            {
                SanBay sanbay = item as SanBay;
                if (sanbay.TenSanBay == cmbSanBayDi.Text)
                {
                    check = true;
                    break;
                }

            }
            if (!check)
            {
                MessageBox.Show("Sân bay không có trong danh sách");
                return;
            }
            check = false;

            //Kiểm tra sân bay đến có chứa trong danh sách sân bay không
            foreach (var item in cmbSanBayDen.Items)
            {
                SanBay sanbay = item as SanBay;
                if (sanbay.TenSanBay == cmbSanBayDen.Text)
                {
                    check = true;
                    break;
                }

            }

            if (dGVSanBayTG.RowCount > 0)
            {
                foreach (DataGridViewRow item in dGVSanBayTG.Rows)
                {
                    if(item.Cells[1].Value.ToString()==cmbSanBayDi.Text|| item.Cells[1].Value.ToString() == cmbSanBayDen.Text)
                    {
                        MessageBox.Show("Sân bay đi và đến không được trùng với sân bay trung gian");
                        return;
                    }
                }
            }
            if (!check)
            {
                MessageBox.Show("Sân bay không có trong danh sách");
                return;
            }

            //Kiểm tra ngày bay phải lớn hơn ngày hiện tại 1 ngày
            if (dtpkNgayKhoiHanh.Value < DateTime.Now+HelpFuction.ConvertHoursToTotalDays(23.8+QuyDinh.ThoiGianChamNhatDatVe))
            {
                MessageBox.Show("Ngày giờ phải lớn hơn hoặc bằng ngày hiện tại 1 ngày");
                return;
            }
            //Kiểm tra thời gian bay phải đúng với quy định
            if (Convert.ToInt32(txtThoiGianBay.Text)< QuyDinh.ThoiGianBayToiThieu)
            {
                MessageBox.Show("Thời gian bay phải tối thiểu là:" + QuyDinh.ThoiGianBayToiThieu.ToString());
                return;
            }
            //Thêm chuyến bay 
            try
            {
                string maChuyenBay;
                SanBay sanBayDi = cmbSanBayDi.SelectedItem as SanBay;
                SanBay sanBayDen = cmbSanBayDen.SelectedItem as SanBay;
                if (ChuyenBay_BUS.NhanLichChuyenBay(sanBayDi.MaSanBay, sanBayDen.MaSanBay,Convert.ToInt32 (txtGiaVe.Text), Convert.ToInt32(txtThoiGianBay.Text), dtpkNgayKhoiHanh.Value, out maChuyenBay))
                {
                    ChuyenBay_BUS.NhapDonGia(maChuyenBay, Convert.ToInt32 (txtGiaVe.Text));
                    if (dGVSanBayTG.RowCount > 0)
                    {
                        for (int i = 0; i < dGVSanBayTG.RowCount; i++)
                        {
                            var row = dGVSanBayTG.Rows[i];
                            string maSanBay = row.Cells[0].Value.ToString();
                            int thoigiandung = (int)row.Cells[2].Value;
                            string ghiChu = row.Cells[3].Value.ToString();
                            ChuyenBay_BUS.NhapChiTietChuyenBay(maChuyenBay, maSanBay, Convert.ToInt32(txtGiaVe.Text), ghiChu);
                        }
                    }
                    for (int i = 0; i < dgvDanhSachGhe.RowCount; i++)
                    {

                        var row = dgvDanhSachGhe.Rows[i];

                        string maHangVe = row.Cells[0].Value.ToString();
                        int soGhe = (int)row.Cells[2].Value;

                        ChuyenBay_BUS.NhapChiTietHangGhe(maChuyenBay, maHangVe, soGhe);

                    }
                    MessageBox.Show("Nhận lịch chuyến bay thành công");

                    DataRow row_Them = danhSachThem.NewRow();
                    row_Them[0] = maChuyenBay;

                    danhSachThem.Rows.Add(row_Them);
                }
                
            }
            catch (Exception err)
            {

                HelpFuction.Log(err);
                MessageBox.Show("Nhận chuyến bay không thành công");
            }

            
            
        }
        /// <summary>
        /// Thêm hạng ghế 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThemHangGhe_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachGhe.RowCount < QuyDinh.SoLuongHangVe && dgvDanhSachGhe.RowCount < HangVe.SoLuongHangVe)
            {
                FORM_HANGGHE form = new FORM_HANGGHE(dgvDanhSachGhe);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn chỉ được phép thêm tối đa " + dgvDanhSachGhe.RowCount.ToString() + " hạng ghế");
            }
        }

        /// <summary>
        /// Xóa hạng ghế
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoaHangGhe_Click(object sender, EventArgs e)
        {

            if (dgvDanhSachGhe.RowCount > 1 && dgvDanhSachGhe.SelectedRows.Count > 0)
            {
                dgvDanhSachGhe.Rows.Remove(dgvDanhSachGhe.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("Phải có tối đa một hạng ghế");
            }
            
        }

        /// <summary>
        /// Thêm sân bay trung gian
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThemSanBayTG_Click(object sender, EventArgs e)
        {
            if (dGVSanBayTG.Rows.Count == QuyDinh.SoSanBayTGToiDa)
            {
                string message = string.Format("Bạn chỉ được phép nhập tối đa {0} {1}", QuyDinh.SoSanBayTGToiDa, "sân bay trung gian");
                MessageBox.Show(message);
            }
            else
            {
                string sanbaydi = "";
                string sanbayden = "";
                if (cmbSanBayDi.SelectedItem != null)
                {
                    SanBay sanbay = cmbSanBayDi.SelectedItem as SanBay;
                    sanbaydi = sanbay.MaSanBay;
                }
                if(cmbSanBayDen.SelectedItem != null)
                {
                    SanBay sanbay = cmbSanBayDen.SelectedItem as SanBay;
                    sanbayden = sanbay.MaSanBay;
                }
                FORM_SANBAYTRUNGGIAN form = new FORM_SANBAYTRUNGGIAN(this.dGVSanBayTG,sanbaydi,sanbayden);
                
                form.ShowDialog();

                
            }


        }
        /// <summary>
        /// Xóa sân bay trung gian
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoaSanBayTG_Click(object sender, EventArgs e)
        {
            if (dGVSanBayTG.RowCount > 0&& dGVSanBayTG.SelectedRows.Count>0)
            {
                dGVSanBayTG.Rows.Remove(dGVSanBayTG.SelectedRows[0]);
            }
        }
        /// <summary>
        /// Sự kiện chọn sân bay đi, sân bay đến tự động chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combobox = sender as ComboBox;
            try
            {
                SanBay sanbaydi = (SanBay)combobox.SelectedValue;
                SanBay_BUS.LoadSanBayDen(sanbaydi.MaSanBay,cmbSanBayDen);
            }
            catch (Exception err)
            {

                HelpFuction.Log(err);
            }
        
        }
        /// <summary>
        /// Thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Tạo số thứ tự
                /// <summary>
                /// Sự kiện thêm sân bay tring gian
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void dGVSanBayTG_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
                {
                    DataGridView dgv = sender as DataGridView;
                    dgv.setRowNumber();
                }
                /// <summary>
                /// Sự kiện xóa sân bay trung gian
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void dGVSanBayTG_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
                {
                    DataGridView dgv = sender as DataGridView;
                    dgv.setRowNumber();
                }
                /// <summary>
                /// Sự kiện thêm hạng ghế
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void dgvDanhSachGhe_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
                {
                    DataGridView dgv = sender as DataGridView;
                    dgv.setRowNumber();
                }
                /// <summary>
                /// Sự kiện xóa hạng ghế
                /// </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                private void dgvDanhSachGhe_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
                {
                    DataGridView dgv = sender as DataGridView;
                    dgv.setRowNumber();
                }
                private void dGVChuyenBayThem_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
                {
                    DataGridView dgv = sender as DataGridView;
                    dgv.setRowNumber();
                }

                private void dGVChuyenBayThem_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
                {
                    DataGridView dgv = sender as DataGridView;
                    dgv.setRowNumber();
                }

        #endregion

        private void txtThoiGianBay_TextChanged(object sender, EventArgs e)
        {
            if (txtThoiGianBay.Text == "")
            {
                return;
            }
            if (HelpFuction.IsContainsText(txtThoiGianBay.Text))
            {
                txtThoiGianBay.Text = txtThoiGianBay.Text.Remove(txtThoiGianBay.Text.Length - 1);
                if (txtThoiGianBay.Text.Length == 0)
                {
                    return;
                }
                txtThoiGianBay.SelectionStart = txtThoiGianBay.Text.Length; // add some logic if length is 0
                txtThoiGianBay.SelectionLength = 0;
            }
        
        }

        private void txtGiaVe_TextChanged(object sender, EventArgs e)
        {
            if (txtGiaVe.Text == "")
            {
                return;
            }
            if (HelpFuction.IsContainsText(txtGiaVe.Text))
            {
                txtGiaVe.Text = txtGiaVe.Text.Remove(txtGiaVe.Text.Length - 1);
                if (txtGiaVe.Text.Length == 0)
                {
                    return;
                }
                txtGiaVe.SelectionStart = txtGiaVe.Text.Length; // add some logic if length is 0
                txtGiaVe.SelectionLength = 0;
            }
     
        }
    }
}
