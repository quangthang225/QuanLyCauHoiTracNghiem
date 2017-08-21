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
        [DisplayName("Mã đề thi")]
        public long MABDT
        {
            get { return _MABDT; }
            set { _MABDT = value; }
        }

        private string _TENBDT;
        [DisplayName("Tên")]
        public string TENBDT
        {
            get { return _TENBDT; }
            set { _TENBDT = value; }
        }

        private int _HOCKY;
        [DisplayName("Học kỳ")]
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

        public DETHIDTO()
        {

        }
        public DETHIDTO(long madt,string tenbdt, int hocky, int namhoc,long maNguoiDung)
        {
            this._MABDT = madt;
            this._TENBDT = tenbdt;
            this._HOCKY = hocky;
            this._NAMHOC = namhoc;
            this._MAGVTAO = maNguoiDung;
        }
    }
}
