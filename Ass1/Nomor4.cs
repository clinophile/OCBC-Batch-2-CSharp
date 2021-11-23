using System;


    public class Nomor4
    {
        public static void Main(string[] args)
        {   
            Console.Write("Enter any number: ");
            int angka = int.Parse(Console.ReadLine());
             
            int reverse = 0;  
            while(angka>0)  
            {  
                int temp = angka % 10;  
                reverse = (reverse * 10) + temp;  
                angka = angka / 10;  
            }  
            Console.WriteLine("Reverse Number: {0}",reverse);  
        }
    
}