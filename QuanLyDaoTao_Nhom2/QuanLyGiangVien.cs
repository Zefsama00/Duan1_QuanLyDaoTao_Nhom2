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
    public partial class QuanLyGiangVien : Form
    {
        QLDTEntities db = new QLDTEntities();
        string[] tk;
        string mkran, username;
        public QuanLyGiangVien(String nametk)
        {
            username = nametk;
            InitializeComponent();
            LoadData();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        void LoadData()
        {
            var result = (from c in db.QLGiangViens
                          select new
                          {
                              MaGv = c.MaGV,
                              HoTen = c.HoTenGV,
                              GioiTinh = c.GioiTinhGV,
                              NgaySinh = c.NgaySinhGV,
                              DiaChi = c.DiaChiGV,
                              SoDT = c.SoDienThoaiGV,
                              Email = c.EmailGV
                          }).ToList();

            dvThongTin.DataSource = result;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaGiangvien.Text = "";
            txtTenGiangvien.Text = "";
            dtNgaySinh.Text = "";
            txtEmail.Text = "";
            txtSoDienThoai.Text = "";
            txtDiaChi.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaGiangvien.Enabled = true;
            btnThem.Enabled = true;
            txtTimKiem.Text = "";
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            if (!string.IsNullOrEmpty(txtMaGiangvien.Text) &&
               !string.IsNullOrEmpty(txtTenGiangvien.Text) &&
               !string.IsNullOrEmpty(txtSoDienThoai.Text) &&
               !string.IsNullOrEmpty(txtEmail.Text) &&
               !string.IsNullOrEmpty(txtDiaChi.Text))
            {
                if (IsEmailValid() && IsPhoneNumberValid() && IsNgaySinhValid())
                {

                    try
                    {

                        QLGiangVien gv = new QLGiangVien()
                        {
                            MaGV = txtMaGiangvien.Text,
                            HoTenGV = txtTenGiangvien.Text,
                            GioiTinhGV = radNam.Checked ? "Nam" : "Nu",
                            NgaySinhGV = dtNgaySinh.Value,
                            DiaChiGV = txtDiaChi.Text,
                            EmailGV = txtEmail.Text,
                            SoDienThoaiGV = txtSoDienThoai.Text
                        };
                        using (var context = new QLDTEntities())
                        {
                            context.QLGiangViens.Add(gv);
                            context.SaveChanges();
                            Random mkrandom = new Random();
                            mkran = mkrandom.Next(1000, 9999).ToString();
                            tk = txtEmail.Text.Split('@');
                            string tkmoi = tk[0];
                            QLUser useradd = new QLUser();
                            useradd.TaiKhoan = tkmoi;
                            useradd.MatKhau = XuLyCode.Encrypt(mkran);
                            useradd.VaiTro = "GIANGVIEN";
                            db.QLUsers.Add(useradd);
                            db.SaveChanges();
                            MessageBox.Show("Mật khẩu của giảng viên là :" + mkran);
                        }

                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                        LoadData();
                    }

                    catch (Exception ex) { MessageBox.Show("Trùng Mã Giảng Viên"); }

                }
                else
                {
                    MessageBox.Show("Vui lòng kiểm tra lại định dạng Email và độ dài của Số điện thoại và ngày sinh không hợp lý", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private bool IsEmailValid()
        {
            string email = txtEmail.Text;
            return email.Contains("@") && email.EndsWith("@gmail.com");
        }
        private bool IsPhoneNumberValid()
        {
            return txtSoDienThoai.Text.Length == 10;
        }
        private bool IsNgaySinhValid()
        {
            return dtNgaySinh.Value <= DateTime.Today;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaGiangvien.Text) ||
              string.IsNullOrEmpty(txtTenGiangvien.Text) ||
              string.IsNullOrEmpty(txtSoDienThoai.Text) ||
              string.IsNullOrEmpty(txtEmail.Text) ||
              string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsEmailValid() && IsPhoneNumberValid() && IsNgaySinhValid())
            {

                QLGiangVien gv = new QLGiangVien()
                {
                    MaGV = txtMaGiangvien.Text,
                    HoTenGV = txtTenGiangvien.Text,
                    GioiTinhGV = radNam.Checked ? "Nam" : "Nữ",
                    NgaySinhGV = dtNgaySinh.Value,
                    DiaChiGV = txtDiaChi.Text,
                    EmailGV = txtEmail.Text,
                    SoDienThoaiGV = txtSoDienThoai.Text
                };

                using (var context = new QLDTEntities())
                {
                    var existingGv = context.QLGiangViens.FirstOrDefault(g => g.MaGV == gv.MaGV);
                    if (existingGv != null)
                    {
                        existingGv.HoTenGV = gv.HoTenGV;
                        existingGv.GioiTinhGV = gv.GioiTinhGV;
                        existingGv.NgaySinhGV = gv.NgaySinhGV;
                        existingGv.DiaChiGV = gv.DiaChiGV;
                        existingGv.EmailGV = gv.EmailGV;
                        existingGv.SoDienThoaiGV = gv.SoDienThoaiGV;
                    }
                    else
                    {
                        context.QLGiangViens.Add(gv);
                    }

                    context.SaveChanges();
                }
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại định dạng Email và độ dài của Số điện thoại và ngày sinh không hợp ly", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string MaGV = txtMaGiangvien.Text;
                QLGiangVien gv = db.QLGiangViens.FirstOrDefault(s => s.MaGV == MaGV);

                if (gv != null)
                {
                    db.QLGiangViens.Remove(gv);
                    int ketQua = db.SaveChanges();
                    if (ketQua > 0)
                    {
                        MessageBox.Show("Xóa thành công", "OK", MessageBoxButtons.OK);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại", "OK", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy Giảng viên để xóa", "OK", MessageBoxButtons.OK);
                }
            }
        }

        private void dvThongTin_DoubleClick(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            txtMaGiangvien.Enabled = false;

            if (dvThongTin.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dvThongTin.SelectedRows[0];

                txtMaGiangvien.Text = row.Cells["MaGV"].Value.ToString();
                txtTenGiangvien.Text = row.Cells["HoTen"].Value.ToString();

                string gioitinh = row.Cells["GioiTinh"].Value.ToString();
                // Xử lý giới tính theo giá trị 'gioitinh'

                if (DateTime.TryParse(row.Cells["NgaySinh"].Value.ToString(), out DateTime ngaySinhDateTime))
                {
                    dtNgaySinh.Value = ngaySinhDateTime;
                }
                else
                {
                    MessageBox.Show("Ngày sinh không được lớn hơn ngày hôm nay");
                }
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtSoDienThoai.Text = row.Cells["SoDT"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();

            using (var context = new QLDTEntities())
            {
                if (string.IsNullOrWhiteSpace(timKiem))
                {
                    MessageBox.Show("Vui lòng nhập Mã Giảng Viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var giangVien = context.QLGiangViens.FirstOrDefault(gv => gv.MaGV == timKiem);

                if (giangVien != null)
                {
                    dvThongTin.DataSource = new List<QLGiangVien> { giangVien };
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin Mã Giảng Viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dvThongTin.DataSource = null;
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu form = new TrangChu(username);
            form.ShowDialog();
            this.Close();
        }

        private void lớpMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyLopMon form2 = new QuanLyLopMon(username);
            form2.ShowDialog();
            this.Close();
        }

        private void chuyênNgànhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChuyenNganh form2 = new ChuyenNganh(username);
            form2.ShowDialog();
            this.Close();
        }

        private void ngànhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nganh form2 = new Nganh(username);
            form2.ShowDialog();
            this.Close();
        }

        private void lịchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyLich form2 = new QuanLyLich(username);
            form2.ShowDialog();
            this.Close();
        }

        private void họcKỳToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyHocKy form2 = new QuanLyHocKy(username);
            form2.ShowDialog();
            this.Close();
        }

        private void mônHọcToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonHoc form2 = new MonHoc(username);
            form2.ShowDialog();
            this.Close();
        }

        private void lớpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyLop form2 = new QuanLyLop(username);
            form2.ShowDialog();
            this.Close();
        }

        private void điểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diem form2 = new Diem(username);
            form2.ShowDialog();
            this.Close();
        }

        private void giảngViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyGiangVien form2 = new QuanLyGiangVien(username);
            form2.ShowDialog();
            this.Close();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLySinhVien form2 = new QuanLySinhVien(username);
            form2.ShowDialog();
            this.Close();
        }
    }
}
