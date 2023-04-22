
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
            M1.isim = "Cengiz";
            M1.soyisim = "Atilla";
            M1.emailAdres = "cengiz.atilla@hotmail.com";
            M1.KullaniciAdi = "cengiz.atilla";
            M1.sifre = "1";

            Bilgi.MusteriEkle(M1);

            Bilgi M2 = new Bilgi()
            {
                musteriID = 2,
                isim = "Ahmet",
                soyisim = "Atilla",
                emailAdres = "ahmet.atilla@hotmail.com",
                KullaniciAdi = "ahmet.atilla",
                sifre = "2"
            };

            Bilgi.MusteriEkle(M2);

            Bilgi M3 = new Bilgi();
            M3.musteriID = 1;
            M3.isim = "Cengiz";
            M3.soyisim = "Atilla";
            M3.emailAdres = "cengiz.atilla@hotmail.com";
            M3.KullaniciAdi = "cengiz.atilla";
            M3.sifre = "1";

            Bilgi.MusteriEkle(M3);


        }
    }
}
