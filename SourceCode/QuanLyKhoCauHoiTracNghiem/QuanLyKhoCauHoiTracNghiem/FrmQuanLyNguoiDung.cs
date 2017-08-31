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

        private void LoadNguoiDung()
        {
            dgvNguoiDung.DataSource = NGUOIDUNGBUS.LayDanhSachNguoiDung();
        }
    }
}
