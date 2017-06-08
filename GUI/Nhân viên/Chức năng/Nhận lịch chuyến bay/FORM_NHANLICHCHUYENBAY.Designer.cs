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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dGVSanBayTG = new System.Windows.Forms.DataGridView();
            this.dgvDanhSachGhe = new System.Windows.Forms.DataGridView();
            this.btnThemHangGhe = new System.Windows.Forms.Button();
            this.btnXoaHangGhe = new System.Windows.Forms.Button();
            this.btnXoaSanBayTG = new System.Windows.Forms.Button();
            this.btnThemSanBayTG = new System.Windows.Forms.Button();
            this.cmbSanBayDen = new System.Windows.Forms.ComboBox();
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
            this.label4.Size = new System.Drawing.Size(1212, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "NHẬN LỊCH CHUYẾN BAY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSanBayDi
            // 
            this.cmbSanBayDi.DropDownHeight = 90;
            this.cmbSanBayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSanBayDi.FormattingEnabled = true;
            this.cmbSanBayDi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSanBayDi.IntegralHeight = false;
            this.cmbSanBayDi.Items.AddRange(new object[] {
            "Cần Thơ",
            "Đà Nẵng",
            "Hải Phòng",
            "Hà Nội",
            "TP HCM"});
            this.cmbSanBayDi.Location = new System.Drawing.Point(176, 67);
            this.cmbSanBayDi.Name = "cmbSanBayDi";
            this.cmbSanBayDi.Size = new System.Drawing.Size(242, 28);
            this.cmbSanBayDi.TabIndex = 88;
            this.cmbSanBayDi.SelectedIndexChanged += new System.EventHandler(this.cmbSanBayDi_SelectedIndexChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Teal;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(1078, 483);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 33);
            this.btnThoat.TabIndex = 98;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Teal;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(863, 483);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 33);
            this.btnThem.TabIndex = 97;
            this.btnThem.Text = "Thêm chuyến bay";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(467, 67);
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
            this.label6.Location = new System.Drawing.Point(467, 113);
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
            this.txtThoiGianBay.Location = new System.Drawing.Point(612, 115);
            this.txtThoiGianBay.Name = "txtThoiGianBay";
            this.txtThoiGianBay.Size = new System.Drawing.Size(203, 26);
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
            this.label10.Location = new System.Drawing.Point(12, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(803, 21);
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
            this.dGVChuyenBayThem.Location = new System.Drawing.Point(863, 85);
            this.dGVChuyenBayThem.Name = "dGVChuyenBayThem";
            this.dGVChuyenBayThem.RowHeadersVisible = false;
            this.dGVChuyenBayThem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVChuyenBayThem.Size = new System.Drawing.Size(337, 383);
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
            this.label11.Location = new System.Drawing.Point(863, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(337, 20);
            this.label11.TabIndex = 110;
            this.label11.Text = "DANH SÁCH CHUYẾN BAY ĐÃ THÊM";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaVe.Location = new System.Drawing.Point(612, 69);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.Size = new System.Drawing.Size(203, 26);
            this.txtGiaVe.TabIndex = 92;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(804, 27);
            this.label9.TabIndex = 111;
            this.label9.Text = "DANH SÁCH HẠNG GHẾ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGVSanBayTG
            // 
            this.dGVSanBayTG.AllowUserToAddRows = false;
            this.dGVSanBayTG.AllowUserToDeleteRows = false;
            this.dGVSanBayTG.AllowUserToResizeColumns = false;
            this.dGVSanBayTG.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dGVSanBayTG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVSanBayTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVSanBayTG.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dGVSanBayTG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVSanBayTG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dGVSanBayTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVSanBayTG.DefaultCellStyle = dataGridViewCellStyle4;
            this.dGVSanBayTG.Location = new System.Drawing.Point(12, 401);
            this.dGVSanBayTG.MultiSelect = false;
            this.dGVSanBayTG.Name = "dGVSanBayTG";
            this.dGVSanBayTG.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVSanBayTG.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dGVSanBayTG.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dGVSanBayTG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVSanBayTG.Size = new System.Drawing.Size(803, 67);
            this.dGVSanBayTG.TabIndex = 96;
            this.dGVSanBayTG.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dGVSanBayTG_RowsAdded);
            this.dGVSanBayTG.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dGVSanBayTG_RowsRemoved);
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
            this.dgvDanhSachGhe.Location = new System.Drawing.Point(12, 261);
            this.dgvDanhSachGhe.MultiSelect = false;
            this.dgvDanhSachGhe.Name = "dgvDanhSachGhe";
            this.dgvDanhSachGhe.ReadOnly = true;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachGhe.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachGhe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachGhe.Size = new System.Drawing.Size(803, 67);
            this.dgvDanhSachGhe.TabIndex = 112;
            this.dgvDanhSachGhe.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDanhSachGhe_RowsAdded);
            this.dgvDanhSachGhe.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDanhSachGhe_RowsRemoved);
            // 
            // btnThemHangGhe
            // 
            this.btnThemHangGhe.BackColor = System.Drawing.Color.Teal;
            this.btnThemHangGhe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHangGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHangGhe.ForeColor = System.Drawing.Color.White;
            this.btnThemHangGhe.Location = new System.Drawing.Point(287, 330);
            this.btnThemHangGhe.Name = "btnThemHangGhe";
            this.btnThemHangGhe.Size = new System.Drawing.Size(107, 33);
            this.btnThemHangGhe.TabIndex = 114;
            this.btnThemHangGhe.Text = "Thêm hạng ghế";
            this.btnThemHangGhe.UseVisualStyleBackColor = false;
            this.btnThemHangGhe.Click += new System.EventHandler(this.btnThemHangGhe_Click);
            // 
            // btnXoaHangGhe
            // 
            this.btnXoaHangGhe.BackColor = System.Drawing.Color.Teal;
            this.btnXoaHangGhe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHangGhe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHangGhe.ForeColor = System.Drawing.Color.White;
            this.btnXoaHangGhe.Location = new System.Drawing.Point(469, 330);
            this.btnXoaHangGhe.Name = "btnXoaHangGhe";
            this.btnXoaHangGhe.Size = new System.Drawing.Size(107, 33);
            this.btnXoaHangGhe.TabIndex = 115;
            this.btnXoaHangGhe.Text = "Xóa hạng ghế";
            this.btnXoaHangGhe.UseVisualStyleBackColor = false;
            this.btnXoaHangGhe.Click += new System.EventHandler(this.btnXoaHangGhe_Click);
            // 
            // btnXoaSanBayTG
            // 
            this.btnXoaSanBayTG.BackColor = System.Drawing.Color.Teal;
            this.btnXoaSanBayTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSanBayTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSanBayTG.ForeColor = System.Drawing.Color.White;
            this.btnXoaSanBayTG.Location = new System.Drawing.Point(469, 483);
            this.btnXoaSanBayTG.Name = "btnXoaSanBayTG";
            this.btnXoaSanBayTG.Size = new System.Drawing.Size(107, 33);
            this.btnXoaSanBayTG.TabIndex = 120;
            this.btnXoaSanBayTG.Text = "Xóa sân bay";
            this.btnXoaSanBayTG.UseVisualStyleBackColor = false;
            this.btnXoaSanBayTG.Click += new System.EventHandler(this.btnXoaSanBayTG_Click);
            // 
            // btnThemSanBayTG
            // 
            this.btnThemSanBayTG.BackColor = System.Drawing.Color.Teal;
            this.btnThemSanBayTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSanBayTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemSanBayTG.ForeColor = System.Drawing.Color.White;
            this.btnThemSanBayTG.Location = new System.Drawing.Point(287, 483);
            this.btnThemSanBayTG.Name = "btnThemSanBayTG";
            this.btnThemSanBayTG.Size = new System.Drawing.Size(107, 33);
            this.btnThemSanBayTG.TabIndex = 119;
            this.btnThemSanBayTG.Text = "Thêm sân bay";
            this.btnThemSanBayTG.UseVisualStyleBackColor = false;
            this.btnThemSanBayTG.Click += new System.EventHandler(this.btnThemSanBayTG_Click);
            // 
            // cmbSanBayDen
            // 
            this.cmbSanBayDen.DropDownHeight = 90;
            this.cmbSanBayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSanBayDen.FormattingEnabled = true;
            this.cmbSanBayDen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbSanBayDen.IntegralHeight = false;
            this.cmbSanBayDen.Items.AddRange(new object[] {
            "Cần Thơ",
            "Đà Nẵng",
            "Hải Phòng",
            "Hà Nội",
            "TP HCM"});
            this.cmbSanBayDen.Location = new System.Drawing.Point(176, 114);
            this.cmbSanBayDen.Name = "cmbSanBayDen";
            this.cmbSanBayDen.Size = new System.Drawing.Size(242, 28);
            this.cmbSanBayDen.TabIndex = 121;
            // 
            // FORM_NHANLICHCHUYENBAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1212, 542);
            this.Controls.Add(this.cmbSanBayDen);
            this.Controls.Add(this.btnXoaSanBayTG);
            this.Controls.Add(this.btnThemSanBayTG);
            this.Controls.Add(this.btnXoaHangGhe);
            this.Controls.Add(this.btnThemHangGhe);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCB;
     
        private System.Windows.Forms.Button btnXoaHangGhe;
        private System.Windows.Forms.Button btnThemHangGhe;
        private System.Windows.Forms.Button btnXoaSanBayTG;
        private System.Windows.Forms.Button btnThemSanBayTG;
        private System.Windows.Forms.ComboBox cmbSanBayDen;
    }
}