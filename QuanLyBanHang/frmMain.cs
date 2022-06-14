using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Class;
namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHang frm = new frmDMHang();
            frm.Show();
        }
        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            frm.Show();
        }
        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            frm.Show();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDon frm = new frmHoaDon();
            frm.Show();
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            frmTimHDBan frm = new frmTimHDBan();
            frm.Show();
        }
    }
}
