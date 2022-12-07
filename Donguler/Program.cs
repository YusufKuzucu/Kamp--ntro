using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-dizi
            string[] kurslar = new string[] { "yazılım gelişrime",
                "programlama",
                "java" ,"python"};


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti ");
            //dizi temelli yapılar tek tek dolaşmaya yarıyor
            //foreach dizilere uygulanır
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");

        }
    }
}
