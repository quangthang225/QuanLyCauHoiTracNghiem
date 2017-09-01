using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;

namespace QuanLyKhoCauHoiTracNghiem
{
    public partial class FrmThemNguoiDung : Form
    {
        FrmQuanLyNguoiDung frmParent;
        public FrmThemNguoiDung()
        {
            InitializeComponent();
        }

        public FrmThemNguoiDung(FrmQuanLyNguoiDung frm)
        {
            InitializeComponent();
            this.frmParent = frm;
            button1.Text = "Thêm";
            this.Text = "Thêm người dùng mới";
            cboLoaiND.DataSource = LOAINGUOIDUNGBUS.LayDanhSachLoaiNguoiDung();
            cboLoaiND.ValueMember = "MALOAI";
            cboLoaiND.DisplayMember = "TENLOAIND";

            cboTenBM.DataSource = BOMONBUS.LayDanhSachBoMon();
            cboTenBM.ValueMember = "MABM";
            cboTenBM.DisplayMember = "TENBM";

            cboTenGVQL.DataSource = NGUOIDUNGBUS.LayDanhSachGiaoVienQuanLy();
            cboTenGVQL.ValueMember = "MAND";
            cboTenGVQL.DisplayMember = "HOTEN";

            cboTrangThai.Items.Add("Mở");
            cboTrangThai.Items.Add("Khóa");
            cboTrangThai.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtTenDangNhap.Text;
            bool trangThai = (bool)(cboTrangThai.SelectedIndex == 0 ? true : false);
            bool toanQuyen = cbToanQuyen.Checked;
            long maLoai = (long)cboLoaiND.SelectedValue;
            long maBM = (long)cboTenBM.SelectedValue;
            long maGVQL = (long)cboTenGVQL.SelectedValue;
            bool result = NGUOIDUNGBUS.ThemNguoiDung(hoTen, tenDangNhap, matKhau, trangThai, toanQuyen, maLoai, maBM, maGVQL);
            if (result)
            {
                MessageBox.Show("Thêm thành công");
                frmParent.LoadNguoiDung();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra! Xin vui lòng thử lại");
            }
        }

        private void cboLoaiND_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }
    }
}
