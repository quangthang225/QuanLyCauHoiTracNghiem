using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAO
{
    public class NGUOIDUNGDAO : AbstractDAO
    {
        public bool DangNhap(string tenDangNhap, string matKhau,out long maNguoiDung)
        {
            SqlConnection connection = ConnectDB();
            SqlCommand cmd = new SqlCommand("sp_DangNhap", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter sParam_tenDangNhap = cmd.Parameters.Add("@tenDangNhap", SqlDbType.VarChar,30);
            sParam_tenDangNhap.Direction = ParameterDirection.Input;
            sParam_tenDangNhap.Value = tenDangNhap;

            SqlParameter sParam_matKhau = cmd.Parameters.Add("@matKhau", SqlDbType.VarChar,30);
            sParam_matKhau.Direction = ParameterDirection.Input;
            sParam_matKhau.Value = matKhau;

            SqlParameter sParam_maNguoiDung = cmd.Parameters.Add("@maNguoiDung", SqlDbType.BigInt);
            sParam_maNguoiDung.Direction = ParameterDirection.Output;

            SqlParameter sParam_ketQua = cmd.Parameters.Add("@return", SqlDbType.Bit);
            sParam_ketQua.Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            connection.Close();
            if ((bool)sParam_ketQua.Value == true)
            {
                maNguoiDung = (long)sParam_maNguoiDung.Value;
                return true;
            }
            else
            {
                maNguoiDung = 0;
                return false;
            }
        }

        public List<NGUOIDUNGDTO> LayDanhSachNguoiDung()
        {
            return null;
           /* try
            {
                List<NGUOIDUNGDTO> lstKQ = new List<NGUOIDUNGDTO>();
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
            }*/
        }
    }
}
