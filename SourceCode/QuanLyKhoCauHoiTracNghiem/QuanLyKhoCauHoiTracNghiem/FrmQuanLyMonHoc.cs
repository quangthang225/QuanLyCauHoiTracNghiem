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
    public partial class FrmQuanLyMonHoc : Form
    {
        public FrmQuanLyMonHoc()
        {
            InitializeComponent();
            dgvMonHoc.AutoGenerateColumns = false;
            dgvMonHoc.AllowUserToAddRows = false;
            dgvMonHoc.DataSource = null;
        }

        private void gbThemMH_Enter(object sender, EventArgs e)
        {

        }

        public void LoadMonHoc()
        {
            dgvMonHoc.DataSource = MONHOCBUS.LayDanhSachMonHoc("", 0);
        }
        public void LoadBoMon()
        {
            var data = BOMONBUS.LayDanhSachBoMon();

            cbTimBM.ValueMember = "MABM";
            cbTimBM.DisplayMember = "TENBM";
            cbTimBM.DataSource = BOMONBUS.LayDanhSachBoMon();
            cbTimBM.SelectedIndex = -1;

            cbThemBM.ValueMember = "MABM";
            cbThemBM.DisplayMember = "TENBM";
            cbThemBM.DataSource = BOMONBUS.LayDanhSachBoMon();
            cbThemBM.SelectedIndex = -1;
        }

        private void txtThemBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            try
            {
                cbThemBM.DropDownStyle = ComboBoxStyle.DropDownList;
                cbTimBM.DropDownStyle = ComboBoxStyle.DropDownList;
                LoadMonHoc();
                LoadBoMon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnResetTim_Click(object sender, EventArgs e)
        {
            cbTimBM.SelectedIndex = -1;
            txtTimMH.Text = "";
            dgvMonHoc.DataSource = MONHOCBUS.LayDanhSachMonHoc("", 0);
        }

        private void btnResetTaoMH_Click(object sender, EventArgs e)
        {
            ckbIsNew.Checked = true;
            btnXoaMonHoc.Enabled = false;
            cbThemBM.SelectedIndex = -1;
            txtThemTenMH.Text = "";
        }

        private void btnLuuMH_Click(object sender, EventArgs e)
        {
            if (ckbIsNew.Checked)
            {
                //Tạo mới môn học
                if (txtThemTenMH.Text.TrimEnd() == "")
                {
                    MessageBox.Show("Tên môn học là bắt buộc!");
                    return;
                }
                if (cbThemBM.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn bộ môn!");
                    return;
                }
                long maBM = ((BOMONDTO)cbThemBM.SelectedItem).MABM;
                MONHOCDTO d = new MONHOCDTO();
                d.MABOMON = maBM;
                d.TENMONHOC = txtThemTenMH.Text.TrimEnd();
                int rs = MONHOCBUS.ThemMonHoc(d);
                if (rs == 1)
                {
                    MessageBox.Show("Thêm môn học thành công");
                    LoadMonHoc();
                }
                else if (rs == 2)
                {
                    MessageBox.Show("Bộ môn không tồn tại");
                }
                else if (rs == 3)
                {
                    MessageBox.Show("Tên môn học không hợp lệ.");
                }
                else
                {
                    MessageBox.Show("Thêm môn học thất bại");
                }
            }else
            {
                //Cập nhật môn học
                if (txtThemTenMH.Text.TrimEnd() == "")
                {
                    MessageBox.Show("Tên môn học là bắt buộc!"); ;
                    return;
                }
                if (cbThemBM.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn bộ môn!");
                    return;
                }
                int selectedIndex = dgvMonHoc.SelectedRows[0].Index;
                long maMH = (long)dgvMonHoc.Rows[selectedIndex].Cells["MAMH"].Value;
                long maBM = ((BOMONDTO)cbThemBM.SelectedItem).MABM;
                MONHOCDTO d = new MONHOCDTO();
                d.MAMONHOC = maMH;
                d.MABOMON = maBM;
                d.TENMONHOC = txtThemTenMH.Text.TrimEnd();
                int rs = MONHOCBUS.CapNhatMonHoc(d);
                if (rs == 1)
                {
                    MessageBox.Show("Cập nhật môn học thành công");
                    LoadMonHoc();
                }
                else if (rs == 2)
                {
                    MessageBox.Show("Môn học không tồn tại");
                }
                else if (rs == 4)
                {
                    MessageBox.Show("Bộ môn không tồn tại");
                }
                else if (rs == 3)
                {
                    MessageBox.Show("Tên môn học không hợp lệ.");
                }
                else
                {
                    MessageBox.Show("Cập nhật môn học thất bại");
                }
            }

            
        }

        private void btnTimMH_Click(object sender, EventArgs e)
        {
            string tenmh = "";
            long maBM = 0;
            if (txtTimMH.Text != "")
            {
                tenmh = txtTimMH.Text;
            }

            if (cbTimBM.SelectedIndex != -1)
            {
                maBM = ((BOMONDTO)cbTimBM.SelectedItem).MABM;
            }
            dgvMonHoc.DataSource = MONHOCBUS.LayDanhSachMonHoc(tenmh, maBM);
        }

        private void dgvMonHoc_SelectionChanged(object sender, EventArgs e)
        {
            ckbIsNew.Checked = false;
            btnXoaMonHoc.Enabled = true;
            if (dgvMonHoc.SelectedRows.Count < 1)
            {
                return;
            }

            int selectedIndex = dgvMonHoc.SelectedRows[0].Index;
            if(dgvMonHoc.Rows[selectedIndex].Cells["TENBM"].Value != null)
            {
                txtThemTenMH.Text = dgvMonHoc.Rows[selectedIndex].Cells["TENMH"].Value.ToString();
            }
        }

        private void btnXoaMonHoc_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa môn học này?", "Xóa môn học", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int selectedIndex = dgvMonHoc.SelectedRows[0].Index;
                long maMH = (long)dgvMonHoc.Rows[selectedIndex].Cells["MAMH"].Value;
                int rs = MONHOCBUS.XoaMonHoc(maMH);
                if (rs == 1)
                {
                    MessageBox.Show("Xóa môn học thành công");
                    LoadMonHoc();
                }else if(rs == 2)
                {
                    MessageBox.Show("Môn học không tồn tại");
                }
                else {
                    MessageBox.Show("Xóa môn học thất bại");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void dgvMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
