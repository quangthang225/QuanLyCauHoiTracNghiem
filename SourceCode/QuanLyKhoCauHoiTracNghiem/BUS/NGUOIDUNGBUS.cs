using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class NGUOIDUNGBUS
    {
        public static bool DangNhap(string tenDangNhap, string matKhau, out long maNguoiDung, out bool biKhoa)
        {
            NGUOIDUNGDAO n = new NGUOIDUNGDAO();
            return n.DangNhap(tenDangNhap, matKhau, out maNguoiDung, out biKhoa);
        }
        public static List<NGUOIDUNGDTO> LayDanhSachNguoiDung()
        {
            NGUOIDUNGDAO n = new NGUOIDUNGDAO();
            return n.LayDanhSachNguoiDung();
        }
        public static bool ThemNguoiDung(string hoTen, string tenDangNhap, string matKhau, bool trangThai, bool toanQuyen, long maLoai, long maBM, long maGVQL)
        {
            NGUOIDUNGDAO n = new NGUOIDUNGDAO();
            return n.ThemNguoiDung(hoTen, tenDangNhap, matKhau, trangThai, toanQuyen, maLoai, maBM, maGVQL);
        }
        public static List<NGUOIDUNGDTO> LayDanhSachGiaoVienQuanLy()
        {
            NGUOIDUNGDAO n = new NGUOIDUNGDAO();
            return n.LayDanhSachGiaoVienQuanLy();
        }
        public static bool XoaNguoiDung(long maND)
        {
            NGUOIDUNGDAO n = new NGUOIDUNGDAO();
            return n.XoaNguoiDung(maND);
        }
        public static NGUOIDUNGDTO LayNguoiDung(long maND)
        {
            NGUOIDUNGDAO n = new NGUOIDUNGDAO();
            return n.LayNguoiDung(maND);
        }
        public static int CapNhatThongTin(long maND, string hoTen, string tenDangNhap, bool trangThai, bool toanQuyen, long maLoai, long maBM, long maGVQL)
        {
            NGUOIDUNGDAO n = new NGUOIDUNGDAO();
            return n.CapNhatThongTin(maND, hoTen, tenDangNhap, trangThai, toanQuyen, maLoai, maBM, maGVQL);
        }
        public static int ThayDoiGVQL(long maND, long maGVQL)
        {
            NGUOIDUNGDAO n = new NGUOIDUNGDAO();
            return n.ThayDoiGVQL(maND, maGVQL);
        }
        public static List<NGUOIDUNGDTO> LayDanhSachGiaoVien(long maGVQL)
        {
            NGUOIDUNGDAO n = new NGUOIDUNGDAO();
            return n.LayDanhSachGV(maGVQL);
        }
        public static bool CapNhatQuyenGV(long maGVQL, long maGV, bool value)
        {
            NGUOIDUNGDAO n = new NGUOIDUNGDAO();
            return n.CapNhatQuyenGV(maGVQL, maGV, value);
        }
    }
}
