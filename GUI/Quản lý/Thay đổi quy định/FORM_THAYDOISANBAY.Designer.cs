namespace GUI
{
    partial class FORM_THAYDOISANBAY
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bnt_2 = new System.Windows.Forms.Button();
            this.bnt_1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "QUY ĐỊNH SÂN BAY";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Số lượng sân bay tối đa:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(197, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 13;
            // 
            // bnt_2
            // 
            this.bnt_2.BackColor = System.Drawing.Color.Teal;
            this.bnt_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_2.Location = new System.Drawing.Point(215, 142);
            this.bnt_2.Name = "bnt_2";
            this.bnt_2.Size = new System.Drawing.Size(82, 33);
            this.bnt_2.TabIndex = 15;
            this.bnt_2.Text = "Thoát";
            this.bnt_2.UseVisualStyleBackColor = false;
            // 
            // bnt_1
            // 
            this.bnt_1.BackColor = System.Drawing.Color.Teal;
            this.bnt_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnt_1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_1.Location = new System.Drawing.Point(67, 142);
            this.bnt_1.Name = "bnt_1";
            this.bnt_1.Size = new System.Drawing.Size(90, 33);
            this.bnt_1.TabIndex = 14;
            this.bnt_1.Text = "Cập Nhật";
            this.bnt_1.UseVisualStyleBackColor = false;
            // 
            // FORM_THAYDOISANBAY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 213);
            this.Controls.Add(this.bnt_2);
            this.Controls.Add(this.bnt_1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "FORM_THAYDOISANBAY";
            this.ShowIcon = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bnt_2;
        private System.Windows.Forms.Button bnt_1;
    }
}