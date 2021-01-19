using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generikKoleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            kitap k = new kitap();
            k.isim = "Cin ali";
            k.yazar = "anonim";
            k.yayinevi="yayınevler";
            k.fiyat = 12;

            kitap k2 = new kitap();
            k2.isim = "monte cristo";
            k2.yazar = "alex";
            k2.yayinevi = "metis";
            k2.fiyat = 25;

            List<kitap> kitaplar = new List<kitap>();
            kitaplar.Add(k);
            kitaplar.Add(k2);

            foreach (kitap item in kitaplar)
            {
                Console.WriteLine(item.isim+" "+item.yazar+" "+item.yayinevi+" "+item.fiyat+" TL");
            }
        }
    }
    class kitap
    {
        public string isim { get; set; }
        public string yazar { get; set; }
        public string yayinevi { get; set; }
        public double fiyat { get; set; }
    }
}
