using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarasi variable
            int hasil;

            //Membuat objek dari kelas Calculator
            Calculator calculator = new Calculator();

            //Panggil method penjumlah
            hasil = calculator.Penjumlah(10, 2);
            CetakHasil("Hasil Penjumlahan : " + hasil);
    

            //Panggil method penjumlah dengan 3 apramewter overload method
            hasil = calculator.Penjumlah(19, 2, 3);
            CetakHasil("Hasil Penjumlahan overload : " + hasil);

            //Panggil Method pengurangan
            hasil = calculator.Pengurangan(7, 2);
            CetakHasil("Hasil Pengurangan : " + hasil);

            //Panggil Method perkalian
            hasil = Calculator.Perkalian(5, 2);
            CetakHasil("Hasil Perkalian : " + hasil);

            Console.ReadKey();
        }

        static void CetakHasil(string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}
