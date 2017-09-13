namespace QuanLyKhoCauHoiTracNghiem
{
    partial class FrmQuanLyGiaoVien
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
            this.dgvGV = new System.Windows.Forms.DataGridView();
            this.MAND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOANQUYENGV = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TENBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGV);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách giáo viên";
            // 
            // dgvGV
            // 
            this.dgvGV.AllowUserToAddRows = false;
            this.dgvGV.AllowUserToDeleteRows = false;
            this.dgvGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAND,
            this.HOTEN,
            this.TOANQUYENGV,
            this.TENBM});
            this.dgvGV.Location = new System.Drawing.Point(6, 21);
            this.dgvGV.Name = "dgvGV";
            this.dgvGV.RowTemplate.Height = 24;
            this.dgvGV.Size = new System.Drawing.Size(834, 291);
            this.dgvGV.TabIndex = 0;
            this.dgvGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGV_CellContentClick);
            // 
            // MAND
            // 
            this.MAND.DataPropertyName = "MAND";
            this.MAND.HeaderText = "Mã GV";
            this.MAND.Name = "MAND";
            this.MAND.ReadOnly = true;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // TOANQUYENGV
            // 
            this.TOANQUYENGV.DataPropertyName = "TOANQUYENGV";
            this.TOANQUYENGV.HeaderText = "Quyền cập nhật câu hỏi";
            this.TOANQUYENGV.Name = "TOANQUYENGV";
            this.TOANQUYENGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TOANQUYENGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TOANQUYENGV.Width = 200;
            // 
            // TENBM
            // 
            this.TENBM.DataPropertyName = "TENBM";
            this.TENBM.HeaderText = "Tên bộ môn";
            this.TENBM.Name = "TENBM";
            this.TENBM.ReadOnly = true;
            this.TENBM.Width = 120;
            // 
            // FrmQuanLyGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 342);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQuanLyGiaoVien";
            this.Text = "Quản lý giáo viên";
            this.Load += new System.EventHandler(this.FrmQuanLyGiaoVien_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAND;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TOANQUYENGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBM;
    }
}