using System;

namespace Program4{

    //public class overloading {
        class data {
            public string nama;
            public double nomor_telp;
            public void print(string nama) {
                this.nama = nama;
                Console.WriteLine("Namanya adalah: {0}", this.nama);
            }

            public void print(double nomor_telp) {
                this.nomor_telp = nomor_telp;
                Console.WriteLine("Nomor HP: {0}", this.nomor_telp);
            }
        }
    }
//}