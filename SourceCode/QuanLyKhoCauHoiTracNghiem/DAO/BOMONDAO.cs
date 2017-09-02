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
        public bool ThemBoMon(string tenBM)
        {
            {
                try
                {
                    SqlConnection connection = ConnectDB();
                    SqlCommand cmd = new SqlCommand("sp_ThemBoMon", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter sParam_TenBM = cmd.Parameters.Add("@TenBM", SqlDbType.NVarChar);
                    sParam_TenBM.Direction = ParameterDirection.Input;
                    sParam_TenBM.Value = tenBM;

                    int rowAffect = cmd.ExecuteNonQuery();
                    connection.Close();
                    return (rowAffect > 0) ? true : false;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public bool XoaBoMon(long maBM)
        {
            {
                try
                {
                    SqlConnection connection = ConnectDB();
                    SqlCommand cmd = new SqlCommand("sp_XoaBoMon", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter sParam_maND = cmd.Parameters.Add("@MaBM", SqlDbType.BigInt);
                    sParam_maND.Direction = ParameterDirection.Input;
                    sParam_maND.Value = maBM;

                    int rowAffect = cmd.ExecuteNonQuery();
                    connection.Close();
                    return (rowAffect > 0) ? true : false;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
    }
}
