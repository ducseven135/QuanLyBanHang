namespace QuanLyBanHang
{
    partial class frmHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.cboMaHD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.cboMaKhachHang = new System.Windows.Forms.ComboBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHDBanHang = new System.Windows.Forms.DataGridView();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.sgf = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lads = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.cboMaHD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 514);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(402, 9);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(92, 23);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cboMaHD
            // 
            this.cboMaHD.FormattingEnabled = true;
            this.cboMaHD.Location = new System.Drawing.Point(135, 9);
            this.cboMaHD.Name = "cboMaHD";
            this.cboMaHD.Size = new System.Drawing.Size(233, 24);
            this.cboMaHD.TabIndex = 1;
            this.cboMaHD.DropDown += new System.EventHandler(this.cboMaHD_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(278, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.txtTenKhachHang);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.cboMaKhachHang);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.cboMaNhanVien);
            this.groupBox1.Controls.Add(this.dtpNgayBan);
            this.groupBox1.Controls.Add(this.txtMaHoaDon);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(581, 108);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.ReadOnly = true;
            this.txtDienThoai.Size = new System.Drawing.Size(188, 22);
            this.txtDienThoai.TabIndex = 15;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(581, 53);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.ReadOnly = true;
            this.txtTenKhachHang.Size = new System.Drawing.Size(188, 22);
            this.txtTenKhachHang.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(581, 80);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(188, 22);
            this.txtDiaChi.TabIndex = 13;
            // 
            // cboMaKhachHang
            // 
            this.cboMaKhachHang.FormattingEnabled = true;
            this.cboMaKhachHang.Location = new System.Drawing.Point(581, 24);
            this.cboMaKhachHang.Name = "cboMaKhachHang";
            this.cboMaKhachHang.Size = new System.Drawing.Size(188, 24);
            this.cboMaKhachHang.TabIndex = 12;
            this.cboMaKhachHang.SelectedIndexChanged += new System.EventHandler(this.cboMaKhachHang_SelectedIndexChanged);
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(135, 111);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(188, 22);
            this.txtTenNhanVien.TabIndex = 11;
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(135, 80);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(188, 24);
            this.cboMaNhanVien.TabIndex = 10;
            this.cboMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboMaNhanVien_SelectedIndexChanged);
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(135, 52);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(188, 22);
            this.dtpNgayBan.TabIndex = 9;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(135, 24);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(188, 22);
            this.txtMaHoaDon.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(451, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Mã khách hàng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(451, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tên khách hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(451, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(451, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(25, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(25, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(25, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(25, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHDBanHang);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.sgf);
            this.groupBox2.Controls.Add(this.txtTenHang);
            this.groupBox2.Controls.Add(this.txtGiamGia);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.cboMaHang);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lads);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(3, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 258);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // dgvHDBanHang
            // 
            this.dgvHDBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBanHang.Location = new System.Drawing.Point(0, 87);
            this.dgvHDBanHang.Name = "dgvHDBanHang";
            this.dgvHDBanHang.RowHeadersWidth = 51;
            this.dgvHDBanHang.RowTemplate.Height = 24;
            this.dgvHDBanHang.Size = new System.Drawing.Size(795, 165);
            this.dgvHDBanHang.TabIndex = 18;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(629, 25);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(140, 22);
            this.txtDonGia.TabIndex = 17;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(629, 54);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(140, 22);
            this.txtThanhTien.TabIndex = 16;
            // 
            // sgf
            // 
            this.sgf.AutoSize = true;
            this.sgf.ForeColor = System.Drawing.Color.Maroon;
            this.sgf.Location = new System.Drawing.Point(557, 54);
            this.sgf.Name = "sgf";
            this.sgf.Size = new System.Drawing.Size(76, 17);
            this.sgf.TabIndex = 15;
            this.sgf.Text = "Thành tiền";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(383, 25);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(140, 22);
            this.txtTenHang.TabIndex = 14;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(383, 54);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(140, 22);
            this.txtGiamGia.TabIndex = 13;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            this.txtGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiamGia_KeyPress);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(115, 51);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(158, 22);
            this.txtSoLuong.TabIndex = 12;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // cboMaHang
            // 
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(115, 21);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(158, 24);
            this.cboMaHang.TabIndex = 11;
            this.cboMaHang.SelectedIndexChanged += new System.EventHandler(this.cboMaHang_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(25, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Mã hàng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(25, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Số lượng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(305, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Tên hàng";
            // 
            // lads
            // 
            this.lads.AutoSize = true;
            this.lads.ForeColor = System.Drawing.Color.Maroon;
            this.lads.Location = new System.Drawing.Point(305, 54);
            this.lads.Name = "lads";
            this.lads.Size = new System.Drawing.Size(64, 17);
            this.lads.TabIndex = 4;
            this.lads.Text = "Giảm giá";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(557, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Đơn giá";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(564, 446);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 17);
            this.label16.TabIndex = 5;
            this.label16.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(642, 446);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(130, 22);
            this.txtTongTien.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(33, 482);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(154, 482);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 23);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(273, 482);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 23);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(404, 482);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(85, 23);
            this.btnInHoaDon.TabIndex = 10;
            this.btnInHoaDon.Text = "In ";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(532, 482);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(658, 482);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(85, 23);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frmHoaDon";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.ComboBox cboMaKhachHang;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHDBanHang;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label sgf;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lads;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
    }
}