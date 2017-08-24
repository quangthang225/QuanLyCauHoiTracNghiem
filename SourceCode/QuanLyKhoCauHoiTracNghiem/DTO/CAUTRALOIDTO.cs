using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CAUTRALOIDTO
    {
        private long _MACTL;

        public long MACTL
        {
            get
            {
                return _MACTL;
            }

            set
            {
                _MACTL = value;
            }
        }

        private string _NOIDUNG;

        public string NOIDUNG
        {
            get
            {
                return _NOIDUNG;
            }

            set
            {
                _NOIDUNG = value;
            }
        }

        private bool _LADAPANDUNG;

        public bool LADAPANDUNG
        {
            get
            {
                return _LADAPANDUNG;
            }

            set
            {
                _LADAPANDUNG = value;
            }
        }
    }
}
