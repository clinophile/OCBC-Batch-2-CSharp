using System;

    public class data3{
        public static void Main(string[] args)
        {
            int m, n, x = 1;
            int[,] tabel = new int[3,4];

            for(m=0; m<3; m++)
            {
                for(n=0; n<4; n++)
                {
                    tabel[m,n] = x;
                    Console.Write(tabel[m,n]+" ");
                    x++;
                }
                Console.WriteLine();
            }
        }
    }
