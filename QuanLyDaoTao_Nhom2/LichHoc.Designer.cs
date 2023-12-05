
namespace QuanLyDaoTao_Nhom2
{
    partial class LichHoc
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LichHocToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTin)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLichHoc
            // 
            this.lblLichHoc.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLichHoc.Location = new System.Drawing.Point(298, 89);
            this.lblLichHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLichHoc.Name = "lblLichHoc";
            this.lblLichHoc.Size = new System.Drawing.Size(214, 51);
            this.lblLichHoc.TabIndex = 9;
            this.lblLichHoc.Text = "LỊCH HỌC";
            // 
            // dvThongTin
            // 
            this.dvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvThongTin.Location = new System.Drawing.Point(11, 194);
            this.dvThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.dvThongTin.Name = "dvThongTin";
            this.dvThongTin.RowHeadersWidth = 62;
            this.dvThongTin.RowTemplate.Height = 28;
            this.dvThongTin.Size = new System.Drawing.Size(777, 247);
            this.dvThongTin.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 24);
            this.menuStrip1.TabIndex = 54;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem1
            // 
            this.quảnLýToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.điểmToolStripMenuItem1,
            this.LichHocToolStripMenuItem1});
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
            // LichHocToolStripMenuItem1
            // 
            this.LichHocToolStripMenuItem1.Name = "LichHocToolStripMenuItem1";
            this.LichHocToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.LichHocToolStripMenuItem1.Text = "Lịch Học";
            this.LichHocToolStripMenuItem1.Click += new System.EventHandler(this.LichHocToolStripMenuItem1_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.Exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.Location = new System.Drawing.Point(685, 27);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(98, 35);
            this.btThoat.TabIndex = 59;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // LichHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 538);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblLichHoc);
            this.Controls.Add(this.dvThongTin);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LichHoc";
            this.Text = "Lịch Học";
            this.Load += new System.EventHandler(this.LichHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTin)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLichHoc;
        private System.Windows.Forms.DataGridView dvThongTin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem điểmToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem LichHocToolStripMenuItem1;
        private System.Windows.Forms.Button btThoat;
    }
}