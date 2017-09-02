using BUS;
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
    public partial class FrmQuanLyBoMon : Form
    {
        public FrmQuanLyBoMon()
        {
            InitializeComponent();
        }

        private void FrmQuanLyBoMon_Load(object sender, EventArgs e)
        {
            LoadBoMon();
        }

        private void LoadBoMon()
        {
            dgvBoMon.DataSource = BOMONBUS.LayDanhSachBoMon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenBM = txtTenBM.Text;
            bool result = BOMONBUS.ThemBoMon(tenBM);
            if (result)
            {
                MessageBox.Show("Thêm thành công");
                LoadBoMon();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvBoMon.CurrentCell.OwningRow;
            string maBM = row.Cells["MaBM"].Value.ToString();
            bool result = BOMONBUS.XoaBoMon(long.Parse(maBM));
            if (result)
            {
                MessageBox.Show("Xóa thành công");
                LoadBoMon();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
