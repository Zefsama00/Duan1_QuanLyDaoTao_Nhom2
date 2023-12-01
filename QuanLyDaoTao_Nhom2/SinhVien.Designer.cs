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
            this.btnDiem = new System.Windows.Forms.Button();
            this.btnLichHoc = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSinhVien
            // 
            this.lblSinhVien.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinhVien.Location = new System.Drawing.Point(324, 26);
            this.lblSinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSinhVien.Name = "lblSinhVien";
            this.lblSinhVien.Size = new System.Drawing.Size(164, 36);
            this.lblSinhVien.TabIndex = 4;
            this.lblSinhVien.Text = "SINH VIÊN";
            // 
            // btnDiem
            // 
            this.btnDiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiem.Location = new System.Drawing.Point(93, 257);
            this.btnDiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(111, 53);
            this.btnDiem.TabIndex = 6;
            this.btnDiem.Text = "ĐIỂM";
            this.btnDiem.UseVisualStyleBackColor = true;
            // 
            // btnLichHoc
            // 
            this.btnLichHoc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichHoc.Location = new System.Drawing.Point(596, 257);
            this.btnLichHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnLichHoc.Name = "btnLichHoc";
            this.btnLichHoc.Size = new System.Drawing.Size(111, 53);
            this.btnLichHoc.TabIndex = 6;
            this.btnLichHoc.Text = "LỊCH HỌC";
            this.btnLichHoc.UseVisualStyleBackColor = true;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.Exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.Location = new System.Drawing.Point(696, 2);
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
            this.pictureBox2.Location = new System.Drawing.Point(297, 187);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(219, 229);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(795, 454);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btnLichHoc);
            this.Controls.Add(this.btnDiem);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblSinhVien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSinhVien;
        private System.Windows.Forms.Button btnDiem;
        private System.Windows.Forms.Button btnLichHoc;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

