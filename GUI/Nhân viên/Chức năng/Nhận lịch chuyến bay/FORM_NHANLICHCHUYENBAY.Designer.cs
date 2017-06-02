namespace GUI
{
    partial class FORM_NHANLICHCHUYENBAY
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
            this.components = new System.ComponentModel.Container();
            this.errorTenChuyenBay = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSanBayDi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNgayGio = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSanBayDi = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThoiGianBay = new System.Windows.Forms.TextBox();
            this.dtpkNgayKhoiHanh = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dGVChuyenBayThem = new System.Windows.Forms.DataGridView();
            this.clSTT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThoiGianDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVSanBayTG = new System.Windows.Forms.DataGridView();
            this.dgvDanhSachGhe = new System.Windows.Forms.DataGridView();
            this.cmbSanBayDen = new Custom.MyComboBox();
            this.TenHangGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenChuyenBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSanBayDi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNgayGio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChuyenBayThem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSanBayTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGhe)).BeginInit();
            this.SuspendLayout();
            // 
            // errorTenChuyenBay
            // 
            this.errorTenChuyenBay.ContainerControl = this;
            // 
            // errorSanBayDi
            // 
            this.errorSanBayDi.ContainerControl = this;
            // 
            // errorNgayGio
            // 
            this.errorNgayGio.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1129, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "NHẬN LỊCH CHUYẾN BAY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSanBayDi
            // 
            this.cmbSanBayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSanBayDi.FormattingEnabled = true;
            this.cmbSanBayDi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSanBayDi.Items.AddRange(new object[] {
            "Cần Thơ",
            "Đà Nẵng",
            "Hải Phòng",
            "Hà Nội",
            "TP HCM"});
            this.cmbSanBayDi.Location = new System.Drawing.Point(176, 67);
            this.cmbSanBayDi.Name = "cmbSanBayDi";
            this.cmbSanBayDi.Size = new System.Drawing.Size(162, 28);
            this.cmbSanBayDi.TabIndex = 88;
            this.cmbSanBayDi.SelectedIndexChanged += new System.EventHandler(this.cmbSanBayDi_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Teal;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(589, 418);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(97, 34);
            this.btnThoat.TabIndex = 98;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Teal;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(414, 418);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 34);
            this.btnThem.TabIndex = 97;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(414, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 28);
            this.label8.TabIndex = 106;
            this.label8.Text = "Giá vé:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 28);
            this.label7.TabIndex = 105;
            this.label7.Text = "Sân bay đến:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(414, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 28);
            this.label6.TabIndex = 104;
            this.label6.Text = "Thời gian bay:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 26);
            this.label3.TabIndex = 101;
            this.label3.Text = "Ngày giờ khởi hành:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 100;
            this.label2.Text = "Sân bay đi:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtThoiGianBay
            // 
            this.txtThoiGianBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThoiGianBay.Location = new System.Drawing.Point(559, 114);
            this.txtThoiGianBay.Name = "txtThoiGianBay";
            this.txtThoiGianBay.Size = new System.Drawing.Size(140, 26);
            this.txtThoiGianBay.TabIndex = 94;
            // 
            // dtpkNgayKhoiHanh
            // 
            this.dtpkNgayKhoiHanh.AllowDrop = true;
            this.dtpkNgayKhoiHanh.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtpkNgayKhoiHanh.CustomFormat = "hh:mm:ss  MM/dd/ yyyy";
            this.dtpkNgayKhoiHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkNgayKhoiHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayKhoiHanh.Location = new System.Drawing.Point(176, 163);
            this.dtpkNgayKhoiHanh.Name = "dtpkNgayKhoiHanh";
            this.dtpkNgayKhoiHanh.Size = new System.Drawing.Size(195, 26);
            this.dtpkNgayKhoiHanh.TabIndex = 107;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Teal;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(674, 21);
            this.label10.TabIndex = 108;
            this.label10.Text = "SÂN BAY TRUNG GIAN";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGVChuyenBayThem
            // 
            this.dGVChuyenBayThem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVChuyenBayThem.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dGVChuyenBayThem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVChuyenBayThem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVChuyenBayThem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT1,
            this.clMaCB});
            this.dGVChuyenBayThem.Location = new System.Drawing.Point(773, 86);
            this.dGVChuyenBayThem.Name = "dGVChuyenBayThem";
            this.dGVChuyenBayThem.RowHeadersVisible = false;
            this.dGVChuyenBayThem.Size = new System.Drawing.Size(337, 326);
            this.dGVChuyenBayThem.TabIndex = 109;
            // 
            // clSTT1
            // 
            this.clSTT1.HeaderText = "STT";
            this.clSTT1.Name = "clSTT1";
            // 
            // clMaCB
            // 
            this.clMaCB.HeaderText = "Mã Chuyến Bay";
            this.clMaCB.Name = "clMaCB";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Teal;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(773, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(337, 20);
            this.label11.TabIndex = 110;
            this.label11.Text = "DANH SÁCH CHUYẾN BAY ĐÃ THÊM";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaVe.Location = new System.Drawing.Point(559, 68);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(140, 26);
            this.txtGiaVe.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(674, 21);
            this.label9.TabIndex = 111;
            this.label9.Text = "DANH SÁCH HẠNG GHẾ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clGhiChu
            // 
            this.clGhiChu.HeaderText = "Ghi Chú";
            this.clGhiChu.Name = "clGhiChu";
            // 
            // clThoiGianDung
            // 
            this.clThoiGianDung.HeaderText = "Thời Gian Dừng";
            this.clThoiGianDung.Name = "clThoiGianDung";
            // 
            // clTenSanBay
            // 
            this.clTenSanBay.HeaderText = "Tên Sân Bay";
            this.clTenSanBay.Name = "clTenSanBay";
            // 
            // dGVSanBayTG
            // 
            this.dGVSanBayTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVSanBayTG.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dGVSanBayTG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVSanBayTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSanBayTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTenSanBay,
            this.clThoiGianDung,
            this.clGhiChu});
            this.dGVSanBayTG.Location = new System.Drawing.Point(12, 345);
            this.dGVSanBayTG.Name = "dGVSanBayTG";
            this.dGVSanBayTG.RowHeadersVisible = false;
            this.dGVSanBayTG.Size = new System.Drawing.Size(674, 67);
            this.dGVSanBayTG.TabIndex = 96;
            // 
            // dgvDanhSachGhe
            // 
            this.dgvDanhSachGhe.AllowUserToAddRows = false;
            this.dgvDanhSachGhe.AllowUserToDeleteRows = false;
            this.dgvDanhSachGhe.AllowUserToResizeColumns = false;
            this.dgvDanhSachGhe.AllowUserToResizeRows = false;
            this.dgvDanhSachGhe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachGhe.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvDanhSachGhe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachGhe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachGhe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHangGhe,
            this.SoLuong});
            this.dgvDanhSachGhe.Location = new System.Drawing.Point(12, 257);
            this.dgvDanhSachGhe.Name = "dgvDanhSachGhe";
            this.dgvDanhSachGhe.RowHeadersVisible = false;
            this.dgvDanhSachGhe.Size = new System.Drawing.Size(674, 67);
            this.dgvDanhSachGhe.TabIndex = 112;
            // 
            // cmbSanBayDen
            // 
            this.cmbSanBayDen.DropDownHeight = 80;
            this.cmbSanBayDen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSanBayDen.FormattingEnabled = true;
            this.cmbSanBayDen.IntegralHeight = false;
            this.cmbSanBayDen.ItemHeight = 19;
            this.cmbSanBayDen.Items.AddRange(new object[] {
            "Cần Thơ",
            "Đà Nẵng",
            "Hải Phòng",
            "Hà Nội",
            "TP HCM",
            "Cần Thơ",
            "Đà Nẵng",
            "Hải Phòng",
            "Hà Nội",
            "TP HCM",
            "Cần Thơ",
            "Đà Nẵng",
            "Hải Phòng",
            "Hà Nội",
            "TP HCM"});
            this.cmbSanBayDen.Location = new System.Drawing.Point(176, 113);
            this.cmbSanBayDen.Name = "cmbSanBayDen";
            this.cmbSanBayDen.Size = new System.Drawing.Size(162, 27);
            this.cmbSanBayDen.TabIndex = 113;
            // 
            // TenHangGhe
            // 
            this.TenHangGhe.HeaderText = "Tên hạng vé";
            this.TenHangGhe.Name = "TenHangGhe";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng ghế";
            this.SoLuong.Name = "SoLuong";
            // 
            // FORM_NHANLICHCHUYENBAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1129, 463);
            this.Controls.Add(this.cmbSanBayDen);
            this.Controls.Add(this.dgvDanhSachGhe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dGVChuyenBayThem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpkNgayKhoiHanh);
            this.Controls.Add(this.cmbSanBayDi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dGVSanBayTG);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtThoiGianBay);
            this.Controls.Add(this.txtGiaVe);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FORM_NHANLICHCHUYENBAY";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FORM_NHANLICHCHUYENBAY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorTenChuyenBay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSanBayDi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNgayGio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVChuyenBayThem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSanBayTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachGhe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorTenChuyenBay;
        private System.Windows.Forms.ErrorProvider errorSanBayDi;
        private System.Windows.Forms.ErrorProvider errorNgayGio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dGVChuyenBayThem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpkNgayKhoiHanh;
        private System.Windows.Forms.ComboBox cmbSanBayDi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtThoiGianBay;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.DataGridView dgvDanhSachGhe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dGVSanBayTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiGianDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCB;
        private Custom.MyComboBox cmbSanBayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}