namespace QuanLyBanHang
{
    partial class frmNhanVien
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkGioiTinh = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(802, 488);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(85, 23);
            this.btnDong.TabIndex = 47;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(302, 488);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 23);
            this.btnXoa.TabIndex = 46;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(677, 488);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(85, 23);
            this.btnBoQua.TabIndex = 45;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(427, 488);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 23);
            this.btnSua.TabIndex = 44;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(552, 488);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 23);
            this.btnLuu.TabIndex = 43;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(177, 488);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 23);
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(21, 159);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1053, 298);
            this.dgvNhanVien.TabIndex = 41;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(148, 63);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(241, 22);
            this.txtMaNhanVien.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(399, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 29);
            this.label2.TabIndex = 39;
            this.label2.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(719, 62);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(264, 22);
            this.txtDiaChi.TabIndex = 38;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(719, 91);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(264, 22);
            this.txtDienThoai.TabIndex = 37;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(148, 91);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(241, 22);
            this.txtTenNhanVien.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(43, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 17);
            this.label15.TabIndex = 35;
            this.label15.Text = "Mã nhân viên";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(43, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 17);
            this.label14.TabIndex = 34;
            this.label14.Text = "Tên nhân vien";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(641, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 33;
            this.label13.Text = "Địa chỉ";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.AutoSize = true;
            this.txtGiamGia.ForeColor = System.Drawing.Color.Maroon;
            this.txtGiamGia.Location = new System.Drawing.Point(641, 91);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(72, 17);
            this.txtGiamGia.TabIndex = 32;
            this.txtGiamGia.Text = "Điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(43, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Giới tính";
            // 
            // chkGioiTinh
            // 
            this.chkGioiTinh.AutoSize = true;
            this.chkGioiTinh.Location = new System.Drawing.Point(148, 127);
            this.chkGioiTinh.Name = "chkGioiTinh";
            this.chkGioiTinh.Size = new System.Drawing.Size(59, 21);
            this.chkGioiTinh.TabIndex = 49;
            this.chkGioiTinh.Text = "Nam";
            this.chkGioiTinh.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(237, 126);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 21);
            this.checkBox2.TabIndex = 50;
            this.checkBox2.Text = "Nữ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(641, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Ngày sinh";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dtpNgaySinh.CustomFormat = "yyyy-MM-dd";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpNgaySinh.Location = new System.Drawing.Point(719, 119);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(264, 22);
            this.dtpNgaySinh.TabIndex = 53;
            this.dtpNgaySinh.Value = new System.DateTime(2021, 1, 24, 0, 0, 0, 0);
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 540);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.chkGioiTinh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtGiamGia);
            this.Name = "frmNhanVien";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh mục nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtGiamGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkGioiTinh;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
    }
}