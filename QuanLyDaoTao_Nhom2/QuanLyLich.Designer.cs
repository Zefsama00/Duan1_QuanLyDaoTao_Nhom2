﻿namespace QuanLyDaoTao_Nhom2
{
    partial class QuanLyLich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyLich));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblQuanLySinhVien = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.cmxHocKy = new System.Windows.Forms.ComboBox();
            this.datetimeNgayHoc = new System.Windows.Forms.DateTimePicker();
            this.txtGioHoc = new System.Windows.Forms.TextBox();
            this.txtMaLichhoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvThongTin = new System.Windows.Forms.DataGridView();
            this.MaLichHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giảngViênToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mônHọcToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.họcKỳToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lịchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ngànhToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyênNgànhToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lớpMônToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(211, 146);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(367, 26);
            this.txtTimKiem.TabIndex = 51;
            // 
            // lblQuanLySinhVien
            // 
            this.lblQuanLySinhVien.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLySinhVien.Location = new System.Drawing.Point(256, 75);
            this.lblQuanLySinhVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuanLySinhVien.Name = "lblQuanLySinhVien";
            this.lblQuanLySinhVien.Size = new System.Drawing.Size(322, 60);
            this.lblQuanLySinhVien.TabIndex = 53;
            this.lblQuanLySinhVien.Text = "QUẢN LÝ LỊCH";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.cmxHocKy);
            this.grbThongTin.Controls.Add(this.datetimeNgayHoc);
            this.grbThongTin.Controls.Add(this.txtGioHoc);
            this.grbThongTin.Controls.Add(this.txtMaLichhoc);
            this.grbThongTin.Controls.Add(this.label8);
            this.grbThongTin.Controls.Add(this.label7);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTin.Location = new System.Drawing.Point(9, 393);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(2);
            this.grbThongTin.Size = new System.Drawing.Size(777, 151);
            this.grbThongTin.TabIndex = 58;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin";
            // 
            // cmxHocKy
            // 
            this.cmxHocKy.FormattingEnabled = true;
            this.cmxHocKy.Location = new System.Drawing.Point(148, 99);
            this.cmxHocKy.Name = "cmxHocKy";
            this.cmxHocKy.Size = new System.Drawing.Size(201, 23);
            this.cmxHocKy.TabIndex = 3;
            // 
            // datetimeNgayHoc
            // 
            this.datetimeNgayHoc.Location = new System.Drawing.Point(521, 30);
            this.datetimeNgayHoc.Name = "datetimeNgayHoc";
            this.datetimeNgayHoc.Size = new System.Drawing.Size(203, 23);
            this.datetimeNgayHoc.TabIndex = 2;
            // 
            // txtGioHoc
            // 
            this.txtGioHoc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioHoc.Location = new System.Drawing.Point(521, 99);
            this.txtGioHoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtGioHoc.Name = "txtGioHoc";
            this.txtGioHoc.Size = new System.Drawing.Size(203, 23);
            this.txtGioHoc.TabIndex = 1;
            // 
            // txtMaLichhoc
            // 
            this.txtMaLichhoc.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLichhoc.Location = new System.Drawing.Point(148, 33);
            this.txtMaLichhoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLichhoc.Name = "txtMaLichhoc";
            this.txtMaLichhoc.Size = new System.Drawing.Size(201, 23);
            this.txtMaLichhoc.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(424, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Giờ học:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Học kỳ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lịch học:";
            // 
            // dvThongTin
            // 
            this.dvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLichHoc,
            this.MaHocKy,
            this.NgayHoc,
            this.GioHoc});
            this.dvThongTin.Location = new System.Drawing.Point(9, 190);
            this.dvThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.dvThongTin.Name = "dvThongTin";
            this.dvThongTin.RowHeadersWidth = 62;
            this.dvThongTin.RowTemplate.Height = 28;
            this.dvThongTin.Size = new System.Drawing.Size(777, 199);
            this.dvThongTin.TabIndex = 52;
            this.dvThongTin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvThongTin_CellClick);
            // 
            // MaLichHoc
            // 
            this.MaLichHoc.HeaderText = "Mã Lịch Học";
            this.MaLichHoc.Name = "MaLichHoc";
            this.MaLichHoc.Width = 180;
            // 
            // MaHocKy
            // 
            this.MaHocKy.HeaderText = "Mã Học Kỳ";
            this.MaHocKy.Name = "MaHocKy";
            this.MaHocKy.Width = 180;
            // 
            // NgayHoc
            // 
            this.NgayHoc.HeaderText = "Ngày Học";
            this.NgayHoc.Name = "NgayHoc";
            this.NgayHoc.Width = 180;
            // 
            // GioHoc
            // 
            this.GioHoc.HeaderText = "Giờ Học";
            this.GioHoc.Name = "GioHoc";
            this.GioHoc.Width = 180;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(595, 140);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(107, 36);
            this.btnTimKiem.TabIndex = 49;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.Refresh;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(619, 568);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(114, 34);
            this.btnLamMoi.TabIndex = 57;
            this.btnLamMoi.Text = "LÀM MỚI";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.Delete;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(446, 568);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 34);
            this.btnXoa.TabIndex = 56;
            this.btnXoa.Text = "XOÁ";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.Edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(265, 568);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 34);
            this.btnSua.TabIndex = 55;
            this.btnSua.Text = "SỬA";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.Add;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(61, 568);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 34);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.Exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.Location = new System.Drawing.Point(688, 27);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(98, 35);
            this.btThoat.TabIndex = 59;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem1
            // 
            this.quảnLýToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinhViênToolStripMenuItem,
            this.giảngViênToolStripMenuItem1,
            this.điểmToolStripMenuItem1,
            this.lớpToolStripMenuItem1,
            this.mônHọcToolStripMenuItem2,
            this.họcKỳToolStripMenuItem1,
            this.lịchToolStripMenuItem1,
            this.ngànhToolStripMenuItem1,
            this.chuyênNgànhToolStripMenuItem1,
            this.lớpMônToolStripMenuItem});
            this.quảnLýToolStripMenuItem1.Name = "quảnLýToolStripMenuItem1";
            this.quảnLýToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.quảnLýToolStripMenuItem1.Text = "Quản Lý";
            // 
            // sinhViênToolStripMenuItem
            // 
            this.sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
            this.sinhViênToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sinhViênToolStripMenuItem.Text = "Sinh Viên";
            this.sinhViênToolStripMenuItem.Click += new System.EventHandler(this.sinhViênToolStripMenuItem_Click);
            // 
            // giảngViênToolStripMenuItem1
            // 
            this.giảngViênToolStripMenuItem1.Name = "giảngViênToolStripMenuItem1";
            this.giảngViênToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.giảngViênToolStripMenuItem1.Text = "Giảng Viên";
            this.giảngViênToolStripMenuItem1.Click += new System.EventHandler(this.giảngViênToolStripMenuItem1_Click);
            // 
            // điểmToolStripMenuItem1
            // 
            this.điểmToolStripMenuItem1.Name = "điểmToolStripMenuItem1";
            this.điểmToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.điểmToolStripMenuItem1.Text = "Điểm";
            this.điểmToolStripMenuItem1.Click += new System.EventHandler(this.điểmToolStripMenuItem1_Click);
            // 
            // lớpToolStripMenuItem1
            // 
            this.lớpToolStripMenuItem1.Name = "lớpToolStripMenuItem1";
            this.lớpToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.lớpToolStripMenuItem1.Text = "Lớp";
            this.lớpToolStripMenuItem1.Click += new System.EventHandler(this.lớpToolStripMenuItem1_Click);
            // 
            // mônHọcToolStripMenuItem2
            // 
            this.mônHọcToolStripMenuItem2.Name = "mônHọcToolStripMenuItem2";
            this.mônHọcToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.mônHọcToolStripMenuItem2.Text = "Môn Học";
            this.mônHọcToolStripMenuItem2.Click += new System.EventHandler(this.mônHọcToolStripMenuItem2_Click);
            // 
            // họcKỳToolStripMenuItem1
            // 
            this.họcKỳToolStripMenuItem1.Name = "họcKỳToolStripMenuItem1";
            this.họcKỳToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.họcKỳToolStripMenuItem1.Text = "Học Kỳ";
            this.họcKỳToolStripMenuItem1.Click += new System.EventHandler(this.họcKỳToolStripMenuItem1_Click);
            // 
            // lịchToolStripMenuItem1
            // 
            this.lịchToolStripMenuItem1.Name = "lịchToolStripMenuItem1";
            this.lịchToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.lịchToolStripMenuItem1.Text = "Lịch";
            this.lịchToolStripMenuItem1.Click += new System.EventHandler(this.lịchToolStripMenuItem1_Click);
            // 
            // ngànhToolStripMenuItem1
            // 
            this.ngànhToolStripMenuItem1.Name = "ngànhToolStripMenuItem1";
            this.ngànhToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ngànhToolStripMenuItem1.Text = "Ngành";
            this.ngànhToolStripMenuItem1.Click += new System.EventHandler(this.ngànhToolStripMenuItem1_Click);
            // 
            // chuyênNgànhToolStripMenuItem1
            // 
            this.chuyênNgànhToolStripMenuItem1.Name = "chuyênNgànhToolStripMenuItem1";
            this.chuyênNgànhToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.chuyênNgànhToolStripMenuItem1.Text = "Chuyên Ngành";
            this.chuyênNgànhToolStripMenuItem1.Click += new System.EventHandler(this.chuyênNgànhToolStripMenuItem1_Click);
            // 
            // lớpMônToolStripMenuItem
            // 
            this.lớpMônToolStripMenuItem.Name = "lớpMônToolStripMenuItem";
            this.lớpMônToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lớpMônToolStripMenuItem.Text = "Lớp Môn";
            this.lớpMônToolStripMenuItem.Click += new System.EventHandler(this.lớpMônToolStripMenuItem_Click);
            // 
            // QuanLyLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 620);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblQuanLySinhVien);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.dvThongTin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyLich";
            this.Text = "Quản Lý Lịch";
            this.Load += new System.EventHandler(this.QuanLyLich_Load);
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblQuanLySinhVien;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvThongTin;
        private System.Windows.Forms.TextBox txtGioHoc;
        private System.Windows.Forms.TextBox txtMaLichhoc;
        private System.Windows.Forms.DateTimePicker datetimeNgayHoc;
        private System.Windows.Forms.ComboBox cmxHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLichHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioHoc;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giảngViênToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem điểmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lớpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mônHọcToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem họcKỳToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lịchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ngànhToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem chuyênNgànhToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lớpMônToolStripMenuItem;
    }
}