using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    public class Program
    {
        public static void Main(string[] args)
        {


            Vatandas vatandas = new Vatandas();
            string mesaj = "selam";
            double tutar = 1234;

            Console.WriteLine(mesaj);
            Console.WriteLine(tutar);
            SelamVer();
            Topla(3, 4);


            Console.ReadLine();

        }
        static void SelamVer()
        {
            Console.WriteLine("Merhaba");
        }
        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            return sonuc;
        }
    }

    public class Vatandas
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }
}
