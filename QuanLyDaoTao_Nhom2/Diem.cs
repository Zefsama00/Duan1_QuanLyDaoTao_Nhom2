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
    public partial class Diem : Form
    {
        NHOM2_QUANLY_DAOTAOEntities db = new NHOM2_QUANLY_DAOTAOEntities();
        public Diem()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            var sql = from c in db.QLDiems
                      select new
                      {
                          ID = c.ID,
                          MaSV = c.MaSV,
                          MaMonHoc = c.MaMonHoc,
                          DiemLab = c.DiemLab,
                          DiemThi = c.DiemThi,
                          DiemTongKet = c.DiemTongKet,
                      };
            dvThongTin.DataSource = sql.ToList();
        }


        private void btnThem_Click(object sender, EventArgs e)
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

                else if (txtMaSV.Text == "")
                {
                    MessageBox.Show("Mã sinh không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (txtMaMonHoc.Text == "")
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

                else if (txtDiemTongKet.Text == "")
                {
                    MessageBox.Show("Điểm tổng kết không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                else if (Convert.ToInt32(txtDiemLAB.Text) <= 0 || Convert.ToInt32(txtDiemLAB.Text) >= 10)
                {
                    MessageBox.Show("Điểm LAB phải nằm trong khoảng từ 0 đến 10.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                db.QLDiems.Add(new QLDiem()
                {
                    ID = txtID.Text,
                    MaSV = txtMaSV.Text,
                    MaMonHoc = txtMaMonHoc.Text,
                    DiemLab = Convert.ToInt32(txtDiemLAB.Text),
                    DiemThi = Convert.ToInt32(txtDiemThi.Text),
                    DiemTongKet = Convert.ToInt32(txtDiemTongKet.Text),
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

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            try
            {
                var sua = (dvThongTin.SelectedCells[0].OwningRow.Cells["ID"].Value.ToString());
                QLDiem sv = db.QLDiems.Find(sua);
                sv.ID = txtID.Text;
                sv.MaSV = txtMaSV.Text;
                sv.MaMonHoc = txtMaMonHoc.Text;
                sv.DiemLab = Convert.ToInt32(txtDiemLAB.Text);
                sv.DiemThi = Convert.ToInt32(txtDiemThi.Text);
                sv.DiemTongKet = Convert.ToInt32(txtDiemTongKet.Text);
                db.SaveChanges();
                MessageBox.Show("Đã sửa thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi sửa điểm", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            var id = txtID.Text;
            QLDiem dd = db.QLDiems.Where(p => p.ID == id && p.MaSV == txtMaSV.Text).FirstOrDefault();
            db.QLDiems.Remove(dd);
            db.SaveChanges();
            LoadData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtMaSV.Text = "";
            txtMaMonHoc.Text = "";
            txtDiemLAB.Text = "";
            txtDiemThi.Text = "";
            txtDiemTongKet.Text = "";
        }
    }
}
