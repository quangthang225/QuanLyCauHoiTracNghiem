using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class MONHOCDTO
    {
        private long _MAMONHOC;

        public long MAMONHOC
        {
            get { return _MAMONHOC; }
            set { _MAMONHOC = value; }
        }

        private string _TENMONHOC;

        public string TENMONHOC
        {
            get { return _TENMONHOC; }
            set { _TENMONHOC = value; }
        }

        private string _TENBOMON;

        public string TENBOMON
        {
            get { return _TENBOMON; }
            set { _TENBOMON = value; }
        }

        private long _MABOMON;

        public long MABOMON
        {
            get { return _MABOMON; }
            set { _MABOMON = value; }
        }

        public override string ToString()
        {
            return _TENMONHOC;
        }
    }
}
