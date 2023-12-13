namespace QuanLyDaoTao_Nhom2
{
    partial class DoiMatKhau
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
            this.panelDMK = new System.Windows.Forms.Panel();
            this.cbHienMatKhau = new System.Windows.Forms.CheckBox();
            this.pcThoat = new System.Windows.Forms.PictureBox();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.txtXacNhanMK = new System.Windows.Forms.TextBox();
            this.txtmkMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDMK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcThoat)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDMK
            // 
            this.panelDMK.BackColor = System.Drawing.Color.DarkGray;
            this.panelDMK.Controls.Add(this.cbHienMatKhau);
            this.panelDMK.Controls.Add(this.pcThoat);
            this.panelDMK.Controls.Add(this.btXacNhan);
            this.panelDMK.Controls.Add(this.txtXacNhanMK);
            this.panelDMK.Controls.Add(this.txtmkMoi);
            this.panelDMK.Controls.Add(this.label4);
            this.panelDMK.Controls.Add(this.label3);
            this.panelDMK.Controls.Add(this.label1);
            this.panelDMK.Location = new System.Drawing.Point(135, 37);
            this.panelDMK.Name = "panelDMK";
            this.panelDMK.Size = new System.Drawing.Size(549, 388);
            this.panelDMK.TabIndex = 0;
            // 
            // cbHienMatKhau
            // 
            this.cbHienMatKhau.AutoSize = true;
            this.cbHienMatKhau.Location = new System.Drawing.Point(358, 253);
            this.cbHienMatKhau.Name = "cbHienMatKhau";
            this.cbHienMatKhau.Size = new System.Drawing.Size(95, 17);
            this.cbHienMatKhau.TabIndex = 8;
            this.cbHienMatKhau.Text = "Hiện mật khẩu";
            this.cbHienMatKhau.UseVisualStyleBackColor = true;
            this.cbHienMatKhau.CheckedChanged += new System.EventHandler(this.cbHienMatKhau_CheckedChanged);
            // 
            // pcThoat
            // 
            this.pcThoat.Image = global::QuanLyDaoTao_Nhom2.Properties.Resources.Exit;
            this.pcThoat.Location = new System.Drawing.Point(504, 3);
            this.pcThoat.Name = "pcThoat";
            this.pcThoat.Size = new System.Drawing.Size(42, 44);
            this.pcThoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcThoat.TabIndex = 7;
            this.pcThoat.TabStop = false;
            this.pcThoat.Click += new System.EventHandler(this.pcThoat_Click);
            // 
            // btXacNhan
            // 
            this.btXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXacNhan.Location = new System.Drawing.Point(178, 287);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(224, 60);
            this.btXacNhan.TabIndex = 6;
            this.btXacNhan.Text = "Xác Nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btXacNhan_Click);
            // 
            // txtXacNhanMK
            // 
            this.txtXacNhanMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacNhanMK.Location = new System.Drawing.Point(211, 210);
            this.txtXacNhanMK.Name = "txtXacNhanMK";
            this.txtXacNhanMK.Size = new System.Drawing.Size(242, 26);
            this.txtXacNhanMK.TabIndex = 5;
            // 
            // txtmkMoi
            // 
            this.txtmkMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkMoi.Location = new System.Drawing.Point(211, 134);
            this.txtmkMoi.Name = "txtmkMoi";
            this.txtmkMoi.Size = new System.Drawing.Size(242, 26);
            this.txtmkMoi.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Xác Nhận Mật Khẩu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu Mới :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDMK);
            this.Name = "DoiMatKhau";
            this.Text = "DoiMatKhau";
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            this.panelDMK.ResumeLayout(false);
            this.panelDMK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcThoat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDMK;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.TextBox txtXacNhanMK;
        private System.Windows.Forms.TextBox txtmkMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcThoat;
        private System.Windows.Forms.CheckBox cbHienMatKhau;
    }
}