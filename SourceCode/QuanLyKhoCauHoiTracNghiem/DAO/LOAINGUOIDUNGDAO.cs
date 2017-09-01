using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data.SqlClient;
using Utilities;
using System.Data;

namespace DAO
{
    public class LOAINGUOIDUNGDAO : AbstractDAO
    {
        public List<LOAINGUOIDUNGDTO> LayDanhSachLoaiNguoiDung()
        {
            try
            {
                List<LOAINGUOIDUNGDTO> lstKQ = new List<LOAINGUOIDUNGDTO>();
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_LayDanhSachLoaiNguoiDung", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    LOAINGUOIDUNGDTO d = new LOAINGUOIDUNGDTO();
                    d.MALOAI = (long)rdr["MALOAI"];
                    d.TENLOAIND = (string)rdr["TENLOAIND"];
                    lstKQ.Add(d);
                }
                return lstKQ;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
