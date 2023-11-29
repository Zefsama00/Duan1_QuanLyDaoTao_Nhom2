using System;
using System.CodeDom;
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
      
        NHOM2_QUANLY_DAOTAOEntities db = new NHOM2_QUANLY_DAOTAOEntities();
        public ChuyenNganh()
        {
            InitializeComponent();
            LoadData();
            YoutubeData();

        }

        void LoadData()
        {
            txtMaChuyenNganh.Hide();
            txtTenChuyenNganh.Hide();
            txtMaSV.Hide();
            txtMaLop.Hide();
            btnThem.Hide();

            var sql = from a in db.QLNganhs
                      from b in db.QLChuyenNganhs
                    

                       select new
                       {

                           MaChuyenNganh = b.MaCN,
                           TenChuyenNganh = b.TenCN,
                           MaNganh = a.MaNganh,
                           TenNganh = a.TenNganh,
                           MaSV = a.MaSV,
                           MaLop = a.MaLop

                       };

            dvThongTin.DataSource = sql.ToList();
            
        }

        void YoutubeData()
        {
            txtMaChuyenNganh.DataBindings.Add(new Binding("Text", dvThongTin.DataSource, "MaChuyenNganh"));
            txtTenChuyenNganh.DataBindings.Add(new Binding("Text", dvThongTin.DataSource, "TenChuyenNganh"));
            txtMaNganh.DataBindings.Add(new Binding("Text", dvThongTin.DataSource, "MaNganh"));
            txtTenNganh.DataBindings.Add(new Binding("Text", dvThongTin.DataSource, "TenNganh"));
            txtMaLop.DataBindings.Add(new Binding("Text", dvThongTin.DataSource, "MaLop"));
            txtMaSV.DataBindings.Add(new Binding("Text", dvThongTin.DataSource, "MaSV"));
        }

        private void ChuyenNganh_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnThem_Click(object sender, EventArgs e)
        {

            try
            {
                db.QLChuyenNganhs.Add(new QLChuyenNganh()
                {
                    MaCN = txtMaChuyenNganh.Text,
                    TenCN = txtTenNganh.Text,
                });
                
 

                var result = db.QLChuyenNganhs.Where(x => x.MaCN == txtMaChuyenNganh.Text && x.TenCN == txtTenChuyenNganh.Text).ToList();

                if (result.Count > 0)
                {
                    db.QLNganhs.Add(new QLNganh()
                    {
                        MaNganh = txtMaNganh.Text,
                        TenNganh = txtTenNganh.Text,
                        MaSV = txtMaSV.Text,
                        MaLop = txtMaLop.Text,

                    });

                    db.SaveChanges();
                    MessageBox.Show("Chuyên ngành đã được thêm thành công.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else{
                    MessageBox.Show("Chuyên ngành đã được thêm thất bại.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
      
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm chuyên ngành: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var sua = (dvThongTin.SelectedCells[0].OwningRow.Cells["MaChuyenNganh"].Value.ToString());
            QLChuyenNganh sv = db.QLChuyenNganhs.Find(sua);
            var suan = (dvThongTin.SelectedCells[0].OwningRow.Cells["MaNganh"].Value.ToString());
            QLNganh sn = db.QLNganhs.Find(suan);
            sv.TenCN = txtTenChuyenNganh.Text;
            sn.MaLop = txtMaLop.Text;
            sn.MaSV = txtMaSV.Text;
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenChuyenNganh.Text = "";
            txtMaChuyenNganh.Text = "";
            txtMaNganh.Text = "";
            txtTenNganh.Text = "";
            txtMaSV.Text = "";
            txtMaLop.Text = "";
        }

        private void btnCheckNganh_Click(object sender, EventArgs e)
        {

            db.QLNganhs.Add(new QLNganh()
            {
                MaNganh = txtMaNganh.Text,
                TenNganh = txtTenNganh.Text,


            });


            var result = db.QLNganhs.Where(x => x.MaNganh == txtMaNganh.Text && x.TenNganh == txtTenNganh.Text).ToList();

            if (result.Count > 0)
            {

                txtMaChuyenNganh.Show();
                txtTenChuyenNganh.Show();
                txtMaLop.Show();
                txtMaSV.Show();
                btnCheckNganh.Hide();
                btnThem.Show();
                
            }
            else
            {

                MessageBox.Show("Mã ngành và tên ngành không tồn tại trong cơ sở dữ liệu.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
