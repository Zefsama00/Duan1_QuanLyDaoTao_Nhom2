namespace QuanLyDaoTao_Nhom2
{
    partial class XemDSSV
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
            this.lblLichHoc = new System.Windows.Forms.Label();
            this.dvThongTin = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btThoat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LenDiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DSSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LichDayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLichHoc
            // 
            this.lblLichHoc.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichHoc.Location = new System.Drawing.Point(227, 68);
            this.lblLichHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLichHoc.Name = "lblLichHoc";
            this.lblLichHoc.Size = new System.Drawing.Size(369, 62);
            this.lblLichHoc.TabIndex = 57;
            this.lblLichHoc.Text = "Danh Sách Sinh Viên";
            // 
            // dvThongTin
            // 
            this.dvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaSV,
            this.TenSV,
            this.TenMon,
            this.DiemLab,
            this.DiemThi,
            this.DiemTongKet});
            this.dvThongTin.Location = new System.Drawing.Point(12, 161);
            this.dvThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.dvThongTin.Name = "dvThongTin";
            this.dvThongTin.RowHeadersWidth = 62;
            this.dvThongTin.RowTemplate.Height = 28;
            this.dvThongTin.Size = new System.Drawing.Size(777, 247);
            this.dvThongTin.TabIndex = 58;
            // 
            // ID
            // 
            this.ID.HeaderText = "Mã Sinh Viên";
            this.ID.Name = "ID";
            // 
            // MaSV
            // 
            this.MaSV.HeaderText = "Tên Sinh Viên";
            this.MaSV.Name = "MaSV";
            // 
            // TenSV
            // 
            this.TenSV.HeaderText = "Ngày Sinh";
            this.TenSV.Name = "TenSV";
            // 
            // TenMon
            // 
            this.TenMon.HeaderText = "Giới Tính";
            this.TenMon.Name = "TenMon";
            // 
            // DiemLab
            // 
            this.DiemLab.HeaderText = "Địa Chỉ";
            this.DiemLab.Name = "DiemLab";
            // 
            // DiemThi
            // 
            this.DiemThi.HeaderText = "Email";
            this.DiemThi.Name = "DiemThi";
            // 
            // DiemTongKet
            // 
            this.DiemTongKet.HeaderText = "Số Điện Thoại";
            this.DiemTongKet.Name = "DiemTongKet";
            this.DiemTongKet.Width = 120;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.Exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.Location = new System.Drawing.Point(691, 27);
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem1
            // 
            this.quảnLýToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LenDiemToolStripMenuItem,
            this.DSSVToolStripMenuItem1,
            this.LichDayToolStripMenuItem1});
            this.quảnLýToolStripMenuItem1.Name = "quảnLýToolStripMenuItem1";
            this.quảnLýToolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.quảnLýToolStripMenuItem1.Text = "Quản Lý";
            // 
            // LenDiemToolStripMenuItem
            // 
            this.LenDiemToolStripMenuItem.Name = "LenDiemToolStripMenuItem";
            this.LenDiemToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.LenDiemToolStripMenuItem.Text = "Lên Điểm";
            this.LenDiemToolStripMenuItem.Click += new System.EventHandler(this.LenDiemToolStripMenuItem_Click);
            // 
            // DSSVToolStripMenuItem1
            // 
            this.DSSVToolStripMenuItem1.Name = "DSSVToolStripMenuItem1";
            this.DSSVToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.DSSVToolStripMenuItem1.Text = "Danh Sách Sinh Viên";
            this.DSSVToolStripMenuItem1.Click += new System.EventHandler(this.DSSVToolStripMenuItem1_Click);
            // 
            // LichDayToolStripMenuItem1
            // 
            this.LichDayToolStripMenuItem1.Name = "LichDayToolStripMenuItem1";
            this.LichDayToolStripMenuItem1.Size = new System.Drawing.Size(182, 22);
            this.LichDayToolStripMenuItem1.Text = "Lịch Dạy";
            this.LichDayToolStripMenuItem1.Click += new System.EventHandler(this.LichDayToolStripMenuItem1_Click);
            // 
            // XemDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.dvThongTin);
            this.Controls.Add(this.lblLichHoc);
            this.Name = "XemDSSV";
            this.Text = "XemDSSV";
            this.Load += new System.EventHandler(this.XemDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLichHoc;
        private System.Windows.Forms.DataGridView dvThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTongKet;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem LenDiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DSSVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem LichDayToolStripMenuItem1;
    }
}