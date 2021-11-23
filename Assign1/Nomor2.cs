using System;

public class Nomor2 {
  public static void Main(string[] args) {
    int range = 0;
    int i, j;

    Console.Write("Enter the range: ");
    range = int.Parse(Console.ReadLine());

    for (i = 0; i <= range; i++) {
        for (j = 1; j <= range - i; j++) {
            Console.Write(" ");
        }
        for (j = 1; j <= i; j++) {
            Console.Write("{0}", j);
        }
        for (j = i - 1; j >= 1; j--) {
            Console.Write("{0}", j); 
        }

        Console.WriteLine();
    }
  }

}