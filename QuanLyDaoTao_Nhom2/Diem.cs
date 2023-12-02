using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaoTao_Nhom2
{
    public partial class Diem : Form
    {
        NHOM2_QUANLY_DAOTAOEntities db = new NHOM2_QUANLY_DAOTAOEntities();
        QLDiem qld = new QLDiem();
        string str = @"Data Source=PHANHUUHIEU\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True;Encrypt=False";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader DuLieu;
        public Diem()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {

            var sql = (from c in db.QLDiems

                       select new
                       {
                           ID = c.ID,
                           MaSV = c.MaSV,
                           MaMonHoc = c.MaMonHoc,
                           DiemLAB = c.DiemLab,
                           DiemThi = c.DiemThi,
                           DiemTongKet = (c.DiemLab + c.DiemThi * 2) / 3,
                       });
            dvThongTin.DataSource = sql.ToList();

        }

        string lenhsv;
        string lenhmh;

        void LoadMaSV()
        {
            cboMaSV.Items.Clear();
            KetNoi = new SqlConnection(str);
            lenhsv = @"SELECT MaSV From QLSinhVien";
            KetNoi.Open();
            ThucHien = new SqlCommand(lenhsv, KetNoi);
            DuLieu = ThucHien.ExecuteReader();
            while (DuLieu.Read())
            {
                cboMaSV.Items.Add(DuLieu[0].ToString());


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
                cboMaMonHoc.Items.Add(DuLieu[0].ToString());
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
            var queryTimBenSV = db.QLDiems.Where(x => x.ID.ToLower() == txtID.Text.ToLower()).FirstOrDefault();
            if (queryTimBenSV != null)
            {
                qld.ID = txtID.Text;
                qld.MaSV = cboMaSV.Text;
                qld.MaMonHoc = cboMaMonHoc.Text;
                qld.DiemLab = double.Parse(txtDiemLAB.Text);
                qld.DiemThi = double.Parse(txtDiemThi.Text);
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
                if (db.QLDiems.Any(diem => diem.ID == txtID.Text))
                {
                    MessageBox.Show("ID đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (txtID.Text == "")
                {
                    MessageBox.Show("ID không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (cboMaSV.Text == "")
                {
                    MessageBox.Show("Mã sinh không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (cboMaMonHoc.Text == "")
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

                    ID = txtID.Text,
                    MaSV = cboMaSV.Text,
                    MaMonHoc = cboMaMonHoc.Text,
                    DiemLab = double.Parse(txtDiemLAB.Text),
                    DiemThi = double.Parse(txtDiemThi.Text),
                    DiemTongKet = Convert.ToInt32(txtDiemLAB.Text + txtDiemThi.Text),
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
                if (db.QLDiems.Any(diem => diem.ID == txtID.Text))
                {
                    MessageBox.Show("ID đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (txtID.Text == "")
                {
                    MessageBox.Show("ID không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (cboMaSV.Text == "")
                {
                    MessageBox.Show("Mã sinh không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (cboMaMonHoc.Text == "")
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
                sv.ID = txtID.Text;
                sv.MaSV = cboMaSV.Text;
                sv.MaMonHoc = cboMaMonHoc.Text;
                sv.DiemLab = double.Parse(txtDiemLAB.Text);
                sv.DiemThi = double.Parse(txtDiemThi.Text);

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
            var id = txtID.Text;
            QLDiem dd = db.QLDiems.Where(p => p.ID == id && p.MaSV == cboMaSV.Text).FirstOrDefault();
            db.QLDiems.Remove(dd);
            db.SaveChanges();
            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            cboMaSV.Text = "";
            cboMaMonHoc.Text = "";
            txtDiemLAB.Text = "";
            txtDiemThi.Text = "";
            lblDiemTongKet.Text = "0.0";
        }

        

        private void txtDiemThi_TextChanged(object sender, EventArgs e)
        {
            TinhDiemTB();
        }

        private void dvThongTin_DoubleClick(object sender, EventArgs e)
        {
            int lst = dvThongTin.CurrentRow.Index;
            btnThem.Enabled = true;
            txtID.Enabled = false;
            cboMaSV.Enabled = false;
            txtID.Text = dvThongTin.Rows[lst].Cells[0].Value.ToString();
            cboMaSV.Text = dvThongTin.Rows[lst].Cells[1].Value.ToString();
            cboMaMonHoc.Text = dvThongTin.Rows[lst].Cells[2].Value.ToString();
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
            LoadMaSV();
            LoadMaMonhoc();
        }
    }
}
