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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            Common.MaNguoiDungDangNhap = -1;
            Common.TenTaiKhoanDangNhap = "";
            mnuXinChao.Text = "";
            DisableMenu(true);
            FrmDangNhap f = new FrmDangNhap();
            f.ShowDialog();
        }

        private void DisableMenu(bool b)
        {
            if (b)
            {
                mnuGiaoVien.Enabled = false;
                mnuQuanLy.Enabled = false;
                mnuQuanTri.Enabled = false;
                mnuDangXuat.Visible = false;
            }
            else
            {
                mnuGiaoVien.Enabled = true;
                mnuQuanLy.Enabled = true;
                mnuQuanTri.Enabled = true;
                mnuDangXuat.Visible = true;
            }
        }

        private void LayFormNeuTonTai(string name, ref Form frm)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.Name == name)
                {
                    frm = f;
                    return;
                }
            }
        }

        private void HienThiForm(ref Form frm)
        {
            LayFormNeuTonTai(frm.Name, ref frm);

            frm.MdiParent = this;
            frm.Location = new Point(Width / 2 - frm.Width / 2, Height / 2 - frm.Height / 2);
            frm.Show();
            frm.Focus();
        }

        private void mnuQuanLyMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void mnuQuanLyDeThi_Click(object sender, EventArgs e)
        {
            FrmQuanLyDeThi frm = new FrmQuanLyDeThi();
            Form f = (Form)frm;
            HienThiForm(ref f);
        }

        private void mnuTaoDeThi_Click(object sender, EventArgs e)
        {

        }

        private void mnuQuanLyCauHoi_Click(object sender, EventArgs e)
        {
            FrmQuanLyCauHoi frm = new FrmQuanLyCauHoi();
            Form f = (Form)frm;
            HienThiForm(ref f);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            if (Common.MaNguoiDungDangNhap < 0)
            {
                DisableMenu(true);
                mnuXinChao.Text = "";
                FrmDangNhap f = new FrmDangNhap();
                f.ShowDialog();
                if (!String.IsNullOrEmpty(Common.TenTaiKhoanDangNhap))
                {
                    mnuXinChao.Text = "Xin chào : " + Common.TenTaiKhoanDangNhap;
                    DisableMenu(false);
                }
            }
        }

        private void mnuQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            FrmQuanLyNguoiDung frm = new FrmQuanLyNguoiDung();
            Form f = (Form)frm;
            HienThiForm(ref f);
        }

        private void mnuBoMon_Click(object sender, EventArgs e)
        {
            FrmQuanLyBoMon frm = new FrmQuanLyBoMon();
            Form f = (Form)frm;
            HienThiForm(ref f);
        }

        private void mnuQuanLyGiaoVien_Click(object sender, EventArgs e)
        {
            FrmQuanLyGiaoVien frm = new FrmQuanLyGiaoVien();
            Form f = (Form)frm;
            HienThiForm(ref f);
        }
    }
}
