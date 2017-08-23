using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Utilities;

namespace DAO
{
    public class CAUHOIDAO : AbstractDAO
    {
        public List<CAUHOIDTO> LayDanhSachCauHoiTheoMonHocChuaCoTrongDeThi(long maMonHoc, long maDeThi)
        {
            try
            {
                List<CAUHOIDTO> lstKQ = new List<CAUHOIDTO>();
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_LayDanhSachCauHoiTheoMonHocChuaCoTrongDeThi", connection);

                SqlParameter sParam_maMonHoc = cmd.Parameters.Add("@MAMH", SqlDbType.BigInt);
                sParam_maMonHoc.Direction = ParameterDirection.Input;
                sParam_maMonHoc.Value = maMonHoc;

                SqlParameter sParam_maDeThi = cmd.Parameters.Add("@MADT", SqlDbType.BigInt);
                sParam_maDeThi.Direction = ParameterDirection.Input;
                sParam_maDeThi.Value = maDeThi;

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    CAUHOIDTO d = new CAUHOIDTO();
                    d.MACH = (long)rdr["MACH"];
                    d.NOIDUNG = (string)rdr["NOIDUNG"];
                    d.THANGDIEM = (double)rdr["THANGDIEM"];
                    d.SOCAUTRALOI = (int)rdr["SOCAUTRALOI"];
                    if ((int)rdr["MUCDO"] == (int)Enums.MucDoCauHoi.De)
                        d.MUCDO = "Dễ";
                    else if ((int)rdr["MUCDO"] == (int)Enums.MucDoCauHoi.Vua)
                        d.MUCDO = "Vừa";
                    else
                        d.MUCDO = "Khó";
                    lstKQ.Add(d);
                }
                return lstKQ;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<CAUHOIDTO> LayDanhSacCauHoiTheoDeThi(long maDeThi)
        {
            try
            {
                List<CAUHOIDTO> lstKQ = new List<CAUHOIDTO>();
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_LayDanhSachCauHoiTheoDeThi", connection);

                SqlParameter sParam_maDeThi = cmd.Parameters.Add("@MABDT", SqlDbType.BigInt);
                sParam_maDeThi.Direction = ParameterDirection.Input;
                sParam_maDeThi.Value = maDeThi;

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    CAUHOIDTO d = new CAUHOIDTO();
                    d.MACH = (long)rdr["MACH"];
                    d.NOIDUNG = (string)rdr["NOIDUNG"];
                    d.THANGDIEM = (double)rdr["THANGDIEM"];
                    d.SOCAUTRALOI = (int)rdr["SOCAUTRALOI"];
                    if ((int)rdr["MUCDO"] == (int)Enums.MucDoCauHoi.De)
                        d.MUCDO = "Dễ";
                    else if ((int)rdr["MUCDO"] == (int)Enums.MucDoCauHoi.Vua)
                        d.MUCDO = "Vừa";
                    else
                        d.MUCDO = "Khó";
                    d.MAMH = (long)rdr["MAMH"];
                    lstKQ.Add(d);
                }
                return lstKQ;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool ThemCauHoiVaoDeThi(long maDeThi, long maCauHoi, double diem)
        {
            try
            {
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_ThemCauHoiVaoBoDeThi", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sParam_MABDT = cmd.Parameters.Add("@MABDT", SqlDbType.BigInt);
                sParam_MABDT.Direction = ParameterDirection.Input;
                sParam_MABDT.Value = maDeThi;

                SqlParameter sParam_MACH = cmd.Parameters.Add("@MACH", SqlDbType.BigInt);
                sParam_MACH.Direction = ParameterDirection.Input;
                sParam_MACH.Value = maCauHoi;

                SqlParameter sParam_Diem = cmd.Parameters.Add("@DIEM", SqlDbType.BigInt);
                sParam_Diem.Direction = ParameterDirection.Input;
                sParam_Diem.Value = diem;

                SqlParameter sParam_ketQua = cmd.Parameters.Add("@Return", SqlDbType.Int);
                sParam_ketQua.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                connection.Close();
                return Convert.ToBoolean(sParam_ketQua.Value);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool DiChuyenCauHoiRaKhoiBoDeThi(long maDeThi, long maCauHoi)
        {
            try
            {
                SqlConnection connection = ConnectDB();
                SqlCommand cmd = new SqlCommand("sp_DiChuyenCauHoiRaKhoiDeThi", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter sParam_MABDT = cmd.Parameters.Add("@MABDT", SqlDbType.BigInt);
                sParam_MABDT.Direction = ParameterDirection.Input;
                sParam_MABDT.Value = maDeThi;

                SqlParameter sParam_MACH = cmd.Parameters.Add("@MACH", SqlDbType.BigInt);
                sParam_MACH.Direction = ParameterDirection.Input;
                sParam_MACH.Value = maCauHoi;

                SqlParameter sParam_ketQua = cmd.Parameters.Add("@Return", SqlDbType.Int);
                sParam_ketQua.Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                connection.Close();
                return Convert.ToBoolean(sParam_ketQua.Value);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
