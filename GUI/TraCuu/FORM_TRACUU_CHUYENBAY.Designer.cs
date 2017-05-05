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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clMaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSanBayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSanBayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayGio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThoiGianBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoGheH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoGheH2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenSanBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThoiGianDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.bnt_luu = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaCB,
            this.clTenCB,
            this.clSanBayDi,
            this.clSanBayDen,
            this.clGiaVe,
            this.clNgayGio,
            this.clThoiGianBay,
            this.clSoGheH1,
            this.clSoGheH2});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(962, 149);
            this.dataGridView1.TabIndex = 3;
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
            // clSoGheH1
            // 
            this.clSoGheH1.HeaderText = "Số Ghế Hạng 1";
            this.clSoGheH1.Name = "clSoGheH1";
            // 
            // clSoGheH2
            // 
            this.clSoGheH2.HeaderText = "Số Ghế Hạng 2";
            this.clSoGheH2.Name = "clSoGheH2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(961, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "TRA CỨU CHUYẾN BAY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SandyBrown;
            this.button3.Location = new System.Drawing.Point(834, 544);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SandyBrown;
            this.button4.Location = new System.Drawing.Point(-1, 522);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 8;
            this.button4.Text = "Trở về";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SandyBrown;
            this.button5.Location = new System.Drawing.Point(94, 522);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 33);
            this.button5.TabIndex = 9;
            this.button5.Text = "Tiếp theo";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Trang:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 230);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSTT,
            this.clTenSanBay,
            this.clThoiGianDung,
            this.clGhiChu});
            this.dataGridView2.Location = new System.Drawing.Point(-1, 444);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(962, 72);
            this.dataGridView2.TabIndex = 12;
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
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-1, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(962, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "SÂN BAY TRUNG GIAN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bnt_luu
            // 
            this.bnt_luu.BackColor = System.Drawing.Color.SandyBrown;
            this.bnt_luu.Location = new System.Drawing.Point(-1, 191);
            this.bnt_luu.Name = "bnt_luu";
            this.bnt_luu.Size = new System.Drawing.Size(83, 33);
            this.bnt_luu.TabIndex = 24;
            this.bnt_luu.Text = "Tìm";
            this.bnt_luu.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(0, 249);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(961, 32);
            this.label9.TabIndex = 25;
            this.label9.Text = "DANH SÁCH SÂN BAY";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(482, 130);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(133, 26);
            this.dateTimePicker2.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(266, 129);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 26);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(414, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 29);
            this.label6.TabIndex = 32;
            this.label6.Text = "Đến:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(223, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 28);
            this.label5.TabIndex = 31;
            this.label5.Text = "Từ:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "Ngày Khởi Hành:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_2
            // 
            this.cb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_2.FormattingEnabled = true;
            this.cb_2.Location = new System.Drawing.Point(208, 86);
            this.cb_2.Name = "cb_2";
            this.cb_2.Size = new System.Drawing.Size(191, 28);
            this.cb_2.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 28);
            this.label7.TabIndex = 28;
            this.label7.Text = "Sân Bay Đến:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_1
            // 
            this.cb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_1.FormattingEnabled = true;
            this.cb_1.Location = new System.Drawing.Point(208, 44);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(191, 28);
            this.cb_1.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Sân Bay Đi:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FORM_TRACUU_CHUYENBAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.plane2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(961, 589);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bnt_luu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Name = "FORM_TRACUU_CHUYENBAY";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSanBayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSanBayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayGio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiGianBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoGheH1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoGheH2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenSanBay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThoiGianDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bnt_luu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_1;
        private System.Windows.Forms.Label label8;
    }
}