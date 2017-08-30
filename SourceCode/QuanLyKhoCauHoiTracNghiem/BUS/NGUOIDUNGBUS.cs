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
        public static bool DangNhap(string tenDangNhap, string matKhau, out long maNguoiDung)
        {
            NGUOIDUNGDAO n = new NGUOIDUNGDAO();
            return n.DangNhap(tenDangNhap, matKhau, out maNguoiDung);
        }
        public static List<NGUOIDUNGDTO> LayDanhSachNguoiDung()
        {
            NGUOIDUNGDAO n = new NGUOIDUNGDAO();
            return n.LayDanhSachNguoiDung();
        }
    }
}
