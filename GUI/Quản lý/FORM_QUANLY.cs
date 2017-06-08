using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FORM_QUANLY : Form
    {
        public FORM_QUANLY()
        {
            InitializeComponent();
        }

        private void quanLySanBaytoolstrip_Click(object sender, EventArgs e)
        {
            FORM_QUANLYSANBAY sanbay = new FORM_QUANLYSANBAY();

            this.Hide();
            sanbay.ShowDialog();
            this.Show();
        }

        private void quanLyTBtoolStrip_Click(object sender, EventArgs e)
        {
            FORM_QUANLYTUYENBAY tuyenbay = new FORM_QUANLYTUYENBAY();

            this.Hide();
            tuyenbay.ShowDialog();
            this.Show();
        }

        private void quanlyNVtoolStrip_Click(object sender, EventArgs e)
        {
            FORM_QUANLYNHANVIEN nhanvien  = new FORM_QUANLYNHANVIEN();

            this.Hide();
            nhanvien.ShowDialog();
            this.Show();
        }

        private void quanLyNVMenu_Click(object sender, EventArgs e)
        {
            FORM_QUANLYNHANVIEN nhanvien = new FORM_QUANLYNHANVIEN();

            this.Hide();
            nhanvien.ShowDialog();
            this.Show();
        }

        private void lapBaoCaoThangMenu_Click(object sender, EventArgs e)
        {

        }

        private void lapBaoCaoNamMenu_Click(object sender, EventArgs e)
        {

        }

        private void thayDoiQuyDinhMenu_Click(object sender, EventArgs e)
        {
            FORM_THAYDOIQUYDINH form = new FORM_THAYDOIQUYDINH();

            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void quanLySBMenu_Click(object sender, EventArgs e)
        {
            FORM_QUANLYSANBAY sanbay = new FORM_QUANLYSANBAY();

            this.Hide();
            sanbay.ShowDialog();
            this.Show();
        }

        private void quanLyTBMenu_Click(object sender, EventArgs e)
        {
            FORM_QUANLYTUYENBAY tuyenbay = new FORM_QUANLYTUYENBAY();

            this.Hide();
            tuyenbay.ShowDialog();
            this.Show();
        }

        private void traCuuNVMenu_Click(object sender, EventArgs e)
        {
            FORM_TRACUUTHONGTINNV form = new FORM_TRACUUTHONGTINNV();

            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void traCuuKHMenu_Click(object sender, EventArgs e)
        {
            FORM_TRACUU_THONGTIN_KH form = new FORM_TRACUU_THONGTIN_KH();

            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void traCuuCBMenu_Click(object sender, EventArgs e)
        {
            FORM_TRACUU_CHUYENBAY form = new FORM_TRACUU_CHUYENBAY(Help_Fuction.State.TraCuu);

            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
