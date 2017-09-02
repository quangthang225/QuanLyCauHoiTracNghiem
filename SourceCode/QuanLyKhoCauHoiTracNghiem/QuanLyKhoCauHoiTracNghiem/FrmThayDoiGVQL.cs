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
    public partial class FrmThayDoiGVQL : Form
    {
        FrmQuanLyNguoiDung frmParent;
        long maND = -1;
        public FrmThayDoiGVQL()
        {
            InitializeComponent();
        }

        public FrmThayDoiGVQL(FrmQuanLyNguoiDung frm, long maND)
        {
            InitializeComponent();
            this.maND = maND;
            this.frmParent = frm;
            cboGVQL.DataSource = NGUOIDUNGBUS.LayDanhSachGiaoVienQuanLy();
            cboGVQL.ValueMember = "MAND";
            cboGVQL.DisplayMember = "HOTEN";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long maGVQL = (long)cboGVQL.SelectedValue;
            int result = NGUOIDUNGBUS.ThayDoiGVQL(this.maND, maGVQL);
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
                    MessageBox.Show("Giáo viên quản lý không tồn tại");
                    break;
                default:
                    MessageBox.Show("Có lỗi xảy ra! Xin vui lòng thử lại");
                    break;
            }
        }
    }
}
