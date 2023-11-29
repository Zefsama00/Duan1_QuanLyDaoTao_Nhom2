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
    public partial class QuanLySinhVien : Form
    {
        NHOM2_QUANLY_DAOTAOEntities db = new NHOM2_QUANLY_DAOTAOEntities();
        public QuanLySinhVien()
        {
            InitializeComponent();
            LoadData();
            YoutubeData();
        }

        void LoadData()
        {
            var sql = from c in db.QLSinhViens
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

        void YoutubeData()
        {
            txtMaSV.DataBindings.Add(new Binding("Text", dvThongTin.DataSource, "MaSV"));
            txtTenSV.DataBindings.Add(new Binding("Text", dvThongTin.DataSource, "HoTenSV"));
            txtGioiTinh.DataBindings.Add(new Binding("Text", dvThongTin.DataSource, "GioiTinhSV"));
            dtNgaySinh.DataBindings.Add(new Binding("Text", dvThongTin.DataSource, "NgaySinhSV"));
            txtDiaChi.DataBindings.Add(new Binding("Text", dvThongTin.DataSource, "DiaChiSV"));
            txtSoDienThoai.DataBindings.Add(new Binding("Text", dvThongTin.DataSource, "SoDienThoaiSV"));
            txtEmail.DataBindings.Add(new Binding("Text", dvThongTin.DataSource, "EmailSV"));

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaSV.Text == "")
                {
                    MessageBox.Show("Mã sinh viên sinh viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtTenSV.Text == "")
                {
                    MessageBox.Show("Họ tên sinh viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtGioiTinh.Text == "")
                {
                    MessageBox.Show("Giới tính sinh viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtSoDienThoai.Text == "")
                {
                    MessageBox.Show("Số điện thoại sinh viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtEmail.Text == "")
                {
                    MessageBox.Show("Email sinh viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtDiaChi.Text == "")
                {
                    MessageBox.Show("Địa chỉ sinh viên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                db.QLSinhViens.Add(new QLSinhVien()
                {
                    MaSV = txtMaSV.Text,
                    HoTenSV = txtTenSV.Text,
                    GioiTinhSV = txtGioiTinh.Text,
                    NgaySinhSV = DateTime.Parse(dtNgaySinh.Text),
                    DiaChiSV = txtDiaChi.Text,
                    SoDienThoaiSV = txtSoDienThoai.Text,
                    EmailSV = txtEmail.Text,
                });
                string matkhausv;
                Random rand = new Random();
                matkhausv = rand.Next(1000, 9999).ToString();
                db.QLUsers.Add(new QLUser()
                {
                    TaiKhoan = txtEmail.Text,
                    MatKhau = matkhausv,
                    VaiTro = "SINHVIEN"
                });
                db.SaveChanges();
                MessageBox.Show("Sinh viên đã được thêm thành công.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm sinh viên: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSua_Click(object sender, EventArgs e)
        {
            var sua = (dvThongTin.SelectedCells[0].OwningRow.Cells["MaSV"].Value.ToString());
            QLSinhVien sv = db.QLSinhViens.Find(sua);
            sv.HoTenSV = txtTenSV.Text;
            sv.NgaySinhSV = DateTime.Parse(dtNgaySinh.Text);
            sv.DiaChiSV = txtDiaChi.Text;
            sv.GioiTinhSV = txtGioiTinh.Text;
            sv.SoDienThoaiSV = txtSoDienThoai.Text;
            sv.EmailSV = txtEmail.Text;

            db.SaveChanges();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var id = txtMaSV.Text;
            QLSinhVien sv = db.QLSinhViens.Where(P => P.MaSV == id && P.HoTenSV == txtTenSV.Text).FirstOrDefault();
            db.QLSinhViens.Remove(sv);
            db.SaveChanges();
            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtEmail.Text = "";
        }

        private void QuanLySinhVien_Load(object sender, EventArgs e)
        {

        }
    }
}
