using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();// loglama alternatifleri
            ILoggerService fileLoggerService = new FileLoggerService();



            List<ILoggerService> loggers=new List<ILoggerService> { new SmsLoggerService(), new DatabaseLoggerService() };
           
            BasvuruManager basvuruManager = new BasvuruManager();
           // basvuruManager.BasvuruYap(tasitKrediManager, fileLoggerService); // hangi krediyi gönderirsek onun hesaplası çalışacak ve loglaması istenen tip çalışacak

          

            // IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //IKrediManager tasitKrediManager = new TasitKrediManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(),loggers );  //şeklinde de kullanılabilir

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager , konutKrediManager , tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
          
        }
    }
}
