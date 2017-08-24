namespace QuanLyKhoCauHoiTracNghiem
{
    partial class FrmQuanLyCauHoi
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCauHoi = new System.Windows.Forms.DataGridView();
            this.gbCauTraLoi = new System.Windows.Forms.GroupBox();
            this.dgvCauTraLoi = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoiDungCauHoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThangDiemCauHoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMucDoCauHoi = new System.Windows.Forms.ComboBox();
            this.btnThemCauHoi = new System.Windows.Forms.Button();
            this.btnCapNhatCauHoi = new System.Windows.Forms.Button();
            this.btnXoaCauHoi = new System.Windows.Forms.Button();
            this.txtNoiDungCauTL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkLaDapAnDung = new System.Windows.Forms.CheckBox();
            this.btnXoaCauTL = new System.Windows.Forms.Button();
            this.btnCapNhatCauTL = new System.Windows.Forms.Button();
            this.btnThemCauTL = new System.Windows.Forms.Button();
            this.cboMonHoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANGDIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOCAUTRALOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUCDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAMONHOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIDUNGCTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LADAPANDUNG = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).BeginInit();
            this.gbCauTraLoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauTraLoi)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCauHoi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách câu hỏi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboMonHoc);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnXoaCauHoi);
            this.groupBox2.Controls.Add(this.btnCapNhatCauHoi);
            this.groupBox2.Controls.Add(this.btnThemCauHoi);
            this.groupBox2.Controls.Add(this.cboMucDoCauHoi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtThangDiemCauHoi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtNoiDungCauHoi);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin câu hỏi";
            // 
            // dgvCauHoi
            // 
            this.dgvCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACH,
            this.NOIDUNG,
            this.THANGDIEM,
            this.SOCAUTRALOI,
            this.MUCDO,
            this.MAMONHOC,
            this.TENMH});
            this.dgvCauHoi.Location = new System.Drawing.Point(8, 19);
            this.dgvCauHoi.MultiSelect = false;
            this.dgvCauHoi.Name = "dgvCauHoi";
            this.dgvCauHoi.ReadOnly = true;
            this.dgvCauHoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCauHoi.Size = new System.Drawing.Size(544, 215);
            this.dgvCauHoi.TabIndex = 0;
            this.dgvCauHoi.SelectionChanged += new System.EventHandler(this.dgvCauHoi_SelectionChanged);
            // 
            // gbCauTraLoi
            // 
            this.gbCauTraLoi.Controls.Add(this.dgvCauTraLoi);
            this.gbCauTraLoi.Location = new System.Drawing.Point(579, 12);
            this.gbCauTraLoi.Name = "gbCauTraLoi";
            this.gbCauTraLoi.Size = new System.Drawing.Size(362, 240);
            this.gbCauTraLoi.TabIndex = 2;
            this.gbCauTraLoi.TabStop = false;
            this.gbCauTraLoi.Text = "Danh sách câu trả lời cho câu hỏi :";
            // 
            // dgvCauTraLoi
            // 
            this.dgvCauTraLoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauTraLoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MACTL,
            this.NOIDUNGCTL,
            this.LADAPANDUNG,
            this.Column1});
            this.dgvCauTraLoi.Location = new System.Drawing.Point(6, 19);
            this.dgvCauTraLoi.MultiSelect = false;
            this.dgvCauTraLoi.Name = "dgvCauTraLoi";
            this.dgvCauTraLoi.ReadOnly = true;
            this.dgvCauTraLoi.Size = new System.Drawing.Size(346, 215);
            this.dgvCauTraLoi.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnXoaCauTL);
            this.groupBox4.Controls.Add(this.btnCapNhatCauTL);
            this.groupBox4.Controls.Add(this.chkLaDapAnDung);
            this.groupBox4.Controls.Add(this.btnThemCauTL);
            this.groupBox4.Controls.Add(this.txtNoiDungCauTL);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(579, 257);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(361, 108);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin câu trả lời";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội dung";
            // 
            // txtNoiDungCauHoi
            // 
            this.txtNoiDungCauHoi.Location = new System.Drawing.Point(98, 20);
            this.txtNoiDungCauHoi.Name = "txtNoiDungCauHoi";
            this.txtNoiDungCauHoi.Size = new System.Drawing.Size(454, 20);
            this.txtNoiDungCauHoi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thang điểm";
            // 
            // txtThangDiemCauHoi
            // 
            this.txtThangDiemCauHoi.Location = new System.Drawing.Point(98, 51);
            this.txtThangDiemCauHoi.Name = "txtThangDiemCauHoi";
            this.txtThangDiemCauHoi.Size = new System.Drawing.Size(100, 20);
            this.txtThangDiemCauHoi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mức độ";
            // 
            // cboMucDoCauHoi
            // 
            this.cboMucDoCauHoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMucDoCauHoi.FormattingEnabled = true;
            this.cboMucDoCauHoi.Items.AddRange(new object[] {
            "Dễ",
            "Vừa",
            "Khó"});
            this.cboMucDoCauHoi.Location = new System.Drawing.Point(263, 50);
            this.cboMucDoCauHoi.Name = "cboMucDoCauHoi";
            this.cboMucDoCauHoi.Size = new System.Drawing.Size(100, 21);
            this.cboMucDoCauHoi.TabIndex = 5;
            // 
            // btnThemCauHoi
            // 
            this.btnThemCauHoi.Location = new System.Drawing.Point(312, 78);
            this.btnThemCauHoi.Name = "btnThemCauHoi";
            this.btnThemCauHoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemCauHoi.TabIndex = 6;
            this.btnThemCauHoi.Text = "Thêm";
            this.btnThemCauHoi.UseVisualStyleBackColor = true;
            this.btnThemCauHoi.Click += new System.EventHandler(this.btnThemCauHoi_Click);
            // 
            // btnCapNhatCauHoi
            // 
            this.btnCapNhatCauHoi.Location = new System.Drawing.Point(396, 78);
            this.btnCapNhatCauHoi.Name = "btnCapNhatCauHoi";
            this.btnCapNhatCauHoi.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatCauHoi.TabIndex = 7;
            this.btnCapNhatCauHoi.Text = "Cập nhật";
            this.btnCapNhatCauHoi.UseVisualStyleBackColor = true;
            // 
            // btnXoaCauHoi
            // 
            this.btnXoaCauHoi.Location = new System.Drawing.Point(477, 78);
            this.btnXoaCauHoi.Name = "btnXoaCauHoi";
            this.btnXoaCauHoi.Size = new System.Drawing.Size(75, 23);
            this.btnXoaCauHoi.TabIndex = 8;
            this.btnXoaCauHoi.Text = "Xóa";
            this.btnXoaCauHoi.UseVisualStyleBackColor = true;
            // 
            // txtNoiDungCauTL
            // 
            this.txtNoiDungCauTL.Location = new System.Drawing.Point(101, 21);
            this.txtNoiDungCauTL.Name = "txtNoiDungCauTL";
            this.txtNoiDungCauTL.Size = new System.Drawing.Size(251, 20);
            this.txtNoiDungCauTL.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nội dung";
            // 
            // chkLaDapAnDung
            // 
            this.chkLaDapAnDung.AutoSize = true;
            this.chkLaDapAnDung.Location = new System.Drawing.Point(101, 55);
            this.chkLaDapAnDung.Name = "chkLaDapAnDung";
            this.chkLaDapAnDung.Size = new System.Drawing.Size(89, 17);
            this.chkLaDapAnDung.TabIndex = 12;
            this.chkLaDapAnDung.Text = "Đáp án đúng";
            this.chkLaDapAnDung.UseVisualStyleBackColor = true;
            // 
            // btnXoaCauTL
            // 
            this.btnXoaCauTL.Location = new System.Drawing.Point(277, 79);
            this.btnXoaCauTL.Name = "btnXoaCauTL";
            this.btnXoaCauTL.Size = new System.Drawing.Size(75, 23);
            this.btnXoaCauTL.TabIndex = 11;
            this.btnXoaCauTL.Text = "Xóa";
            this.btnXoaCauTL.UseVisualStyleBackColor = true;
            // 
            // btnCapNhatCauTL
            // 
            this.btnCapNhatCauTL.Location = new System.Drawing.Point(196, 79);
            this.btnCapNhatCauTL.Name = "btnCapNhatCauTL";
            this.btnCapNhatCauTL.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatCauTL.TabIndex = 10;
            this.btnCapNhatCauTL.Text = "Cập nhật";
            this.btnCapNhatCauTL.UseVisualStyleBackColor = true;
            // 
            // btnThemCauTL
            // 
            this.btnThemCauTL.Location = new System.Drawing.Point(112, 79);
            this.btnThemCauTL.Name = "btnThemCauTL";
            this.btnThemCauTL.Size = new System.Drawing.Size(75, 23);
            this.btnThemCauTL.TabIndex = 9;
            this.btnThemCauTL.Text = "Thêm";
            this.btnThemCauTL.UseVisualStyleBackColor = true;
            this.btnThemCauTL.Click += new System.EventHandler(this.btnThemCauTL_Click);
            // 
            // cboMonHoc
            // 
            this.cboMonHoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMonHoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMonHoc.FormattingEnabled = true;
            this.cboMonHoc.Items.AddRange(new object[] {
            "Dễ",
            "Vừa",
            "Khó"});
            this.cboMonHoc.Location = new System.Drawing.Point(452, 50);
            this.cboMonHoc.Name = "cboMonHoc";
            this.cboMonHoc.Size = new System.Drawing.Size(100, 21);
            this.cboMonHoc.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Môn học";
            // 
            // MACH
            // 
            this.MACH.DataPropertyName = "MACH";
            this.MACH.HeaderText = "MACH";
            this.MACH.Name = "MACH";
            this.MACH.Visible = false;
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.DataPropertyName = "NOIDUNG";
            this.NOIDUNG.HeaderText = "Nội dung";
            this.NOIDUNG.Name = "NOIDUNG";
            // 
            // THANGDIEM
            // 
            this.THANGDIEM.DataPropertyName = "THANGDIEM";
            this.THANGDIEM.HeaderText = "Thang điểm";
            this.THANGDIEM.Name = "THANGDIEM";
            // 
            // SOCAUTRALOI
            // 
            this.SOCAUTRALOI.DataPropertyName = "SOCAUTRALOI";
            this.SOCAUTRALOI.HeaderText = "Số câu trả lời";
            this.SOCAUTRALOI.Name = "SOCAUTRALOI";
            // 
            // MUCDO
            // 
            this.MUCDO.DataPropertyName = "MUCDO";
            this.MUCDO.HeaderText = "Mức độ";
            this.MUCDO.Name = "MUCDO";
            // 
            // MAMONHOC
            // 
            this.MAMONHOC.DataPropertyName = "MAMH";
            this.MAMONHOC.HeaderText = "MAMONHOC";
            this.MAMONHOC.Name = "MAMONHOC";
            this.MAMONHOC.Visible = false;
            // 
            // TENMH
            // 
            this.TENMH.DataPropertyName = "TENMH";
            this.TENMH.HeaderText = "Môn học";
            this.TENMH.Name = "TENMH";
            // 
            // MACTL
            // 
            this.MACTL.DataPropertyName = "MACTL";
            this.MACTL.HeaderText = "MACTL";
            this.MACTL.Name = "MACTL";
            this.MACTL.Visible = false;
            // 
            // NOIDUNGCTL
            // 
            this.NOIDUNGCTL.DataPropertyName = "NOIDUNG";
            this.NOIDUNGCTL.HeaderText = "Nội dung";
            this.NOIDUNGCTL.Name = "NOIDUNGCTL";
            this.NOIDUNGCTL.Width = 200;
            // 
            // LADAPANDUNG
            // 
            this.LADAPANDUNG.DataPropertyName = "LADAPANDUNG";
            this.LADAPANDUNG.HeaderText = "Đáp án đúng";
            this.LADAPANDUNG.Name = "LADAPANDUNG";
            this.LADAPANDUNG.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LADAPANDUNG.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MACH";
            this.Column1.HeaderText = "MACH";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // FrmQuanLyCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 370);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.gbCauTraLoi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQuanLyCauHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý câu hỏi";
            this.Load += new System.EventHandler(this.FrmQuanLyCauHoi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).EndInit();
            this.gbCauTraLoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauTraLoi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCauHoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboMonHoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoaCauHoi;
        private System.Windows.Forms.Button btnCapNhatCauHoi;
        private System.Windows.Forms.Button btnThemCauHoi;
        private System.Windows.Forms.ComboBox cboMucDoCauHoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtThangDiemCauHoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoiDungCauHoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCauTraLoi;
        private System.Windows.Forms.DataGridView dgvCauTraLoi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXoaCauTL;
        private System.Windows.Forms.Button btnCapNhatCauTL;
        private System.Windows.Forms.CheckBox chkLaDapAnDung;
        private System.Windows.Forms.Button btnThemCauTL;
        private System.Windows.Forms.TextBox txtNoiDungCauTL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANGDIEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOCAUTRALOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUCDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMONHOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIDUNGCTL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LADAPANDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}