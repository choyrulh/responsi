using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2645
{
    class Karyawan
    {
        public int _nomer { get; set; }
        public string _nik { get; set; }
        public string _nama { get; set; }
        public double _gaji { get; set; }

        public Karyawan(int nomer, string nik, string nama, double gaji)
        {
            _nomer = nomer;
            _nik = nik;
            _nama = nama;
            _gaji = gaji;

            if (_gaji < 0)
            {
                _gaji = 0;
            }

        }
    }
}