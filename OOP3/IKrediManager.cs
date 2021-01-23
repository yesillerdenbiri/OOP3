using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{ 
    //interface olduğu belli olsun diye başına I harfi koyulur
    interface IKrediManager
    {
        void Hesapla(); //hepsinde ortak ancak içerik farklı olacak.Bu yüzden interface tanımlıyoruz.
        void BiseyYap();
    } //eğer interface kullanılıyorsa onunla ilgili herşey kullanılmalı


}
