using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //bu claslar varlıktır üzerinde methodlar olmaz. Müsteri Claslarında olur. Tüzel veya gerçek must. claslarında olmaz
    //İnheritance
    //Müsteride olan özellikler gerçekte de tüzelde de var demektir miras
    class GercekMusteri : Musteri //Müsteri parents oldu.
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
