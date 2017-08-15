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
    public partial class FrmMain : Form
    {
        public FrmMain(string tenDangNhap)
        {
            InitializeComponent();
            mnuXinChao.Text = "Xin chào: " + tenDangNhap;
        }
    }
}
