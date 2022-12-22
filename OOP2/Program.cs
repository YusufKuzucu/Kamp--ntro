using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GerçekMüsteri müsteri1 = new GerçekMüsteri();
            müsteri1.Id = 1;
            müsteri1.MüsteriNo = "123124512";
            müsteri1.Adi = "yusuf";
            müsteri1.Soyadi = "kzc";
            müsteri1.TcNo="4151351254774542";

            TüzelMüsteri müsteri2 = new TüzelMüsteri();
            müsteri2.Id = 2;
            müsteri2.MüsteriNo = "31241";
            müsteri2.SirketNo = "412412412";
            müsteri2.SirketAdi = "kod";
            müsteri2.VergiNo = "123213124";


            Müsteri müsteri3 = new GerçekMüsteri();
            
            
            Müsteri müsteri4 = new TüzelMüsteri();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(müsteri1);
            customerManager.Ekle(müsteri2);
            customerManager.Ekle(müsteri3);
            customerManager.Ekle(müsteri4);



        }
    }
}
