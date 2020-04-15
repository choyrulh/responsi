  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman2645
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan pertama = new Karyawan(1, "190300123", "Choirul", 3000000);
            Karyawan kedua = new Karyawan(2, "190300124", "Humam", 2000000);
            TampilkanGaji(pertama);
            TampilkanGaji(kedua);
            Console.WriteLine("No NIK/Nama\t Gaji Bulanan");
            Console.WriteLine("===============================");
            Console.WriteLine("Alhamdulillah Kenaikan Gaji 10%");
            Console.WriteLine("No NIK/Nama\t Gaji Bulanan");
            Console.WriteLine("===============================");
            TambahanGaji(pertama);
            TambahanGaji(kedua);

            Console.ReadKey();

        }
        static void TampilkanGaji(Karyawan Pegawai)
        {
            Console.WriteLine(Pegawai._nomer + ". " + Pegawai._nik + " " + Pegawai._nama + " " + Pegawai._gaji);
        }

        static void TambahanGaji(Karyawan Pegawai)
        {
            double tambahan;
            tambahan = Pegawai._gaji * 0.1;
            Pegawai._gaji = Pegawai._gaji + tambahan;
            Console.WriteLine(Pegawai._nomer + ". " + Pegawai._nik + " " + Pegawai._nama + " " + Pegawai._gaji);
        }


    }
}


