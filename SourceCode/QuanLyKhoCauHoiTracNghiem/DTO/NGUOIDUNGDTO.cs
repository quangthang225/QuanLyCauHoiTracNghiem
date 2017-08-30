using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class NGUOIDUNGDTO
    {
        private long _MAND;

        public long MAND
        {
            get { return _MAND; }
            set { _MAND = value; }
        }

        private string _HOTEN;

        public string HOTEN
        {
            get { return _HOTEN; }
            set { _HOTEN = value; }
        }

        private string _TENDANGNHAP;

        public string TENDANGNHAP
        {
            get { return _TENDANGNHAP; }
            set { _TENDANGNHAP = value; }
        }

        private string _MATKHAU;

        public string MATKHAU
        {
            get { return _MATKHAU; }
            set { _MATKHAU = value; }
        }

        private bool _TRANGTHAI;

        public bool TRANGTHAI
        {
            get { return _TRANGTHAI; }
            set { _TRANGTHAI = value; }
        }
        private bool _TOANQUYENGV;

        public bool TOANQUYENGV
        {
            get { return _TOANQUYENGV; }
            set { _TOANQUYENGV = value; }
        }

        private long _MALOAI;

        public long MALOAI
        {
            get { return _MALOAI; }
            set { _MALOAI = value; }
        }

        private long _MABM;

        public long MABM
        {
            get { return _MABM; }
            set { _MABM = value; }
        }

        private long _MAGVQL;

        public long MAGVQL1
        {
            get { return _MAGVQL; }
            set { _MAGVQL = value; }
        }

        public long MAGVQL
        {
            get { return _MAGVQL; }
            set { _MAGVQL = value; }
        }

        private string _TENLOAIND;
        public string TENLOAIND
        {
            get
            {
                return _TENLOAIND;
            }

            set
            {
                _TENLOAIND = value;
            }
        }

        private string _TENBM;
        public string TENBM
        {
            get
            {
                return _TENBM;
            }

            set
            {
                _TENBM = value;
            }
        }

        private string _TENGVQL;
        public string TENGVQL
        {
            get
            {
                return _TENGVQL;
            }

            set
            {
                _TENGVQL = value;
            }
        }
    }
}
