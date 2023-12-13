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
    public partial class DoiMatKhau : Form
    {
        List<QLUser> dsuser;
        QLDTEntities db = new QLDTEntities();
        string username = "";
        public DoiMatKhau(String taiKhoan)
        {
            InitializeComponent();
            username = taiKhoan;
            dsuser = XuLyCode.GetLishUser();
        }

        private void pcThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            if(txtmkMoi.Text != txtXacNhanMK.Text)
            {
                MessageBox.Show("Mật Khẩu mới và xác nhận mật khẩu không trùng khớp ! Vui lòng thử lại!");
            }
            else
            {
                QLUser sv = db.QLUsers.FirstOrDefault(x=>x.TaiKhoan.Contains(username));
                sv.MatKhau = XuLyCode.Encrypt(txtmkMoi.Text);
                db.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            txtmkMoi.PasswordChar = '*';
            txtXacNhanMK.PasswordChar = '*';
        }

        private void cbHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMatKhau.Checked)
            {
                txtmkMoi.PasswordChar = (char)0;
                txtXacNhanMK.PasswordChar = (char)0;
            }
            else
            {
                txtmkMoi.PasswordChar = '*';
                txtXacNhanMK.PasswordChar = '*';
            }
        }
    }
}
