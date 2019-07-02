using System;

namespace LatihanAgregasi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Membuat Objek Kar.1
            Karyawan karyawan1 = new Karyawan();
            karyawan1.Nama = "Bagas";

            //Membuat Objek Kar.2
            Karyawan karyawan2 = new Karyawan();
            karyawan2.Nama = "Bagus";

            //Membuat Objek Perusahaan
            Perusahaan perusahaan = new Perusahaan();

            //Membuat Project Agregasi
            perusahaan.DaftarKaryawan.Add(karyawan1);
            perusahaan.DaftarKaryawan.Add(karyawan2);

            int noUrut = 1;

            Console.WriteLine("Daftar karyawan:");
            foreach (Karyawan karyawan in perusahaan.DaftarKaryawan)
            {
                Console.WriteLine("{0}. {1}", noUrut, karyawan.Nama);
                noUrut++;
            }

            Console.ReadKey();

        }
    }
}
