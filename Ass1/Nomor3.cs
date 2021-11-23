using System;


    public class Nomor3
    {
        public static void Main(string[] args)
        {   
            int result = 1 ;
            Console.Write("Enter any number: ");
            int angka = int.Parse(Console.ReadLine());
            
            for(int i= 1; i <= angka; i++) {    
               result = result * i ;
            }

            Console.Write("Factorial of " + angka + " is: " + result);
        }
    
}

