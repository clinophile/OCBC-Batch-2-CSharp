using System;

public class Nomor1 {
  public static void Main(string[] args) {

    int alphabet = 64;
    int i, j;


    for (i = 1; i <= 5; i++) {
        for (j = 1; j <= 5 - i; j++) {
            Console.Write(" ");
        }
        for (j = 1; j <= i; j++) {
            Console.Write("{0}", Convert.ToChar(alphabet + j));
        }
        for (j = i - 1; j >= 1; j--) {
            Console.Write("{0}", Convert.ToChar(alphabet + j)); 
        }

        Console.WriteLine();
    }
  }

}