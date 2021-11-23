using System;


    public class Nomor5
    {
        public static void Main(string[] args)
        {   
            string[] words_angka = {"zero", "one", "two", "three", "four",
            "five", "six", "seven", "eight", "nine"};

            Console.Write("Enter any number: ");
            string angka = Console.ReadLine();
            string result = "";

            for(int i = 0 ; i < angka.Length ; i++) {
                int temp = (int)Char.GetNumericValue(angka[i]) ;
                result += words_angka[temp] + " ";   
                
            }

            Console.Write(result);
  
        }
    
}