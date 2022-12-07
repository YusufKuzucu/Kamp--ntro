using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety=tip güvenliği
            //do not repeat yourself
            //değer tutucu ,alias
            string kategoriEtiketi = "Kategoriler";
            int oğrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirişYapmnmişMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış butonu göster");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış butonu göster");
            }
            else
            {
                Console.WriteLine("değişmedi");
            }

            if (sistemeGirişYapmnmişMi==true)
            {
                Console.WriteLine("evet doğru");
            }
            else
            {
                Console.WriteLine("hayır giriş yapmamış");
            }





            


            
        }
    }
}
