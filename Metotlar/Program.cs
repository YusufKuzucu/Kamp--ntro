using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //clasların içeriklerini doldurduk
            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "amasya elması";


            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "karpuz gibi karpuz";


            Urun[] urunler = new Urun[] { urun1, urun2 };
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------");
            }
            Console.WriteLine("------------METOTLAR------");

            //instance -örnek 
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);  //metothu çağırdık
            sepetManager.Ekle(urun2);  //metothu çağırdık
            //classın farklı verisiyonu patlama kısmı
            sepetManager.Ekle2("armut","çok hoş",12,34);
            sepetManager.Ekle2("çilek", "çok hoş", 12, 34);
            


        }
    }
}
