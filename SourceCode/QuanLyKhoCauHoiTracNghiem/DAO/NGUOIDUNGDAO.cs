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
        public bool DangNhap(string tenDangNhap, string matKhau, out long maNguoiDung, out bool biKhoa)
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

            SqlParameter sParam_biKhoa = cmd.Parameters.Add("@islocked", SqlDbType.Bit);
            sParam_biKhoa.Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            connection.Close();
            biKhoa = !(bool)sParam_biKhoa.Value;
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

        public bool ThemNguoiDung(string hoTen, string tenDangNhap, string matKhau, bool trangThai, bool toanQuyen, long maLoai, long maBM, long maGVQL)
        {
            {
                try
                {
                    SqlConnection connection = ConnectDB();
                    SqlCommand cmd = new SqlCommand("sp_TaoTaiKhoan", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter sParam_HoTen = cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar);
                    sParam_HoTen.Direction = ParameterDirection.Input;
                    sParam_HoTen.Value = hoTen;

                    SqlParameter sParam_TenDangNhap = cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar);
                    sParam_TenDangNhap.Direction = ParameterDirection.Input;
                    sParam_TenDangNhap.Value = tenDangNhap;

                    SqlParameter sParam_MatKhau = cmd.Parameters.Add("@MatKhau", SqlDbType.VarChar);
                    sParam_MatKhau.Direction = ParameterDirection.Input;
                    sParam_MatKhau.Value = matKhau;

                    SqlParameter sParam_TrangThai = cmd.Parameters.Add("@TrangThai", SqlDbType.Bit);
                    sParam_TrangThai.Direction = ParameterDirection.Input;
                    sParam_TrangThai.Value = trangThai;

                    SqlParameter sParam_ToanQuyen = cmd.Parameters.Add("@ToanQuyenGV", SqlDbType.Bit);
                    sParam_ToanQuyen.Direction = ParameterDirection.Input;
                    sParam_ToanQuyen.Value = toanQuyen;

                    SqlParameter sParam_MaLoai = cmd.Parameters.Add("@MaLoai", SqlDbType.BigInt);
                    sParam_MaLoai.Direction = ParameterDirection.Input;
                    sParam_MaLoai.Value = maLoai;

                    SqlParameter sParam_MaBM = cmd.Parameters.Add("@MaBM", SqlDbType.BigInt);
                    sParam_MaBM.Direction = ParameterDirection.Input;
                    sParam_MaBM.Value = maBM;

                    SqlParameter sParam_MaGVQL = cmd.Parameters.Add("@MaGVQL", SqlDbType.BigInt);
                    sParam_MaGVQL.Direction = ParameterDirection.Input;
                    sParam_MaGVQL.Value = maGVQL;

                    //SqlParameter sParam_ketQua = cmd.Parameters.Add("@Return", SqlDbType.Int);
                    //sParam_ketQua.Direction = ParameterDirection.Output;

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

        public List<NGUOIDUNGDTO> LayDanhSachGiaoVienQuanLy()
        {
            try
            {
                List<NGUOIDUNGDTO> lstKQ = new List<NGUOIDUNGDTO>();
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_LayDanhSachGiaoVienQuanLy", connection);

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
        public bool XoaNguoiDung(long maND)
        {
            {
                try
                {
                    SqlConnection connection = ConnectDB();
                    SqlCommand cmd = new SqlCommand("sp_XoaTaiKhoan", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter sParam_maND= cmd.Parameters.Add("@MaND", SqlDbType.BigInt);
                    sParam_maND.Direction = ParameterDirection.Input;
                    sParam_maND.Value = maND;

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

        public NGUOIDUNGDTO LayNguoiDung(long maND)
        {
            try
            {
                NGUOIDUNGDTO d = new NGUOIDUNGDTO();
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_LayNguoiDung", connection);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sParam_maND = cmd.Parameters.Add("@MaND", SqlDbType.BigInt);
                sParam_maND.Direction = ParameterDirection.Input;
                sParam_maND.Value = maND;

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
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
                }
                return d;
            }
            catch (Exception e)
            {
                throw e;

            }
        }

        public int CapNhatThongTin(long maND, string hoTen, string tenDangNhap, bool trangThai, bool toanQuyen, long maLoai, long maBM, long maGVQL)
        {
            {
                try
                {
                    SqlConnection connection = ConnectDB();
                    SqlCommand cmd = new SqlCommand("sp_CapNhatThongTin", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter sParam_MaND = cmd.Parameters.Add("@MaND", SqlDbType.BigInt);
                    sParam_MaND.Direction = ParameterDirection.Input;
                    sParam_MaND.Value = maND;

                    SqlParameter sParam_HoTen = cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar);
                    sParam_HoTen.Direction = ParameterDirection.Input;
                    sParam_HoTen.Value = hoTen;

                    SqlParameter sParam_TenDangNhap = cmd.Parameters.Add("@TenDangNhap", SqlDbType.VarChar);
                    sParam_TenDangNhap.Direction = ParameterDirection.Input;
                    sParam_TenDangNhap.Value = tenDangNhap;

                    SqlParameter sParam_TrangThai = cmd.Parameters.Add("@TrangThai", SqlDbType.Bit);
                    sParam_TrangThai.Direction = ParameterDirection.Input;
                    sParam_TrangThai.Value = trangThai;

                    SqlParameter sParam_ToanQuyen = cmd.Parameters.Add("@ToanQuyenGV", SqlDbType.Bit);
                    sParam_ToanQuyen.Direction = ParameterDirection.Input;
                    sParam_ToanQuyen.Value = toanQuyen;

                    SqlParameter sParam_MaLoai = cmd.Parameters.Add("@MaLoai", SqlDbType.BigInt);
                    sParam_MaLoai.Direction = ParameterDirection.Input;
                    sParam_MaLoai.Value = maLoai;

                    SqlParameter sParam_MaBM = cmd.Parameters.Add("@MaBM", SqlDbType.BigInt);
                    sParam_MaBM.Direction = ParameterDirection.Input;
                    sParam_MaBM.Value = maBM;

                    SqlParameter sParam_MaGVQL = cmd.Parameters.Add("@MaGVQL", SqlDbType.BigInt);
                    sParam_MaGVQL.Direction = ParameterDirection.Input;
                    sParam_MaGVQL.Value = maGVQL;

                    /*SqlParameter sParam_MaGVQL = cmd.Parameters.Add("@MaGVQL", SqlDbType.BigInt);
                    sParam_MaGVQL.Direction = ParameterDirection.Input;
                    sParam_MaGVQL.Value = maGVQL;*/

                    SqlParameter sParam_ketQua = cmd.Parameters.Add("@Return", SqlDbType.Int);
                    sParam_ketQua.Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
               //     connection.Close();
                    Console.WriteLine("THANGGGG: " + sParam_ketQua.Value.ToString());
                    return Convert.ToInt32(sParam_ketQua.Value);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public int ThayDoiGVQL(long maND, long maGVQL)
        {
            {
                try
                {
                    SqlConnection connection = ConnectDB();
                    SqlCommand cmd = new SqlCommand("sp_ThayDoiGVQL", connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter sParam_MaND = cmd.Parameters.Add("@MaND", SqlDbType.BigInt);
                    sParam_MaND.Direction = ParameterDirection.Input;
                    sParam_MaND.Value = maND;

                    SqlParameter sParam_MaGVQL = cmd.Parameters.Add("@MaGVQL", SqlDbType.BigInt);
                    sParam_MaGVQL.Direction = ParameterDirection.Input;
                    sParam_MaGVQL.Value = maGVQL;


                    SqlParameter sParam_ketQua = cmd.Parameters.Add("@Return", SqlDbType.Int);
                    sParam_ketQua.Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();
                    //     connection.Close();
                    Console.WriteLine("THANGGGG: " + sParam_ketQua.Value.ToString());
                    return Convert.ToInt32(sParam_ketQua.Value);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public List<NGUOIDUNGDTO> LayDanhSachGV(long maGVQL)
        {
            try
            {
                List<NGUOIDUNGDTO> lstKQ = new List<NGUOIDUNGDTO>();
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_LayDanhGV", connection);

                SqlParameter sParam_MaGVQL = cmd.Parameters.Add("@MaGVQL", SqlDbType.BigInt);
                sParam_MaGVQL.Direction = ParameterDirection.Input;
                sParam_MaGVQL.Value = maGVQL;

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
                    //Console.WriteLine(rdr["TENGVQL"]);
                    //if (rdr["TENGVQL"] != DBNull.Value)
                    //    d.TENGVQL = (string)rdr["TENGVQL"];
                    lstKQ.Add(d);
                }
                return lstKQ;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                throw e;

            }
        }

        public bool CapNhatQuyenGV(long maGVQL, long maGV, bool value)
        {
            try
            {
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_GVQLCAPQUYEN", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sParam_MaGVQL = cmd.Parameters.Add("@MAGVQL", SqlDbType.BigInt);
                sParam_MaGVQL.Direction = ParameterDirection.Input;
                sParam_MaGVQL.Value = maGVQL;

                SqlParameter sParam_MaGV = cmd.Parameters.Add("@MAGV", SqlDbType.BigInt);
                sParam_MaGV.Direction = ParameterDirection.Input;
                sParam_MaGV.Value = maGV;

                SqlParameter sParam_Value = cmd.Parameters.Add("@VALUE", SqlDbType.Bit);
                sParam_Value.Direction = ParameterDirection.Input;
                sParam_Value.Value = value;

                SqlParameter sParam_ketQua = cmd.Parameters.Add("@KETQUA", SqlDbType.Bit);
                sParam_ketQua.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                return Convert.ToBoolean(sParam_ketQua.Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return false;
        }
    }
}
