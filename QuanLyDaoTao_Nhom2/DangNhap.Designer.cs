namespace QuanLyDaoTao_Nhom2
{
    partial class DangNhap
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
            this.cbghinho = new System.Windows.Forms.CheckBox();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Hienmatkhau = new System.Windows.Forms.PictureBox();
            this.Anmatkhau = new System.Windows.Forms.PictureBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.avartaryetibox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hienmatkhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anmatkhau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avartaryetibox)).BeginInit();
            this.SuspendLayout();
            // 
            // cbghinho
            // 
            this.cbghinho.AutoSize = true;
            this.cbghinho.Location = new System.Drawing.Point(120, 326);
            this.cbghinho.Name = "cbghinho";
            this.cbghinho.Size = new System.Drawing.Size(111, 17);
            this.cbghinho.TabIndex = 50;
            this.cbghinho.Text = "Duy trì đăng nhập";
            this.cbghinho.UseVisualStyleBackColor = true;
            // 
            // btDangNhap
            // 
            this.btDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.ForeColor = System.Drawing.Color.Crimson;
            this.btDangNhap.Location = new System.Drawing.Point(210, 357);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(102, 40);
            this.btDangNhap.TabIndex = 49;
            this.btDangNhap.Text = "Đăng nhập";
            this.btDangNhap.UseVisualStyleBackColor = true;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Crimson;
            this.linkLabel1.Location = new System.Drawing.Point(306, 330);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(89, 13);
            this.linkLabel1.TabIndex = 45;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Quên mật khẩu? ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(156, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mật Khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(156, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tài Khoản :";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(150, 292);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(245, 23);
            this.txtMatkhau.TabIndex = 39;
            this.txtMatkhau.Click += new System.EventHandler(this.txtMatkhau_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(150, 229);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(245, 23);
            this.txtTaiKhoan.TabIndex = 38;
            this.txtTaiKhoan.Click += new System.EventHandler(this.txtTaiKhoan_Click);
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.txtTaiKhoan_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 409);
            this.panel1.TabIndex = 37;
            // 
            // Hienmatkhau
            // 
            this.Hienmatkhau.BackColor = System.Drawing.Color.Transparent;
            this.Hienmatkhau.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.hien;
            this.Hienmatkhau.Location = new System.Drawing.Point(361, 293);
            this.Hienmatkhau.Name = "Hienmatkhau";
            this.Hienmatkhau.Size = new System.Drawing.Size(32, 20);
            this.Hienmatkhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hienmatkhau.TabIndex = 47;
            this.Hienmatkhau.TabStop = false;
            this.Hienmatkhau.Click += new System.EventHandler(this.Hienmatkhau_Click);
            // 
            // Anmatkhau
            // 
            this.Anmatkhau.BackColor = System.Drawing.Color.Transparent;
            this.Anmatkhau.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.an;
            this.Anmatkhau.Location = new System.Drawing.Point(361, 293);
            this.Anmatkhau.Name = "Anmatkhau";
            this.Anmatkhau.Size = new System.Drawing.Size(32, 20);
            this.Anmatkhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Anmatkhau.TabIndex = 48;
            this.Anmatkhau.TabStop = false;
            this.Anmatkhau.Click += new System.EventHandler(this.Anmatkhau_Click);
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.Color.White;
            this.btThoat.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.if_quit_37278;
            this.btThoat.Location = new System.Drawing.Point(465, 0);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(42, 34);
            this.btThoat.TabIndex = 46;
            this.btThoat.UseVisualStyleBackColor = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.Forgot_Password_48px;
            this.pictureBox3.Location = new System.Drawing.Point(120, 286);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.Businessman_52px;
            this.pictureBox2.Location = new System.Drawing.Point(120, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // avartaryetibox
            // 
            this.avartaryetibox.BackColor = System.Drawing.Color.RosyBrown;
            this.avartaryetibox.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.debut;
            this.avartaryetibox.Location = new System.Drawing.Point(198, 39);
            this.avartaryetibox.Name = "avartaryetibox";
            this.avartaryetibox.Size = new System.Drawing.Size(140, 140);
            this.avartaryetibox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avartaryetibox.TabIndex = 42;
            this.avartaryetibox.TabStop = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 409);
            this.Controls.Add(this.cbghinho);
            this.Controls.Add(this.btDangNhap);
            this.Controls.Add(this.Hienmatkhau);
            this.Controls.Add(this.Anmatkhau);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.avartaryetibox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Hienmatkhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Anmatkhau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avartaryetibox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbghinho;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.PictureBox Hienmatkhau;
        private System.Windows.Forms.PictureBox Anmatkhau;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox avartaryetibox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Panel panel1;
    }
}