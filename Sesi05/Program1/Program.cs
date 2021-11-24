using System;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();        

 //           laptop1.merk = "lenovo";
 //           laptop1.ram = 4 ;
 //           laptop1.memory = 128;

            Console.Write("Masukan merk laptop: ");
            laptop1.merk = Console.ReadLine();
            Console.Write("Masukan kapasitas RAM: ");
            laptop1.ram = int.Parse(Console.ReadLine());
            Console.Write("Masukan kapasitas memory: ");
            laptop1.memory = int.Parse(Console.ReadLine());


            Console.WriteLine("\nMerk Laptop adalah {0}", laptop1.merk);
            Console.WriteLine("Kapasitas RAM ada {0}", laptop1.ram);
            Console.WriteLine("Kapasitas Memory ada {0}", laptop1.memory);

            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            Console.Read();

        }
    }
}
