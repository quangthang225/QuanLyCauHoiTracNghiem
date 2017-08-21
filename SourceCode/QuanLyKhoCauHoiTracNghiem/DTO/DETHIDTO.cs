using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DTO
{
    public class DETHIDTO
    {
        private long _MABDT;
        public long MABDT
        {
            get { return _MABDT; }
            set { _MABDT = value; }
        }

        private string _TENBDT;
        public string TENBDT
        {
            get { return _TENBDT; }
            set { _TENBDT = value; }
        }

        private int _HOCKY;
        public int HOCKY
        {
            get { return _HOCKY; }
            set { _HOCKY = value; }
        }

        private int _NAMHOC;
        [DisplayName("Năm học")]
        public int NAMHOC
        {
            get { return _NAMHOC; }
            set { _NAMHOC = value; }
        }

        private long _MAGVTAO;
        public long MAGVTAO
        {
            get { return _MAGVTAO; }
            set { _MAGVTAO = value; }
        }

        private long _MAMH;
        public long MAMH
        {
            get { return _MAMH; }
            set { _MAMH = value; }
        }

        private string _TENMH;
        public string TENMH
        {
            get { return _TENMH; }
            set { _TENMH = value; }
        }

        public DETHIDTO()
        {
        }

        public DETHIDTO(long madt,string tenbdt, int hocky, int namhoc,long maNguoiDung, long maMonHoc, string tenMonHoc)
        {
            this._MABDT = madt;
            this._TENBDT = tenbdt;
            this._HOCKY = hocky;
            this._NAMHOC = namhoc;
            this._MAGVTAO = maNguoiDung;
            this._MAMH = maMonHoc;
            this._TENMH = tenMonHoc;
        }
    }
}
