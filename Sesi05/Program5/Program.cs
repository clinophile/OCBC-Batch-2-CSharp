using System;

namespace program5
{
    class Program
    {
        public int bil1, bil2;

        public void bilangan(int angka1, int angka2) {
            bil1 = angka1 ;
            bil2 = angka2 ;
        }

        public virtual void penjumlahanperkaliandll() {
            Console.WriteLine("Overiding 1.....----->>>>>");
            Console.WriteLine("Hasil penjumlahan angka {0} dan angka {1} = {2}",
            bil1, bil2, bil1+bil2);
            Console.WriteLine("Hasil perkalian angka {0} dan angka {1} = {2}",
            bil1, bil2, bil1*bil2);
        }
    }

    class overide:Program {

        public override void penjumlahanperkaliandll() {
            Console.WriteLine("Overiding 2.....----->>>>>");
            Console.WriteLine("Hasil pembagian angka {0} dan angka {1} = {2}",
            bil1, bil2, bil1/bil2);
            Console.WriteLine("Hasil pengurangan angka {0} dan angka {1} = {2}",
            bil1, bil2, bil1-bil2);
        }


        static void Main(string[] args)
        {
            Program overiding = new Program();
            overiding.bilangan(10,5);
            overiding.penjumlahanperkaliandll();

            overiding = new overide();
            overiding.bilangan(20,5);
            overiding.penjumlahanperkaliandll();
            Console.Read();
        }
    }
}
