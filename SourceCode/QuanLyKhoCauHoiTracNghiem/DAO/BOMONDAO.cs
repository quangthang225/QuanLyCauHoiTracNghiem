using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class BOMONDAO : AbstractDAO
    {
        public List<BOMONDTO> LayDanhSachBoMon()
        {
            try
            {
                List<BOMONDTO> lstKQ = new List<BOMONDTO>();
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_LayDanhSachBoMon", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    BOMONDTO d = new BOMONDTO();
                    d.MABM = (long)rdr["MABM"];
                    d.TENBM = (string)rdr["TENBM"];
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
