namespace QuanLyKhoCauHoiTracNghiem
{
    partial class FrmQuanLyCauHoiTheoBoDeThi
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
            this.dgvCauHoi = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvCauHoiTheoDeThi = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANGDIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOCAUTRALOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MUCDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoiTheoDeThi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCauHoi);
            this.groupBox1.Location = new System.Drawing.Point(9, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách câu hỏi thuộc môn học : ";
            // 
            // dgvCauHoi
            // 
            this.dgvCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvCauHoi.Location = new System.Drawing.Point(9, 19);
            this.dgvCauHoi.Name = "dgvCauHoi";
            this.dgvCauHoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCauHoi.Size = new System.Drawing.Size(464, 350);
            this.dgvCauHoi.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(500, 160);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(46, 32);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = ">>";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(500, 198);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(46, 32);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "<<";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCauHoiTheoDeThi);
            this.groupBox2.Location = new System.Drawing.Point(552, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(485, 366);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách câu hỏi có trong đề thi :";
            // 
            // dgvCauHoiTheoDeThi
            // 
            this.dgvCauHoiTheoDeThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCauHoiTheoDeThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOIDUNG,
            this.THANGDIEM,
            this.SOCAUTRALOI,
            this.MUCDO});
            this.dgvCauHoiTheoDeThi.Location = new System.Drawing.Point(9, 19);
            this.dgvCauHoiTheoDeThi.Name = "dgvCauHoiTheoDeThi";
            this.dgvCauHoiTheoDeThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCauHoiTheoDeThi.Size = new System.Drawing.Size(464, 341);
            this.dgvCauHoiTheoDeThi.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NOIDUNG";
            this.Column1.HeaderText = "Nội dung";
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "THANGDIEM";
            this.Column2.HeaderText = "Thang điểm";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SOCAUTRALOI";
            this.Column3.HeaderText = "Số câu trả lời";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MUCDO";
            this.Column4.HeaderText = "Mức độ";
            this.Column4.Name = "Column4";
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.DataPropertyName = "NOIDUNG";
            this.NOIDUNG.HeaderText = "Nội dung";
            this.NOIDUNG.Name = "NOIDUNG";
            this.NOIDUNG.Width = 180;
            // 
            // THANGDIEM
            // 
            this.THANGDIEM.DataPropertyName = "THANGDIEM";
            this.THANGDIEM.HeaderText = "Thang điểm";
            this.THANGDIEM.Name = "THANGDIEM";
            this.THANGDIEM.Width = 70;
            // 
            // SOCAUTRALOI
            // 
            this.SOCAUTRALOI.DataPropertyName = "SOCAUTRALOI";
            this.SOCAUTRALOI.HeaderText = "Số câu trả lời";
            this.SOCAUTRALOI.Name = "SOCAUTRALOI";
            this.SOCAUTRALOI.Width = 70;
            // 
            // MUCDO
            // 
            this.MUCDO.DataPropertyName = "MUCDO";
            this.MUCDO.HeaderText = "Mức độ";
            this.MUCDO.Name = "MUCDO";
            // 
            // FrmQuanLyCauHoiTheoBoDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 385);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmQuanLyCauHoiTheoBoDeThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý câu hỏi theo bộ đề thi";
            this.Load += new System.EventHandler(this.FrmQuanLyCauHoiTheoBoDeThi_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoi)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCauHoiTheoDeThi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCauHoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCauHoiTheoDeThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANGDIEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOCAUTRALOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUCDO;
    }
}