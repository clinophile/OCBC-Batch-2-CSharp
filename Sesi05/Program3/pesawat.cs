using System;

namespace Program3 {
    public class pesawat {
        public string nama;
        private string ketinggian1;
        private string jumlahPenumpang1;
        private int jumlahRoda1;

        public string ketinggian {
            get {return ketinggian1 ;}
            set { ketinggian1 = value;}
        }

        public string jumlahPenumpang {
            get {return jumlahPenumpang1 ;}
            set { jumlahPenumpang1 = value;}
        }

        public int jumlahRoda {
            get {return jumlahRoda1 ;}
            set { jumlahRoda1 = value;}
        }

        public void terbang() {
             Console.WriteLine("Pesawat Tempur dengan nama {0} " +
                "yang mempunyai jumlah roda {1} " +
                "sedang berada pada ketinggian {2} " + 
                "dengan membawa jumlah penumpang sebanyak {3} akan meledakan senjata",
                this.nama, this.jumlahRoda, this.ketinggian, this.jumlahPenumpang);
        }

        public void sudahTerbang() {
            Console.WriteLine("Pesawat sekarang berada pada ketinggian {0}", this.ketinggian);
        }
    
    }

        class pesawat_tempur: pesawat {
            public void terbangTinggi() {
                Console.WriteLine("Pesawat Tempur dengan nama {0} " +
                "yang mempunyai jumlah roda {1} " +
                "sedang berada pada ketinggian {2} " + 
                "dengan membawa jumlah penumpang sebanyak {3} akan meledakan senjata",
                this.nama, this.jumlahRoda, this.ketinggian, this.jumlahPenumpang);
            }
        }
    }

