﻿using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhoCauHoiTracNghiem
{
    public partial class FrmQuanLyCauHoiTheoBoDeThi : Form
    {
        public long _madethi;
        public string _tendethi;
        public long _maMonHoc;
        public string _tenMonHoc;
        public FrmQuanLyCauHoiTheoBoDeThi()
        {
            InitializeComponent();
            dgvCauHoi.AutoGenerateColumns = false;
            dgvCauHoi.AllowUserToAddRows = false;
            dgvCauHoiTheoDeThi.AutoGenerateColumns = false;
            dgvCauHoiTheoDeThi.AllowUserToAddRows = false;
        }

        private void FrmQuanLyCauHoiTheoBoDeThi_Load(object sender, EventArgs e)
        {
            groupBox1.Text = "Danh sách câu hỏi thuộc môn học: " + _tenMonHoc;
            groupBox2.Text = "Danh sách câu hỏi có trong đề thi: " + _tendethi;
            LoadData(); 
        }

        private void LoadData()
        {
            try
            {
                var lstCauHoiTheoMonHocChuaCoTrongDeThi = CAUHOIBUS.LayDanhSachCauHoiTheoMonHocChuaCoTrongDeThi(_maMonHoc,_madethi);
                dgvCauHoi.DataSource = lstCauHoiTheoMonHocChuaCoTrongDeThi;
                var lstCauHoiTheoDeThi = CAUHOIBUS.LayDanhSachCauHoiTheoDeThi(_madethi);
                dgvCauHoiTheoDeThi.DataSource = lstCauHoiTheoDeThi;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            
        }
    }
}
