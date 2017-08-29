using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using Utilities;

namespace QuanLyKhoCauHoiTracNghiem
{
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            long maNguoiDung;
            bool rs = NGUOIDUNGBUS.DangNhap(tenDangNhap, matKhau, out maNguoiDung);
            if (rs == true)
            {
                Common.MaNguoiDungDangNhap = maNguoiDung;
                Common.TenTaiKhoanDangNhap = tenDangNhap;
                this.Hide();
                
                //FrmMain f = new FrmMain();
                //f.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
