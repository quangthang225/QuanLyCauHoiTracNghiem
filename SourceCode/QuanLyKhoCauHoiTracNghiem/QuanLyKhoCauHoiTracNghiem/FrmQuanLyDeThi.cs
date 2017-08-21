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
using Utilities;

namespace QuanLyKhoCauHoiTracNghiem
{
    public partial class FrmQuanLyDeThi : Form
    {
        public FrmQuanLyDeThi()
        {
            InitializeComponent();
        }

        private void FrmQuanLyDeThi_Load(object sender, EventArgs e)
        {
            LayDanhSachBoDeThi();
        }

        private void LayDanhSachBoDeThi()
        {
            var lst = DETHIBUS.LayDanhSachBoDeThi();
            dgvDeThi.DataSource = lst;
            dgvDeThi.Columns["MAGVTAO"].Visible = false;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            DETHIDTO d = new DETHIDTO(txtTenDeThi.Text.TrimEnd(),Convert.ToInt32(txtHocKy.Value), Convert.ToInt32(txtNamHoc.Value), Common.MaNguoiDungDangNhap);
            bool rs = DETHIBUS.ThemBoDeThi(d);
            if (rs)
            {
                LayDanhSachBoDeThi();
            }
            else
            {
                MessageBox.Show("Thêm bộ đề thi thất bại");
            }
        }

        private void dgvDeThi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeThi.SelectedRows.Count < 0)
            {
                return;
            }
            int selectedIndex = dgvDeThi.SelectedRows[0].Index;
            txtTenDeThi.Text = dgvDeThi.Rows[selectedIndex].Cells["TENBDT"].Value.ToString();
            txtHocKy.Value = Convert.ToInt32(dgvDeThi.Rows[selectedIndex].Cells["HOCKY"].Value);
            txtNamHoc.Value = Convert.ToInt32(dgvDeThi.Rows[selectedIndex].Cells["NAMHOC"].Value);
        }
    }
}
