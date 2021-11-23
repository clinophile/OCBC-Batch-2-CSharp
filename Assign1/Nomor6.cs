using System;

    public class Nomor6
    {
        public static void Main(string[] args)
        {   
            Console.Write("Enter words: ");
            string input_word = Console.ReadLine();

            string reverse = "";  

            for(int i = input_word.Length-1 ; i >= 0 ; i--) {
                reverse = reverse + input_word[i];  
            }  

            if(input_word.Equals(reverse)) {
                Console.WriteLine("THIS IS PALINDROME");
            } else {
                Console.WriteLine("THIS IS NOT PALINDROME");
            }

  
        }
    
}