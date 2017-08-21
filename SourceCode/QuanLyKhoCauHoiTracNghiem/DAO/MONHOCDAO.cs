using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class MONHOCDAO : AbstractDAO
    {
        public List<MONHOCDTO> LayDanhSachMonHoc()
        {
            try
            {
                List<MONHOCDTO> lstKQ = new List<MONHOCDTO>();
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_LayDanhSachMonHoc", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    MONHOCDTO d = new MONHOCDTO();
                    d.MAMONHOC = (long)rdr["MAMH"];
                    d.TENMONHOC = (string)rdr["TENMH"];
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
