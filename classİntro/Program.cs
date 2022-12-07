using System;

namespace classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "engin";
            int yas = 36;

            //gerçek hayat
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.eğitmen = "engin demiroğ";
            kurs1.İzlenmeOrani = 58;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "java";
            kurs2.eğitmen = "kerem demiroğ";
            kurs2.İzlenmeOrani =64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "python";
            kurs3.eğitmen = "berke ";
            kurs3.İzlenmeOrani = 69;
            
            //Console.WriteLine(kurs1.KursAdi +  " " +kurs1.eğitmen);
            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.eğitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string eğitmen { get; set; }
        public int İzlenmeOrani { get; set; }

    }
}
