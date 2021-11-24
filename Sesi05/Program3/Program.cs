using System;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            pesawat pesawat = new pesawat();
            pesawat_tempur pesawat_Tempur = new pesawat_tempur() ;

            pesawat.nama = "Helly" ;
            pesawat.jumlahRoda = 3 ;
            pesawat.ketinggian = "1000 kaki";
            pesawat.jumlahPenumpang = "3 penumpang";

            pesawat_Tempur.nama = "AZ500TPU";
            pesawat_Tempur.jumlahRoda = 5 ;
            pesawat_Tempur.ketinggian = "200 kaki";
            pesawat_Tempur.jumlahPenumpang = "2 penumpang plus kopilot dan asistance";

            pesawat.terbang();
            pesawat_Tempur.terbangTinggi();
            Console.Read();

        }
    }
}
