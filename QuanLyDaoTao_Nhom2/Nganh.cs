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
    public partial class Nganh : Form
    {
        QLDTEntities db = new QLDTEntities();
        string username;
        public Nganh(String nametk)
        {
            username = nametk;
            InitializeComponent();
            LoadData();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        void LoadData()
        {
            using (var context = new QLDTEntities())
            {
                var result = (from c in context.QLNganhs
                              select new
                              {
                                  Manganh = c.MaNganh,
                                  Tennganh = c.TenNganh,
                                  Masv = c.MaSV,
                                  MaCn = c.MaCN,
                                  Malop = c.MaLop,
                              }).ToList();
                dvThongTin.DataSource = result;
                cmbChuyenNganh.DataSource = context.QLChuyenNganhs.Select(cn => cn.MaCN).ToList();
                cmbMaLop.DataSource = context.QLLops.Select(l => l.MaLop).ToList();
                cmbMaSV.DataSource = context.QLSinhViens.Select(sv => sv.MaSV).ToList();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNganh.Text = "";
            txtTenNganh.Text = "";
            cmbChuyenNganh.SelectedIndex = 0;
            cmbMaLop.SelectedIndex = 0;
            cmbMaSV.SelectedIndex = 0;
            txtTimKiem.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            txtMaNganh.Enabled = true;
            LoadData();
        }

        private void dvThongTin_DoubleClick(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            txtMaNganh.Enabled = false;

            if (dvThongTin.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dvThongTin.SelectedRows[0];

                txtMaNganh.Text = row.Cells["MaNganh"].Value.ToString();
                txtTenNganh.Text = row.Cells["TenNganh"].Value.ToString();
                cmbMaSV.Text = row.Cells["MaSV"].Value.ToString();
                cmbChuyenNganh.Text = row.Cells["MaCN"].Value.ToString();
                cmbMaLop.Text = row.Cells["MaLop"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            if (!string.IsNullOrEmpty(txtMaNganh.Text) &&
                !string.IsNullOrEmpty(txtTenNganh.Text) &&
                !string.IsNullOrEmpty(cmbChuyenNganh.Text) &&
                !string.IsNullOrEmpty(cmbMaLop.Text) &&
                !string.IsNullOrEmpty(cmbMaSV.Text))
            {
                try
                {
                    using (var context = new QLDTEntities())
                    {

                        QLNganh nganh = new QLNganh()
                        {
                            MaNganh = txtMaNganh.Text,
                            TenNganh = txtTenNganh.Text,
                            MaSV = cmbMaSV.SelectedItem.ToString(),
                            MaCN = cmbChuyenNganh.SelectedItem.ToString(),
                            MaLop = cmbMaLop.SelectedItem.ToString(),
                        };

                        context.QLNganhs.Add(nganh);
                        context.SaveChanges();

                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Trùng Mã Ngành");
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            if (!string.IsNullOrEmpty(txtMaNganh.Text) &&
                !string.IsNullOrEmpty(txtTenNganh.Text) &&
                !string.IsNullOrEmpty(cmbChuyenNganh.Text) &&
                !string.IsNullOrEmpty(cmbMaLop.Text) &&
                !string.IsNullOrEmpty(cmbMaSV.Text))
            {
                try
                {
                    using (var context = new QLDTEntities())
                    {
                        string selectedMaNganh = dvThongTin.CurrentRow.Cells["MaNganh"].Value.ToString();
                        QLNganh nganh = context.QLNganhs.Where(n => n.MaNganh == selectedMaNganh).FirstOrDefault();


                        if (nganh != null)
                        {
                            nganh.TenNganh = txtTenNganh.Text;
                            nganh.MaSV = cmbMaSV.SelectedItem.ToString();
                            nganh.MaCN = cmbChuyenNganh.SelectedItem.ToString();
                            nganh.MaLop = cmbMaLop.SelectedItem.ToString();

                            context.SaveChanges();
                            MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                            LoadData();
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string MaNganh = txtMaNganh.Text;
                QLNganh gv = db.QLNganhs.FirstOrDefault(s => s.MaNganh == MaNganh);

                if (gv != null)
                {
                    db.QLNganhs.Remove(gv);
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timKiem = txtTimKiem.Text.Trim();

            using (var context = new QLDTEntities())
            {
                if (string.IsNullOrWhiteSpace(timKiem))
                {
                    MessageBox.Show("Vui lòng nhập Mã Ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var nganh = context.QLNganhs.FirstOrDefault(gv => gv.MaNganh == timKiem);

                if (nganh != null)
                {
                    dvThongTin.DataSource = new List<QLNganh> { nganh };
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin Mã Ngành này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dvThongTin.DataSource = null;
                }
            }
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

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu form = new TrangChu(username);
            form.ShowDialog();
            this.Close();
        }
    }
}
