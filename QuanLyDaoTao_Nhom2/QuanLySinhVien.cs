using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaoTao_Nhom2
{
    public partial class QuanLySinhVien : Form
    {
        string filePath;
        QLDTEntities db = new QLDTEntities();
        List<QLUser> dsuser;
        string[] tk;
        string mkran, username;
        public QuanLySinhVien(String nametk)
        {
            username = nametk;
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            var sql = from c in db.QLSinhViens.ToList()
                      select new
                      {
                          MaSV = c.MaSV,
                          HoTenSV = c.HoTenSV,
                          GioiTinhSV = c.GioiTinhSV,
                          NgaySinhSV = c.NgaySinhSV,
                          DiaChiSV = c.DiaChiSV,
                          SoDienThoaiSV = c.SoDienThoaiSV,
                          EmailSV = c.EmailSV,
                      };
            dvThongTin.DataSource = sql.ToList();
        }
        void SaveData()
        {
            Random mkrandom = new Random();
            mkran = mkrandom.Next(1000, 9999).ToString();
            QLSinhVien qlsv = new QLSinhVien();
            qlsv.MaSV = txtMaSV.Text;
            qlsv.HoTenSV = txtTenSV.Text;
            qlsv.SoDienThoaiSV = txtSoDienThoai.Text;
            qlsv.NgaySinhSV = DateTime.Parse(dtNgaySinh.Text);
            qlsv.EmailSV = txtEmail.Text;
            qlsv.DiaChiSV = txtDiaChi.Text;
            if (radNam.Checked == true)
            {
                qlsv.GioiTinhSV = radNam.Text;
            }
            else
            {
                qlsv.GioiTinhSV = radNu.Text;
            }
            db.QLSinhViens.Add(qlsv);
            int result = db.SaveChanges();
            if (result > 0)
            {
                tk = txtEmail.Text.Split('@');
                string tkmoi= tk[0];
                QLUser useradd = new QLUser();
                useradd.TaiKhoan = tkmoi;
                useradd.MatKhau = XuLyCode.Encrypt(mkran);
                useradd.VaiTro = "SINHVIEN";
                db.QLUsers.Add(useradd);
                db.SaveChanges();
                MessageBox.Show("Thêm Thành công");
                MessageBox.Show("Mật khẩu của sinh viên là :" + mkran);
            }
            else
            {
                MessageBox.Show("Thêm Thất bại");
            }
        }
        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {
            dsuser = XuLyCode.GetLishUser();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var CheckID_MaSV = db.QLSinhViens.Where(x => x.MaSV == txtMaSV.Text || x.MaSV == txtMaSV.Text).ToList().FirstOrDefault();
            var CheckSDT_Email = db.QLSinhViens.Where(x => x.SoDienThoaiSV == txtSoDienThoai.Text || x.EmailSV == txtEmail.Text).ToList().FirstOrDefault();
            string emailAddress = txtEmail.Text;
            int lengthSDT = Convert.ToInt32(txtSoDienThoai.TextLength);
            if (string.IsNullOrWhiteSpace(txtMaSV.Text)
                || string.IsNullOrWhiteSpace(txtTenSV.Text)
                || string.IsNullOrWhiteSpace(txtSoDienThoai.Text)
                || string.IsNullOrEmpty(dtNgaySinh.Text)
                || string.IsNullOrWhiteSpace(txtEmail.Text)
                || string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {

                MessageBox.Show("Bạn đang nhập dữ chưa đủ - Vui lòng kiểm tra lại!!!");
            }
            else if (CheckID_MaSV != null)
            {
                MessageBox.Show("Mã sinh viên bị trùng - Vui lòng kiểm tra lại");
            }
            else if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính");
            }
            else if (CheckSDT_Email != null)
            {
                MessageBox.Show("Bạn đã nhập SDT hoặc Email trùng với một sinh viên khác");
            }
            else if (!Regex.IsMatch(emailAddress, @"^[a-zA-Z0-9\.\+_-]+@[a-zA-Z0-9\.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lengthSDT < 10 || lengthSDT > 10)
            {
                MessageBox.Show("Số điện thoại không được ít hoặc hơn 10 số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                SaveData();
                LoadData();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var CheckID_MaSV = db.QLSinhViens.Where(x => x.MaSV == txtMaSV.Text || x.MaSV == txtMaSV.Text).ToList().FirstOrDefault();
            var checkEmail = db.QLSinhViens.Where(x => x.EmailSV == txtEmail.Text && x.MaSV != txtMaSV.Text).FirstOrDefault();
            var CheckSDT = db.QLSinhViens.Where(x => x.SoDienThoaiSV == txtSoDienThoai.Text).ToList().FirstOrDefault();
            string emailAddress = txtEmail.Text;
            int lengthSDT = Convert.ToInt32(txtSoDienThoai.TextLength);
            if (string.IsNullOrWhiteSpace(txtMaSV.Text)
                || string.IsNullOrWhiteSpace(txtTenSV.Text)
                || string.IsNullOrWhiteSpace(txtSoDienThoai.Text)
                || string.IsNullOrEmpty(dtNgaySinh.Text)
                || string.IsNullOrWhiteSpace(txtEmail.Text)
                || string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {

                MessageBox.Show("Bạn đang nhập dữ chưa đủ - Vui lòng kiểm tra lại!!!");
            }

            else if (radNam.Checked == false && radNu.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính");
            }
            else if (checkEmail != null)
            {
                MessageBox.Show("Email  trùng với một sinh viên khác");
                return;
            }
            else if (!Regex.IsMatch(emailAddress, @"^[a-zA-Z0-9\.\+_-]+@[a-zA-Z0-9\.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lengthSDT < 10 || lengthSDT > 10)
            {
                MessageBox.Show("Số điện thoại không được ít hoặc hơn 10 số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Sửa Thành Công!");
                var sua = (dvThongTin.SelectedCells[0].OwningRow.Cells["MaSV"].Value.ToString());
                QLSinhVien sv = db.QLSinhViens.Find(sua);
                sv.HoTenSV = txtTenSV.Text;
                sv.NgaySinhSV = DateTime.Parse(dtNgaySinh.Text);
                sv.DiaChiSV = txtDiaChi.Text;
                sv.GioiTinhSV = (radNam.Checked ? radNam.Text : radNu.Text);
                sv.SoDienThoaiSV = txtSoDienThoai.Text;
                sv.EmailSV = txtEmail.Text;
                db.SaveChanges();
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa Thành Công!");
            var id = txtMaSV.Text;
            QLSinhVien sv = db.QLSinhViens.Where(P => P.MaSV == id && P.HoTenSV == txtTenSV.Text).FirstOrDefault();
            db.QLSinhViens.Remove(sv);
            db.SaveChanges();
            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtEmail.Text = "";
        }

        private void dvThongTin_DoubleClick(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            int lst = dvThongTin.CurrentRow.Index;
            DataGridViewRow selectedRow = dvThongTin.SelectedRows[0];
            txtMaSV.Enabled = false;
            txtMaSV.Text = dvThongTin.Rows[lst].Cells[0].Value.ToString();
            txtTenSV.Text = dvThongTin.Rows[lst].Cells[1].Value.ToString();
            string GioiTinh = dvThongTin.Rows[lst].Cells[2].Value.ToString();
            dtNgaySinh.Text = dvThongTin.Rows[lst].Cells[3].Value.ToString();
            txtDiaChi.Text = dvThongTin.Rows[lst].Cells[4].Value.ToString();
            txtSoDienThoai.Text = dvThongTin.Rows[lst].Cells[5].Value.ToString();
            txtEmail.Text = dvThongTin.Rows[lst].Cells[6].Value.ToString();
            if (GioiTinh == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text.Trim().ToLower();
            dvThongTin.DataSource = db.QLSinhViens.Where(x => x.HoTenSV.ToLower().Contains(key)).ToList();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLySinhVien form2 = new QuanLySinhVien(username);
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

        private void điểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diem form2 = new Diem(username);
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

        private void mônHọcToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonHoc form2 = new MonHoc(username);
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

        private void lịchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyLich form2 = new QuanLyLich(username);
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

        private void chuyênNgànhToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChuyenNganh form2 = new ChuyenNganh(username);
            form2.ShowDialog();
            this.Close();
        }

        private void lớpMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyLopMon form2 = new QuanLyLopMon(username);
            form2.ShowDialog();
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            string inSinhVien = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DSSinhVien.xlsx");
            if (File.Exists(inSinhVien))
            {

                DialogResult overwriteResult = MessageBox.Show($"Chắc chưa ? '{filePath}' muốn in phải không?",
                                                                "File Exists",
                                                                MessageBoxButtons.YesNo);

                if (overwriteResult != DialogResult.Yes)
                {
                    return;
                }
            }
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook workbook = excelApp.Workbooks.Add();
            Worksheet worksheet = workbook.Sheets[1];
            int row = 1;

            for (int i = 0; i < dvThongTin.Columns.Count; i++)
            {
                worksheet.Cells[row, i + 1] = dvThongTin.Columns[i].HeaderText;
            }
            row++;

            for (int i = 0; i < dvThongTin.Rows.Count; i++)
            {
                for (int j = 0; j < dvThongTin.Columns.Count; j++)
                {
                    worksheet.Cells[row, j + 1] = dvThongTin.Rows[i].Cells[j].Value.ToString();
                }
                row++;
            }
            workbook.SaveAs(inSinhVien);
            excelApp.Quit();
            MessageBox.Show("Dữ liệu đã được xuất ra file Excel thành công!");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu form = new TrangChu(username);
            form.ShowDialog();
            this.Close();
        }
    }
}
