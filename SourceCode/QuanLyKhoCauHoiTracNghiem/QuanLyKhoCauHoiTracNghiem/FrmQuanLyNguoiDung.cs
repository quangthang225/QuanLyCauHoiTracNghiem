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
    public partial class FrmQuanLyNguoiDung : Form
    {
        public FrmQuanLyNguoiDung()
        {
            InitializeComponent();
            dgvNguoiDung.AutoGenerateColumns = false;
            dgvNguoiDung.AllowUserToAddRows = false;

        }

        private void FrmQuanLyNguoiDung_Load(object sender, EventArgs e)
        {
            try
            {
                LoadNguoiDung();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        public void LoadNguoiDung()
        {
            dgvNguoiDung.DataSource = NGUOIDUNGBUS.LayDanhSachNguoiDung();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            FrmThemNguoiDung frm = new FrmThemNguoiDung(this);
            Form f = (Form)frm;
            f.Show();
            f.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNguoiDung.CurrentCell.OwningRow;
            string maND = row.Cells["MaND"].Value.ToString();
            FrmThemNguoiDung frm = new FrmThemNguoiDung(this, long.Parse(maND));
            Form f = (Form)frm;
            f.Show();
            f.Focus();
        }

        private void dgvNguoiDung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNguoiDung.CurrentCell.RowIndex >=0)
            {
                txtCapNhat.Enabled = true;
            }
            else
            {
                txtCapNhat.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNguoiDung.CurrentCell.OwningRow;
            string maND = row.Cells["MaND"].Value.ToString();
            bool result = NGUOIDUNGBUS.XoaNguoiDung(long.Parse(maND));
            if (result)
            {
                
                MessageBox.Show("Xóa thành công");
                LoadNguoiDung();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra! Xin vui lòng thử lại");
            }
        }

        private void bntThayDoiGVQL_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvNguoiDung.CurrentCell.OwningRow;
            string maND = row.Cells["MaND"].Value.ToString();
            FrmThayDoiGVQL frm = new FrmThayDoiGVQL(this, long.Parse(maND));
            Form f = (Form)frm;
            f.Show();
            f.Focus();
        }
    }
}
