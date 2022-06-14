using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHang.Class;

namespace QuanLyBanHang
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String sql;
            Functions.Connect();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText= "Select * from TK where TenDN  Like N'%" + txtTenDN.Text + "%'";
            command.Connection = Functions.Con;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (txtTenDN.Text == reader.GetString(0).Trim() && txtMatKhau.Text == reader.GetString(1).Trim()) ;
                MessageBox.Show("Đăng nhập thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có muốn thoát không?", "Hỏi thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.OK)
                Application.Exit();

        }
    }
}
