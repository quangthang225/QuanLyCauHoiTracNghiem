using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class LOAINGUOIDUNGBUS
    {
        public static List<LOAINGUOIDUNGDTO> LayDanhSachLoaiNguoiDung()
        {
            LOAINGUOIDUNGDAO c = new LOAINGUOIDUNGDAO();
            return c.LayDanhSachLoaiNguoiDung();
        }
     }
}
