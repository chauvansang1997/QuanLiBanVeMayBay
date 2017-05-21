namespace GUI
{
    partial class FORM_THAYDOIQUYDINH
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
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnChangeSLSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnChangeCB = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(735, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "THAY ĐỔI QUY ĐỊNH";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangeSLSB,
            this.toolStripSeparator2,
            this.toolStripLabel4,
            this.btnChangeCB,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(735, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnChangeSLSB
            // 
            this.btnChangeSLSB.Image = global::GUI.Properties.Resources.change_document;
            this.btnChangeSLSB.Name = "btnChangeSLSB";
            this.btnChangeSLSB.Size = new System.Drawing.Size(166, 22);
            this.btnChangeSLSB.Text = "Thay đổi quy định sân bay";
            this.btnChangeSLSB.Click += new System.EventHandler(this.btnChangeSLSB_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnChangeCB
            // 
            this.btnChangeCB.Image = global::GUI.Properties.Resources.change_document;
            this.btnChangeCB.Name = "btnChangeCB";
            this.btnChangeCB.Size = new System.Drawing.Size(187, 22);
            this.btnChangeCB.Text = "Thay đổi quy định chuyến bay";
            this.btnChangeCB.Click += new System.EventHandler(this.btnChangeCB_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(87, 22);
            this.toolStripLabel1.Text = "Thay đổi giá vé";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::GUI.Properties.Resources.change_document;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(202, 22);
            this.toolStripButton1.Text = "Thay đổi quy định vé chuyến bay";
            // 
            // FORM_THAYDOIQUYDINH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.plane2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(735, 328);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Name = "FORM_THAYDOIQUYDINH";
            this.ShowIcon = false;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnChangeSLSB;
        private System.Windows.Forms.ToolStripButton btnChangeCB;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}