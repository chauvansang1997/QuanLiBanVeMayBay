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
        private DataGridView danhSachHangGhe;
        public FORM_HANGGHE(DataGridView _danhSachHangGhe)
        {
            danhSachHangGhe = _danhSachHangGhe;
            InitializeComponent();
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            int check = 0;
            if(danhSachHangGhe.RowCount<QuyDinh.SoLuongHangVe&& danhSachHangGhe.RowCount < HangVe.SoLuongHangVe)
            {
                try
                {
                    if (HelpFuction.IsContainsText(txtSoGhe.Text))
                    {
                        throw new Exception("Số ghế chỉ chứa số");
                    }
                    foreach (var item in cmbHangGhe.Items)
                    {
                        HangVe hangve = item as HangVe;
                        if (hangve.TenHangVe == cmbHangGhe.Text)
                        {
                            check++;
                            break;
                        }
                    }
                    if (check == 0)
                    {
                        throw new Exception("Hạng vé phải có trong danh sách hạng vé");
                    }
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
            HangVe_BUS.LoadHangVe(cmbHangGhe);
        }
    }
}
