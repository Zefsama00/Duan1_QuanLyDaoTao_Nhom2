namespace QuanLyDaoTao_Nhom2
{
    partial class Diem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diem));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDiemTongKet = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboMaMonHoc = new System.Windows.Forms.ComboBox();
            this.cboMaSV = new System.Windows.Forms.ComboBox();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.txtDiemLAB = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.dvThongTin = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDiemTongKet);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cboMaMonHoc);
            this.groupBox1.Controls.Add(this.cboMaSV);
            this.groupBox1.Controls.Add(this.txtDiemThi);
            this.groupBox1.Controls.Add(this.txtDiemLAB);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 511);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1166, 205);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // lblDiemTongKet
            // 
            this.lblDiemTongKet.AutoSize = true;
            this.lblDiemTongKet.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemTongKet.ForeColor = System.Drawing.Color.Red;
            this.lblDiemTongKet.Location = new System.Drawing.Point(925, 135);
            this.lblDiemTongKet.Name = "lblDiemTongKet";
            this.lblDiemTongKet.Size = new System.Drawing.Size(49, 32);
            this.lblDiemTongKet.TabIndex = 4;
            this.lblDiemTongKet.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(906, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 23);
            this.label7.TabIndex = 3;
            // 
            // cboMaMonHoc
            // 
            this.cboMaMonHoc.FormattingEnabled = true;
            this.cboMaMonHoc.Location = new System.Drawing.Point(181, 143);
            this.cboMaMonHoc.Name = "cboMaMonHoc";
            this.cboMaMonHoc.Size = new System.Drawing.Size(319, 31);
            this.cboMaMonHoc.TabIndex = 2;
            // 
            // cboMaSV
            // 
            this.cboMaSV.FormattingEnabled = true;
            this.cboMaSV.Location = new System.Drawing.Point(181, 81);
            this.cboMaSV.Name = "cboMaSV";
            this.cboMaSV.Size = new System.Drawing.Size(319, 31);
            this.cboMaSV.TabIndex = 2;
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemThi.Location = new System.Drawing.Point(786, 82);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(319, 30);
            this.txtDiemThi.TabIndex = 1;
            this.txtDiemThi.TextChanged += new System.EventHandler(this.txtDiemThi_TextChanged);
            // 
            // txtDiemLAB
            // 
            this.txtDiemLAB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiemLAB.Location = new System.Drawing.Point(786, 31);
            this.txtDiemLAB.Name = "txtDiemLAB";
            this.txtDiemLAB.Size = new System.Drawing.Size(319, 30);
            this.txtDiemLAB.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.AcceptsReturn = true;
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(181, 28);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(319, 30);
            this.txtID.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(643, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điểm Tổng Kết:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm Thi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(643, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Điểm LAB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã môn học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV:";
            // 
            // lblDiem
            // 
            this.lblDiem.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.Location = new System.Drawing.Point(346, 106);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(527, 70);
            this.lblDiem.TabIndex = 53;
            this.lblDiem.Text = "ĐIỂM SINH VIÊN";
            // 
            // dvThongTin
            // 
            this.dvThongTin.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dvThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvThongTin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MaSV,
            this.MaMonHoc,
            this.DiemLab,
            this.DiemThi,
            this.DiemTongKet});
            this.dvThongTin.Location = new System.Drawing.Point(101, 240);
            this.dvThongTin.Name = "dvThongTin";
            this.dvThongTin.RowHeadersWidth = 62;
            this.dvThongTin.RowTemplate.Height = 28;
            this.dvThongTin.Size = new System.Drawing.Size(986, 265);
            this.dvThongTin.TabIndex = 52;
            this.dvThongTin.DoubleClick += new System.EventHandler(this.dvThongTin_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.MinimumWidth = 8;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 150;
            // 
            // MaMonHoc
            // 
            this.MaMonHoc.DataPropertyName = "MaMonHoc";
            this.MaMonHoc.HeaderText = "Mã môn học";
            this.MaMonHoc.MinimumWidth = 8;
            this.MaMonHoc.Name = "MaMonHoc";
            this.MaMonHoc.Width = 150;
            // 
            // DiemLab
            // 
            this.DiemLab.DataPropertyName = "DiemLab";
            this.DiemLab.HeaderText = "Điểm lab";
            this.DiemLab.MinimumWidth = 8;
            this.DiemLab.Name = "DiemLab";
            this.DiemLab.Width = 150;
            // 
            // DiemThi
            // 
            this.DiemThi.DataPropertyName = "DiemThi";
            this.DiemThi.HeaderText = "Điểm thi";
            this.DiemThi.MinimumWidth = 8;
            this.DiemThi.Name = "DiemThi";
            this.DiemThi.Width = 150;
            // 
            // DiemTongKet
            // 
            this.DiemTongKet.DataPropertyName = "DiemTongKet";
            this.DiemTongKet.HeaderText = "Điểm tổng kết";
            this.DiemTongKet.MinimumWidth = 8;
            this.DiemTongKet.Name = "DiemTongKet";
            this.DiemTongKet.Width = 150;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(294, 179);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(548, 35);
            this.txtTimKiem.TabIndex = 51;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(879, 170);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(161, 52);
            this.btnTimKiem.TabIndex = 59;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.Refresh;
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(892, 753);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(175, 49);
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
            this.btnXoa.Location = new System.Drawing.Point(640, 753);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 49);
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
            this.btnSua.Location = new System.Drawing.Point(400, 753);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 49);
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
            this.btnThem.Location = new System.Drawing.Point(137, 753);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(140, 49);
            this.btnThem.TabIndex = 54;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.FPT_Polytechnic1;
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // Diem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 844);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.dvThongTin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "Diem";
            this.Text = "Diem";
            this.Load += new System.EventHandler(this.Diem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDiemTongKet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboMaMonHoc;
        private System.Windows.Forms.ComboBox cboMaSV;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.TextBox txtDiemLAB;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.DataGridView dvThongTin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTongKet;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}