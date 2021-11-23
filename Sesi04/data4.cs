using System;


    public class data4{
        public static void Main(string[] args)
        {
            int x = 1;
            int[,] data4 = new int[10,2];

            for(int i=0; i<10; i++)
            {
                for(int j=0; j<2; j++)
                {
                    if(j==0){
                        data4[i,j] = x;
                        Console.Write(data4[i,j]+" ");
                    }
                    else{
                        data4[i,j] = x*x;
                        Console.Write(data4[i,j]+" ");
                    }
                }
                x++;
                Console.WriteLine();
            }
        }
    }
