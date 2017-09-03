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
        public static List<MONHOCDTO> LayDanhSachMonHoc()
        {
            MONHOCDAO d = new MONHOCDAO();
            return d.LayDanhSachMonHoc();
        }
        public static int ThemMonHoc(MONHOCDTO d)
        {
            MONHOCDAO dao = new MONHOCDAO();
            return dao.ThemMonHoc(d);
        }
    }
}
