using System;


    public class Nomor1
    {
        public static void Main(string[] args)
        {
            int range = 0 ;
            int alphabet = 64;
            int i, j ;

            Console.Write("Enter the range: ");
            range = int.Parse(Console.ReadLine());
            
            for(i=0;i<=range;i++) {
                for(j=1;j<=range-i;j++)
	        Console.Write(" ");
                for(j=1;j<=i;j++)
                    Console.Write("{0}",Convert.ToChar(alphabet+j));
                    for(j=i-1;j>=1;j--)
                        Console.Write("{0}",Convert.ToChar(alphabet+j));
        
            Console.WriteLine();
            }
        }
    
}

