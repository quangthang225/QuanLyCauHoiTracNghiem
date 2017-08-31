namespace QuanLyKhoCauHoiTracNghiem
{
    partial class FrmQuanLyNguoiDung
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
            this.MaND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaoVienQuanLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNguoiDung);
            this.groupBox1.Location = new System.Drawing.Point(46, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1219, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách người dùng";
            // 
            // dgvNguoiDung
            // 
            this.dgvNguoiDung.AllowUserToAddRows = false;
            this.dgvNguoiDung.AllowUserToDeleteRows = false;
            this.dgvNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaND,
            this.HoTen,
            this.TenDangNhap,
            this.TrangThai,
            this.LoaiNguoiDung,
            this.BoMon,
            this.GiaoVienQuanLy});
            this.dgvNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNguoiDung.Location = new System.Drawing.Point(3, 18);
            this.dgvNguoiDung.Name = "dgvNguoiDung";
            this.dgvNguoiDung.ReadOnly = true;
            this.dgvNguoiDung.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvNguoiDung.RowTemplate.Height = 24;
            this.dgvNguoiDung.Size = new System.Drawing.Size(1213, 296);
            this.dgvNguoiDung.TabIndex = 0;
            // 
            // MaND
            // 
            this.MaND.DataPropertyName = "MAND";
            this.MaND.HeaderText = "Mã người dùng";
            this.MaND.Name = "MaND";
            this.MaND.ReadOnly = true;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HOTEN";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TENDANGNHAP";
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TRANGTHAI";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // LoaiNguoiDung
            // 
            this.LoaiNguoiDung.DataPropertyName = "TENLOAIND";
            this.LoaiNguoiDung.HeaderText = "Loại Người Dùng";
            this.LoaiNguoiDung.Name = "LoaiNguoiDung";
            this.LoaiNguoiDung.ReadOnly = true;
            // 
            // BoMon
            // 
            this.BoMon.DataPropertyName = "TENBM";
            this.BoMon.HeaderText = "Bộ Môn";
            this.BoMon.Name = "BoMon";
            this.BoMon.ReadOnly = true;
            // 
            // GiaoVienQuanLy
            // 
            this.GiaoVienQuanLy.DataPropertyName = "TENGVQL";
            this.GiaoVienQuanLy.HeaderText = "Giáo viên quản lý";
            this.GiaoVienQuanLy.Name = "GiaoVienQuanLy";
            this.GiaoVienQuanLy.ReadOnly = true;
            // 
            // FrmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 510);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQuanLyNguoiDung";
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.FrmQuanLyNguoiDung_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaND;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaoVienQuanLy;
    }
}