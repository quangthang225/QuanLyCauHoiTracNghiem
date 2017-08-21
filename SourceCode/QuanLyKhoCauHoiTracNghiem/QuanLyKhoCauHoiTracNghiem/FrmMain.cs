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
        public FrmMain(long maNguoiDung,string tenDangNhap)
        {
            InitializeComponent();
            Common.MaNguoiDungDangNhap = maNguoiDung;
            mnuXinChao.Text = "Xin chào: " + tenDangNhap;
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDangNhap f = new FrmDangNhap();
            f.Show();
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
            //FrmQuanLyMonHoc frm = new FrmQuanLyMonHoc();
            //Form f = (Form)frm;
            //HienThiForm(ref f);
        }

        private void mnuQuanLyDeThi_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuTaoDeThi_Click(object sender, EventArgs e)
        {
            FrmQuanLyDeThi frm = new FrmQuanLyDeThi();
            Form f = (Form)frm;
            HienThiForm(ref f);
        }
    }
}
