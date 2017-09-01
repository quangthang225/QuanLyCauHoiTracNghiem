using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class BOMONDTO
    {
        private long _MABM;

        public long MABM
        {
            get { return _MABM; }
            set { _MABM = value; }
        }

        private string _TENBM;

        public string TENBM
        {
            get { return _TENBM; }
            set { _TENBM = value; }
        }

        public override string ToString()
        {
            return _TENBM;
        }
    }
}
