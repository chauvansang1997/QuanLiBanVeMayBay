﻿namespace GUI
{
    partial class FORM_HUYPHIEUDATCHO
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dGVDSPDC = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtPageNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbMaCB = new System.Windows.Forms.ComboBox();
            this.cmbPhieuDC = new System.Windows.Forms.ComboBox();
            this.txtTotalPage = new System.Windows.Forms.TextBox();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCMND = new System.Windows.Forms.ComboBox();
            this.cmbTenHanhKhach = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDSPDC)).BeginInit();
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
            this.label1.Text = "HỦY PHIẾU ĐẶT CHỖ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(449, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 23);
            this.label2.TabIndex = 122;
            this.label2.Text = "Mã phiếu đặt chỗ:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(26, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 23);
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
            this.label7.Size = new System.Drawing.Size(191, 23);
            this.label7.TabIndex = 114;
            this.label7.Text = "Chứng minh nhân dân:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(449, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 25);
            this.label3.TabIndex = 112;
            this.label3.Text = "Mã chuyến bay:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dGVDSPDC
            // 
            this.dGVDSPDC.AllowUserToAddRows = false;
            this.dGVDSPDC.AllowUserToDeleteRows = false;
            this.dGVDSPDC.AllowUserToResizeColumns = false;
            this.dGVDSPDC.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dGVDSPDC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVDSPDC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVDSPDC.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dGVDSPDC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVDSPDC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVDSPDC.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGVDSPDC.Location = new System.Drawing.Point(0, 293);
            this.dGVDSPDC.MultiSelect = false;
            this.dGVDSPDC.Name = "dGVDSPDC";
            this.dGVDSPDC.ReadOnly = true;
            this.dGVDSPDC.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dGVDSPDC.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dGVDSPDC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDSPDC.Size = new System.Drawing.Size(832, 171);
            this.dGVDSPDC.TabIndex = 124;
            this.dGVDSPDC.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dGVDSPDC_RowsAdded);
            this.dGVDSPDC.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dGVDSPDC_RowsRemoved);
            this.dGVDSPDC.SelectionChanged += new System.EventHandler(this.dGVDSPDC_SelectionChanged);
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
            this.btnThoat.Location = new System.Drawing.Point(730, 481);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 35);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Teal;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(614, 481);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 35);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtPageNumber
            // 
            this.txtPageNumber.Location = new System.Drawing.Point(47, 242);
            this.txtPageNumber.Name = "txtPageNumber";
            this.txtPageNumber.Size = new System.Drawing.Size(37, 20);
            this.txtPageNumber.TabIndex = 136;
            this.txtPageNumber.Text = "1";
            this.txtPageNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(2, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 135;
            this.label6.Text = "Trang:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbMaCB
            // 
            this.cmbMaCB.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaCB.FormattingEnabled = true;
            this.cmbMaCB.Location = new System.Drawing.Point(614, 127);
            this.cmbMaCB.Name = "cmbMaCB";
            this.cmbMaCB.Size = new System.Drawing.Size(189, 23);
            this.cmbMaCB.TabIndex = 4;
            // 
            // cmbPhieuDC
            // 
            this.cmbPhieuDC.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPhieuDC.FormattingEnabled = true;
            this.cmbPhieuDC.Location = new System.Drawing.Point(614, 75);
            this.cmbPhieuDC.Name = "cmbPhieuDC";
            this.cmbPhieuDC.Size = new System.Drawing.Size(189, 23);
            this.cmbPhieuDC.TabIndex = 2;
            // 
            // txtTotalPage
            // 
            this.txtTotalPage.Location = new System.Drawing.Point(84, 242);
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
            this.btnLastPage.Location = new System.Drawing.Point(565, 220);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(75, 33);
            this.btnLastPage.TabIndex = 11;
            this.btnLastPage.Text = "Trang cuối";
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.Teal;
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.ForeColor = System.Drawing.Color.White;
            this.btnFirstPage.Location = new System.Drawing.Point(230, 220);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(75, 33);
            this.btnFirstPage.TabIndex = 8;
            this.btnFirstPage.Text = "Trang đầu";
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.BackColor = System.Drawing.Color.Teal;
            this.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevPage.ForeColor = System.Drawing.Color.White;
            this.btnPrevPage.Location = new System.Drawing.Point(348, 220);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(75, 33);
            this.btnPrevPage.TabIndex = 9;
            this.btnPrevPage.Text = "Trang trước";
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.Teal;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(457, 220);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(75, 33);
            this.btnNextPage.TabIndex = 10;
            this.btnNextPage.Text = "Trang sau";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(832, 32);
            this.label9.TabIndex = 144;
            this.label9.Text = "DANH SÁCH PHIẾU ĐẶT CHỖ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCMND
            // 
            this.cmbCMND.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCMND.FormattingEnabled = true;
            this.cmbCMND.Location = new System.Drawing.Point(220, 125);
            this.cmbCMND.Name = "cmbCMND";
            this.cmbCMND.Size = new System.Drawing.Size(189, 23);
            this.cmbCMND.TabIndex = 3;
            // 
            // cmbTenHanhKhach
            // 
            this.cmbTenHanhKhach.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenHanhKhach.FormattingEnabled = true;
            this.cmbTenHanhKhach.Location = new System.Drawing.Point(220, 75);
            this.cmbTenHanhKhach.Name = "cmbTenHanhKhach";
            this.cmbTenHanhKhach.Size = new System.Drawing.Size(189, 23);
            this.cmbTenHanhKhach.TabIndex = 1;
            // 
            // FORM_HUYPHIEUDATCHO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 528);
            this.Controls.Add(this.cmbTenHanhKhach);
            this.Controls.Add(this.cmbCMND);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLastPage);
            this.Controls.Add(this.btnFirstPage);
            this.Controls.Add(this.btnPrevPage);
            this.Controls.Add(this.btnNextPage);
            this.Controls.Add(this.txtTotalPage);
            this.Controls.Add(this.cmbPhieuDC);
            this.Controls.Add(this.cmbMaCB);
            this.Controls.Add(this.txtPageNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dGVDSPDC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_HUYPHIEUDATCHO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FORM_HUYPHIEUDATCHO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDSPDC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGVDSPDC;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtPageNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbMaCB;
        private System.Windows.Forms.ComboBox cmbPhieuDC;
        private System.Windows.Forms.TextBox txtTotalPage;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCMND;
        private System.Windows.Forms.ComboBox cmbTenHanhKhach;
    }
}