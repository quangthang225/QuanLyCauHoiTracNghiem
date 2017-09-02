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
            this.ToanQuyenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaoVienQuanLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Them = new System.Windows.Forms.Button();
            this.txtCapNhat = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bntThayDoiGVQL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvNguoiDung);
            this.groupBox1.Location = new System.Drawing.Point(45, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1219, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách người dùng";
            // 
            // dgvNguoiDung
            // 
            this.dgvNguoiDung.AllowUserToAddRows = false;
            this.dgvNguoiDung.AllowUserToDeleteRows = false;
            this.dgvNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaND,
            this.HoTen,
            this.TenDangNhap,
            this.TrangThai,
            this.ToanQuyenGV,
            this.LoaiNguoiDung,
            this.BoMon,
            this.GiaoVienQuanLy});
            this.dgvNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNguoiDung.Location = new System.Drawing.Point(3, 17);
            this.dgvNguoiDung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNguoiDung.Name = "dgvNguoiDung";
            this.dgvNguoiDung.ReadOnly = true;
            this.dgvNguoiDung.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvNguoiDung.RowTemplate.Height = 24;
            this.dgvNguoiDung.Size = new System.Drawing.Size(1213, 299);
            this.dgvNguoiDung.TabIndex = 0;
            this.dgvNguoiDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoiDung_CellContentClick);
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
            // ToanQuyenGV
            // 
            this.ToanQuyenGV.DataPropertyName = "ToanQuyenGV";
            this.ToanQuyenGV.HeaderText = "Toàn Quyền GV";
            this.ToanQuyenGV.Name = "ToanQuyenGV";
            this.ToanQuyenGV.ReadOnly = true;
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
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(274, 376);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(140, 28);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm người dùng";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txtCapNhat
            // 
            this.txtCapNhat.Location = new System.Drawing.Point(465, 376);
            this.txtCapNhat.Name = "txtCapNhat";
            this.txtCapNhat.Size = new System.Drawing.Size(153, 28);
            this.txtCapNhat.TabIndex = 3;
            this.txtCapNhat.Text = "Cập nhật thông tin";
            this.txtCapNhat.UseVisualStyleBackColor = true;
            this.txtCapNhat.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(922, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 28);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xóa người dùng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bntThayDoiGVQL
            // 
            this.bntThayDoiGVQL.Location = new System.Drawing.Point(673, 376);
            this.bntThayDoiGVQL.Name = "bntThayDoiGVQL";
            this.bntThayDoiGVQL.Size = new System.Drawing.Size(195, 28);
            this.bntThayDoiGVQL.TabIndex = 6;
            this.bntThayDoiGVQL.Text = "Thay đổi giáo viên quản lý";
            this.bntThayDoiGVQL.UseVisualStyleBackColor = true;
            this.bntThayDoiGVQL.Click += new System.EventHandler(this.bntThayDoiGVQL_Click);
            // 
            // FrmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 459);
            this.Controls.Add(this.bntThayDoiGVQL);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtCapNhat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmQuanLyNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý người dùng";
            this.Load += new System.EventHandler(this.FrmQuanLyNguoiDung_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvNguoiDung;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button txtCapNhat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaND;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToanQuyenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaoVienQuanLy;
        private System.Windows.Forms.Button bntThayDoiGVQL;
    }
}