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
        }

        private void gbThemMH_Enter(object sender, EventArgs e)
        {

        }

        public void LoadMonHoc()
        {
            dgvMonHoc.DataSource = MONHOCBUS.LayDanhSachMonHoc();
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
        }

        private void btnResetTaoMH_Click(object sender, EventArgs e)
        {
            cbThemBM.SelectedIndex = -1;
            txtThemTenMH.Text = "";
        }

        private void btnLuuMH_Click(object sender, EventArgs e)
        {
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
                MessageBox.Show("Đã tồn tại môn học trong hệ thống. Thêm thất bại");
            }
            else
            {
                MessageBox.Show("Thêm môn học thất bại");
            }
        }
    }
}
