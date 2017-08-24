using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class CAUTRALOIBUS
    {
        public static List<CAUTRALOIDTO> LayDanhSachCauTraLoiTheoCauHoi(long maCauHoi)
        {
            CAUTRALOIDAO c = new CAUTRALOIDAO();
            return c.LayDanhSachCauTraLoiTheoCauHoi(maCauHoi);
        }

        public static bool ThemCauTraLoiVaoCauHoi(string noiDung, bool laDapAnDung, long maCauHoi)
        {
            CAUTRALOIDAO c = new CAUTRALOIDAO();
            return c.ThemCauTraLoiVaoCauHoi(noiDung,laDapAnDung,maCauHoi);
        }
    }
}
