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
            this.mnuXinChao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBoMon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyMonHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyDeThi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLyCauHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanTri,
            this.xinChàoToolStripMenuItem,
            this.mnuQuanLy,
            this.mnuGiaoVien,
            this.mnuDangXuat,
            this.mnuXinChao});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuQuanTri
            // 
            this.mnuQuanTri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLyNguoiDung});
            this.mnuQuanTri.Name = "mnuQuanTri";
            this.mnuQuanTri.Size = new System.Drawing.Size(62, 20);
            this.mnuQuanTri.Text = "Quản trị";
            // 
            // mnuQuanLyNguoiDung
            // 
            this.mnuQuanLyNguoiDung.Name = "mnuQuanLyNguoiDung";
            this.mnuQuanLyNguoiDung.Size = new System.Drawing.Size(180, 22);
            this.mnuQuanLyNguoiDung.Text = "Quản lý người dùng";
            // 
            // xinChàoToolStripMenuItem
            // 
            this.xinChàoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.xinChàoToolStripMenuItem.Name = "xinChàoToolStripMenuItem";
            this.xinChàoToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.xinChàoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mnuXinChao
            // 
            this.mnuXinChao.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuXinChao.Name = "mnuXinChao";
            this.mnuXinChao.Size = new System.Drawing.Size(71, 20);
            this.mnuXinChao.Text = "Xin chào: ";
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBoMon,
            this.mnuQuanLyMonHoc});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(60, 20);
            this.mnuQuanLy.Text = "Quản lý";
            // 
            // mnuBoMon
            // 
            this.mnuBoMon.Name = "mnuBoMon";
            this.mnuBoMon.Size = new System.Drawing.Size(166, 22);
            this.mnuBoMon.Text = "Quản lý bộ môn";
            // 
            // mnuQuanLyMonHoc
            // 
            this.mnuQuanLyMonHoc.Name = "mnuQuanLyMonHoc";
            this.mnuQuanLyMonHoc.Size = new System.Drawing.Size(166, 22);
            this.mnuQuanLyMonHoc.Text = "Quản lý môn học";
            this.mnuQuanLyMonHoc.Click += new System.EventHandler(this.mnuQuanLyMonHoc_Click);
            // 
            // mnuGiaoVien
            // 
            this.mnuGiaoVien.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLyDeThi,
            this.mnuQuanLyCauHoi});
            this.mnuGiaoVien.Name = "mnuGiaoVien";
            this.mnuGiaoVien.Size = new System.Drawing.Size(68, 20);
            this.mnuGiaoVien.Text = "Giáo viên";
            // 
            // mnuQuanLyDeThi
            // 
            this.mnuQuanLyDeThi.Name = "mnuQuanLyDeThi";
            this.mnuQuanLyDeThi.Size = new System.Drawing.Size(157, 22);
            this.mnuQuanLyDeThi.Text = "Quản lý đề thi";
            this.mnuQuanLyDeThi.Click += new System.EventHandler(this.mnuQuanLyDeThi_Click);
            // 
            // mnuQuanLyCauHoi
            // 
            this.mnuQuanLyCauHoi.Name = "mnuQuanLyCauHoi";
            this.mnuQuanLyCauHoi.Size = new System.Drawing.Size(157, 22);
            this.mnuQuanLyCauHoi.Text = "Quản lý câu hỏi";
            this.mnuQuanLyCauHoi.Click += new System.EventHandler(this.mnuQuanLyCauHoi_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(72, 20);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 402);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
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