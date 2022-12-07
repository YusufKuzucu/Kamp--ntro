using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun) //parametre verdik
        {
            Console.WriteLine("sepete eklendi : " + urun.Adi);

        }
        public void Ekle2(string urunAdi ,string Açiklama ,double Fiyat,int StokAdedi)
        {
            Console.WriteLine("sepete eklendi : " + urunAdi);

        }
    }
}
