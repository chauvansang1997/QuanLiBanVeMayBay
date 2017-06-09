namespace GUI
{
    partial class FORM_HUYVECB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dGVDanhSachVe = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMaChuyenBay = new System.Windows.Forms.ComboBox();
            this.cmbMaVe = new System.Windows.Forms.ComboBox();
            this.txtTotalPage = new System.Windows.Forms.TextBox();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFristPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.cmbTenHanhKhach = new System.Windows.Forms.ComboBox();
            this.cmbCMND = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachVe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(832, 48);
            this.label1.TabIndex = 111;
            this.label1.Text = "HỦY VÉ CHUYẾN BAY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(449, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 30);
            this.label2.TabIndex = 122;
            this.label2.Text = "Mã vé:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(26, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 30);
            this.label11.TabIndex = 119;
            this.label11.Text = "Tên hành khách:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 30);
            this.label7.TabIndex = 114;
            this.label7.Text = "Chứng minh nhân dân:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(445, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 30);
            this.label3.TabIndex = 112;
            this.label3.Text = "Mã chuyến bay:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dGVDanhSachVe
            // 
            this.dGVDanhSachVe.AllowUserToAddRows = false;
            this.dGVDanhSachVe.AllowUserToDeleteRows = false;
            this.dGVDanhSachVe.AllowUserToResizeColumns = false;
            this.dGVDanhSachVe.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dGVDanhSachVe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVDanhSachVe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDanhSachVe.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dGVDanhSachVe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVDanhSachVe.Location = new System.Drawing.Point(0, 250);
            this.dGVDanhSachVe.MultiSelect = false;
            this.dGVDanhSachVe.Name = "dGVDanhSachVe";
            this.dGVDanhSachVe.ReadOnly = true;
            this.dGVDanhSachVe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dGVDanhSachVe.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVDanhSachVe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDanhSachVe.Size = new System.Drawing.Size(832, 216);
            this.dGVDanhSachVe.TabIndex = 124;
            this.dGVDanhSachVe.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dGVDanhSachVe_RowsAdded);
            this.dGVDanhSachVe.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dGVDanhSachVe_RowsRemoved);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Teal;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(0, 191);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 33);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Teal;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(735, 472);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 33);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Teal;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(614, 472);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 33);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Location = new System.Drawing.Point(46, 231);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(37, 20);
            this.txtPageNumber.TabIndex = 136;
            this.txtPageNumber.Text = "1";
            this.txtPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(1, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 135;
            this.label6.Text = "Trang:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMaChuyenBay
            // 
            this.cmbMaChuyenBay.DropDownHeight = 90;
            this.cmbMaChuyenBay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaChuyenBay.FormattingEnabled = true;
            this.cmbMaChuyenBay.IntegralHeight = false;
            this.cmbMaChuyenBay.Location = new System.Drawing.Point(614, 127);
            this.cmbMaChuyenBay.Name = "cmbMaChuyenBay";
            this.cmbMaChuyenBay.Size = new System.Drawing.Size(186, 27);
            this.cmbMaChuyenBay.TabIndex = 4;
            // 
            // cmbMaVe
            // 
            this.cmbMaVe.DropDownHeight = 90;
            this.cmbMaVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaVe.FormattingEnabled = true;
            this.cmbMaVe.IntegralHeight = false;
            this.cmbMaVe.Location = new System.Drawing.Point(614, 75);
            this.cmbMaVe.Name = "cmbMaVe";
            this.cmbMaVe.Size = new System.Drawing.Size(186, 27);
            this.cmbMaVe.TabIndex = 2;
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Location = new System.Drawing.Point(83, 231);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.ReadOnly = true;
            this.txtTotalPage.Size = new System.Drawing.Size(37, 20);
            this.txtTotalPage.TabIndex = 139;
            this.txtTotalPage.Text = "1";
            this.txtTotalPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.Teal;
            this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPage.ForeColor = System.Drawing.Color.White;
            this.btnLastPage.Location = new System.Drawing.Point(583, 211);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(75, 33);
            this.btnLastPage.TabIndex = 9;
            this.btnLastPage.Text = "Trang cuối";
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnFristPage
            // 
            this.btnFristPage.BackColor = System.Drawing.Color.Teal;
            this.btnFristPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFristPage.ForeColor = System.Drawing.Color.White;
            this.btnFristPage.Location = new System.Drawing.Point(243, 211);
            this.btnFristPage.Name = "btnFristPage";
            this.btnFristPage.Size = new System.Drawing.Size(75, 33);
            this.btnFristPage.TabIndex = 6;
            this.btnFristPage.Text = "Trang đầu";
            this.btnFristPage.UseVisualStyleBackColor = false;
            this.btnFristPage.Click += new System.EventHandler(this.btnFristPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.Teal;
            this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPage.ForeColor = System.Drawing.Color.White;
            this.btnPrevPage.Location = new System.Drawing.Point(363, 211);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(75, 33);
            this.btnPrevPage.TabIndex = 7;
            this.btnPrevPage.Text = "Trang sau";
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Teal;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(474, 211);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 33);
            this.btnNextPage.TabIndex = 8;
            this.btnNextPage.Text = "Trang trước";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // cmbTenHanhKhach
            // 
            this.cmbTenHanhKhach.DropDownHeight = 90;
            this.cmbTenHanhKhach.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenHanhKhach.FormattingEnabled = true;
            this.cmbTenHanhKhach.IntegralHeight = false;
            this.cmbTenHanhKhach.Location = new System.Drawing.Point(219, 82);
            this.cmbTenHanhKhach.Name = "cmbTenHanhKhach";
            this.cmbTenHanhKhach.Size = new System.Drawing.Size(195, 25);
            this.cmbTenHanhKhach.TabIndex = 1;
            // 
            // cmbCMND
            // 
            this.cmbCMND.DropDownHeight = 90;
            this.cmbCMND.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCMND.FormattingEnabled = true;
            this.cmbCMND.IntegralHeight = false;
            this.cmbCMND.Location = new System.Drawing.Point(219, 127);
            this.cmbCMND.Name = "cmbCMND";
            this.cmbCMND.Size = new System.Drawing.Size(195, 25);
            this.cmbCMND.TabIndex = 3;
            // 
            // FORM_HUYVECB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 526);
            this.Controls.Add(this.cmbCMND);
            this.Controls.Add(this.cmbTenHanhKhach);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnFristPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.txtTotalPage);
            this.Controls.Add(this.cmbMaVe);
            this.Controls.Add(this.cmbMaChuyenBay);
            this.Controls.Add(this.txtPageNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dGVDanhSachVe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_HUYVECB";
            this.Load += new System.EventHandler(this.FORM_HUYVECB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGVDanhSachVe;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMaChuyenBay;
        private System.Windows.Forms.ComboBox cmbMaVe;
        private System.Windows.Forms.TextBox txtTotalPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnFristPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.ComboBox cmbTenHanhKhach;
        private System.Windows.Forms.ComboBox cmbCMND;
    }
}