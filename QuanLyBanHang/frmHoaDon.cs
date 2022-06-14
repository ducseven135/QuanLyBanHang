using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using COMExcel = Microsoft.Office.Interop.Excel;
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
    public partial class frmHoaDon : Form
    {
        DataTable tblCTHDB;
        public frmHoaDon()
        {
            InitializeComponent();
        }
        public TextBox txtMaHD { get { return txtMaHoaDon; } }
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            btnInHoaDon.Enabled = false;
            txtTenNhanVien.ReadOnly = true;
            txtTenKhachHang.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtDienThoai.ReadOnly = true;
            txtTenHang.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            txtThanhTien.ReadOnly = true;
            txtTongTien.ReadOnly = true;
            txtGiamGia.Text = "0";
            txtTongTien.Text = "0";
            Functions.FillCombo("SELECT MaKhach, TenKhach FROM Khachhang", cboMaKhachHang, "MaKhach", "MaKhach");
            cboMaKhachHang.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaNhanVien, TenNhanVien FROM NhanVien", cboMaNhanVien, "MaNhanVien", "TenKhach");
            cboMaNhanVien.SelectedIndex = -1;
            Functions.FillCombo("SELECT MaHang, TenHang FROM Hang", cboMaHang, "MaHang", "MaHang");
            cboMaHang.SelectedIndex = -1;
            if (txtMaHoaDon.Text != "")
            {
                LoadInfoHoaDon();
                btnXoa.Enabled = true;
                btnInHoaDon.Enabled = true;
            }
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.MaHang, b.TenHang, a.SoLuong, b.DonGiaBan, a.GiamGia,a.ThanhTien FROM ChiTietHD AS a, Hang AS b WHERE a.MaHD = N'" + txtMaHoaDon.Text + "' AND a.MaHang=b.MaHang";
            tblCTHDB = Functions.GetDataToTable(sql);
            dgvHDBanHang.DataSource = tblCTHDB;
            dgvHDBanHang.Columns[0].HeaderText = "Mã hàng";
            dgvHDBanHang.Columns[1].HeaderText = "Tên hàng";
            dgvHDBanHang.Columns[2].HeaderText = "Số lượng";
            dgvHDBanHang.Columns[3].HeaderText = "Đơn giá";
            dgvHDBanHang.Columns[4].HeaderText = "Giảm giá %";
            dgvHDBanHang.Columns[5].HeaderText = "Thành tiền";
            dgvHDBanHang.Columns[0].Width = 80;
            dgvHDBanHang.Columns[1].Width = 130;
            dgvHDBanHang.Columns[2].Width = 80;
            dgvHDBanHang.Columns[3].Width = 90;
            dgvHDBanHang.Columns[4].Width = 90;
            dgvHDBanHang.Columns[5].Width = 90;
            dgvHDBanHang.AllowUserToAddRows = false;
            dgvHDBanHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT NgayBan FROM HoaDon WHERE MaHD = N'" + txtMaHoaDon.Text + "'";
            dtpNgayBan.Text = Functions.GetFieldValues(str);
            str = "SELECT MaNhanVien FROM HoaDon WHERE MaHD = N'" + txtMaHoaDon.Text + "'";
            cboMaNhanVien.Text = Functions.GetFieldValues(str);
            str = "SELECT MaKhach FROM HoaDon WHERE MaHD = N'" + txtMaHoaDon.Text + "'";
            cboMaKhachHang.Text = Functions.GetFieldValues(str);
            str = "SELECT TongTien FROM HoaDon WHERE MaHD = N'" + txtMaHoaDon.Text + "'";
            txtTongTien.Text = Functions.GetFieldValues(str);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnInHoaDon.Enabled = false;
            btnThem.Enabled = false;
            ResetValues();
            txtMaHoaDon.Enabled = true;
            LoadDataGridView();
        }
        private void ResetValues()
        {
            txtMaHoaDon.Text = "";
            dtpNgayBan.Text = DateTime.Now.ToShortDateString();
            cboMaNhanVien.Text = "";
            cboMaKhachHang.Text = "";
            txtTongTien.Text = "0";
            cboMaHang.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT MaHD FROM HoaDon WHERE MaHD=N'" + txtMaHoaDon.Text + "'";
            if (!Functions.CheckKey(sql))
            {
                if (txtMaHoaDon.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập mã hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaHoaDon.Focus();
                    return;
                }
                if (cboMaNhanVien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaNhanVien.Focus();
                    return;
                }
                if (cboMaKhachHang.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMaKhachHang.Focus();
                    return;
                }
                sql = "INSERT INTO HoaDon(MaHD, NgayBan, MaNhanVien, MaKhach, TongTien) VALUES (N'" + txtMaHoaDon.Text.Trim() + "','" +
                        dtpNgayBan.Text.Trim() +"',N'" + cboMaNhanVien.SelectedValue + "',N'" +
                        cboMaKhachHang.SelectedValue + "','" + txtTongTien.Text + "')";
                Functions.RunSQL(sql);
            }
            if (cboMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHang.Focus();
                return;
            }
            if ((txtSoLuong.Text.Trim().Length == 0) || (txtSoLuong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            if (txtGiamGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiamGia.Focus();
                return;
            }
            sql = "SELECT MaHang FROM ChiTietHD WHERE MaHang=N'" + cboMaHang.SelectedValue + "' AND MaHD = N'" + txtMaHoaDon.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cboMaHang.Focus();
                return;
            }
            sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM Hang WHERE MaHang = N'" + cboMaHang.SelectedValue + "'"));
            if (Convert.ToDouble(txtSoLuong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Text = "";
                txtSoLuong.Focus();
                return;
            }
            sql = "INSERT INTO ChiTietHD(MaHD,MaHang,SoLuong,DonGia, GiamGia,ThanhTien) VALUES(N'" + txtMaHoaDon.Text.Trim() + "',N'" + cboMaHang.SelectedValue + "'," + txtSoLuong.Text + "," + txtDonGia.Text + "," + txtGiamGia.Text + ",'" + txtThanhTien.Text + "')";
            Functions.RunSQL(sql);
            LoadDataGridView();
            SLcon = sl - Convert.ToDouble(txtSoLuong.Text);
            sql = "UPDATE Hang SET SoLuong =" + SLcon + " WHERE MaHang= N'" + cboMaHang.SelectedValue + "'";
            Functions.RunSQL(sql);
            tong = Convert.ToDouble(Functions.GetFieldValues("SELECT TongTien FROM HoaDon WHERE MaHD = N'" + txtMaHoaDon.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtThanhTien.Text);
            sql = "UPDATE HoaDon SET TongTien ='" + Tongmoi + "' WHERE MaHD = N'" + txtMaHoaDon.Text + "'";
            Functions.RunSQL(sql);
            txtTongTien.Text = Tongmoi.ToString();
            ResetValuesHang();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnInHoaDon.Enabled = true;
        }
        private void ResetValuesHang()
        {
            cboMaHang.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "0";
            txtThanhTien.Text = "0";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT MaHang,SoLuong FROM ChiTietHD WHERE MaHD = N'" + txtMaHoaDon.Text + "'";
                DataTable Hang = Functions.GetDataToTable(sql);
                for (int hang = 0; hang <= Hang.Rows.Count - 1; hang++)
                {
                    sl = Convert.ToDouble(Functions.GetFieldValues("SELECT SoLuong FROM Hang WHERE MaHang = N'" + Hang.Rows[hang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(Hang.Rows[hang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE Hang SET SoLuong =" + slcon + " WHERE MaHang= N'" + Hang.Rows[hang][0].ToString() + "'";
                    Functions.RunSQL(sql);
                }

                sql = "DELETE ChiTietHD WHERE MaHD=N'" + txtMaHoaDon.Text + "'";
                Functions.RunSqlDel(sql);

                sql = "DELETE HoaDon WHERE MaHD=N'" + txtMaHoaDon.Text + "'";
                Functions.RunSqlDel(sql);
                ResetValues();
                LoadDataGridView();
                btnXoa.Enabled = false;
                btnInHoaDon.Enabled = false;
            }
        } 
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }
        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, gg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);
            if (txtGiamGia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtGiamGia.Text);
            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtThanhTien.Text = tt.ToString();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; 
            COMExcel.Worksheet exSheet; 
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblThongtinHD, tblThongtinHang;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:Z300"].Font.Name = "Times new roman"; 
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; 
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Shop B.A.";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Chùa Bộc - Hà Nội";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)38526419";
            exRange.Range["C2:E2"].Font.Size = 16;
            exRange.Range["C2:E2"].Font.Bold = true;
            exRange.Range["C2:E2"].Font.ColorIndex = 3; 
            exRange.Range["C2:E2"].MergeCells = true;
            exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            sql = "SELECT a.MaHD, a.NgayBan, a.TongTien, b.TenKhach, b.DiaChi, b.DienThoai, c.TenNhanVien FROM HoaDon AS a, Khachhang AS b, NhanVien AS c WHERE a.MaHD = N'" + txtMaHoaDon.Text + "' AND a.MaKhach = b.MaKhach AND a.MaNhanVien = c.MaNhanVien";
            tblThongtinHD = Functions.GetDataToTable(sql);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Địa chỉ:";
            exRange.Range["C8:E8"].MergeCells = true;
            exRange.Range["C8:E8"].Value = tblThongtinHD.Rows[0][4].ToString();
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = tblThongtinHD.Rows[0][5].ToString();
            sql = "SELECT b.TenHang, a.SoLuong, b.DonGiaBan, a.GiamGia, a.ThanhTien " +
                  "FROM ChiTietHD AS a , Hang AS b WHERE a.MaHD = N'" +
                  txtMaHoaDon.Text + "' AND a.MaHang = b.MaHang";
            tblThongtinHang = Functions.GetDataToTable(sql);
            exRange.Range["A11:F11"].Font.Bold = true;
            exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:F11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Tên hàng";
            exRange.Range["C11:C11"].Value = "Số lượng";
            exRange.Range["D11:D11"].Value = "Đơn giá";
            exRange.Range["E11:E11"].Value = "Giảm giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                {
                    exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            exRange = exSheet.Cells[cot][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = "Tổng tiền:";
            exRange = exSheet.Cells[cot + 1][hang + 14];
            exRange.Font.Bold = true;
            exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
            exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
            exRange.Range["A1:F1"].MergeCells = true;
            exRange.Range["A1:F1"].Font.Bold = true;
            exRange.Range["A1:F1"].Font.Italic = true;
            exRange.Range["A1:F1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
            exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
            exRange.Range["A1:C1"].MergeCells = true;
            exRange.Range["A1:C1"].Font.Italic = true;
            exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
            exRange.Range["A1:C1"].Value = "Hà Nội, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
            exRange.Range["A2:C2"].MergeCells = true;
            exRange.Range["A2:C2"].Font.Italic = true;
            exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
            exRange.Range["A6:C6"].MergeCells = true;
            exRange.Range["A6:C6"].Font.Italic = true;
            exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
            exSheet.Name = "Hóa đơn nhập";
            exApp.Visible = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboMaHD.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaHD.Focus();
                return;
            }
            txtMaHoaDon.Text = cboMaHD.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            btnXoa.Enabled = true;
            btnLuu.Enabled = true;
            btnInHoaDon.Enabled = true;
            cboMaHD.SelectedIndex = -1;
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }
        private void txtGiamGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }
        private void cboMaHD_DropDown(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT MaHD FROM HoaDon", cboMaHD, "MaHD", "MaHD");
            cboMaHD.SelectedIndex = -1;
        }
        private void frmHoadonBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaHang.Text == "")
            {
                txtTenHang.Text = "";
                txtDonGia.Text = "";
            }
            str = "SELECT TenHang FROM Hang WHERE MaHang =N'" + cboMaHang.SelectedValue + "'";
            txtTenHang.Text = Functions.GetFieldValues(str);
            str = "SELECT DonGiaBan FROM Hang WHERE MaHang =N'" + cboMaHang.SelectedValue + "'";
            txtDonGia.Text = Functions.GetFieldValues(str);
        }

        private void cboMaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaKhachHang.Text == "")
            {
                txtTenKhachHang.Text = "";
                txtDiaChi.Text = "";
                txtDienThoai.Text = "";
            }
            str = "Select TenKhach from Khachhang where MaKhach = N'" + cboMaKhachHang.SelectedValue + "'";
            txtTenKhachHang.Text = Functions.GetFieldValues(str);
            str = "Select DiaChi from Khachhang where MaKhach = N'" + cboMaKhachHang.SelectedValue + "'";
            txtDiaChi.Text = Functions.GetFieldValues(str);
            str = "Select DienThoai from Khachhang where MaKhach= N'" + cboMaKhachHang.SelectedValue + "'";
            txtDienThoai.Text = Functions.GetFieldValues(str);
        }

        private void cboMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cboMaNhanVien.Text == "")
            {
                txtTenNhanVien.Text = "";    
            }
            str = "Select TenNhanVien from Nhanvien where MaNhanVien = N'" + cboMaNhanVien.SelectedValue + "'";
            txtTenNhanVien.Text = Functions.GetFieldValues(str);
        }
    }
}
