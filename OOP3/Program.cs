using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyaçKrediManager = new İhtiyaçKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FİleLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BaşvuruYap(ihtiyaçKrediManager, databaseLoggerService);



            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyaçKrediManager,tasitKrediManager,konutKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
