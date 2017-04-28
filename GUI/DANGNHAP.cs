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
    public partial class DANGNHAP : Form
    {
        public DANGNHAP()
        {
            InitializeComponent();
        }

        private void tbName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                errorUser.Icon = Properties.Resources.error_icon1;
                errorUser.SetError(tbName,"Tài khoản chưa được điền");

            }
            else
            {
                errorUser.Icon = Properties.Resources.ok_icon;
                errorUser.SetError(tbName, "Ok");
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                errorPassword.Icon = Properties.Resources.error_icon1;
                errorPassword.SetError(tbPassword, "Mật khẩu chưa được điền");

            }
            else
            {
                errorPassword.Icon = Properties.Resources.ok_icon;
                errorPassword.SetError(tbPassword, "Ok");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
