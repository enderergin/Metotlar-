
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework.S10.D3.StaticBolumSonuOdevUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgi M1 = new Bilgi();
            M1.musteriID = 1;
            M1.isim = "ender";
            M1.soyisim = "ergin";
            M1.emailAdres = "sda@gmail.com";
            M1.KullaniciAdi = "ender.ergin";
            M1.sifre = "1";

            Bilgi.MusteriEkle(M1);

            Bilgi M2 = new Bilgi()
            {
                musteriID = 2,
                isim = "ender",
                soyisim = "ergin",
                emailAdres = "enderergin31@gmail.com",
                KullaniciAdi = "ahmet.atilla",
                sifre = "2"
            };

            Bilgi.MusteriEkle(M2);

            Bilgi M3 = new Bilgi();
            M3.musteriID = 1;
            M3.isim = "ender";
            M3.soyisim = "ergin";
            M3.emailAdres = "enderergin@endrergn.com.tr";
            M3.KullaniciAdi = "ender_ergin";
            M3.sifre = "1";

            Bilgi.MusteriEkle(M3);


        }
    }
}
