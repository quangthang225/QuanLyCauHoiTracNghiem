using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class MONHOCBUS
    {
        public static List<MONHOCDTO> LayDanhSachMonHoc(string tenMH, long maBM)
        {
            MONHOCDAO dao = new MONHOCDAO();
            return dao.LayDanhSachMonHoc(tenMH, maBM);
        }
        public static int ThemMonHoc(MONHOCDTO d)
        {
            MONHOCDAO dao = new MONHOCDAO();
            return dao.ThemMonHoc(d);
        }
        public static int CapNhatMonHoc(MONHOCDTO d)
        {
            MONHOCDAO dao = new MONHOCDAO();
            return dao.CapNhatMonHoc(d);
        }
        public static int XoaMonHoc(long maMH)
        {
            MONHOCDAO dao = new MONHOCDAO();
            return dao.XoaMonHoc(maMH);
        }
    }
}
