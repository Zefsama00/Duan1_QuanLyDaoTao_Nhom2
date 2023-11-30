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
        string str = @"Data Source=PHANHUUHIEU\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True;Encrypt=False";
        SqlConnection KetNoi;
        SqlCommand ThucHien;
        SqlDataReader DuLieu;
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

        

    

        string manganh;
        string tennganh;
       

        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                if (txtMaChuyenNganh.Text == "")
                {
                    MessageBox.Show("Mã chuyên ngành không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }else if(txtTenChuyenNganh.Text == "")
                {
                    MessageBox.Show("Tên chuyên ngành không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string key = txtTenChuyenNganh.Text.Trim().ToLower();
            dvThongTin.DataSource = db.QLChuyenNganhs.Where(x => x.TenCN.ToLower().Contains(key)).ToList();
        }

        private void dvThongTin_DoubleClick(object sender, EventArgs e)
        {
            int lst = dvThongTin.CurrentRow.Index;
            txtMaChuyenNganh.Text = dvThongTin.Rows[lst].Cells[0].Value.ToString();
            txtTenChuyenNganh.Text = dvThongTin.Rows[lst].Cells[1].Value.ToString();
        }

    }
}
