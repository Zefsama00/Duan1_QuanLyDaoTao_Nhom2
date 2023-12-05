namespace QuanLyDaoTao_Nhom2
{
    partial class SinhVien
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
            this.lblSinhVien = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.họcKỳToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSinhVien
            // 
            this.lblSinhVien.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinhVien.Location = new System.Drawing.Point(303, 76);
            this.lblSinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSinhVien.Name = "lblSinhVien";
            this.lblSinhVien.Size = new System.Drawing.Size(208, 83);
            this.lblSinhVien.TabIndex = 4;
            this.lblSinhVien.Text = "SINH VIÊN";
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.Exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.Location = new System.Drawing.Point(697, 27);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(98, 35);
            this.btThoat.TabIndex = 49;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.yeti21;
            this.pictureBox2.Location = new System.Drawing.Point(292, 183);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 229);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem1,
            this.đổiMậtKhẩuToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 53;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem1
            // 
            this.quảnLýToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.điểmToolStripMenuItem1,
            this.họcKỳToolStripMenuItem1});
            this.quảnLýToolStripMenuItem1.Name = "quảnLýToolStripMenuItem1";
            this.quảnLýToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.quảnLýToolStripMenuItem1.Text = "Quản Lý";
            // 
            // điểmToolStripMenuItem1
            // 
            this.điểmToolStripMenuItem1.Name = "điểmToolStripMenuItem1";
            this.điểmToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.điểmToolStripMenuItem1.Text = "Điểm";
            this.điểmToolStripMenuItem1.Click += new System.EventHandler(this.điểmToolStripMenuItem1_Click);
            // 
            // họcKỳToolStripMenuItem1
            // 
            this.họcKỳToolStripMenuItem1.Name = "họcKỳToolStripMenuItem1";
            this.họcKỳToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.họcKỳToolStripMenuItem1.Text = "Lịch Học";
            this.họcKỳToolStripMenuItem1.Click += new System.EventHandler(this.họcKỳToolStripMenuItem1_Click);
            // 
            // đổiMậtKhẩuToolStripMenuItem1
            // 
            this.đổiMậtKhẩuToolStripMenuItem1.Name = "đổiMậtKhẩuToolStripMenuItem1";
            this.đổiMậtKhẩuToolStripMenuItem1.Size = new System.Drawing.Size(91, 20);
            this.đổiMậtKhẩuToolStripMenuItem1.Text = "Đổi Mật Khẩu";
            this.đổiMậtKhẩuToolStripMenuItem1.Click += new System.EventHandler(this.đổiMậtKhẩuToolStripMenuItem1_Click);
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(795, 454);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblSinhVien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SinhVien";
            this.Text = "Trang Chủ Sinh Viên";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSinhVien;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem điểmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem họcKỳToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem1;
    }
}

