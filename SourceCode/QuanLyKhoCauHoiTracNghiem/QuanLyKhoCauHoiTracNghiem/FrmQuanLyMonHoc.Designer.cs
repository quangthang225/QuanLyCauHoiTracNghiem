﻿namespace QuanLyKhoCauHoiTracNghiem
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
            this.cbTimBM = new System.Windows.Forms.ComboBox();
            this.btnResetTim = new System.Windows.Forms.Button();
            this.btnTimMH = new System.Windows.Forms.Button();
            this.txtTimMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMonHoc = new System.Windows.Forms.DataGridView();
            this.MAMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENBM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbThemMH = new System.Windows.Forms.GroupBox();
            this.btnXoaMonHoc = new System.Windows.Forms.Button();
            this.ckbIsNew = new System.Windows.Forms.CheckBox();
            this.cbThemBM = new System.Windows.Forms.ComboBox();
            this.btnResetTaoMH = new System.Windows.Forms.Button();
            this.btnLuuMH = new System.Windows.Forms.Button();
            this.txtThemTenMH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // cbTimBM
            // 
            this.cbTimBM.FormattingEnabled = true;
            this.cbTimBM.Location = new System.Drawing.Point(548, 44);
            this.cbTimBM.Name = "cbTimBM";
            this.cbTimBM.Size = new System.Drawing.Size(277, 28);
            this.cbTimBM.TabIndex = 6;
            // 
            // btnResetTim
            // 
            this.btnResetTim.Location = new System.Drawing.Point(710, 97);
            this.btnResetTim.Name = "btnResetTim";
            this.btnResetTim.Size = new System.Drawing.Size(115, 34);
            this.btnResetTim.TabIndex = 5;
            this.btnResetTim.Text = "Tìm tất cả";
            this.btnResetTim.UseVisualStyleBackColor = true;
            this.btnResetTim.Click += new System.EventHandler(this.btnResetTim_Click);
            // 
            // btnTimMH
            // 
            this.btnTimMH.Location = new System.Drawing.Point(619, 97);
            this.btnTimMH.Name = "btnTimMH";
            this.btnTimMH.Size = new System.Drawing.Size(75, 34);
            this.btnTimMH.TabIndex = 4;
            this.btnTimMH.Text = "Tìm";
            this.btnTimMH.UseVisualStyleBackColor = true;
            this.btnTimMH.Click += new System.EventHandler(this.btnTimMH_Click);
            // 
            // txtTimMH
            // 
            this.txtTimMH.Location = new System.Drawing.Point(131, 50);
            this.txtTimMH.Name = "txtTimMH";
            this.txtTimMH.Size = new System.Drawing.Size(280, 26);
            this.txtTimMH.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn học";
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
            this.MAMH,
            this.TENMH,
            this.TENBM});
            this.dgvMonHoc.Location = new System.Drawing.Point(0, 26);
            this.dgvMonHoc.MultiSelect = false;
            this.dgvMonHoc.Name = "dgvMonHoc";
            this.dgvMonHoc.ReadOnly = true;
            this.dgvMonHoc.RowTemplate.Height = 28;
            this.dgvMonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonHoc.Size = new System.Drawing.Size(849, 201);
            this.dgvMonHoc.TabIndex = 0;
            this.dgvMonHoc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMonHoc_CellContentClick);
            this.dgvMonHoc.SelectionChanged += new System.EventHandler(this.dgvMonHoc_SelectionChanged);
            // 
            // MAMH
            // 
            this.MAMH.DataPropertyName = "MAMONHOC";
            this.MAMH.HeaderText = "Mã môn học";
            this.MAMH.Name = "MAMH";
            this.MAMH.ReadOnly = true;
            this.MAMH.Width = 120;
            // 
            // TENMH
            // 
            this.TENMH.DataPropertyName = "TENMONHOC";
            this.TENMH.HeaderText = "Tên môn học";
            this.TENMH.Name = "TENMH";
            this.TENMH.ReadOnly = true;
            this.TENMH.Width = 200;
            // 
            // TENBM
            // 
            this.TENBM.DataPropertyName = "TENBOMON";
            this.TENBM.HeaderText = "Tên bộ môn";
            this.TENBM.Name = "TENBM";
            this.TENBM.ReadOnly = true;
            this.TENBM.Width = 180;
            // 
            // gbThemMH
            // 
            this.gbThemMH.Controls.Add(this.btnXoaMonHoc);
            this.gbThemMH.Controls.Add(this.ckbIsNew);
            this.gbThemMH.Controls.Add(this.cbThemBM);
            this.gbThemMH.Controls.Add(this.btnResetTaoMH);
            this.gbThemMH.Controls.Add(this.btnLuuMH);
            this.gbThemMH.Controls.Add(this.txtThemTenMH);
            this.gbThemMH.Controls.Add(this.label3);
            this.gbThemMH.Controls.Add(this.label4);
            this.gbThemMH.Location = new System.Drawing.Point(13, 410);
            this.gbThemMH.Name = "gbThemMH";
            this.gbThemMH.Size = new System.Drawing.Size(848, 196);
            this.gbThemMH.TabIndex = 2;
            this.gbThemMH.TabStop = false;
            this.gbThemMH.Text = "Thêm/Sửa môn học";
            this.gbThemMH.Enter += new System.EventHandler(this.gbThemMH_Enter);
            // 
            // btnXoaMonHoc
            // 
            this.btnXoaMonHoc.Enabled = false;
            this.btnXoaMonHoc.Location = new System.Drawing.Point(556, 137);
            this.btnXoaMonHoc.Name = "btnXoaMonHoc";
            this.btnXoaMonHoc.Size = new System.Drawing.Size(75, 36);
            this.btnXoaMonHoc.TabIndex = 14;
            this.btnXoaMonHoc.Text = "Xóa";
            this.btnXoaMonHoc.UseVisualStyleBackColor = true;
            this.btnXoaMonHoc.Click += new System.EventHandler(this.btnXoaMonHoc_Click);
            // 
            // ckbIsNew
            // 
            this.ckbIsNew.AutoSize = true;
            this.ckbIsNew.Checked = true;
            this.ckbIsNew.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbIsNew.Enabled = false;
            this.ckbIsNew.Location = new System.Drawing.Point(18, 47);
            this.ckbIsNew.Name = "ckbIsNew";
            this.ckbIsNew.Size = new System.Drawing.Size(91, 24);
            this.ckbIsNew.TabIndex = 13;
            this.ckbIsNew.Text = "Tạo mới";
            this.ckbIsNew.UseVisualStyleBackColor = true;
            // 
            // cbThemBM
            // 
            this.cbThemBM.FormattingEnabled = true;
            this.cbThemBM.Location = new System.Drawing.Point(556, 90);
            this.cbThemBM.Name = "cbThemBM";
            this.cbThemBM.Size = new System.Drawing.Size(277, 28);
            this.cbThemBM.TabIndex = 12;
            this.cbThemBM.SelectedIndexChanged += new System.EventHandler(this.txtThemBoMon_SelectedIndexChanged);
            // 
            // btnResetTaoMH
            // 
            this.btnResetTaoMH.Location = new System.Drawing.Point(735, 137);
            this.btnResetTaoMH.Name = "btnResetTaoMH";
            this.btnResetTaoMH.Size = new System.Drawing.Size(98, 36);
            this.btnResetTaoMH.TabIndex = 11;
            this.btnResetTaoMH.Text = "Làm lại";
            this.btnResetTaoMH.UseVisualStyleBackColor = true;
            this.btnResetTaoMH.Click += new System.EventHandler(this.btnResetTaoMH_Click);
            // 
            // btnLuuMH
            // 
            this.btnLuuMH.Location = new System.Drawing.Point(645, 137);
            this.btnLuuMH.Name = "btnLuuMH";
            this.btnLuuMH.Size = new System.Drawing.Size(75, 36);
            this.btnLuuMH.TabIndex = 10;
            this.btnLuuMH.Text = "Lưu";
            this.btnLuuMH.UseVisualStyleBackColor = true;
            this.btnLuuMH.Click += new System.EventHandler(this.btnLuuMH_Click);
            // 
            // txtThemTenMH
            // 
            this.txtThemTenMH.Location = new System.Drawing.Point(139, 92);
            this.txtThemTenMH.Name = "txtThemTenMH";
            this.txtThemTenMH.Size = new System.Drawing.Size(280, 26);
            this.txtThemTenMH.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bộ môn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên môn học";
            // 
            // FrmQuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 618);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENBM;
        private System.Windows.Forms.CheckBox ckbIsNew;
        private System.Windows.Forms.Button btnXoaMonHoc;
    }
}