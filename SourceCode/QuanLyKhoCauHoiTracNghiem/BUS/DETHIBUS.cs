using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class DETHIBUS
    {
        public static List<DETHIDTO> LayDanhSachBoDeThi()
        {
            DETHIDAO d = new DETHIDAO();
            return d.LayDanhSachBoDeThi();
        }

        public static int ThemBoDeThi(DETHIDTO d)
        {
            DETHIDAO dao = new DETHIDAO();
            return dao.ThemBoDeThi(d);
        }

        public static bool CapNhatBoDeThi(DETHIDTO d)
        {
            DETHIDAO dao = new DETHIDAO();
            return dao.CapNhatBoDeThi(d);
        }
    }
}
