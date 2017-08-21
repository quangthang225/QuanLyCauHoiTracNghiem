namespace QuanLyKhoCauHoiTracNghiem
{
    partial class FrmQuanLyDeThi
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
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHocKy = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamHoc = new System.Windows.Forms.NumericUpDown();
            this.txtTenDeThi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDeThi = new System.Windows.Forms.DataGridView();
            this.btnThemCauHoi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.MABDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOCKY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMHOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAGVTAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeThi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMonHoc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnThemCauHoi);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.btnTao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHocKy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNamHoc);
            this.groupBox1.Controls.Add(this.txtTenDeThi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvDeThi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đề thi";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(262, 395);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnTao
            // 
            this.btnTao.Location = new System.Drawing.Point(164, 395);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(75, 23);
            this.btnTao.TabIndex = 7;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = true;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Học kỳ";
            // 
            // txtHocKy
            // 
            this.txtHocKy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHocKy.Location = new System.Drawing.Point(195, 354);
            this.txtHocKy.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtHocKy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(64, 20);
            this.txtHocKy.TabIndex = 5;
            this.txtHocKy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Năm học";
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamHoc.Location = new System.Drawing.Point(70, 354);
            this.txtNamHoc.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.txtNamHoc.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(63, 20);
            this.txtNamHoc.TabIndex = 3;
            this.txtNamHoc.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // txtTenDeThi
            // 
            this.txtTenDeThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenDeThi.Location = new System.Drawing.Point(70, 325);
            this.txtTenDeThi.Name = "txtTenDeThi";
            this.txtTenDeThi.Size = new System.Drawing.Size(522, 20);
            this.txtTenDeThi.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên đề thi";
            // 
            // dgvDeThi
            // 
            this.dgvDeThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MABDT,
            this.TENBDT,
            this.HOCKY,
            this.NAMHOC,
            this.MAGVTAO,
            this.Column1,
            this.Column2});
            this.dgvDeThi.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDeThi.Location = new System.Drawing.Point(3, 16);
            this.dgvDeThi.MultiSelect = false;
            this.dgvDeThi.Name = "dgvDeThi";
            this.dgvDeThi.ReadOnly = true;
            this.dgvDeThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeThi.Size = new System.Drawing.Size(589, 299);
            this.dgvDeThi.TabIndex = 0;
            this.dgvDeThi.SelectionChanged += new System.EventHandler(this.dgvDeThi_SelectionChanged);
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.Location = new System.Drawing.Point(361, 395);
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.Size = new System.Drawing.Size(89, 23);
            this.btnThemCauHoi.TabIndex = 9;
            this.btnThemCauHoi.Text = "Quản lý câu hỏi";
            this.btnThemCauHoi.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Môn học";
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Location = new System.Drawing.Point(333, 354);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(121, 21);
            this.cboMonHoc.TabIndex = 11;
            // 
            // MABDT
            // 
            this.MABDT.DataPropertyName = "MABDT";
            this.MABDT.Frozen = true;
            this.MABDT.HeaderText = "Mã đề thi";
            this.MABDT.Name = "MABDT";
            this.MABDT.ReadOnly = true;
            // 
            // TENBDT
            // 
            this.TENBDT.DataPropertyName = "TENBDT";
            this.TENBDT.Frozen = true;
            this.TENBDT.HeaderText = "Tên";
            this.TENBDT.Name = "TENBDT";
            this.TENBDT.ReadOnly = true;
            // 
            // HOCKY
            // 
            this.HOCKY.DataPropertyName = "HOCKY";
            this.HOCKY.Frozen = true;
            this.HOCKY.HeaderText = "Học kỳ";
            this.HOCKY.Name = "HOCKY";
            this.HOCKY.ReadOnly = true;
            // 
            // NAMHOC
            // 
            this.NAMHOC.DataPropertyName = "NAMHOC";
            this.NAMHOC.Frozen = true;
            this.NAMHOC.HeaderText = "Năm học";
            this.NAMHOC.Name = "NAMHOC";
            this.NAMHOC.ReadOnly = true;
            // 
            // MAGVTAO
            // 
            this.MAGVTAO.DataPropertyName = "MAGVTAO";
            this.MAGVTAO.HeaderText = "MAGVTAO";
            this.MAGVTAO.Name = "MAGVTAO";
            this.MAGVTAO.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TENMH";
            this.Column1.HeaderText = "Môn học";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "MAMH";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // FrmQuanLyDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 464);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmQuanLyDeThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đề thi";
            this.Load += new System.EventHandler(this.FrmQuanLyDeThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNamHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtHocKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtNamHoc;
        private System.Windows.Forms.TextBox txtTenDeThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDeThi;
        private System.Windows.Forms.Button btnThemCauHoi;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MABDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOCKY;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMHOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAGVTAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}