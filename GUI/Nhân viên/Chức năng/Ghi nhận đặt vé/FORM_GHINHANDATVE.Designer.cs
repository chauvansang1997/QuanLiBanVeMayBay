namespace GUI
{
    partial class FORM_GHINHANDATVE
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTenHanhKhach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGiaVe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorTenHanhKhach = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCMND = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorSoDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMaChuyenBay = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorHangVe = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMaChuyenBay = new System.Windows.Forms.TextBox();
            this.txtTenHangVe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorTenHanhKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCMND)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaChuyenBay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHangVe)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(468, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 26);
            this.label7.TabIndex = 40;
            this.label7.Text = "Chứng minh nhân dân:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCMND
            // 
            this.txtCMND.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCMND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(646, 85);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(227, 26);
            this.txtCMND.TabIndex = 2;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            this.txtCMND.Leave += new System.EventHandler(this.txtCMND_Leave);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(52, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 26);
            this.label9.TabIndex = 44;
            this.label9.Text = "Số điện Thoại:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSoDT
            // 
            this.txtSoDT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSoDT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDT.Location = new System.Drawing.Point(204, 145);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(227, 26);
            this.txtSoDT.TabIndex = 3;
            this.txtSoDT.TextChanged += new System.EventHandler(this.txtSoDT_TextChanged);
            this.txtSoDT.Leave += new System.EventHandler(this.txtSoDT_Leave);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(472, 206);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 28);
            this.label10.TabIndex = 48;
            this.label10.Text = "Giá Tiền:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(52, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 26);
            this.label11.TabIndex = 53;
            this.label11.Text = "Tên hành khách:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(637, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Đặt";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Teal;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(786, 290);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 40);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTenHanhKhach
            // 
            this.txtTenHanhKhach.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenHanhKhach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHanhKhach.Location = new System.Drawing.Point(204, 85);
            this.txtTenHanhKhach.Name = "txtTenHanhKhach";
            this.txtTenHanhKhach.Size = new System.Drawing.Size(227, 26);
            this.txtTenHanhKhach.TabIndex = 1;
            this.txtTenHanhKhach.TextChanged += new System.EventHandler(this.txtTenHanhKhach_TextChanged);
            this.txtTenHanhKhach.Leave += new System.EventHandler(this.txtTenHanhKhach_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 58;
            this.label1.Text = "Hạng vé:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(472, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 114;
            this.label2.Text = "Mã chuyến bay:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGiaVe
            // 
            this.txtGiaVe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGiaVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaVe.Location = new System.Drawing.Point(646, 206);
            this.txtGiaVe.Name = "txtGiaVe";
            this.txtGiaVe.ReadOnly = true;
            this.txtGiaVe.Size = new System.Drawing.Size(227, 26);
            this.txtGiaVe.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(904, 52);
            this.label4.TabIndex = 1;
            this.label4.Text = "GHI NHẬN ĐẶT VÉ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorTenHanhKhach
            // 
            this.errorTenHanhKhach.ContainerControl = this;
            // 
            // errorCMND
            // 
            this.errorCMND.ContainerControl = this;
            // 
            // errorSoDT
            // 
            this.errorSoDT.ContainerControl = this;
            // 
            // errorMaChuyenBay
            // 
            this.errorMaChuyenBay.ContainerControl = this;
            // 
            // errorHangVe
            // 
            this.errorHangVe.ContainerControl = this;
            // 
            // txtMaChuyenBay
            // 
            this.txtMaChuyenBay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMaChuyenBay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChuyenBay.Location = new System.Drawing.Point(646, 145);
            this.txtMaChuyenBay.Name = "txtMaChuyenBay";
            this.txtMaChuyenBay.ReadOnly = true;
            this.txtMaChuyenBay.Size = new System.Drawing.Size(227, 26);
            this.txtMaChuyenBay.TabIndex = 4;
            // 
            // txtTenHangVe
            // 
            this.txtTenHangVe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTenHangVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenHangVe.Location = new System.Drawing.Point(204, 206);
            this.txtTenHangVe.Name = "txtTenHangVe";
            this.txtTenHangVe.ReadOnly = true;
            this.txtTenHangVe.Size = new System.Drawing.Size(227, 26);
            this.txtTenHangVe.TabIndex = 5;
            // 
            // FORM_GHINHANDATVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(904, 372);
            this.Controls.Add(this.txtTenHangVe);
            this.Controls.Add(this.txtMaChuyenBay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGiaVe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenHanhKhach);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSoDT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FORM_GHINHANDATVE";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorTenHanhKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCMND)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorSoDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMaChuyenBay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorHangVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTenHanhKhach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGiaVe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorTenHanhKhach;
        private System.Windows.Forms.ErrorProvider errorCMND;
        private System.Windows.Forms.ErrorProvider errorSoDT;
        private System.Windows.Forms.ErrorProvider errorMaChuyenBay;
        private System.Windows.Forms.ErrorProvider errorHangVe;
        private System.Windows.Forms.TextBox txtTenHangVe;
        private System.Windows.Forms.TextBox txtMaChuyenBay;
    }
}