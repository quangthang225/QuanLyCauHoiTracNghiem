using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class BOMONBUS
    {
        public static List<BOMONDTO> LayDanhSachBoMon()
        {
            BOMONDAO d = new BOMONDAO();
            return d.LayDanhSachBoMon();
        }
        public static bool ThemBoMon(string tenBM)
        {
            BOMONDAO n = new BOMONDAO();
            return n.ThemBoMon(tenBM);
        }
        public static int XoaBoMon(long maBM)
        {
            BOMONDAO n = new BOMONDAO();
            return n.XoaBoMon(maBM);
        }
    }
}
