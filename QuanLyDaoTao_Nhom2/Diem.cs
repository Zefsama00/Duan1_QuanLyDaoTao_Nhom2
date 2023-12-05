﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaoTao_Nhom2
{
    public partial class Diem : Form
    {
        QLDTEntities db = new QLDTEntities();
        QLDiem qld = new QLDiem();
        string str = @"Data Source=ZEF\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True;Encrypt=False";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader DuLieu;
        string username;
        public Diem(String nametk)
        {
            username = nametk;
            InitializeComponent();
           
        }

        void LoadData()
        {

            var sql = (from c in db.QLDiems
                       select new
                       {
                           ID = c.MaDiem,
                           MaSV = c.MaSV,
                           MaMonHoc = c.MaMonHoc,
                           DiemLAB = c.DiemLab,
                           DiemThi = c.DiemThi,
                           DiemTongKet = (c.DiemLab + c.DiemThi * 2) / 3,
                       });
            dvThongTin.DataSource = sql.ToList();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        string lenhsv;
        string lenhmh;

        void LoadMaSV()
        {
            cbbMaSV.Items.Clear();
            KetNoi = new SqlConnection(str);
            lenhsv = @"SELECT MaSV From QLSinhVien";
            KetNoi.Open();
            ThucHien = new SqlCommand(lenhsv, KetNoi);
            DuLieu = ThucHien.ExecuteReader();
            while (DuLieu.Read())
            {
                cbbMaSV.Items.Add(DuLieu[0].ToString());


            }
            KetNoi.Close();

        }

        void LoadMaMonhoc()
        {

            KetNoi = new SqlConnection(str);
            lenhmh = @"SELECT MaMonHoc From QLMonHoc";
            KetNoi.Open();
            ThucHien = new SqlCommand(lenhmh, KetNoi);
            DuLieu = ThucHien.ExecuteReader();
            while (DuLieu.Read())
            {
                cbbMamon.Items.Add(DuLieu[0].ToString());
            }

            KetNoi.Close();
        }

        private void TinhDiemTB()
        {
            if (!string.IsNullOrWhiteSpace(txtDiemLAB.Text) &&
                !string.IsNullOrWhiteSpace(txtDiemThi.Text))
            {
                double lab = double.Parse(txtDiemLAB.Text);
                double thi = double.Parse(txtDiemThi.Text);
                double diemTB = (lab + thi * 2) / 3;
                lblDiemTongKet.Text = diemTB.ToString("F2");
            }
            else
            {
                lblDiemTongKet.Text = "0.0";
            }
        }

        void SaveData()
        {
            var queryTimBenSV = db.QLDiems.Where(x => x.MaDiem.ToLower() == txtMaDiem.Text.ToLower()).FirstOrDefault();
            if (queryTimBenSV != null)
            {
                qld.MaDiem = txtMaDiem.Text;
                qld.MaSV = cbbMaSV.Text;
                qld.MaMonHoc = cbbMamon.Text;
                qld.DiemLab = double.Parse(txtDiemLAB.Text);
                qld.DiemThi = double.Parse(txtDiemThi.Text);
                qld.DiemTongKet = (((double.Parse(txtDiemLAB.Text) + double.Parse(txtDiemThi.Text)) * 2)/3);
                db.QLDiems.Add(qld);
                int result = db.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("Đã lưu thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Đã lưu thất bại");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã SV khớp với mã SV đã nhập!!!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int lengthLab = Convert.ToInt32(txtDiemLAB.TextLength);
                int lengthThi = Convert.ToInt32(txtDiemThi.TextLength);
                if (db.QLDiems.Any(diem => diem.MaDiem == txtMaDiem.Text))
                {
                    MessageBox.Show("ID đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (txtMaDiem.Text == "")
                {
                    MessageBox.Show("ID không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (cbbMaSV.Text == "")
                {
                    MessageBox.Show("Mã sinh không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (cbbMamon.Text == "")
                {
                    MessageBox.Show("Mã môn học không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (txtDiemLAB.Text == "")
                {
                    MessageBox.Show("Điểm LAB không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (Convert.ToInt32(txtDiemLAB.Text) <= 0 || Convert.ToInt32(txtDiemLAB.Text) >= 10)
                {
                    MessageBox.Show("Điểm LAB phải nằm trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (txtDiemThi.Text == "")
                {
                    MessageBox.Show("Điểm thi không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (Convert.ToInt32(txtDiemThi.Text) <= 0 || Convert.ToInt32(txtDiemThi.Text) >= 10)
                {
                    MessageBox.Show("Điểm thi phải nằm trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }




                db.QLDiems.Add(new QLDiem()
                {

                    MaDiem = txtMaDiem.Text,
                    MaSV = cbbMaSV.Text,
                    MaMonHoc = cbbMamon.Text,
                    DiemLab = double.Parse(txtDiemLAB.Text),
                    DiemThi = double.Parse(txtDiemThi.Text),
                    DiemTongKet = (((double.Parse(txtDiemLAB.Text) + double.Parse(txtDiemThi.Text) * 2) ) / 3),
                });

                db.SaveChanges();
                MessageBox.Show("Điểm đã được thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm điểm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMaDiem.Text == "")
                {
                    MessageBox.Show("ID không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (cbbMaSV.Text == "")
                {
                    MessageBox.Show("Mã sinh không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (cbbMamon.Text == "")
                {
                    MessageBox.Show("Mã môn học không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (txtDiemLAB.Text == "")
                {
                    MessageBox.Show("Điểm LAB không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (txtDiemThi.Text == "")
                {
                    MessageBox.Show("Điểm thi không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (lblDiemTongKet.Text == "")
                {
                    MessageBox.Show("Điểm tổng kết không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (Convert.ToInt32(txtDiemLAB.Text) <= 0 || Convert.ToInt32(txtDiemLAB.Text) >= 10)
                {
                    MessageBox.Show("Điểm LAB phải nằm trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var sua = (dvThongTin.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                QLDiem sv = db.QLDiems.Find(sua);
                sv.MaDiem = txtMaDiem.Text;
                sv.MaSV = cbbMaSV.Text;
                sv.MaMonHoc = cbbMamon.Text;
                sv.DiemLab = double.Parse(txtDiemLAB.Text);
                sv.DiemThi = double.Parse(txtDiemThi.Text);
                sv.DiemTongKet = (((double.Parse(txtDiemLAB.Text) + double.Parse(txtDiemThi.Text) * 2) ) / 3);
                db.SaveChanges();
                MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi sửa điểm", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var id = txtMaDiem.Text;
            QLDiem dd = db.QLDiems.Where(p => p.MaDiem == id && p.MaSV == cbbMaSV.Text).FirstOrDefault();
            db.QLDiems.Remove(dd);
            db.SaveChanges();
            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDiem.Text = "";
            cbbMaSV.Text = "";
            cbbMamon.Text = "";
            txtDiemLAB.Text = "";
            txtDiemThi.Text = "";
            lblDiemTongKet.Text = "0.0";
            txtMaDiem.Enabled = true;
            cbbMaSV.Enabled = true;
            LoadData();
        }

        private void txtDiemThi_TextChanged(object sender, EventArgs e)
        {
            TinhDiemTB();
        }

        private void dvThongTin_DoubleClick(object sender, EventArgs e)
        {
            QLUser sv = db.QLUsers.FirstOrDefault(x => x.TaiKhoan.Contains(username));
            if (sv.VaiTro == "ADMIN")
            {
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            int lst = dvThongTin.CurrentRow.Index;
            btnThem.Enabled = true;
            txtMaDiem.Enabled = false;
            cbbMaSV.Enabled = false;
            txtMaDiem.Text = dvThongTin.Rows[lst].Cells[0].Value.ToString();
            cbbMaSV.Text = dvThongTin.Rows[lst].Cells[1].Value.ToString();
            cbbMamon.Text = dvThongTin.Rows[lst].Cells[2].Value.ToString();
            txtDiemLAB.Text = dvThongTin.Rows[lst].Cells[3].Value.ToString();
            txtDiemThi.Text = dvThongTin.Rows[lst].Cells[4].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string key = txtTimKiem.Text.Trim().ToLower();
            dvThongTin.DataSource = db.QLSinhViens.Where(x => x.HoTenSV.ToLower().Contains(key)).ToList();
        }

        private void Diem_Load(object sender, EventArgs e)
        {
            QLUser sv = db.QLUsers.FirstOrDefault(x => x.TaiKhoan.Contains(username));
            if (sv.VaiTro == "ADMIN")
            {
                menuStrip1.Visible = true; menuStrip2.Visible = false;
            }
            else
            {
                menuStrip1.Visible = false; menuStrip2.Visible = true;
                btnSua.Visible = false;
                btnXoa.Visible = false;
            }
            LoadData();
            LoadMaSV();
            LoadMaMonhoc();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            QLUser sv = db.QLUsers.FirstOrDefault(x => x.TaiKhoan.Contains(username));
            if (sv.VaiTro == "ADMIN")
            {
                this.Hide();
                TrangChu form = new TrangChu(username);
                form.ShowDialog();
                this.Close();
            }
            else
            {
                this.Hide();
                GiangVien form = new GiangVien(username);
                form.ShowDialog();
                this.Close();
            }
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Diem formLuuDiem = new Diem(username);
            formLuuDiem.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LichDay form2 = new LichDay(username);
            form2.ShowDialog();
            this.Close();
        }
    }
}
