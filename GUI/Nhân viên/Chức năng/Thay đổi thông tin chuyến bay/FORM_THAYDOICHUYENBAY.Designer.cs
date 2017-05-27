namespace GUI
{
    partial class FORM_THAYDOICHUYENBAY
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
            this.dGVDanhSachCB = new System.Windows.Forms.DataGridView();
            this.clMaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSanBayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSanBayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThoiGianBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dGVDanhSachSBTG = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThoiGianDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bnt_Tim = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.TenHangGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongGhe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachSBTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVDanhSachCB
            // 
            this.dGVDanhSachCB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDanhSachCB.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dGVDanhSachCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachCB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaCB,
            this.clTenCB,
            this.clSanBayDi,
            this.clSanBayDen,
            this.clGiaVe,
            this.clNgayGio,
            this.clThoiGianBay});
            this.dGVDanhSachCB.Location = new System.Drawing.Point(3, 252);
            this.dGVDanhSachCB.Name = "dGVDanhSachCB";
            this.dGVDanhSachCB.RowHeadersVisible = false;
            this.dGVDanhSachCB.Size = new System.Drawing.Size(1010, 149);
            this.dGVDanhSachCB.TabIndex = 3;
            // 
            // clMaCB
            // 
            this.clMaCB.HeaderText = "Mã Chuyến Bay";
            this.clMaCB.Name = "clMaCB";
            // 
            // clTenCB
            // 
            this.clTenCB.HeaderText = "Tên Chuyến Bay";
            this.clTenCB.Name = "clTenCB";
            // 
            // clSanBayDi
            // 
            this.clSanBayDi.HeaderText = "Sân Bay Đi";
            this.clSanBayDi.Name = "clSanBayDi";
            // 
            // clSanBayDen
            // 
            this.clSanBayDen.HeaderText = "Sân Bay Đến";
            this.clSanBayDen.Name = "clSanBayDen";
            // 
            // clGiaVe
            // 
            this.clGiaVe.HeaderText = "Giá Vé";
            this.clGiaVe.Name = "clGiaVe";
            // 
            // clNgayGio
            // 
            this.clNgayGio.HeaderText = "Ngày-Giờ bay";
            this.clNgayGio.Name = "clNgayGio";
            // 
            // clThoiGianBay
            // 
            this.clThoiGianBay.HeaderText = "Thời Gian Bay";
            this.clThoiGianBay.Name = "clThoiGianBay";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1009, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "THAY ĐỔI CHUYẾN BAY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(822, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(725, 613);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cập nhật";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Teal;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(924, 613);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Trang:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 206);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dGVDanhSachSBTG
            // 
            this.dGVDanhSachSBTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDanhSachSBTG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVDanhSachSBTG.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dGVDanhSachSBTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachSBTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clTenSanBay,
            this.clThoiGianDung,
            this.clGhiChu});
            this.dGVDanhSachSBTG.Location = new System.Drawing.Point(0, 531);
            this.dGVDanhSachSBTG.Name = "dGVDanhSachSBTG";
            this.dGVDanhSachSBTG.RowHeadersVisible = false;
            this.dGVDanhSachSBTG.Size = new System.Drawing.Size(1010, 64);
            this.dGVDanhSachSBTG.TabIndex = 12;
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
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1010, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "SÂN BAY TRUNG GIAN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(629, 135);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(133, 26);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(413, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 26);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(561, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Đến:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 28);
            this.label5.TabIndex = 20;
            this.label5.Text = "Từ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ngày Khởi Hành:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_2
            // 
            this.cb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_2.FormattingEnabled = true;
            this.cb_2.Location = new System.Drawing.Point(355, 91);
            this.cb_2.Name = "cb_2";
            this.cb_2.Size = new System.Drawing.Size(191, 28);
            this.cb_2.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(203, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sân Bay Đến:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_1
            // 
            this.cb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_1.FormattingEnabled = true;
            this.cb_1.Location = new System.Drawing.Point(355, 49);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(191, 28);
            this.cb_1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(203, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sân Bay Đi:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bnt_Tim
            // 
            this.bnt_Tim.BackColor = System.Drawing.Color.Teal;
            this.bnt_Tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_Tim.ForeColor = System.Drawing.Color.White;
            this.bnt_Tim.Location = new System.Drawing.Point(3, 167);
            this.bnt_Tim.Name = "bnt_Tim";
            this.bnt_Tim.Size = new System.Drawing.Size(83, 33);
            this.bnt_Tim.TabIndex = 24;
            this.bnt_Tim.Text = "Tìm";
            this.bnt_Tim.UseVisualStyleBackColor = false;
            this.bnt_Tim.Click += new System.EventHandler(this.bnt_Tim_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1009, 32);
            this.label9.TabIndex = 25;
            this.label9.Text = "DANH SÁCH CHUYẾN BAY";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(37, 20);
            this.textBox2.TabIndex = 26;
            this.textBox2.Text = "1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Teal;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1009, 26);
            this.label10.TabIndex = 41;
            this.label10.Text = "DANH SÁCH HẠNG GHẾ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHangGhe,
            this.SoLuongGhe});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 430);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1011, 69);
            this.dataGridView1.TabIndex = 40;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(642, 191);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 45;
            this.button4.Text = "Trang cuối";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Teal;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(302, 191);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 33);
            this.button5.TabIndex = 44;
            this.button5.Text = "Trang đầu";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Teal;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(422, 191);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 33);
            this.btnNextPage.TabIndex = 43;
            this.btnNextPage.Text = "Trang sau";
            this.btnNextPage.UseVisualStyleBackColor = false;
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.Teal;
            this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPage.ForeColor = System.Drawing.Color.White;
            this.btnPrevPage.Location = new System.Drawing.Point(533, 191);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(75, 33);
            this.btnPrevPage.TabIndex = 42;
            this.btnPrevPage.Text = "Trang trước";
            this.btnPrevPage.UseVisualStyleBackColor = false;
            // 
            // TenHangGhe
            // 
            this.TenHangGhe.HeaderText = "Tên hạng ghế";
            this.TenHangGhe.Name = "TenHangGhe";
            // 
            // SoLuongGhe
            // 
            this.SoLuongGhe.HeaderText = "Số lượng ghế";
            this.SoLuongGhe.Name = "SoLuongGhe";
            // 
            // FORM_THAYDOICHUYENBAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 654);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bnt_Tim);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dGVDanhSachSBTG);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGVDanhSachCB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "FORM_THAYDOICHUYENBAY";
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachSBTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVDanhSachCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dGVDanhSachSBTG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiGianDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bnt_Tim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSanBayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSanBayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiGianBay;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangGhe;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongGhe;
    }
}