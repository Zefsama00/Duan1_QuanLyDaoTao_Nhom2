
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
            this.btnLichDay = new System.Windows.Forms.Button();
            this.btnLenDiem = new System.Windows.Forms.Button();
            this.lblGiangvien = new System.Windows.Forms.Label();
            this.btnDanhSachSV = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLichDay
            // 
            this.btnLichDay.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichDay.Location = new System.Drawing.Point(170, 414);
            this.btnLichDay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLichDay.Name = "btnLichDay";
            this.btnLichDay.Size = new System.Drawing.Size(148, 66);
            this.btnLichDay.TabIndex = 12;
            this.btnLichDay.Text = "LỊCH DẠY";
            this.btnLichDay.UseVisualStyleBackColor = true;
            // 
            // btnLenDiem
            // 
            this.btnLenDiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLenDiem.Location = new System.Drawing.Point(170, 274);
            this.btnLenDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLenDiem.Name = "btnLenDiem";
            this.btnLenDiem.Size = new System.Drawing.Size(148, 66);
            this.btnLenDiem.TabIndex = 13;
            this.btnLenDiem.Text = "LÊN ĐIỂM";
            this.btnLenDiem.UseVisualStyleBackColor = true;
            this.btnLenDiem.Click += new System.EventHandler(this.btnLenDiem_Click);
            // 
            // lblGiangvien
            // 
            this.lblGiangvien.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiangvien.Location = new System.Drawing.Point(373, 131);
            this.lblGiangvien.Name = "lblGiangvien";
            this.lblGiangvien.Size = new System.Drawing.Size(414, 45);
            this.lblGiangvien.TabIndex = 10;
            this.lblGiangvien.Text = "GIẢNG VIÊN";
            // 
            // btnDanhSachSV
            // 
            this.btnDanhSachSV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachSV.Location = new System.Drawing.Point(876, 330);
            this.btnDanhSachSV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDanhSachSV.Name = "btnDanhSachSV";
            this.btnDanhSachSV.Size = new System.Drawing.Size(148, 66);
            this.btnDanhSachSV.TabIndex = 13;
            this.btnDanhSachSV.Text = "DANH SÁCH SINH VIÊN";
            this.btnDanhSachSV.UseVisualStyleBackColor = true;
            this.btnDanhSachSV.Click += new System.EventHandler(this.btnDanhSachSV_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.download;
            this.pictureBox2.Location = new System.Drawing.Point(449, 248);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 282);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.FPT_Polytechnic1;
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 559);
            this.Controls.Add(this.btnLichDay);
            this.Controls.Add(this.btnDanhSachSV);
            this.Controls.Add(this.btnLenDiem);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblGiangvien);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GiangVien";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLichDay;
        private System.Windows.Forms.Button btnLenDiem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblGiangvien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDanhSachSV;
    }
}