using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class CAUTRALOIDAO : AbstractDAO
    {
        public List<CAUTRALOIDTO> LayDanhSachCauTraLoiTheoCauHoi(long maCauHoi, out string Error)
        {
            try
            {
                List<CAUTRALOIDTO> lstKQ = new List<CAUTRALOIDTO>();
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_LayDanhSachCauTraLoiTheoCauHoi", connection);

                SqlParameter sParam_maCauHoi = cmd.Parameters.Add("@MACH", SqlDbType.BigInt);
                sParam_maCauHoi.Direction = ParameterDirection.Input;
                sParam_maCauHoi.Value = maCauHoi;

                SqlParameter sParam_ketQua = cmd.Parameters.Add("@Return", SqlDbType.NVarChar,500);
                sParam_ketQua.Direction = ParameterDirection.Output;

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                Error = Convert.ToString(sParam_ketQua.Value);
                while (rdr.Read())
                {
                    CAUTRALOIDTO d = new CAUTRALOIDTO();
                    d.MACTL = (long)rdr["MACTL"];
                    d.NOIDUNG = (string)rdr["NOIDUNG"];
                    d.LADAPANDUNG = (bool)rdr["LADAPANDUNG"];
                    lstKQ.Add(d);
                }
                return lstKQ;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string ThemCauTraLoiVaoCauHoi(string noiDung, bool laDapAnDung, long maCauHoi)
        {
            try
            {
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_ThemCauTraLoiVaoCauHoi_DEMO", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sParam_NOIDUNG = cmd.Parameters.Add("@NOIDUNG", SqlDbType.NVarChar);
                sParam_NOIDUNG.Direction = ParameterDirection.Input;
                sParam_NOIDUNG.Value = noiDung;

                SqlParameter sParam_LADAPANDUNG = cmd.Parameters.Add("@LADAPANDUNG", SqlDbType.Bit);
                sParam_LADAPANDUNG.Direction = ParameterDirection.Input;
                sParam_LADAPANDUNG.Value = laDapAnDung;

                SqlParameter sParam_MACH = cmd.Parameters.Add("@MACH", SqlDbType.BigInt);
                sParam_MACH.Direction = ParameterDirection.Input;
                sParam_MACH.Value = maCauHoi;

                SqlParameter sParam_ketQua = cmd.Parameters.Add("@Return", SqlDbType.NVarChar,500);
                sParam_ketQua.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                connection.Close();
                return Convert.ToString(sParam_ketQua.Value);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string CapNhatCauTraLoi(long maCTL, string noiDung, bool laDapAnDung)
        {
            try
            {
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_CapNhatCauTraLoi", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sParam_MACTL = cmd.Parameters.Add("@MACTL", SqlDbType.BigInt);
                sParam_MACTL.Direction = ParameterDirection.Input;
                sParam_MACTL.Value = maCTL;

                SqlParameter sParam_NOIDUNG = cmd.Parameters.Add("@NOIDUNG", SqlDbType.NVarChar);
                sParam_NOIDUNG.Direction = ParameterDirection.Input;
                sParam_NOIDUNG.Value = noiDung;

                SqlParameter sParam_LADAPANDUNG = cmd.Parameters.Add("@LADAPANDUNG", SqlDbType.Bit);
                sParam_LADAPANDUNG.Direction = ParameterDirection.Input;
                sParam_LADAPANDUNG.Value = laDapAnDung;

                SqlParameter sParam_ketQua = cmd.Parameters.Add("@Return", SqlDbType.NVarChar, 500);
                sParam_ketQua.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                connection.Close();
                return Convert.ToString(sParam_ketQua.Value);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string XoaCauTraLoi(long maCTL)
        {
            try
            {
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_XoaCauTraLoi_DEMO", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sParam_MACTL = cmd.Parameters.Add("@MACTL", SqlDbType.BigInt);
                sParam_MACTL.Direction = ParameterDirection.Input;
                sParam_MACTL.Value = maCTL;

                SqlParameter sParam_ketQua = cmd.Parameters.Add("@Return", SqlDbType.NVarChar, 500);
                sParam_ketQua.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                connection.Close();
                return Convert.ToString(sParam_ketQua.Value);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
