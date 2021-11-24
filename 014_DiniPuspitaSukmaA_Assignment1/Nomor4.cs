using System;


    public class Nomor4
    {
        public static void Main(string[] args)
        {   
            Console.Write("Enter any number: ");
            string angka = Console.ReadLine();
             
            string reverse = "";  

            for(int i = angka.Length-1 ; i >= 0 ; i--) {
                reverse = reverse + angka[i];  
            }  
            Console.WriteLine("Reverse Number: " + reverse);  
        }
    
}