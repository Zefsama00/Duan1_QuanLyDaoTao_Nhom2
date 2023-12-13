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
    public partial class QuanLyHocKy : Form
    {
        string username;
        QLDTEntities db = new QLDTEntities();
        public QuanLyHocKy(String nametk)
        {
            username = nametk;
            InitializeComponent();
            LoadData();
        }

        private void QuanLyHocKy_Load(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            dvThongTin.Rows.Clear();
            var result = from st in db.QLHocKies
                        
                         select new
                         {
                             MaHocKy = st.MaHocKy,
                             TenHocKy = st.TenHocKy,
                             NgayBatDau = st.NgayBatDau,
                             NgayKetThuc = st.NgayKetThuc,

                         };

            result.ToList().ForEach(x => dvThongTin.Rows.Add(x.MaHocKy, x.TenHocKy, x.NgayBatDau, x.NgayKetThuc));
            dvThongTin.Update();
        }
        void ClearFields()
        {
            lblQuanLyHocKy.Hide();
            txtMaHocky.Text = "";
            txtTenHocky.Text = "";
            dtNgayBatDau.Text = "";
            dtNgayKetThuc.Text = "";
            txtTimKiem.Text = "";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtMaHocky.Text) &&
             !string.IsNullOrEmpty(txtTenHocky.Text) &&
              !string.IsNullOrEmpty(dtNgayBatDau.Text) &&
               !string.IsNullOrEmpty(dtNgayKetThuc.Text))


            {
                try
                {
                    QLHocKy st = new QLHocKy()
                    {
                        MaHocKy = txtMaHocky.Text,
                        TenHocKy = txtTenHocky.Text,
                        NgayBatDau = dtNgayBatDau.Value,
                        NgayKetThuc = dtNgayKetThuc.Value,

                    };

                    db.QLHocKies.Add(st);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công", "OK", MessageBoxButtons.OK);
                    LoadData();
                    ClearFields();
                    
                    btnThem.Enabled = false;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thất bại do trùng thông tin", "Lỗi", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Thêm thất bại do có trường bỏ trống", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaHocky.Text) &&
     !string.IsNullOrEmpty(txtTenHocky.Text) &&
     !string.IsNullOrEmpty(dtNgayBatDau.Text) &&
     !string.IsNullOrEmpty(dtNgayKetThuc.Text))
            {
                try
                {
                    using (var context = new QLDTEntities())
                    {
                        string hk = dvThongTin.CurrentRow.Cells["MaHocKy"].Value.ToString();
                        QLHocKy HocKy = context.QLHocKies.Where(n => n.MaHocKy == hk).FirstOrDefault();


                        if (HocKy != null)
                        {
                            HocKy.MaHocKy = txtMaHocky.Text;
                            HocKy.TenHocKy = txtTenHocky.Text;
                            HocKy.NgayBatDau = dtNgayBatDau.Value;
                            HocKy.NgayKetThuc = dtNgayKetThuc.Value;

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
                string MaHocKy = txtMaHocky.Text;
                QLHocKy hk = db.QLHocKies.FirstOrDefault(s => s.MaHocKy == MaHocKy);
                QLLich lH = db.QLLiches.FirstOrDefault(s => s.MaHocKy == MaHocKy);
                QLLopMon lm = db.QLLopMons.FirstOrDefault(s => s.MaHocKy == MaHocKy);

                if (hk != null)
                {
                    if(lH != null)
                    {
                        db.QLLiches.Remove(lH);
                    }
                    db.QLHocKies.Remove(hk);
                    if(lm != null)
                    {
                        db.QLLopMons.Remove(lm);
                    }
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
                    MessageBox.Show("Xóa thất bại", "OK", MessageBoxButtons.OK);

                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHocky.Text = "";
            txtTenHocky.Text = "";
            txtTimKiem.Text = "";
            dtNgayBatDau.Text = "";
            dtNgayKetThuc.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnLamMoi.Enabled = true;
            txtMaHocky.Enabled = true;
            LoadData();
        }

        private void dvThongTin_DoubleClick(object sender, EventArgs e)
        {
            if (dvThongTin.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dvThongTin.SelectedRows[0];
                txtMaHocky.Text = row.Cells["MaHocKy"].Value.ToString();
                txtTenHocky.Text = row.Cells["TenHocKy"].Value.ToString();
                dtNgayBatDau.Text = row.Cells["NgayBatDau"].Value.ToString();
                dtNgayKetThuc.Text = row.Cells["NgayKetThuc"].Value.ToString();
                txtMaHocky.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnThem.Enabled = false;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timCN = txtTimKiem.Text.Trim().ToLower();
            dvThongTin.DataSource = db.QLHocKies.Where(x => x.MaHocKy.ToLower().Contains(timCN)).ToList();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu form = new TrangChu(username);
            form.ShowDialog();
            this.Close();
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
    }
}
