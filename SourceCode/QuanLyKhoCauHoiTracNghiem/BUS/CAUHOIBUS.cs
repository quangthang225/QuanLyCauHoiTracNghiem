using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class CAUHOIBUS
    {
        public static List<CAUHOIDTO> LayDanhSachCauHoiTheoMonHocChuaCoTrongDeThi(long maMonHoc, long maDeThi)
        {
            CAUHOIDAO c = new CAUHOIDAO();
            return c.LayDanhSachCauHoiTheoMonHocChuaCoTrongDeThi(maMonHoc,maDeThi);
        }

        public static List<CAUHOIDTO> LayDanhSachCauHoiTheoDeThi(long maDeThi)
        {
            CAUHOIDAO c = new CAUHOIDAO();
            return c.LayDanhSacCauHoiTheoDeThi(maDeThi);
        }
    }
}
