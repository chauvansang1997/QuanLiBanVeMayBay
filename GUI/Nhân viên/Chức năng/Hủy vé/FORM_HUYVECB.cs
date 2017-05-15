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
    public partial class FORM_HUYVECB : Form
    {
        public FORM_HUYVECB()
        {
            InitializeComponent();
            AddTable();
        }

        private void AddTable()
        {
            DataTable table = new DataTable();
            table.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("Hành khách"),
                new DataColumn("CMNN"),
                new DataColumn("Điện thoại"),
               
                new DataColumn("Mã vé"),
                new DataColumn("Hạng vé"),
                new DataColumn("Giá tiền"),
               
                new DataColumn("Mã chuyến bay"),
                 new DataColumn("Ngày giờ bay"),
            });
            
        }

        private void LoadMaCB()
        {

        }
    }
}
