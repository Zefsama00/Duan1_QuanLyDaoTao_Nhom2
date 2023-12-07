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
    public partial class ChuyenNganh : Form
    {
        QLDTEntities db = new QLDTEntities();
        string username;
        public ChuyenNganh(String nametk)
        {
            username = nametk;
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            var sql = from b in db.QLChuyenNganhs
                      select new
                      {
                          MaChuyenNganh = b.MaCN,
                          TenChuyenNganh = b.TenCN,
                      };

            dvthongtin.DataSource = sql.ToList();

        }


   

        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                var CheckID_MaCN = db.QLChuyenNganhs.Where(x => x.MaCN == txtMaCN.Text || x.MaCN == txtMaCN.Text).ToList().FirstOrDefault();
                var CheckID_TenCN = db.QLChuyenNganhs.Where(x => x.TenCN == txtTenCN.Text || x.TenCN == txtTenCN.Text).ToList().FirstOrDefault();
                if (txtMaCN.Text == "")
                {
                    MessageBox.Show("Mã chuyên ngành không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (CheckID_MaCN != null)
                {
                    MessageBox.Show("Mã chuyên ngành này đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtMaCN.Text == "")
                {
                    MessageBox.Show("Tên chuyên ngành không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (CheckID_TenCN != null)
                {
                    MessageBox.Show("Tên chuyên ngành này đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                db.QLChuyenNganhs.Add(new QLChuyenNganh()
                {
                    MaCN = txtMaCN.Text,
                    TenCN = txtTenCN.Text,
                });

                db.SaveChanges();
                MessageBox.Show("Chuyên ngành đã được thêm thành công.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm chuyên ngành: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var CheckID_MaCN = db.QLChuyenNganhs.Where(x => x.MaCN == txtMaCN.Text || x.MaCN == txtMaCN.Text).ToList().FirstOrDefault();
            var CheckID_TenCN = db.QLChuyenNganhs.Where(x => x.TenCN == txtTenCN.Text || x.TenCN == txtTenCN.Text).ToList().FirstOrDefault();
            if (txtMaCN.Text == "")
            {
                MessageBox.Show("Mã chuyên ngành không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (txtTenCN.Text == "")
            {
                MessageBox.Show("Tên chuyên ngành không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (CheckID_TenCN != null)
            {
                MessageBox.Show("Tên chuyên ngành này đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var sua = (dvthongtin.SelectedCells[0].OwningRow.Cells["MaChuyenNganh"].Value.ToString());
            QLChuyenNganh sv = db.QLChuyenNganhs.Find(sua);
            sv.TenCN = txtTenCN.Text;

            db.SaveChanges();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var CN = txtMaCN.Text;
            QLChuyenNganh sv = db.QLChuyenNganhs.Where(P => P.MaCN == CN && P.TenCN == txtTenCN.Text).FirstOrDefault();
            db.QLChuyenNganhs.Remove(sv);
            db.SaveChanges();
            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenCN.Text = "";
            txtMaCN.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timCN = txtTimKiem.Text.Trim().ToLower();
            var query = db.QLChuyenNganhs.Where(x => x.TenCN == timCN).Select(x => new
            {
                MaChuyenNganh = x.MaCN,
                TenChuyenNganh = x.TenCN

            });
            dvthongtin.DataSource = query.ToList();
        }

        private void dvthongtin_DoubleClick(object sender, EventArgs e)
        {
            int lst = dvthongtin.CurrentRow.Index;
            btnThem.Enabled = true;
            txtMaCN.Enabled = false;
            txtMaCN.Text = dvthongtin.Rows[lst].Cells[0].Value.ToString();
            txtTenCN.Text = dvthongtin.Rows[lst].Cells[1].Value.ToString();
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
