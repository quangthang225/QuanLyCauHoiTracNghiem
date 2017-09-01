using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class LOAINGUOIDUNGDTO
    {
        private long _MALOAI;

        public long MALOAI
        {
            get
            {
                return _MALOAI;
            }

            set
            {
                _MALOAI = value;
            }
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
    }
}
