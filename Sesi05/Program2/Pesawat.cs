using System;

public class Pesawat {

//    class class_Pesawat {

        public string nama;
        private string ketinggian1;

        public string ketinggian {
            get {return ketinggian1 ;}
            set { ketinggian1 = value;}
        }

        public void terbang() {
            Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.nama);
        }

        public void sudahTerbang() {
            Console.WriteLine("Pesawat sekarang berada pada ketinggian {0}", this.ketinggian);
        }

//    }
}