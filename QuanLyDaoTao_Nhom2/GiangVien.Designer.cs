
namespace QuanLyDaoTao_Nhom2
{
    partial class GiangVien
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
            this.lblGiangvien = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDanhSachSV = new System.Windows.Forms.Button();
            this.btnLichDay = new System.Windows.Forms.Button();
            this.btnLenDiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGiangvien
            // 
            this.lblGiangvien.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiangvien.Location = new System.Drawing.Point(277, 71);
            this.lblGiangvien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiangvien.Name = "lblGiangvien";
            this.lblGiangvien.Size = new System.Drawing.Size(311, 36);
            this.lblGiangvien.TabIndex = 10;
            this.lblGiangvien.Text = "GIẢNG VIÊN";
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.Exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.Location = new System.Drawing.Point(695, 2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(98, 35);
            this.btThoat.TabIndex = 49;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.yeti1;
            this.pictureBox2.Location = new System.Drawing.Point(285, 133);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(235, 269);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnDanhSachSV
            // 
            this.btnDanhSachSV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachSV.Location = new System.Drawing.Point(620, 238);
            this.btnDanhSachSV.Margin = new System.Windows.Forms.Padding(2);
            this.btnDanhSachSV.Name = "btnDanhSachSV";
            this.btnDanhSachSV.Size = new System.Drawing.Size(111, 53);
            this.btnDanhSachSV.TabIndex = 13;
            this.btnDanhSachSV.Text = "DANH SÁCH SINH VIÊN";
            this.btnDanhSachSV.UseVisualStyleBackColor = true;
            // 
            // btnLichDay
            // 
            this.btnLichDay.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichDay.Location = new System.Drawing.Point(72, 321);
            this.btnLichDay.Margin = new System.Windows.Forms.Padding(2);
            this.btnLichDay.Name = "btnLichDay";
            this.btnLichDay.Size = new System.Drawing.Size(111, 53);
            this.btnLichDay.TabIndex = 12;
            this.btnLichDay.Text = "LỊCH DẠY";
            this.btnLichDay.UseVisualStyleBackColor = true;
            // 
            // btnLenDiem
            // 
            this.btnLenDiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLenDiem.Location = new System.Drawing.Point(72, 201);
            this.btnLenDiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnLenDiem.Name = "btnLenDiem";
            this.btnLenDiem.Size = new System.Drawing.Size(111, 53);
            this.btnLenDiem.TabIndex = 13;
            this.btnLenDiem.Text = "LÊN ĐIỂM";
            this.btnLenDiem.UseVisualStyleBackColor = true;
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(795, 454);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btnLichDay);
            this.Controls.Add(this.btnDanhSachSV);
            this.Controls.Add(this.btnLenDiem);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblGiangvien);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GiangVien";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblGiangvien;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDanhSachSV;
        private System.Windows.Forms.Button btnLichDay;
        private System.Windows.Forms.Button btnLenDiem;
    }
}