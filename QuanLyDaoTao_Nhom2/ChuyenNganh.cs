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
        
 

            var sql = 
                      from b in db.QLChuyenNganhs
                    

                       select new
                       {

                           MaChuyenNganh = b.MaCN,
                           TenChuyenNganh = b.TenCN,
                      
                       };

            dvThongTin.DataSource = sql.ToList();
            
        }

        void YoutubeData()
        {
            txtMaChuyenNganh.DataBindings.Add(new Binding("Text", dvThongTin.DataSource, "MaChuyenNganh"));
            txtTenChuyenNganh.DataBindings.Add(new Binding("Text", dvThongTin.DataSource, "TenChuyenNganh"));
        
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

        private void btnSua_Click(object sender, EventArgs e)
        {
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTenChuyenNganh.Text = "";
            txtMaChuyenNganh.Text = "";
         
        }

        


        
    }
}
