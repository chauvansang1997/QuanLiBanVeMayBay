namespace GUI
{
    partial class FORM_SUATHONGTINCHUYENBAY
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtPKNgayGioKH = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dGVSanBayTG = new System.Windows.Forms.DataGridView();
            this.btnXoaSanBayTG = new System.Windows.Forms.Button();
            this.btnThemSanBayTG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSanBayTG)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPKNgayGioKH
            // 
            this.dtPKNgayGioKH.AllowDrop = true;
            this.dtPKNgayGioKH.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtPKNgayGioKH.CustomFormat = "hh:mm:ss  MM/dd/ yyyy";
            this.dtPKNgayGioKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtPKNgayGioKH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPKNgayGioKH.Location = new System.Drawing.Point(324, 58);
            this.dtPKNgayGioKH.Name = "dtPKNgayGioKH";
            this.dtPKNgayGioKH.Size = new System.Drawing.Size(195, 26);
            this.dtPKNgayGioKH.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(184, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 26);
            this.label3.TabIndex = 108;
            this.label3.Text = "Ngày giờ khởi hành:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(789, 32);
            this.label1.TabIndex = 110;
            this.label1.Text = "SỬA THÔNG TIN CHUYẾN BAY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Teal;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(542, 302);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(107, 35);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Teal;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(670, 302);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 35);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(789, 31);
            this.label2.TabIndex = 124;
            this.label2.Text = "SÂN BAY TRUNG GIAN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGVSanBayTG
            // 
            this.dGVSanBayTG.AllowUserToAddRows = false;
            this.dGVSanBayTG.AllowUserToDeleteRows = false;
            this.dGVSanBayTG.AllowUserToResizeColumns = false;
            this.dGVSanBayTG.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dGVSanBayTG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dGVSanBayTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVSanBayTG.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dGVSanBayTG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVSanBayTG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dGVSanBayTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVSanBayTG.DefaultCellStyle = dataGridViewCellStyle8;
            this.dGVSanBayTG.Location = new System.Drawing.Point(0, 147);
            this.dGVSanBayTG.MultiSelect = false;
            this.dGVSanBayTG.Name = "dGVSanBayTG";
            this.dGVSanBayTG.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVSanBayTG.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dGVSanBayTG.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dGVSanBayTG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVSanBayTG.Size = new System.Drawing.Size(789, 67);
            this.dGVSanBayTG.TabIndex = 123;
            this.dGVSanBayTG.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dGVSanBayTG_RowsAdded);
            this.dGVSanBayTG.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dGVSanBayTG_RowsRemoved);
            // 
            // btnXoaSanBayTG
            // 
            this.btnXoaSanBayTG.BackColor = System.Drawing.Color.Teal;
            this.btnXoaSanBayTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaSanBayTG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaSanBayTG.ForeColor = System.Drawing.Color.White;
            this.btnXoaSanBayTG.Location = new System.Drawing.Point(447, 232);
            this.btnXoaSanBayTG.Name = "btnXoaSanBayTG";
            this.btnXoaSanBayTG.Size = new System.Drawing.Size(107, 33);
            this.btnXoaSanBayTG.TabIndex = 3;
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
            this.btnThemSanBayTG.Location = new System.Drawing.Point(264, 232);
            this.btnThemSanBayTG.Name = "btnThemSanBayTG";
            this.btnThemSanBayTG.Size = new System.Drawing.Size(107, 33);
            this.btnThemSanBayTG.TabIndex = 2;
            this.btnThemSanBayTG.Text = "Thêm sân bay";
            this.btnThemSanBayTG.UseVisualStyleBackColor = false;
            this.btnThemSanBayTG.Click += new System.EventHandler(this.btnThemSanBayTG_Click);
            // 
            // FORM_SUATHONGTINCHUYENBAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 366);
            this.Controls.Add(this.btnXoaSanBayTG);
            this.Controls.Add(this.btnThemSanBayTG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGVSanBayTG);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPKNgayGioKH);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_SUATHONGTINCHUYENBAY";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FORM_SUATHONGTINCHUYENBAY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVSanBayTG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPKNgayGioKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGVSanBayTG;
        private System.Windows.Forms.Button btnXoaSanBayTG;
        private System.Windows.Forms.Button btnThemSanBayTG;
    }
}