using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class NGUOIDUNGDAO : AbstractDAO
    {
        public bool DangNhap(string tenDangNhap, string matKhau,out long maNguoiDung)
        {
            // B1: Tạo kết nối
            SqlConnection connection = ConnectDB();
            SqlCommand cmd = new SqlCommand("sp_DangNhap", connection);
            cmd.CommandTimeout = 50;
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
    }
}
