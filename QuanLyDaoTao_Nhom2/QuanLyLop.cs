using System;
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
    public partial class QuanLyLop : Form
    {
        public QuanLyLop()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        SqlConnection conn;
        SqlCommand cmd;
        DataTable table = new DataTable();
        SqlDataAdapter adapter = new System.Data.SqlClient.SqlDataAdapter();
        private DataTable originalData;

        private void QuanLyLop_Load(object sender, EventArgs e)
        {
            string str = @"Data Source=VINHPC07764\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True";
            conn = new SqlConnection(str);
            conn.Open();
            LoadData();
        }
        void LoadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT MaLop as [Ma Lop], TenLop as [Ten Lop] FROM QLLop";
            adapter.SelectCommand = cmd;
            originalData = new DataTable();
            adapter.Fill(originalData);
            dvThongTin.DataSource = originalData;

            txtMaLop.Text = "";
            txtTenLop.Text = "";
            txtTimKiem.Text = "";

        }
        private bool IsValidInput()
        {
            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(txtMaLop.Text) || string.IsNullOrEmpty(txtTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return false;
            }

            // Thêm các kiểm tra khác tùy vào yêu cầu của ứng dụng

            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string str = @"Data Source=VINHPC07764\SQLEXPRESS;Initial Catalog=NHOM2_QUANLY_DAOTAO;Integrated Security=True";

            if (IsValidInput())
            {
                using (SqlConnection connection = new SqlConnection(str))
                {
                    connection.Open();

                    string query = "INSERT INTO QLLop (MaLop, TenLop) VALUES (@MaLop, @TenLop)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaLop", txtMaLop.Text);
                        command.Parameters.AddWithValue("@TenLop", txtTenLop.Text);

                        command.ExecuteNonQuery();
                    }
                }

                LoadData();
                MessageBox.Show("Thêm lớp thành công");
            }

        }

        private void dvThongTin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int list = dvThongTin.CurrentRow.Index;
            txtMaLop.Text = dvThongTin.Rows[list].Cells[0].Value.ToString();
            txtTenLop.Text = dvThongTin.Rows[list].Cells[1].Value.ToString();
        }
    }
}
