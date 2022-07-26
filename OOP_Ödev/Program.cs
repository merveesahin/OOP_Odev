using System;
using System.Threading;

namespace OOP_Ödev
{
    public class Program
    {
        //Delegate, bir yada birden fazla metot referansı saklayabilen yapılardır. Metot tutucudur.
        public delegate void Matematiksel(int param, int param2);
        //public static int Topla(int a, int b)
        //{
        //    return a + b;
        //}
        static void Topla(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        //static int Carp(int a, int b)
        //{
        //    return a * b;
        //}
        static void Carp(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        static void Main(string[] args)
        {
            //Matematiksel matematik = new Matematiksel(Carp);
            //matematik += Topla; //*//birden fazla metot (carp+topla) bir delegate'e atandı.
            //int sonuc = matematik(10, 15);
            //Console.WriteLine(sonuc); //*//geriye değer döndürdüğü için geriye dönen değer son metot referansından döndü o nedele sonuç 25 olur.
            //matematik(10, 15); //*// çıktı= 150, 25
            //matematik.Invoke(10, 15); //*// delegate i çağırmanın başka bir yoludur. Senkron çalışır.
            //matematik.BeginInvoke(10, 15); //*// delegate i çağırmanın başka bir yoludur. Asenkron çalışır.
            //matematik -= Carp; //*// bir metot referansı delegate den çıkarıldı
            //matematik(10, 1); //*// çıktı= 150, 25, 11  

            //*//Extension Method
            //String str = "merve";
            //String ifade = str.GetFirstTwoCharacters();
            //Console.WriteLine(ifade);

            //*//Delegate Event
            Otomobil arabam = new Otomobil();
            arabam.HizAsildi += new HizEventHandler(arabam_HizAsildi);
            for (int i = 70; i <= 90; i+=5)
            {
                arabam.Hiz = i;
                Console.WriteLine("Hızınız, {0}", arabam.Hiz);
                Thread.Sleep(1000);
            }

        }
        public static void arabam_HizAsildi(object sender, HizArgs arg)
        {
            Console.WriteLine("Hız Sınırı Aşıldı!!!!" +" "+ arg.Zaman);
        }


    }

     
}
