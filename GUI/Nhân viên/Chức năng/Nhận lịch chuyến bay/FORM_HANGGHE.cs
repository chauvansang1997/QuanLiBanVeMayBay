using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Help_Fuction;
using BUS;
using DTO;

namespace GUI
{
    public partial class FORM_HANGGHE : Form
    {
        private uint check_SoGhe;
        private DataGridView danhSachHangGhe;
        public FORM_HANGGHE(DataGridView _danhSachHangGhe)
        {
            danhSachHangGhe = _danhSachHangGhe;
            InitializeComponent();
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            bool check = false;
            //Kiểm tra quy định xem có mấy hạng vé hiện tại
            if(danhSachHangGhe.RowCount<QuyDinh.SoLuongHangVe&& danhSachHangGhe.RowCount < HangVe.SoLuongHangVe)
            {
                try
                { 
                    //kiểm tra hạng ghê có nằm trong danh sách
                    foreach (var item in cmbHangGhe.Items)
                    {
                        HangVe hangve = item as HangVe;
                        if (hangve.TenHangVe == cmbHangGhe.Text)
                        {
                            check=true;
                            break;
                        }
                    }
                    if (!check)
                    {
                        throw new Exception("Hạng vé phải có trong danh sách hạng vé");
                    }
                    //Kiểm tra hạng vé đã tồn tại chưa
                    if (danhSachHangGhe.Contains(cmbHangGhe.Text,1))
                    {
                        throw new Exception("Hạng vé đã tồn tại");
                    }

                    if (cmbHangGhe.SelectedItem != null)
                    {
                        HangVe hangve = cmbHangGhe.SelectedItem as HangVe;
                        int soGhe = Convert.ToInt32(txtSoGhe.Text);


                        DataTable table = (DataTable)danhSachHangGhe.DataSource;
                        DataRow row = table.NewRow();

                        row[0] = hangve.MaHangVe;
                        row[1] = hangve.TenHangVe;
                        row[2] = soGhe;
                        table.Rows.Add(row);
                    }


                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    
                }
            }
            else
            {
                MessageBox.Show("Bạn chỉ có thể thêm tối đa " + danhSachHangGhe.RowCount + " hạng ghế");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FORM_HANGGHE_Load(object sender, EventArgs e)
        {
            txtSoGhe.Text = "100";
            HangVe_BUS.LoadHangVe(cmbHangGhe);
        }
        /// <summary>
        /// Sự kiện text của số ghế thay đổi ta không cho nhập kí tự khác số
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSoGhe_TextChanged(object sender, EventArgs e)
        {
            if (!HelpFuction.IsContainsText(txtSoGhe.Text))
            {
                check_SoGhe = Convert.ToUInt32(txtSoGhe.Text);
            }
            else
            {
                txtSoGhe.Text = check_SoGhe.ToString();
            }
        }
    }
}
