namespace GUI
{
    partial class FORM_TRACUU_CHUYENBAY
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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.dGVSanBayTG = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThoiGianDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.bnt_Find = new System.Windows.Forms.Button();
            this.dtPKNgayKhDen = new System.Windows.Forms.DateTimePicker();
            this.dtPKNgayKHTu = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSanBayDen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSanBayDi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalPage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenHangGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.dGVDachSanhCB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSanBayTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDachSanhCB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(962, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "TRA CỨU CHUYẾN BAY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(874, 648);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Trang:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Location = new System.Drawing.Point(45, 206);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(37, 20);
            this.txtPageNumber.TabIndex = 11;
            this.txtPageNumber.Text = "1";
            this.txtPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dGVSanBayTG
            // 
            this.dGVSanBayTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVSanBayTG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVSanBayTG.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dGVSanBayTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSanBayTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clTenSanBay,
            this.clThoiGianDung,
            this.clGhiChu});
            this.dGVSanBayTG.Location = new System.Drawing.Point(-1, 567);
            this.dGVSanBayTG.Name = "dGVSanBayTG";
            this.dGVSanBayTG.RowHeadersVisible = false;
            this.dGVSanBayTG.Size = new System.Drawing.Size(962, 72);
            this.dGVSanBayTG.TabIndex = 12;
            // 
            // clSTT
            // 
            this.clSTT.HeaderText = "STT";
            this.clSTT.Name = "clSTT";
            // 
            // clTenSanBay
            // 
            this.clTenSanBay.HeaderText = "Tên Sân Bay";
            this.clTenSanBay.Name = "clTenSanBay";
            // 
            // clThoiGianDung
            // 
            this.clThoiGianDung.HeaderText = "Thời Gian Dừng";
            this.clThoiGianDung.Name = "clThoiGianDung";
            // 
            // clGhiChu
            // 
            this.clGhiChu.HeaderText = "Ghi Chú";
            this.clGhiChu.Name = "clGhiChu";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(962, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "SÂN BAY TRUNG GIAN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bnt_Find
            // 
            this.bnt_Find.BackColor = System.Drawing.Color.Teal;
            this.bnt_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Find.ForeColor = System.Drawing.Color.White;
            this.bnt_Find.Location = new System.Drawing.Point(-1, 167);
            this.bnt_Find.Name = "bnt_Find";
            this.bnt_Find.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bnt_Find.Size = new System.Drawing.Size(83, 33);
            this.bnt_Find.TabIndex = 24;
            this.bnt_Find.Text = "Tìm";
            this.bnt_Find.UseVisualStyleBackColor = false;
            this.bnt_Find.Click += new System.EventHandler(this.bnt_Find_Click);
            // 
            // dtPKNgayKhDen
            // 
            this.dtPKNgayKhDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPKNgayKhDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPKNgayKhDen.Location = new System.Drawing.Point(482, 130);
            this.dtPKNgayKhDen.Name = "dtPKNgayKhDen";
            this.dtPKNgayKhDen.Size = new System.Drawing.Size(133, 26);
            this.dtPKNgayKhDen.TabIndex = 34;
            // 
            // dtPKNgayKHTu
            // 
            this.dtPKNgayKHTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPKNgayKHTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPKNgayKHTu.Location = new System.Drawing.Point(266, 129);
            this.dtPKNgayKHTu.Name = "dtPKNgayKHTu";
            this.dtPKNgayKHTu.Size = new System.Drawing.Size(133, 26);
            this.dtPKNgayKHTu.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(414, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "Đến:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(223, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 28);
            this.label5.TabIndex = 31;
            this.label5.Text = "Từ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(56, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ngày Khởi Hành:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSanBayDen
            // 
            this.cmbSanBayDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSanBayDen.FormattingEnabled = true;
            this.cmbSanBayDen.Location = new System.Drawing.Point(630, 80);
            this.cmbSanBayDen.Name = "cmbSanBayDen";
            this.cmbSanBayDen.Size = new System.Drawing.Size(191, 28);
            this.cmbSanBayDen.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(478, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 28);
            this.label7.TabIndex = 28;
            this.label7.Text = "Sân Bay Đến:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSanBayDi
            // 
            this.cmbSanBayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSanBayDi.FormattingEnabled = true;
            this.cmbSanBayDi.Location = new System.Drawing.Point(220, 79);
            this.cmbSanBayDi.Name = "cmbSanBayDi";
            this.cmbSanBayDi.Size = new System.Drawing.Size(191, 28);
            this.cmbSanBayDi.TabIndex = 27;
            this.cmbSanBayDi.SelectedIndexChanged += new System.EventHandler(this.cmbSanBayDi_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(56, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Sân Bay Đi:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Location = new System.Drawing.Point(81, 206);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.Size = new System.Drawing.Size(37, 20);
            this.txtTotalPage.TabIndex = 35;
            this.txtTotalPage.Text = "1";
            this.txtTotalPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(962, 32);
            this.label9.TabIndex = 25;
            this.label9.Text = "DANH SÁCH CHUYẾN BAY";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHangGhe,
            this.SoGhe,
            this.GiaVe});
            this.dataGridView1.Location = new System.Drawing.Point(0, 434);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(962, 101);
            this.dataGridView1.TabIndex = 38;
            // 
            // TenHangGhe
            // 
            this.TenHangGhe.HeaderText = "Tên hạng ghế";
            this.TenHangGhe.Name = "TenHangGhe";
            // 
            // SoGhe
            // 
            this.SoGhe.HeaderText = "Số lượng ghế";
            this.SoGhe.Name = "SoGhe";
            // 
            // GiaVe
            // 
            this.GiaVe.HeaderText = "Giá Vé";
            this.GiaVe.Name = "GiaVe";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Teal;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(962, 29);
            this.label10.TabIndex = 39;
            this.label10.Text = "DANH SÁCH HẠNG GHẾ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.Teal;
            this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPage.ForeColor = System.Drawing.Color.White;
            this.btnLastPage.Location = new System.Drawing.Point(624, 192);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(75, 33);
            this.btnLastPage.TabIndex = 43;
            this.btnLastPage.Text = "Trang cuối";
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.Teal;
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.ForeColor = System.Drawing.Color.White;
            this.btnFirstPage.Location = new System.Drawing.Point(289, 192);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(75, 33);
            this.btnFirstPage.TabIndex = 42;
            this.btnFirstPage.Text = "Trang đầu";
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.Teal;
            this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPage.ForeColor = System.Drawing.Color.White;
            this.btnPrevPage.Location = new System.Drawing.Point(407, 192);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(75, 33);
            this.btnPrevPage.TabIndex = 41;
            this.btnPrevPage.Text = "Trang trước";
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Teal;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(516, 192);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 33);
            this.btnNextPage.TabIndex = 40;
            this.btnNextPage.Text = "Trang sau";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // dGVDachSanhCB
            // 
            this.dGVDachSanhCB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDachSanhCB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGVDachSanhCB.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dGVDachSanhCB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVDachSanhCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDachSanhCB.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dGVDachSanhCB.Location = new System.Drawing.Point(0, 258);
            this.dGVDachSanhCB.MultiSelect = false;
            this.dGVDachSanhCB.Name = "dGVDachSanhCB";
            this.dGVDachSanhCB.ReadOnly = true;
            this.dGVDachSanhCB.RowHeadersVisible = false;
            this.dGVDachSanhCB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDachSanhCB.Size = new System.Drawing.Size(962, 147);
            this.dGVDachSanhCB.TabIndex = 44;
            // 
            // FORM_TRACUU_CHUYENBAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 693);
            this.Controls.Add(this.dGVDachSanhCB);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTotalPage);
            this.Controls.Add(this.dtPKNgayKhDen);
            this.Controls.Add(this.dtPKNgayKHTu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSanBayDen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSanBayDi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bnt_Find);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dGVSanBayTG);
            this.Controls.Add(this.txtPageNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FORM_TRACUU_CHUYENBAY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FORM_TRACUU_CHUYENBAY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVSanBayTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDachSanhCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.DataGridView dGVSanBayTG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnt_Find;
        private System.Windows.Forms.DateTimePicker dtPKNgayKhDen;
        private System.Windows.Forms.DateTimePicker dtPKNgayKHTu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSanBayDen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSanBayDi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiGianDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaVe;
        private System.Windows.Forms.DataGridView dGVDachSanhCB;
    }
}