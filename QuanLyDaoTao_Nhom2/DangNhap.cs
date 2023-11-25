using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaoTao_Nhom2
{
    public partial class DangNhap : Form
    {
        List<Image> images = new List<Image>();
        string[] location = new string[25];
        public DangNhap()
        {
            InitializeComponent();
            location[0] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_1.jpg";
            location[1] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_2.jpg";
            location[2] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_4.jpg";
            location[3] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_5.jpg";
            location[4] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_6.jpg";
            location[5] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_7.jpg";
            location[6] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_8.jpg";
            location[7] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_9.jpg";
            location[8] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_10.jpg";
            location[9] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_11.jpg";
            location[10] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_12.jpg";
            location[11] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_13.jpg";
            location[12] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_14.jpg";
            location[13] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_15.jpg";
            location[14] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_16.jpg";
            location[15] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_17.jpg";
            location[16] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_18.jpg";
            location[17] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_19.jpg";
            location[18] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_20.jpg";
            location[19] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_21.jpg";
            location[20] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_22.jpg";
            location[21] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_23.jpg";
            location[22] = @"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_user_24.jpg";
            tounage();
        }
        private void tounage()
        {
            for (int i = 0; i < 23; i++)
            {
                Bitmap bitmap = new Bitmap(location[i]);
                images.Add(bitmap);
            }
            images.Add(Properties.Resources.textbox_user_24);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Length > 0 && txtTaiKhoan.Text.Length <= 15)
            {
                avartaryetibox.Image = images[txtTaiKhoan.Text.Length - 1];
                avartaryetibox.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else if (txtTaiKhoan.Text.Length <= 0)
            {
                avartaryetibox.Image = Properties.Resources.debut;
            }
            else
            {
                avartaryetibox.Image = images[22];
            }
        }

        private void txtMatkhau_Click(object sender, EventArgs e)
        {
            Bitmap bmpass = new Bitmap(@"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_password.png");
            avartaryetibox.Image = bmpass;
        }

        private void txtTaiKhoan_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text.Length > 0)
            {
                avartaryetibox.Image = images[txtTaiKhoan.Text.Length - 1];
            }
            else
            {
                avartaryetibox.Image = Properties.Resources.debut;
            }
        }

        private void Hienmatkhau_Click(object sender, EventArgs e)
        {
            Bitmap bmpass = new Bitmap(@"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_passwordshow.png");
            avartaryetibox.Image = bmpass;
            txtMatkhau.PasswordChar = (char)0;
            Hienmatkhau.Visible = false;
            Anmatkhau.Visible = true;
        }

        private void Anmatkhau_Click(object sender, EventArgs e)
        {
            Bitmap bmpass = new Bitmap(@"D:\duan1\QuanLyDaoTao_Nhom2\QuanLyDaoTao_Nhom2\animation\textbox_password.png");
            avartaryetibox.Image = bmpass;
            txtMatkhau.PasswordChar = '*';
            Anmatkhau.Visible = false;
            Hienmatkhau.Visible = true;
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.Username))
            {
                txtTaiKhoan.Text = Properties.Settings.Default.Username;
                txtMatkhau.Text = Properties.Settings.Default.Password;
                cbghinho.Checked = true;
            }
            txtMatkhau.PasswordChar = '*';
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTaiKhoan.Text)
              || String.IsNullOrWhiteSpace(txtTaiKhoan.Text)
              || String.IsNullOrEmpty(txtMatkhau.Text)
              || String.IsNullOrWhiteSpace(txtMatkhau.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đủ tài khoản và mật khẩu",
                    "Lỗi nhập liệu",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            else
            {
                String role = XuLyCode.Login(txtTaiKhoan.Text, txtMatkhau.Text);
                if (!String.IsNullOrEmpty(role))
                {
                    if (cbghinho.Checked)
                    {
                        Properties.Settings.Default.Username = txtTaiKhoan.Text;
                        Properties.Settings.Default.Password = txtMatkhau.Text;
                    }
                    if (role.Equals("ADMIN"))
                    {
                        this.Hide();
                        TrangChu form = new TrangChu(txtTaiKhoan.Text);
                        form.ShowDialog();
                        this.Close();
                    }
                    else if (role.Equals("GIANGVIEN"))
                    {
                        this.Hide();
                        GiangVien form = new GiangVien(txtTaiKhoan.Text);
                        form.ShowDialog();
                        this.Close();
                    }
                    else if (role.Equals("SINHVIEN"))
                    {
                        this.Hide();
                        SinhVien form = new SinhVien(txtTaiKhoan.Text);
                        form.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Tài khoản chưa được cấp quyền",
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Tài khoản hoặc mật khẩu chưa đúng",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
    }
}
