using BUS;
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
    public partial class FrmQuanLyGiaoVien : Form
    {
        public FrmQuanLyGiaoVien()
        {
            InitializeComponent();
        }

        private void FrmQuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            var lst = NGUOIDUNGBUS.LayDanhSachGiaoVien(Common.MaNguoiDungDangNhap);
            dgvGV.DataSource = null;
            dgvGV.DataSource = lst;
            dgvGV.Columns["TRANGTHAI"].Visible = false;
            dgvGV.Columns["TENDANGNHAP"].Visible = false;
            dgvGV.Columns["MATKHAU"].Visible = false;
            dgvGV.Columns["MALOAI"].Visible = false;
            dgvGV.Columns["MABM"].Visible = false;
            dgvGV.Columns["MAGVQL"].Visible = false;
            dgvGV.Columns["MAGVQL1"].Visible = false;
            dgvGV.Columns["TENLOAIND"].Visible = false;
            dgvGV.Columns["TENGVQL"].Visible = false;
            //dgvGV.Columns["TOANQUYENHGV"].
        }

        private void dgvGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)   
            {
                this.dgvGV.CommitEdit(DataGridViewDataErrorContexts.Commit);
                object temp = dgvGV[0, e.RowIndex].Value;
                object temp2 = dgvGV[5, e.RowIndex].Value;
                long maGV = -1;
                bool value;
                bool result;

                if (temp != null && temp2 != null)
                {
                    maGV = (long)temp;
                    value = (bool)temp2;
                    result = NGUOIDUNGBUS.CapNhatQuyenGV(Common.MaNguoiDungDangNhap, maGV, value);

                    if (!result)
                        dgvGV[5, e.RowIndex].Value = !value;
                }
            }
        }
    }
}
