using System;


    public class final_assignment1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("====WELCOME TO ASSIGNMENT 1====") ;
            Console.WriteLine() ;

            Console.WriteLine("Nama : Dini Puspita Sukma Ariyanti") ;
            Console.WriteLine("Kode Peserta : FSDO002ONL014");
            Console.WriteLine("Alamat : Bandung");
            Console.WriteLine() ;

            Console.WriteLine("Tipe Soal : ") ;
            Console.WriteLine("1. Segitiga Alfabet") ;
            Console.WriteLine("2. Segitiga Angka") ;
            Console.WriteLine("3. Faktorial") ;
            Console.WriteLine("4. Reversed Number") ;
            Console.WriteLine("5. Convert Number to String") ;

            
            string ulang = "N";

            
            do {
                Console.Write("Silahkan Masukan Nomor Tipe Soal: ") ;
                int tipe_soal = int.Parse(Console.ReadLine()) ;

                switch(tipe_soal) {
                    case 1 : {
                        Console.WriteLine() ;
                        Console.WriteLine("Anda memilih : 1. Segitiga Alfabet") ;

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
                        break ;
                    }
                    case 2 : {
                        Console.WriteLine() ;
                        Console.WriteLine("Anda memilih : 2. Segitiga Angka") ;
                        
                        int range = 0;
                        int i, j;

                        Console.Write("Enter the range: ");
                        range = int.Parse(Console.ReadLine());

                        for (i = 1; i <= range; i++) {
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
                        break;
                    }
                    case 3 : {
                        Console.WriteLine() ;
                        Console.WriteLine("Anda memilih : 3. Faktorial") ;

                        int result = 1 ;
                        Console.Write("Enter any number: ");
                        int angka = int.Parse(Console.ReadLine());
                        
                        for(int i= 1; i <= angka; i++) {    
                        result = result * i ;
                        }

                        Console.Write("Factorial of " + angka + " is: " + result);
                        break ;
                    }
                    case 4 : {
                        Console.WriteLine() ;
                        Console.WriteLine("Anda memilih : 4. Reversed Number") ;

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
                        break ;
                    }
                    case 5 : {
                        Console.WriteLine() ;
                        Console.WriteLine("Anda memilih : 5. Convert Number to String") ;

                        string[] words_angka = {"zero", "one", "two", "three", "four",
                        "five", "six", "seven", "eight", "nine"};

                        Console.Write("Enter any number: ");
                        string angka = Console.ReadLine();
                        string result = "";

                        for(int i = 0 ; i < angka.Length ; i++) {
                            int temp = (int)Char.GetNumericValue(angka[i]) ;
                            result += words_angka[temp] + " ";   
                            
                        }

                        Console.WriteLine(result);
                        break ;
                    }
                    default : {
                        Console.WriteLine("Invalid Number");
                        break ;
                    }
                }

                Console.WriteLine();
                Console.Write("Ingin mencoba lagi? (Y/N) : ");
                ulang = Console.ReadLine() ;
                
            }
            while (ulang == "Y") ;

            if(ulang == "N") {
                Console.WriteLine("Terimakasih telah mencoba! :)");
            }
            
        }
    }