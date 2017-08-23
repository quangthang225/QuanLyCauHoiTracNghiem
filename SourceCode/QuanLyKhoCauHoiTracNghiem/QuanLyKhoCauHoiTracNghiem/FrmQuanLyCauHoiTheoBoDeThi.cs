using BUS;
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (dgvCauHoi.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn câu hỏi để thêm vào đề thi");
                return;
            }

            DataGridViewSelectedRowCollection selectedRows = dgvCauHoi.SelectedRows;
            for (int i = 0; i < dgvCauHoi.SelectedRows.Count; i++)
            {
                int selectedIndex = dgvCauHoi.SelectedRows[i].Index;
                long maCauHoi = Convert.ToInt64(dgvCauHoi.Rows[selectedIndex].Cells[0].Value);
                double thangDiem = Convert.ToInt64(dgvCauHoi.Rows[selectedIndex].Cells[2].Value);
                CAUHOIBUS.ThemCauHoiVaoDeThi(_madethi, maCauHoi,thangDiem);
            }
            LoadData();
       }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvCauHoiTheoDeThi.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn câu hỏi để di chuyển khỏi đề thi");
                return;
            }

            DataGridViewSelectedRowCollection selectedRows = dgvCauHoi.SelectedRows;
            for (int i = 0; i < dgvCauHoiTheoDeThi.SelectedRows.Count; i++)
            {
                int selectedIndex = dgvCauHoiTheoDeThi.SelectedRows[i].Index;
                long maCauHoi = Convert.ToInt64(dgvCauHoiTheoDeThi.Rows[selectedIndex].Cells[0].Value);
                CAUHOIBUS.DiChuyenCauHoiRaKhoiBoDeThi(_madethi, maCauHoi);
            }
            LoadData();
        }
    }
}
