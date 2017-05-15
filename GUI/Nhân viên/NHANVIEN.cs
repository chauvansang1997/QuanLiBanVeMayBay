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

        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhanLichCBToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thayDoiCBToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ghiNhanDVToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lapPhieuDCToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void huyVeMBToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void traCuuCBToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void traCuuKHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void huongDanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
