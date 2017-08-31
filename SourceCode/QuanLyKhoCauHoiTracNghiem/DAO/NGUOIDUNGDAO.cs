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
        public bool DangNhap(string tenDangNhap, string matKhau, out long maNguoiDung)
        {
            SqlConnection connection = ConnectDB();
            SqlCommand cmd = new SqlCommand("sp_DangNhap", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter sParam_tenDangNhap = cmd.Parameters.Add("@tenDangNhap", SqlDbType.VarChar, 30);
            sParam_tenDangNhap.Direction = ParameterDirection.Input;
            sParam_tenDangNhap.Value = tenDangNhap;

            SqlParameter sParam_matKhau = cmd.Parameters.Add("@matKhau", SqlDbType.VarChar, 30);
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
            try
            {
                List<NGUOIDUNGDTO> lstKQ = new List<NGUOIDUNGDTO>();
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_LayDanhSachNguoiDung", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    NGUOIDUNGDTO d = new NGUOIDUNGDTO();
                    d.HOTEN = (string)rdr["HOTEN"];
                    d.MAND = (long)rdr["MAND"];
                    d.TENDANGNHAP = (string)rdr["TENDANGNHAP"];
                    d.MATKHAU = (string)rdr["MATKHAU"];
                    d.TRANGTHAI = (bool)rdr["TRANGTHAI"];
                    d.TOANQUYENGV = (bool)rdr["TOANQUYENGV"];
                    d.MALOAI = (long)rdr["MALOAI"];
                    d.MABM = (long)rdr["MABM"];
                    if (rdr["MAGVQL"] != DBNull.Value)
                        d.MAGVQL = (long)rdr["MAGVQL"];
                    d.TENLOAIND = (string)rdr["TENLOAIND"];
                    d.TENBM = (string)rdr["TENBM"];
                    Console.WriteLine(rdr["TENGVQL"]);
                    if (rdr["TENGVQL"] != DBNull.Value)
                        d.TENGVQL = (string)rdr["TENGVQL"];
                    lstKQ.Add(d);
                }
                return lstKQ;
            }
            catch (Exception e)
            {
                Console.WriteLine("THANG: " + e.ToString());
                throw e;

            }
        }
    }
}
