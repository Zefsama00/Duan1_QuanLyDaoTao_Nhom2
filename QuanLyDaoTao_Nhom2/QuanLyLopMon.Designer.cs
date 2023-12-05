namespace QuanLyDaoTao_Nhom2
{
    partial class QuanLyLopMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyLopMon));
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dvThongTin = new System.Windows.Forms.DataGridView();
            this.MaLopMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKyHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLopHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblQuanLyLopMon = new System.Windows.Forms.Label();
            this.txtMaLopmon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.cmxPhong = new System.Windows.Forms.ComboBox();
            this.cmxHocKy = new System.Windows.Forms.ComboBox();
            this.cmxLop = new System.Windows.Forms.ComboBox();
            this.cmxGV = new System.Windows.Forms.ComboBox();
            this.cmxMonHoc = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTin)).BeginInit();
            this.grbThongTin.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(595, 123);
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
            this.btnLamMoi.Location = new System.Drawing.Point(617, 554);
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
            this.btnXoa.Location = new System.Drawing.Point(453, 554);
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
            this.btnSua.Location = new System.Drawing.Point(281, 554);
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
            this.btnThem.Location = new System.Drawing.Point(104, 554);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 34);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dvThongTin
            // 
            this.dvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLopMon,
            this.MaGiangVien,
            this.MaMH,
            this.MaPhongHoc,
            this.MaKyHoc,
            this.MaLopHoc});
            this.dvThongTin.Location = new System.Drawing.Point(9, 190);
            this.dvThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.dvThongTin.Name = "dvThongTin";
            this.dvThongTin.RowHeadersWidth = 62;
            this.dvThongTin.RowTemplate.Height = 28;
            this.dvThongTin.Size = new System.Drawing.Size(775, 199);
            this.dvThongTin.TabIndex = 52;
            this.dvThongTin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvThongTin_CellClick);
            // 
            // MaLopMon
            // 
            this.MaLopMon.HeaderText = "Mã Lớp Môn";
            this.MaLopMon.Name = "MaLopMon";
            this.MaLopMon.Width = 120;
            // 
            // MaGiangVien
            // 
            this.MaGiangVien.HeaderText = "Mã Giảng Viên";
            this.MaGiangVien.Name = "MaGiangVien";
            this.MaGiangVien.Width = 120;
            // 
            // MaMH
            // 
            this.MaMH.HeaderText = "Mã Môn Học";
            this.MaMH.Name = "MaMH";
            this.MaMH.Width = 120;
            // 
            // MaPhongHoc
            // 
            this.MaPhongHoc.HeaderText = "Mã Phòng";
            this.MaPhongHoc.Name = "MaPhongHoc";
            this.MaPhongHoc.Width = 120;
            // 
            // MaKyHoc
            // 
            this.MaKyHoc.HeaderText = "Mã Học Kỳ";
            this.MaKyHoc.Name = "MaKyHoc";
            this.MaKyHoc.Width = 120;
            // 
            // MaLopHoc
            // 
            this.MaLopHoc.HeaderText = "Mã Lớp";
            this.MaLopHoc.Name = "MaLopHoc";
            this.MaLopHoc.Width = 120;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(215, 130);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(367, 26);
            this.txtTimKiem.TabIndex = 51;
            // 
            // lblQuanLyLopMon
            // 
            this.lblQuanLyLopMon.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyLopMon.Location = new System.Drawing.Point(224, 60);
            this.lblQuanLyLopMon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuanLyLopMon.Name = "lblQuanLyLopMon";
            this.lblQuanLyLopMon.Size = new System.Drawing.Size(385, 50);
            this.lblQuanLyLopMon.TabIndex = 53;
            this.lblQuanLyLopMon.Text = "QUẢN LÝ LỚP MÔN";
            // 
            // txtMaLopmon
            // 
            this.txtMaLopmon.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLopmon.Location = new System.Drawing.Point(135, 18);
            this.txtMaLopmon.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaLopmon.Name = "txtMaLopmon";
            this.txtMaLopmon.Size = new System.Drawing.Size(214, 23);
            this.txtMaLopmon.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã môn học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã giảng viên:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã học kỳ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp môn:";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.cmxPhong);
            this.grbThongTin.Controls.Add(this.cmxHocKy);
            this.grbThongTin.Controls.Add(this.cmxLop);
            this.grbThongTin.Controls.Add(this.cmxGV);
            this.grbThongTin.Controls.Add(this.cmxMonHoc);
            this.grbThongTin.Controls.Add(this.txtMaLopmon);
            this.grbThongTin.Controls.Add(this.label5);
            this.grbThongTin.Controls.Add(this.label4);
            this.grbThongTin.Controls.Add(this.label3);
            this.grbThongTin.Controls.Add(this.label6);
            this.grbThongTin.Controls.Add(this.label2);
            this.grbThongTin.Controls.Add(this.label1);
            this.grbThongTin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTin.Location = new System.Drawing.Point(9, 393);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(2);
            this.grbThongTin.Size = new System.Drawing.Size(777, 138);
            this.grbThongTin.TabIndex = 58;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin";
            // 
            // cmxPhong
            // 
            this.cmxPhong.FormattingEnabled = true;
            this.cmxPhong.Location = new System.Drawing.Point(524, 18);
            this.cmxPhong.Name = "cmxPhong";
            this.cmxPhong.Size = new System.Drawing.Size(214, 23);
            this.cmxPhong.TabIndex = 6;
            // 
            // cmxHocKy
            // 
            this.cmxHocKy.FormattingEnabled = true;
            this.cmxHocKy.Location = new System.Drawing.Point(524, 58);
            this.cmxHocKy.Name = "cmxHocKy";
            this.cmxHocKy.Size = new System.Drawing.Size(214, 23);
            this.cmxHocKy.TabIndex = 5;
            // 
            // cmxLop
            // 
            this.cmxLop.FormattingEnabled = true;
            this.cmxLop.Location = new System.Drawing.Point(524, 95);
            this.cmxLop.Name = "cmxLop";
            this.cmxLop.Size = new System.Drawing.Size(214, 23);
            this.cmxLop.TabIndex = 4;
            // 
            // cmxGV
            // 
            this.cmxGV.FormattingEnabled = true;
            this.cmxGV.Location = new System.Drawing.Point(135, 97);
            this.cmxGV.Name = "cmxGV";
            this.cmxGV.Size = new System.Drawing.Size(214, 23);
            this.cmxGV.TabIndex = 3;
            // 
            // cmxMonHoc
            // 
            this.cmxMonHoc.FormattingEnabled = true;
            this.cmxMonHoc.Location = new System.Drawing.Point(135, 58);
            this.cmxMonHoc.Name = "cmxMonHoc";
            this.cmxMonHoc.Size = new System.Drawing.Size(214, 23);
            this.cmxMonHoc.TabIndex = 2;
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
            // QuanLyLopMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 599);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dvThongTin);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblQuanLyLopMon);
            this.Controls.Add(this.grbThongTin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QuanLyLopMon";
            this.Text = "Quản Lý Lớp Môn";
            this.Load += new System.EventHandler(this.QuanLyLopMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTin)).EndInit();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
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
        private System.Windows.Forms.DataGridView dvThongTin;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblQuanLyLopMon;
        private System.Windows.Forms.TextBox txtMaLopmon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.ComboBox cmxPhong;
        private System.Windows.Forms.ComboBox cmxHocKy;
        private System.Windows.Forms.ComboBox cmxLop;
        private System.Windows.Forms.ComboBox cmxGV;
        private System.Windows.Forms.ComboBox cmxMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLopMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhongHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKyHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLopHoc;
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