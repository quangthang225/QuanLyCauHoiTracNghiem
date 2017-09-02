using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyKhoCauHoiTracNghiem
{
    public partial class FrmThemNguoiDung : Form
    {
        FrmQuanLyNguoiDung frmParent;
        long maND = -1;
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

        public FrmThemNguoiDung(FrmQuanLyNguoiDung frm, long maND)
        {
            InitializeComponent();
            this.maND = maND;
            this.frmParent = frm;
            button1.Text = "Cập nhật";
            this.Text = "Cập nhật thông tin người dùng";
            cboLoaiND.DataSource = LOAINGUOIDUNGBUS.LayDanhSachLoaiNguoiDung();
            cboLoaiND.ValueMember = "MALOAI";
            cboLoaiND.DisplayMember = "TENLOAIND";

            cboTenBM.DataSource = BOMONBUS.LayDanhSachBoMon();
            cboTenBM.ValueMember = "MABM";
            cboTenBM.DisplayMember = "TENBM";

            cboTrangThai.Items.Add("Mở");
            cboTrangThai.Items.Add("Khóa");
            cboTrangThai.SelectedIndex = 0;

            NGUOIDUNGDTO d = NGUOIDUNGBUS.LayNguoiDung(this.maND);
            txtHoTen.Text = d.HOTEN;
            txtTenDangNhap.Text = d.TENDANGNHAP;
            cbToanQuyen.Checked = d.TOANQUYENGV;
            cboLoaiND.SelectedValue = d.MALOAI;
            cboTenBM.SelectedValue = d.MABM;
            cboTrangThai.SelectedValue = d.TRANGTHAI;

            cboTenGVQL.DataSource = NGUOIDUNGBUS.LayDanhSachGiaoVienQuanLy();
            cboTenGVQL.ValueMember = "MaND";
            cboTenGVQL.DisplayMember = "HoTen";
            cboTenGVQL.SelectedValue = d.MAGVQL;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string hoTen = txtHoTen.Text;
            string tenDangNhap = txtTenDangNhap.Text;
            
            bool trangThai = (bool)(cboTrangThai.SelectedIndex == 0 ? true : false);
            bool toanQuyen = cbToanQuyen.Checked;
            long maLoai = (long)cboLoaiND.SelectedValue;
            long maBM = (long)cboTenBM.SelectedValue;
            long maGVQL = (long)cboTenGVQL.SelectedValue;
            if (this.maND == -1)
            {
                string matKhau = txtTenDangNhap.Text;
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
            else
            {
                int result = NGUOIDUNGBUS.CapNhatThongTin(this.maND, hoTen, tenDangNhap, trangThai, toanQuyen, maLoai, maBM, maGVQL);
                switch (result)
                {
                    case 0:
                        MessageBox.Show("Câp nhật thành công");
                        frmParent.LoadNguoiDung();
                        this.Hide();
                        break;
                    case 1:
                        MessageBox.Show("Người dùng không tồn tại");
                        break;
                    case 2:
                        MessageBox.Show("Loại người dùng không tồn tại");
                        break;
                    case 3:
                        MessageBox.Show("Bộ môn không tồn tại");
                        break;
                    default:
                        MessageBox.Show("Có lỗi xảy ra! Xin vui lòng thử lại");
                        break;
                }
            }
        }
    }
}
