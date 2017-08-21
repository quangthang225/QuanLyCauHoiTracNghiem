using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class DETHIDAO : AbstractDAO
    {
        public List<DETHIDTO> LayDanhSachBoDeThi()
        {
            try
            {
                List<DETHIDTO> lstKQ = new List<DETHIDTO>();
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_LayDanhSachBoDeThi", connection);


                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    DETHIDTO d = new DETHIDTO();
                    d.MABDT = (long)rdr["MABDT"];
                    d.TENBDT = (string)rdr["TENBDT"];
                    d.HOCKY = (int)rdr["HOCKY"];
                    d.NAMHOC = (int)rdr["NAMHOC"];
                    d.MAGVTAO = (long)rdr["MAGVTAO"];
                    d.MAMH = (long)rdr["MAMH"];
                    d.TENMH = (string)rdr["TENMH"];
                    lstKQ.Add(d);
                }
                return lstKQ;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int ThemBoDeThi(DETHIDTO d)
        {
            try
            {
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_TaoBoDeThi", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sParam_tenBoDeThi = cmd.Parameters.Add("@TenBoDeThi", SqlDbType.NVarChar, 255);
                sParam_tenBoDeThi.Direction = ParameterDirection.Input;
                sParam_tenBoDeThi.Value = d.TENBDT;

                SqlParameter sParam_hocKy = cmd.Parameters.Add("@HocKy", SqlDbType.Int);
                sParam_hocKy.Direction = ParameterDirection.Input;
                sParam_hocKy.Value = d.HOCKY;

                SqlParameter sParam_namHoc = cmd.Parameters.Add("@NamHoc", SqlDbType.Int);
                sParam_namHoc.Direction = ParameterDirection.Input;
                sParam_namHoc.Value = d.NAMHOC;

                SqlParameter sParam_magv = cmd.Parameters.Add("@MaGvTao", SqlDbType.BigInt);
                sParam_magv.Direction = ParameterDirection.Input;
                sParam_magv.Value = d.MAGVTAO;

                SqlParameter sParam_ketQua = cmd.Parameters.Add("@Return", SqlDbType.Int);
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

        public bool CapNhatBoDeThi(DETHIDTO d)
        {
            try
            {
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_CapNhatBoDeThi", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sParam_maBoDeThi = cmd.Parameters.Add("@MaBDT", SqlDbType.BigInt);
                sParam_maBoDeThi.Direction = ParameterDirection.Input;
                sParam_maBoDeThi.Value = d.MABDT;

                SqlParameter sParam_tenBoDeThi = cmd.Parameters.Add("@TenBoDeThi", SqlDbType.NVarChar, 255);
                sParam_tenBoDeThi.Direction = ParameterDirection.Input;
                sParam_tenBoDeThi.Value = d.TENBDT;

                SqlParameter sParam_hocKy = cmd.Parameters.Add("@HocKy", SqlDbType.Int);
                sParam_hocKy.Direction = ParameterDirection.Input;
                sParam_hocKy.Value = d.HOCKY;

                SqlParameter sParam_namHoc = cmd.Parameters.Add("@NamHoc", SqlDbType.Int);
                sParam_namHoc.Direction = ParameterDirection.Input;
                sParam_namHoc.Value = d.NAMHOC;

                SqlParameter sParam_ketQua = cmd.Parameters.Add("@Return", SqlDbType.Bit);
                sParam_ketQua.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                connection.Close();
                if ((bool)sParam_ketQua.Value == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
