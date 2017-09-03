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
                    d.MABOMON = (long)rdr["MABM"];
                    d.TENBOMON = (string)rdr["TENBM"];
                    lstKQ.Add(d);
                }
                return lstKQ;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int ThemMonHoc(MONHOCDTO d)
        {
            try
            {
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_ThemMonHoc", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sParam_tenMonHoc = cmd.Parameters.Add("@TENMH", SqlDbType.NVarChar, 255);
                sParam_tenMonHoc.Direction = ParameterDirection.Input;
                sParam_tenMonHoc.Value = d.TENMONHOC;

                SqlParameter sParam_maBM = cmd.Parameters.Add("@MABM", SqlDbType.Int);
                sParam_maBM.Direction = ParameterDirection.Input;
                sParam_maBM.Value = d.MABOMON;

                SqlParameter sParam_ketQua = cmd.Parameters.Add("@KETQUA", SqlDbType.Int);
                sParam_ketQua.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                connection.Close();
                return (int)sParam_ketQua.Value;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
