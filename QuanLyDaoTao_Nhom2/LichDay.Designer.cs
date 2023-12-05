
namespace QuanLyDaoTao_Nhom2
{
    partial class LichDay
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
            this.lblLichDay = new System.Windows.Forms.Label();
            this.dvThongTin = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LenDiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DSSVToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LichDayToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLichDay
            // 
            this.lblLichDay.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichDay.Location = new System.Drawing.Point(297, 50);
            this.lblLichDay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLichDay.Name = "lblLichDay";
            this.lblLichDay.Size = new System.Drawing.Size(230, 52);
            this.lblLichDay.TabIndex = 20;
            this.lblLichDay.Text = "LỊCH DẠY";
            // 
            // dvThongTin
            // 
            this.dvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvThongTin.Location = new System.Drawing.Point(9, 144);
            this.dvThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.dvThongTin.Name = "dvThongTin";
            this.dvThongTin.RowHeadersWidth = 62;
            this.dvThongTin.RowTemplate.Height = 28;
            this.dvThongTin.Size = new System.Drawing.Size(777, 246);
            this.dvThongTin.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem1,
            this.đổiMậtKhẩuToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 54;
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
            // đổiMậtKhẩuToolStripMenuItem1
            // 
            this.đổiMậtKhẩuToolStripMenuItem1.Name = "đổiMậtKhẩuToolStripMenuItem1";
            this.đổiMậtKhẩuToolStripMenuItem1.Size = new System.Drawing.Size(91, 20);
            this.đổiMậtKhẩuToolStripMenuItem1.Text = "Đổi Mật Khẩu";
            // 
            // LichDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 538);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblLichDay);
            this.Controls.Add(this.dvThongTin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LichDay";
            this.Text = "Lịch Dạy";
            this.Load += new System.EventHandler(this.LichDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLichDay;
        private System.Windows.Forms.DataGridView dvThongTin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem LenDiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DSSVToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem LichDayToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem1;
    }
}