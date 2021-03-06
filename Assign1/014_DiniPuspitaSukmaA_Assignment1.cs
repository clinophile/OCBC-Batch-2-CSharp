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
            
            string ulang = "N";

            
            do {
                Console.WriteLine() ;
                Console.WriteLine("Tipe Soal : ") ;
                Console.WriteLine("1. Segitiga Alfabet") ;
                Console.WriteLine("2. Segitiga Angka") ;
                Console.WriteLine("3. Faktorial") ;
                Console.WriteLine("4. Reversed Number") ;
                Console.WriteLine("5. Convert Number to String") ;
                Console.WriteLine("6. Palindrome") ;
                
                Console.Write("Silahkan Masukan Nomor Tipe Soal: ") ;
                int tipe_soal = int.Parse(Console.ReadLine()) ;

                switch(tipe_soal) {
                    case 1 : {
                        Console.WriteLine() ;
                        Console.WriteLine("Anda memilih : 1. Segitiga Alfabet") ;
                        Soal1() ;
                        break ;
                    }
                    case 2 : {
                        Console.WriteLine() ;
                        Console.WriteLine("Anda memilih : 2. Segitiga Angka") ;
                        Soal2();
                        break;
                    }
                    case 3 : {
                        Console.WriteLine() ;
                        Console.WriteLine("Anda memilih : 3. Faktorial") ;
                        Soal3();
                        break ;
                    }
                    case 4 : {
                        Console.WriteLine() ;
                        Console.WriteLine("Anda memilih : 4. Reversed Number") ;
                        Soal4() ;  
                        break ;
                    }
                    case 5 : {
                        Console.WriteLine() ;
                        Console.WriteLine("Anda memilih : 5. Convert Number to String") ;
                        Soal5() ;
                        break ;
                    }
                    case 6 : {
                        Console.WriteLine() ;
                        Console.WriteLine("Anda memilih : 6. Palindrome") ;
                        Soal6();
                        break;
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


        public static void Soal1() {
            int range;
            int alphabet = 64;
            int i, j;
            Console.Write("Enter the range: ");
            range = int.Parse(Console.ReadLine());

            for (i = 1; i <= range; i++) {
                for (j = 1; j <= range - i; j++) {
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

        public static void Soal2() {
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
        }


        public static void Soal3() {
            int result = 1 ;
            Console.Write("Enter any number: ");
            int angka = int.Parse(Console.ReadLine());
            
            for(int i= 1; i <= angka; i++) {    
            result = result * i ;
            }

            Console.WriteLine("Factorial of " + angka + " is: " + result);
        }

        public static void Soal4() {
            Console.Write("Enter any number: ");
            string angka = Console.ReadLine();
            
            string reverse = "";  

            for(int i = angka.Length-1 ; i >= 0 ; i--) {
                reverse = reverse + angka[i];  
            }  
            Console.WriteLine("Reverse Number: " + reverse);
        }

        public static void Soal5() {
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
        }

        public static void Soal6() {
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