namespace QuanLyKhoCauHoiTracNghiem
{
    partial class FrmQuanLyMonHoc
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
            this.gbTimMH = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimMH = new System.Windows.Forms.TextBox();
            this.btnTimMH = new System.Windows.Forms.Button();
            this.btnResetTim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.gbThemMH = new System.Windows.Forms.GroupBox();
            this.btnResetTaoMH = new System.Windows.Forms.Button();
            this.btnLuuMH = new System.Windows.Forms.Button();
            this.txtThemTenMH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbThemBM = new System.Windows.Forms.ComboBox();
            this.cbTimBM = new System.Windows.Forms.ComboBox();
            this.MAMONHOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMONHOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBOMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTimMH.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).BeginInit();
            this.gbThemMH.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTimMH
            // 
            this.gbTimMH.Controls.Add(this.cbTimBM);
            this.gbTimMH.Controls.Add(this.btnResetTim);
            this.gbTimMH.Controls.Add(this.btnTimMH);
            this.gbTimMH.Controls.Add(this.txtTimMH);
            this.gbTimMH.Controls.Add(this.label2);
            this.gbTimMH.Controls.Add(this.label1);
            this.gbTimMH.Location = new System.Drawing.Point(12, 12);
            this.gbTimMH.Name = "gbTimMH";
            this.gbTimMH.Size = new System.Drawing.Size(849, 147);
            this.gbTimMH.TabIndex = 0;
            this.gbTimMH.TabStop = false;
            this.gbTimMH.Text = "Tìm môn học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bộ môn";
            // 
            // txtTimMH
            // 
            this.txtTimMH.Location = new System.Drawing.Point(131, 50);
            this.txtTimMH.Name = "txtTimMH";
            this.txtTimMH.Size = new System.Drawing.Size(280, 26);
            this.txtTimMH.TabIndex = 2;
            // 
            // btnTimMH
            // 
            this.btnTimMH.Location = new System.Drawing.Point(637, 97);
            this.btnTimMH.Name = "btnTimMH";
            this.btnTimMH.Size = new System.Drawing.Size(75, 34);
            this.btnTimMH.TabIndex = 4;
            this.btnTimMH.Text = "Tìm";
            this.btnTimMH.UseVisualStyleBackColor = true;
            // 
            // btnResetTim
            // 
            this.btnResetTim.Location = new System.Drawing.Point(727, 97);
            this.btnResetTim.Name = "btnResetTim";
            this.btnResetTim.Size = new System.Drawing.Size(98, 34);
            this.btnResetTim.TabIndex = 5;
            this.btnResetTim.Text = "Làm lại";
            this.btnResetTim.UseVisualStyleBackColor = true;
            this.btnResetTim.Click += new System.EventHandler(this.btnResetTim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMonHoc);
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(849, 227);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin môn học";
            // 
            // dgvMonHoc
            // 
            this.dgvMonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMONHOC,
            this.TENMONHOC,
            this.TENBOMON});
            this.dgvMonHoc.Location = new System.Drawing.Point(0, 26);
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.RowTemplate.Height = 28;
            this.dgvMonHoc.Size = new System.Drawing.Size(849, 201);
            this.dgvMonHoc.TabIndex = 0;
            // 
            // gbThemMH
            // 
            this.gbThemMH.Controls.Add(this.cbThemBM);
            this.gbThemMH.Controls.Add(this.btnResetTaoMH);
            this.gbThemMH.Controls.Add(this.btnLuuMH);
            this.gbThemMH.Controls.Add(this.txtThemTenMH);
            this.gbThemMH.Controls.Add(this.label3);
            this.gbThemMH.Controls.Add(this.label4);
            this.gbThemMH.Location = new System.Drawing.Point(13, 410);
            this.gbThemMH.Name = "gbThemMH";
            this.gbThemMH.Size = new System.Drawing.Size(848, 164);
            this.gbThemMH.TabIndex = 2;
            this.gbThemMH.TabStop = false;
            this.gbThemMH.Text = "Thêm/Sửa môn học";
            this.gbThemMH.Enter += new System.EventHandler(this.gbThemMH_Enter);
            // 
            // btnResetTaoMH
            // 
            this.btnResetTaoMH.Location = new System.Drawing.Point(726, 96);
            this.btnResetTaoMH.Name = "btnResetTaoMH";
            this.btnResetTaoMH.Size = new System.Drawing.Size(98, 36);
            this.btnResetTaoMH.TabIndex = 11;
            this.btnResetTaoMH.Text = "Làm lại";
            this.btnResetTaoMH.UseVisualStyleBackColor = true;
            this.btnResetTaoMH.Click += new System.EventHandler(this.btnResetTaoMH_Click);
            // 
            // btnLuuMH
            // 
            this.btnLuuMH.Location = new System.Drawing.Point(636, 96);
            this.btnLuuMH.Name = "btnLuuMH";
            this.btnLuuMH.Size = new System.Drawing.Size(75, 36);
            this.btnLuuMH.TabIndex = 10;
            this.btnLuuMH.Text = "Lưu";
            this.btnLuuMH.UseVisualStyleBackColor = true;
            this.btnLuuMH.Click += new System.EventHandler(this.btnLuuMH_Click);
            // 
            // txtThemTenMH
            // 
            this.txtThemTenMH.Location = new System.Drawing.Point(130, 51);
            this.txtThemTenMH.Name = "txtThemTenMH";
            this.txtThemTenMH.Size = new System.Drawing.Size(280, 26);
            this.txtThemTenMH.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bộ môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên môn học";
            // 
            // cbThemBM
            // 
            this.cbThemBM.FormattingEnabled = true;
            this.cbThemBM.Location = new System.Drawing.Point(547, 49);
            this.cbThemBM.Name = "cbThemBM";
            this.cbThemBM.Size = new System.Drawing.Size(277, 28);
            this.cbThemBM.TabIndex = 12;
            this.cbThemBM.SelectedIndexChanged += new System.EventHandler(this.txtThemBoMon_SelectedIndexChanged);
            // 
            // cbTimBM
            // 
            this.cbTimBM.FormattingEnabled = true;
            this.cbTimBM.Location = new System.Drawing.Point(548, 44);
            this.cbTimBM.Name = "cbTimBM";
            this.cbTimBM.Size = new System.Drawing.Size(277, 28);
            this.cbTimBM.TabIndex = 6;
            // 
            // MAMONHOC
            // 
            this.MAMONHOC.DataPropertyName = "MAMONHOC";
            this.MAMONHOC.HeaderText = "Mã môn học";
            this.MAMONHOC.Name = "MAMONHOC";
            this.MAMONHOC.Width = 120;
            // 
            // TENMONHOC
            // 
            this.TENMONHOC.DataPropertyName = "TENMONHOC";
            this.TENMONHOC.HeaderText = "Tên môn học";
            this.TENMONHOC.Name = "TENMONHOC";
            this.TENMONHOC.Width = 200;
            // 
            // TENBOMON
            // 
            this.TENBOMON.DataPropertyName = "TENBOMON";
            this.TENBOMON.HeaderText = "Tên bộ môn";
            this.TENBOMON.Name = "TENBOMON";
            this.TENBOMON.Width = 180;
            // 
            // FrmQuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 587);
            this.Controls.Add(this.gbThemMH);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbTimMH);
            this.Name = "FrmQuanLyMonHoc";
            this.Text = "FrmQuanLyMonHoc";
            this.Load += new System.EventHandler(this.FrmQuanLyMonHoc_Load);
            this.gbTimMH.ResumeLayout(false);
            this.gbTimMH.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonHoc)).EndInit();
            this.gbThemMH.ResumeLayout(false);
            this.gbThemMH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTimMH;
        private System.Windows.Forms.TextBox txtTimMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResetTim;
        private System.Windows.Forms.Button btnTimMH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMonHoc;
        private System.Windows.Forms.GroupBox gbThemMH;
        private System.Windows.Forms.Button btnResetTaoMH;
        private System.Windows.Forms.Button btnLuuMH;
        private System.Windows.Forms.TextBox txtThemTenMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTimBM;
        private System.Windows.Forms.ComboBox cbThemBM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMONHOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMONHOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBOMON;
    }
}