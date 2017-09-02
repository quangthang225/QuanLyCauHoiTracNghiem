namespace QuanLyKhoCauHoiTracNghiem
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuQuanTri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.xinChàoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBoMon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyDeThi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyCauHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXinChao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanTri,
            this.xinChàoToolStripMenuItem,
            this.mnuQuanLy,
            this.mnuGiaoVien,
            this.mnuDangXuat,
            this.mnuXinChao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(943, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuQuanTri
            // 
            this.mnuQuanTri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLyNguoiDung});
            this.mnuQuanTri.Name = "mnuQuanTri";
            this.mnuQuanTri.Size = new System.Drawing.Size(74, 24);
            this.mnuQuanTri.Text = "Quản trị";
            // 
            // mnuQuanLyNguoiDung
            // 
            this.mnuQuanLyNguoiDung.Name = "mnuQuanLyNguoiDung";
            this.mnuQuanLyNguoiDung.Size = new System.Drawing.Size(215, 26);
            this.mnuQuanLyNguoiDung.Text = "Quản lý người dùng";
            this.mnuQuanLyNguoiDung.Click += new System.EventHandler(this.mnuQuanLyNguoiDung_Click);
            // 
            // xinChàoToolStripMenuItem
            // 
            this.xinChàoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xinChàoToolStripMenuItem.Name = "xinChàoToolStripMenuItem";
            this.xinChàoToolStripMenuItem.Size = new System.Drawing.Size(12, 24);
            this.xinChàoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBoMon,
            this.mnuQuanLyMonHoc});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(71, 24);
            this.mnuQuanLy.Text = "Quản lý";
            // 
            // mnuBoMon
            // 
            this.mnuBoMon.Name = "mnuBoMon";
            this.mnuBoMon.Size = new System.Drawing.Size(196, 26);
            this.mnuBoMon.Text = "Quản lý bộ môn";
            this.mnuBoMon.Click += new System.EventHandler(this.mnuBoMon_Click);
            // 
            // mnuQuanLyMonHoc
            // 
            this.mnuQuanLyMonHoc.Name = "mnuQuanLyMonHoc";
            this.mnuQuanLyMonHoc.Size = new System.Drawing.Size(196, 26);
            this.mnuQuanLyMonHoc.Text = "Quản lý môn học";
            this.mnuQuanLyMonHoc.Click += new System.EventHandler(this.mnuQuanLyMonHoc_Click);
            // 
            // mnuGiaoVien
            // 
            this.mnuGiaoVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLyDeThi,
            this.mnuQuanLyCauHoi});
            this.mnuGiaoVien.Name = "mnuGiaoVien";
            this.mnuGiaoVien.Size = new System.Drawing.Size(83, 24);
            this.mnuGiaoVien.Text = "Giáo viên";
            // 
            // mnuQuanLyDeThi
            // 
            this.mnuQuanLyDeThi.Name = "mnuQuanLyDeThi";
            this.mnuQuanLyDeThi.Size = new System.Drawing.Size(186, 26);
            this.mnuQuanLyDeThi.Text = "Quản lý đề thi";
            this.mnuQuanLyDeThi.Click += new System.EventHandler(this.mnuQuanLyDeThi_Click);
            // 
            // mnuQuanLyCauHoi
            // 
            this.mnuQuanLyCauHoi.Name = "mnuQuanLyCauHoi";
            this.mnuQuanLyCauHoi.Size = new System.Drawing.Size(186, 26);
            this.mnuQuanLyCauHoi.Text = "Quản lý câu hỏi";
            this.mnuQuanLyCauHoi.Click += new System.EventHandler(this.mnuQuanLyCauHoi_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(89, 24);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuXinChao
            // 
            this.mnuXinChao.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuXinChao.Name = "mnuXinChao";
            this.mnuXinChao.Size = new System.Drawing.Size(85, 24);
            this.mnuXinChao.Text = "Xin chào: ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 495);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho câu hỏi trắc nghiệm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanTri;
        private System.Windows.Forms.ToolStripMenuItem xinChàoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuXinChao;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyMonHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuGiaoVien;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem mnuBoMon;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyDeThi;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLyCauHoi;
    }
}