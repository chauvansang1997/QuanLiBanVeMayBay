namespace GUI
{
    partial class FORM_QUANLYTUYENBAY
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
            this.label4 = new System.Windows.Forms.Label();
            this.dGVDanhSachTB = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSanBayDen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSanBayDi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtTotalPage = new System.Windows.Forms.TextBox();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachTB)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(954, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "QUẢN LÝ TUYẾN BAY";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGVDanhSachTB
            // 
            this.dGVDanhSachTB.AllowUserToAddRows = false;
            this.dGVDanhSachTB.AllowUserToDeleteRows = false;
            this.dGVDanhSachTB.AllowUserToResizeColumns = false;
            this.dGVDanhSachTB.AllowUserToResizeRows = false;
            this.dGVDanhSachTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDanhSachTB.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dGVDanhSachTB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dGVDanhSachTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDanhSachTB.Location = new System.Drawing.Point(0, 260);
            this.dGVDanhSachTB.MultiSelect = false;
            this.dGVDanhSachTB.Name = "dGVDanhSachTB";
            this.dGVDanhSachTB.ReadOnly = true;
            this.dGVDanhSachTB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDanhSachTB.Size = new System.Drawing.Size(954, 167);
            this.dGVDanhSachTB.TabIndex = 4;
            this.dGVDanhSachTB.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dGVDanhSachTB_RowsAdded);
            this.dGVDanhSachTB.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dGVDanhSachTB_RowsRemoved);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Teal;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(418, 433);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 33);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Teal;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(540, 433);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 33);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Location = new System.Drawing.Point(46, 240);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(37, 20);
            this.txtPageNumber.TabIndex = 17;
            this.txtPageNumber.Text = "1";
            this.txtPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(1, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Trang:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSanBayDen
            // 
            this.cmbSanBayDen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSanBayDen.FormattingEnabled = true;
            this.cmbSanBayDen.Location = new System.Drawing.Point(320, 118);
            this.cmbSanBayDen.Name = "cmbSanBayDen";
            this.cmbSanBayDen.Size = new System.Drawing.Size(191, 27);
            this.cmbSanBayDen.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 27);
            this.label7.TabIndex = 25;
            this.label7.Text = "Sân Bay Đến:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbSanBayDi
            // 
            this.cmbSanBayDi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSanBayDi.FormattingEnabled = true;
            this.cmbSanBayDi.Location = new System.Drawing.Point(320, 73);
            this.cmbSanBayDi.Name = "cmbSanBayDi";
            this.cmbSanBayDi.Size = new System.Drawing.Size(191, 27);
            this.cmbSanBayDi.TabIndex = 24;
            this.cmbSanBayDi.SelectedIndexChanged += new System.EventHandler(this.cmbSanBayDi_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(194, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 27);
            this.label8.TabIndex = 23;
            this.label8.Text = "Sân Bay Đi:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Teal;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(0, 201);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 33);
            this.btnFind.TabIndex = 27;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Location = new System.Drawing.Point(82, 240);
            this.txtTotalPage.Name = "txtTotalPage";
            this.txtTotalPage.Size = new System.Drawing.Size(37, 20);
            this.txtTotalPage.TabIndex = 28;
            this.txtTotalPage.Text = "1";
            this.txtTotalPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.Teal;
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.ForeColor = System.Drawing.Color.White;
            this.btnFirstPage.Location = new System.Drawing.Point(320, 221);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(75, 33);
            this.btnFirstPage.TabIndex = 156;
            this.btnFirstPage.Text = "Trang đầu";
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.Teal;
            this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPage.ForeColor = System.Drawing.Color.White;
            this.btnLastPage.Location = new System.Drawing.Point(616, 221);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(75, 33);
            this.btnLastPage.TabIndex = 155;
            this.btnLastPage.Text = "Trang cuối";
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.Teal;
            this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPage.ForeColor = System.Drawing.Color.White;
            this.btnPrevPage.Location = new System.Drawing.Point(418, 221);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(75, 33);
            this.btnPrevPage.TabIndex = 154;
            this.btnPrevPage.Text = "Trang trước";
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Teal;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(511, 221);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 33);
            this.btnNextPage.TabIndex = 153;
            this.btnNextPage.Text = "Trang sau";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // FORM_QUANLYTUYENBAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 505);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.txtTotalPage);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.cmbSanBayDen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbSanBayDi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPageNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dGVDanhSachTB);
            this.Controls.Add(this.label4);
            this.Name = "FORM_QUANLYTUYENBAY";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FORM_QUANLYTUYENBAY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDanhSachTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dGVDanhSachTB;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSanBayDen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbSanBayDi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtTotalPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
    }
}