using BUS;
using Custom;
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
            dgvDanhSachGhe.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            dGVSanBayTG.TopLeftHeaderCell.Value = "STT";
            dGVSanBayTG.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
        }
        /// <summary>
        /// Sự kiện load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FORM_NHANLICHCHUYENBAY_Load(object sender, EventArgs e)
        {
            Init();
            
            QuyDinh_BUS.LoadQuyDinh();

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
            int thoigianbay = 0;
            int giave = 0;
            //Kiểm tra giá tiền cco1 đúng định dạng không
            try
            {
                giave = Convert.ToInt32(txtGiaVe.Text);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập sai định dạng của giá vé");
                return;
            }

            //Kiểm tra thời gian bay có đúng định dạng không
            try
            {
                 thoigianbay = Convert.ToInt32( txtThoiGianBay.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Nhập sai định dạng của thời gian bay");
                return;
            }
            //Kiểm tra sân bay đi có chứa trong danh sách sân bay không

            bool check = false;
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
            if (!check)
            {
                MessageBox.Show("Sân bay không có trong danh sách");
                return;
            }

            //Kiểm tra ngày bay phải lớn hơn ngày hiện tại 1 ngày
            if (dtpkNgayKhoiHanh.Value < DateTime.Now+HelpFuction.ConvertHoursToTotalDays(24))
            {
                MessageBox.Show("Ngày giờ phải lớn hơn hoặc bằng ngày hiện tại");
                return;
            }
            //Kiểm tra thời gian bay phải đúng với quy định
            if (thoigianbay < QuyDinh.ThoiGianBayToiThieu)
            {
                MessageBox.Show("Thời gian bay phải tối thiểu là:" + QuyDinh.ThoiGianBayToiThieu.ToString());
                return;
            }

            try
            {
                string maChuyenBay;
                SanBay sanBayDi = cmbSanBayDi.SelectedItem as SanBay;
                SanBay sanBayDen = cmbSanBayDen.SelectedItem as SanBay;
                if (ChuyenBay_BUS.NhanLichChuyenBay(sanBayDi.MaSanBay, sanBayDen.MaSanBay, giave, thoigianbay, dtpkNgayKhoiHanh.Value, out maChuyenBay))
                {
                    ChuyenBay_BUS.NhapDonGia(maChuyenBay, giave);
                    if (dGVSanBayTG.RowCount > 0)
                    {
                        for (int i = 0; i < dGVSanBayTG.RowCount; i++)
                        {
                            var row = dGVSanBayTG.Rows[i];
                            string maSanBay = row.Cells[0].Value.ToString();
                            int thoigiandung = (int)row.Cells[2].Value;
                            string ghiChu = row.Cells[3].Value.ToString();
                            ChuyenBay_BUS.NhapChiTietChuyenBay(maChuyenBay, maSanBay, thoigianbay, ghiChu);
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
                FORM_SANBAYTRUNGGIAN form = new FORM_SANBAYTRUNGGIAN(this.dGVSanBayTG);
                
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
    }
}
