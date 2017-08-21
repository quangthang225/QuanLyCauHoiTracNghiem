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
            dgvDeThi.AutoGenerateColumns = false;
            dgvDeThi.AllowUserToAddRows = false;
            dgvDeThi.Columns["MAGVTAO"].Visible = false;
        }

        private void FrmQuanLyDeThi_Load(object sender, EventArgs e)
        {
            LayDanhSachBoDeThi();
        }

        private void LayDanhSachBoDeThi()
        {
            try
            {
                var lst = DETHIBUS.LayDanhSachBoDeThi();
                dgvDeThi.DataSource = null;
                dgvDeThi.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            DETHIDTO d = new DETHIDTO(0,txtTenDeThi.Text.TrimEnd(), Convert.ToInt32(txtHocKy.Value), Convert.ToInt32(txtNamHoc.Value), Common.MaNguoiDungDangNhap);
            int rs = DETHIBUS.ThemBoDeThi(d);
            if (rs == 1)
            {
                LayDanhSachBoDeThi();
            }
            else if (rs == 2)
            {
                MessageBox.Show("Đã tồn tại tên bộ đề thi trong hệ thống. Thêm bộ đề thi thất bại");
            }
            else
            {
                MessageBox.Show("Thêm bộ đề thi thất bại");
            }
        }

        private void dgvDeThi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDeThi.SelectedRows.Count < 1)
            {
                return;
            }
            int selectedIndex = dgvDeThi.SelectedRows[0].Index;
            txtTenDeThi.Text = dgvDeThi.Rows[selectedIndex].Cells["TENBDT"].Value.ToString();
            txtHocKy.Value = Convert.ToInt32(dgvDeThi.Rows[selectedIndex].Cells["HOCKY"].Value);
            txtNamHoc.Value = Convert.ToInt32(dgvDeThi.Rows[selectedIndex].Cells["NAMHOC"].Value);
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (dgvDeThi.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn 1 đề thi cần cập nhật");
                return;
            }

            int selectedIndex = dgvDeThi.SelectedRows[0].Index;
            long maDeThi = Convert.ToInt64(dgvDeThi.Rows[selectedIndex].Cells["MABDT"].Value);
            DETHIDTO d = new DETHIDTO(maDeThi, txtTenDeThi.Text.TrimEnd(), (int)txtHocKy.Value, (int)txtNamHoc.Value, 0);
            bool rs = DETHIBUS.CapNhatBoDeThi(d);
            if (rs)
            {
                LayDanhSachBoDeThi();
            }
            else
            {
                MessageBox.Show("Cập nhật bộ đề thi thất bại");
            }
        }
    }
}
