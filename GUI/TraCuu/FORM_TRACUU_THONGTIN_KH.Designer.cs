namespace GUI
{
   
    partial class FORM_TRACUU_THONGTIN_KH
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clHanhKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCMNN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clHangVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgayGioBay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(832, 32);
            this.label1.TabIndex = 111;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LemonChiffon;
            this.textBox1.Location = new System.Drawing.Point(139, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(195, 30);
            this.textBox1.TabIndex = 121;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(9, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 30);
            this.label11.TabIndex = 119;
            this.label11.Text = "Hành Khách:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_8
            // 
            this.txt_8.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_8.Location = new System.Drawing.Point(497, 51);
            this.txt_8.Multiline = true;
            this.txt_8.Name = "txt_8";
            this.txt_8.ReadOnly = true;
            this.txt_8.Size = new System.Drawing.Size(187, 30);
            this.txt_8.TabIndex = 117;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(366, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 30);
            this.label9.TabIndex = 116;
            this.label9.Text = "Điện Thoại:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_6
            // 
            this.txt_6.BackColor = System.Drawing.Color.LemonChiffon;
            this.txt_6.Location = new System.Drawing.Point(136, 110);
            this.txt_6.Multiline = true;
            this.txt_6.Name = "txt_6";
            this.txt_6.ReadOnly = true;
            this.txt_6.Size = new System.Drawing.Size(195, 30);
            this.txt_6.TabIndex = 115;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(11, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 30);
            this.label7.TabIndex = 114;
            this.label7.Text = "CMND:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clHanhKhach,
            this.clCMNN,
            this.clDT,
            this.clMaVe,
            this.clHangVe,
            this.clGiaTien,
            this.clMaCB,
            this.clNgayGioBay});
            this.dataGridView1.Location = new System.Drawing.Point(0, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(832, 150);
            this.dataGridView1.TabIndex = 124;
            // 
            // clHanhKhach
            // 
            this.clHanhKhach.HeaderText = "Hành khách";
            this.clHanhKhach.Name = "clHanhKhach";
            // 
            // clCMNN
            // 
            this.clCMNN.HeaderText = "CMNN";
            this.clCMNN.Name = "clCMNN";
            // 
            // clDT
            // 
            this.clDT.HeaderText = "Điện thoại";
            this.clDT.Name = "clDT";
            // 
            // clMaVe
            // 
            this.clMaVe.HeaderText = "Mã vé";
            this.clMaVe.Name = "clMaVe";
            // 
            // clHangVe
            // 
            this.clHangVe.HeaderText = "Hạng vé";
            this.clHangVe.Name = "clHangVe";
            // 
            // clGiaTien
            // 
            this.clGiaTien.HeaderText = "Giá tiền";
            this.clGiaTien.Name = "clGiaTien";
            // 
            // clMaCB
            // 
            this.clMaCB.HeaderText = "Mã chuyến bay";
            this.clMaCB.Name = "clMaCB";
            // 
            // clNgayGioBay
            // 
            this.clNgayGioBay.HeaderText = "Ngày giờ bay";
            this.clNgayGioBay.Name = "clNgayGioBay";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SandyBrown;
            this.button1.Location = new System.Drawing.Point(0, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 125;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SandyBrown;
            this.button2.Location = new System.Drawing.Point(93, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 126;
            this.button2.Text = "Tiếp theo";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SandyBrown;
            this.button3.Location = new System.Drawing.Point(0, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 127;
            this.button3.Text = "Trỏ về";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SandyBrown;
            this.button5.Location = new System.Drawing.Point(730, 407);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 36);
            this.button5.TabIndex = 129;
            this.button5.Text = "Thoát";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SandyBrown;
            this.button4.Location = new System.Drawing.Point(609, 407);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 130;
            this.button4.Text = "Hủy vé";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(46, 213);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(37, 20);
            this.textBox3.TabIndex = 136;
            this.textBox3.Text = "1";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(1, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 135;
            this.label6.Text = "Trang:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FORM_TRACUU_THONGTIN_KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.plane2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(832, 454);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "FORM_TRACUU_THONGTIN_KH";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHanhKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCMNN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clHangVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgayGioBay;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
    }
}