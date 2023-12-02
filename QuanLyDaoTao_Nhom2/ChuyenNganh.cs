using System;
using System.CodeDom;
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
    public partial class ChuyenNganh : Form
    {
       
        NHOM2_QUANLY_DAOTAOEntities db = new NHOM2_QUANLY_DAOTAOEntities();
        public ChuyenNganh()
        {
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

            dvThongTin.DataSource = sql.ToList();

        }



        private void btnThem_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                var CheckID_MaCN = db.QLChuyenNganhs.Where(x => x.MaCN == txtMaChuyenNganh.Text || x.MaCN == txtMaChuyenNganh.Text).ToList().FirstOrDefault();
                var CheckID_TenCN = db.QLChuyenNganhs.Where(x => x.TenCN == txtTenChuyenNganh.Text || x.TenCN == txtTenChuyenNganh.Text).ToList().FirstOrDefault();
                if (txtMaChuyenNganh.Text == "")
                {
                    MessageBox.Show("Mã chuyên ngành không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (CheckID_MaCN != null)
                {
                    MessageBox.Show("Mã chuyên ngành này đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if(txtTenChuyenNganh.Text == "")
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
                    MaCN = txtMaChuyenNganh.Text,
                    TenCN = txtTenChuyenNganh.Text,
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

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            var CheckID_MaCN = db.QLChuyenNganhs.Where(x => x.MaCN == txtMaChuyenNganh.Text || x.MaCN == txtMaChuyenNganh.Text).ToList().FirstOrDefault();
            var CheckID_TenCN = db.QLChuyenNganhs.Where(x => x.TenCN == txtTenChuyenNganh.Text || x.TenCN == txtTenChuyenNganh.Text).ToList().FirstOrDefault();
            if (txtMaChuyenNganh.Text == "")
            {
                MessageBox.Show("Mã chuyên ngành không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            else if (txtTenChuyenNganh.Text == "")
            {
                MessageBox.Show("Tên chuyên ngành không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (CheckID_TenCN != null)
            {
                MessageBox.Show("Tên chuyên ngành này đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var sua = (dvThongTin.SelectedCells[0].OwningRow.Cells["MaChuyenNganh"].Value.ToString());
            QLChuyenNganh sv = db.QLChuyenNganhs.Find(sua);
            sv.TenCN = txtTenChuyenNganh.Text;

            db.SaveChanges();
             LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var CN = txtMaChuyenNganh.Text;
            QLChuyenNganh sv = db.QLChuyenNganhs.Where(P => P.MaCN == CN && P.TenCN == txtTenChuyenNganh.Text).FirstOrDefault();
            db.QLChuyenNganhs.Remove(sv);
            db.SaveChanges();
            LoadData();
        }

        private void btnLamMoi_Click_1(object sender, EventArgs e)
        {
            txtTenChuyenNganh.Text = "";
            txtMaChuyenNganh.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string timCN = txtTimKiem.Text.Trim().ToLower();
            var query = db.QLChuyenNganhs.Where(x => x.TenCN == timCN).Select(x => new
            {
                MaChuyenNganh = x.MaCN,
                TenChuyenNganh = x.TenCN

            });
            dvThongTin.DataSource = query.ToList();
            


        }

        private void dvThongTin_DoubleClick(object sender, EventArgs e)
        {
            int lst = dvThongTin.CurrentRow.Index;
            btnThem.Enabled = true;
            txtMaChuyenNganh.Enabled = false;
            txtMaChuyenNganh.Text = dvThongTin.Rows[lst].Cells[0].Value.ToString();
            txtTenChuyenNganh.Text = dvThongTin.Rows[lst].Cells[1].Value.ToString();
        }

    }
}
