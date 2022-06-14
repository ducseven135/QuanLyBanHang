namespace QuanLyBanHang
{
    partial class frmDMHang
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvHang = new System.Windows.Forms.DataGridView();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(426, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "Ghi chú";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(426, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 69;
            this.label1.Text = "Số lượng";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(684, 415);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(85, 23);
            this.btnDong.TabIndex = 68;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(126, 415);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 67;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(405, 415);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(85, 23);
            this.btnBoQua.TabIndex = 66;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(219, 415);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 23);
            this.btnSua.TabIndex = 65;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(312, 415);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 23);
            this.btnLuu.TabIndex = 64;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(33, 415);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 23);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvHang
            // 
            this.dgvHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHang.Location = new System.Drawing.Point(21, 177);
            this.dgvHang.Name = "dgvHang";
            this.dgvHang.RowHeadersWidth = 51;
            this.dgvHang.RowTemplate.Height = 24;
            this.dgvHang.Size = new System.Drawing.Size(758, 218);
            this.dgvHang.TabIndex = 62;
            this.dgvHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHang_CellClick);
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(148, 63);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(193, 22);
            this.txtMaHang.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(271, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 29);
            this.label2.TabIndex = 60;
            this.label2.Text = "DANH MỤC HÀNG HÓA";
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(148, 120);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(193, 22);
            this.txtDonGiaNhap.TabIndex = 59;
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(148, 149);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(193, 22);
            this.txtDonGiaBan.TabIndex = 58;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(148, 91);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(193, 22);
            this.txtTenHang.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(43, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 17);
            this.label15.TabIndex = 56;
            this.label15.Text = "Mã hàng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(43, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 17);
            this.label14.TabIndex = 55;
            this.label14.Text = "Tên hàng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(46, 123);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 54;
            this.label13.Text = "Đơn giá nhập";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.AutoSize = true;
            this.txtGiamGia.ForeColor = System.Drawing.Color.Maroon;
            this.txtGiamGia.Location = new System.Drawing.Point(46, 149);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(85, 17);
            this.txtGiamGia.TabIndex = 53;
            this.txtGiamGia.Text = "Đơn giá bán";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(532, 66);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(197, 22);
            this.txtSoLuong.TabIndex = 74;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(532, 94);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(198, 63);
            this.txtGhiChu.TabIndex = 75;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(591, 415);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(85, 23);
            this.btnHienThi.TabIndex = 78;
            this.btnHienThi.Text = "Hiển thị DS";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(498, 415);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(85, 23);
            this.btnTimKiem.TabIndex = 79;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.txtTimKiem_Click);
            // 
            // frmDMHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDonGiaNhap);
            this.Controls.Add(this.txtDonGiaBan);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtGiamGia);
            this.Name = "frmDMHang";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh mục hàng hóa";
            this.Load += new System.EventHandler(this.frmDMHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDonGiaNhap;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtGiamGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnTimKiem;
    }
}