﻿using DTO;
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
    public partial class NHANVIEN : Form
    {
        public NHANVIEN()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.staff_icon;
            dateTimetimer.Interval = 1000;
            dateTimetimer.Enabled = true;
            dateTimetimer.Tick += DateTimetimer_Tick;
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void DateTimetimer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void xemInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void doiMatKhauToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DANGNHAP form = new DANGNHAP();
            this.Hide();
            form.ShowDialog();

            this.Close();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhanLichCBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dateTimetimer.Enabled = false;
            FORM_NHANLICHCHUYENBAY form = new FORM_NHANLICHCHUYENBAY();
            this.Hide();
            form.ShowDialog();
            this.Show();
            dateTimetimer.Enabled = true;
        }

        private void thayDoiCBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dateTimetimer.Enabled = false;
            FORM_THAYDOICHUYENBAY form = new FORM_THAYDOICHUYENBAY();
            this.Hide();
            form.ShowDialog();
            this.Show();
            dateTimetimer.Enabled = true;
        }

        private void ghiNhanDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_TRACUU_CHUYENBAY form = new FORM_TRACUU_CHUYENBAY(Help_Fuction.State.DatVe);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }


        private void huyVeMBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_HUYVECB form = new FORM_HUYVECB();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void traCuuCBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_TRACUU_CHUYENBAY form = new FORM_TRACUU_CHUYENBAY(Help_Fuction.State.TraCuu);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void traCuuKHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FORM_TRACUU_THONGTIN_KH form = new FORM_TRACUU_THONGTIN_KH();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void huongDanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhanLichCBStripLabel_Click(object sender, EventArgs e)
        {
            FORM_NHANLICHCHUYENBAY form = new FORM_NHANLICHCHUYENBAY();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void ghiNhanDVtoolStripLabel_Click(object sender, EventArgs e)
        {
            FORM_TRACUU_CHUYENBAY form = new FORM_TRACUU_CHUYENBAY(Help_Fuction.State.DatVe);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

 

        private void traCuuCBtoolStripLabel_Click(object sender, EventArgs e)
        {
            FORM_TRACUU_CHUYENBAY form = new FORM_TRACUU_CHUYENBAY(Help_Fuction.State.TraCuu);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void huyPhieuDatChoToolStrip_Click(object sender, EventArgs e)
        {
            FORM_HUYPHIEUDATCHO form = new FORM_HUYPHIEUDATCHO();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void NHANVIEN_Load(object sender, EventArgs e)
        {
            lbXinChao.Text = "Xin Chào"+User.TenNhanVien;
        }
    }
}
