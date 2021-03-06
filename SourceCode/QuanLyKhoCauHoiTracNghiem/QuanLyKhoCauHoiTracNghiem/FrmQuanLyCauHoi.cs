﻿using BUS;
using DTO;
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
    public partial class FrmQuanLyCauHoi : Form
    {
        public FrmQuanLyCauHoi()
        {
            InitializeComponent();
            dgvCauTraLoi.AutoGenerateColumns = false;
            dgvCauTraLoi.AllowUserToAddRows = false;
            dgvCauHoi.AutoGenerateColumns = false;
            dgvCauHoi.AllowUserToAddRows = false;
        }

        private void FrmQuanLyCauHoi_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMonHoc();
                LoadCauHoi();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void LoadMonHoc()
        {
            cboMonHoc.DataSource = MONHOCBUS.LayDanhSachMonHoc("", 0);
        }

        private void LoadCauHoi()
        {
            dgvCauHoi.DataSource = CAUHOIBUS.LayDanhSachCauHoi();
        }

        private void LoadCauTraLoiTheoCauHoi()
        {
            dgvCauHoi.DataSource = CAUHOIBUS.LayDanhSachCauHoi();
        }

        private void btnThemCauHoi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNoiDungCauHoi.Text.TrimEnd()))
            {
                MessageBox.Show("Vui lòng nhập nội dung câu hỏi");
                return;
            }
            if (String.IsNullOrEmpty(txtThangDiemCauHoi.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập thang điểm của câu hỏi");
                return;
            }
            if (cboMonHoc.SelectedItem == null)
            {
                MessageBox.Show("Vùi lòng cho biết câu hỏi thuộc môn học nào");
                return;
            }
            string noiDung = txtNoiDungCauHoi.Text.TrimEnd();
            double thangDiem = Convert.ToDouble(txtThangDiemCauHoi.Text.Trim());
            int mucDo = 0;
            if (cboMucDoCauHoi.SelectedItem.ToString().Equals("Khó"))
                mucDo = (int)Enums.MucDoCauHoi.Kho;
            if (cboMucDoCauHoi.SelectedItem.ToString().Equals("Dễ"))
                mucDo = (int)Enums.MucDoCauHoi.De;
            if (cboMucDoCauHoi.SelectedItem.ToString().Equals("Vừa"))
                mucDo = (int)Enums.MucDoCauHoi.Vua;
            long maMonHoc = ((MONHOCDTO)cboMonHoc.SelectedItem).MAMONHOC;
            bool rs = CAUHOIBUS.ThemCauHoi(noiDung, thangDiem, mucDo, maMonHoc);
            if (rs)
            {
                LoadCauHoi();
            }
            else
            {
                MessageBox.Show("Thêm câu hỏi thất bại. Đã có lỗi xảy ra");
            }
        }

        private void dgvCauHoi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCauHoi.SelectedRows.Count < 1)
            {
                return;
            }

            int index = dgvCauHoi.SelectedRows[0].Index;
            long maCauHoi = Convert.ToInt64(dgvCauHoi.Rows[index].Cells["MACH"].Value);
            txtNoiDungCauHoi.Text = Convert.ToString(dgvCauHoi.Rows[index].Cells["NOIDUNG"].Value);
            string mucDo = Convert.ToString(dgvCauHoi.Rows[index].Cells["MUCDO"].Value);
            if (mucDo == "Dễ")
                cboMucDoCauHoi.SelectedIndex = (int)Enums.MucDoCauHoi.De - 1;
            else if (mucDo == "Vừa")
                cboMucDoCauHoi.SelectedIndex = (int)Enums.MucDoCauHoi.Vua - 1;
            else
                cboMucDoCauHoi.SelectedIndex = (int)Enums.MucDoCauHoi.Kho - 1;
            txtThangDiemCauHoi.Text = Convert.ToString(dgvCauHoi.Rows[index].Cells["THANGDIEM"].Value);

            long maMonHoc = Convert.ToInt64(dgvCauHoi.Rows[index].Cells["MAMH"].Value);
            foreach (MONHOCDTO item in cboMonHoc.Items)
            {
                if (item.MAMONHOC == maMonHoc)
                {
                    cboMonHoc.SelectedItem = item;
                }
            }
            string error;
            dgvCauTraLoi.DataSource = CAUTRALOIBUS.LayDanhSachCauTraLoiTheoCauHoi(maCauHoi,out error);
            if (!String.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
            }
        }

        private void btnThemCauTL_Click(object sender, EventArgs e)
        {
            if (dgvCauHoi.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn 1 câu hỏi cho câu trả lời này");
                return;
            }

            int index = dgvCauHoi.SelectedRows[0].Index;

            string noiDung = txtNoiDungCauTL.Text.TrimEnd();
            if (String.IsNullOrEmpty(noiDung))
            {
                MessageBox.Show("Vui lòng nhập nội dung cho câu trả lời");
                return;
            }

            long maCauHoi = Convert.ToInt64(dgvCauHoi.Rows[index].Cells["MACH"].Value);

            string rs = CAUTRALOIBUS.ThemCauTraLoiVaoCauHoi(noiDung, chkLaDapAnDung.Checked, maCauHoi);
            if (String.IsNullOrEmpty(rs))
            {
                LoadCauHoi();
            }
            else
            {
                MessageBox.Show(rs);
            }
        }

        private void btnXoaCauTL_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn xóa câu trả lời này không ?", this.Text, MessageBoxButtons.YesNo);
            if (d == DialogResult.No)
                return;

            if (dgvCauTraLoi.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn 1 câu trả lời để xóa");
                return;
            }
            int index = dgvCauTraLoi.SelectedRows[0].Index;
            long maCTL = Convert.ToInt64(dgvCauTraLoi.Rows[index].Cells[0].Value);
            string rs = CAUTRALOIBUS.XoaCauTraLoi(maCTL);
            if (String.IsNullOrEmpty(rs))
            {
                LoadCauHoi();
            }
            else
            {
                MessageBox.Show(rs);
            }
        }

        private void dgvCauTraLoi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCauTraLoi.SelectedRows.Count < 1)
            {
                return;
            }

            int index = dgvCauTraLoi.SelectedRows[0].Index;
            txtNoiDungCauTL.Text = Convert.ToString(dgvCauTraLoi.Rows[index].Cells[1].Value);
            chkLaDapAnDung.Checked = Convert.ToBoolean(dgvCauTraLoi.Rows[index].Cells[2].Value);
        }

        private void btnCapNhatCauTL_Click(object sender, EventArgs e)
        {
            if (dgvCauTraLoi.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn 1 câu trả lời để cập nhật");
                return;
            }

            int index = dgvCauTraLoi.SelectedRows[0].Index;
            long maCTL = Convert.ToInt64(dgvCauTraLoi.Rows[index].Cells[0].Value);
            string noiDung = txtNoiDungCauTL.Text.TrimEnd();
            bool laDapAnDung = chkLaDapAnDung.Checked;
            string rs = CAUTRALOIBUS.CapNhatCauTraLoi(maCTL, noiDung, laDapAnDung);
            if (String.IsNullOrEmpty(rs))
            {
                LoadCauHoi();
            }
            else
            {
                MessageBox.Show(rs);
            }
        }

        private void btnCapNhatCauHoi_Click(object sender, EventArgs e)
        {
            if (dgvCauHoi.SelectedRows.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn 1 câu hỏi cần cập nhật thông tin");
                return;
            }

            if (cboMonHoc.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn môn học cho câu hỏi");
                return;
            }

            int index = dgvCauHoi.SelectedRows[0].Index;
            long maCauHoi = Convert.ToInt64(dgvCauHoi.Rows[index].Cells["MACH"].Value);
            string noiDung = txtNoiDungCauHoi.Text.Trim();
            double thangDiem = Convert.ToDouble(txtThangDiemCauHoi.Text.Trim());
            int mucDo;
            if (cboMucDoCauHoi.SelectedIndex == (int)Enums.MucDoCauHoi.De - 1)
                mucDo = (int)Enums.MucDoCauHoi.De;
            else if (cboMucDoCauHoi.SelectedIndex == (int)Enums.MucDoCauHoi.Vua - 1)
                mucDo = (int)Enums.MucDoCauHoi.Vua;
            else
                mucDo = (int)Enums.MucDoCauHoi.Kho;
            MONHOCDTO m = (MONHOCDTO)cboMonHoc.SelectedItem;
            string rs = CAUHOIBUS.CapNhatCauHoi(maCauHoi, noiDung, thangDiem, mucDo, m.MAMONHOC);
            if (String.IsNullOrEmpty(rs))
            {
                LoadCauHoi();
                MessageBox.Show("Cập nhật câu hỏi thành công");
            }
            else
            {
                MessageBox.Show(rs);
            }
        }

        private void txtThangDiemCauHoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int mucDo = 0;
            if (cboMucDoTimKiem.SelectedItem.ToString().Equals("Khó"))
                mucDo = (int)Enums.MucDoCauHoi.Kho;
            if (cboMucDoTimKiem.SelectedItem.ToString().Equals("Dễ"))
                mucDo = (int)Enums.MucDoCauHoi.De;
            if (cboMucDoTimKiem.SelectedItem.ToString().Equals("Vừa"))
                mucDo = (int)Enums.MucDoCauHoi.Vua;
            string error = "";
            string noiDung = txtNoiDungTimKiem.Text.Trim();
            var lstCauHoi = CAUHOIBUS.LayDanhSachCauHoiTheoNoiDungVaMucDo(noiDung, mucDo);
            dgvCauHoi.DataSource = lstCauHoi;
        }
    }
}
