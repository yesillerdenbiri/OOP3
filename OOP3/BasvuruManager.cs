using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,List<ILoggerService> loggerServices) //referans almasını söylicez. Başvuru fonksiyonunu krediden bağımsız hale getirdik.
        {
            //başvuran bilgilerini değerlendirme

           // KonutKrediManager konutKrediManager = new KonutKrediManager();//yanlış bir kullanım
           krediManager.Hesapla();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
