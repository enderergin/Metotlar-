using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Linq.Expressions;

namespace ödev
{
    internal class Program
    {
        private static object sw;

        static void Main(string[] args)
        {
            string secim = string.Empty;
            ArrayList liste = new ArrayList();
            do
            {
                Console.WriteLine("1 - Değer ekle ");
                Console.WriteLine("2- Değer listele");
                Console.WriteLine("3- Değer Ara");
                Console.WriteLine("4- Değer düzenle ");
                Console.WriteLine("5- Değer sil ");
                Console.WriteLine("6- Uylamadan Çıkış ");
                secim = Console.ReadLine();
                switch (secim)
                { 
                    case"1":
                        Console.WriteLine("Eklemek istediğiniz değeri yazınız: ");
                        string deger1 = Console.ReadLine();
                        liste.Add(deger1);
                        Console.WriteLine("Değeriniz başarı ile eklendi.");
                        System.Threading.Thread.Sleep(1000); // Sistemi Bekletiyor
                        break;
                    case "2":
                        for (int i = 0; i < liste.Count; i++)
                        {
                            Console.WriteLine("{0} İndexteki Değerler: {1}", i, liste[i] );
                        }
                        Console.WriteLine("Devam etmek için bir tuşa basın");
                        Console.ReadLine();

                        break;
                    case "3":
                        Console.WriteLine("Aramak istediğiniz değeri giriniz");
                        string a = Console.ReadLine();
                        if (liste.Contains(a)) {
                            int bul = liste.IndexOf(a);
                            Console.WriteLine("Aradınızğınız Değer {0} indexte",bul);
                        
                        
                        }
                        else { 
                            Console.WriteLine("Girdiğiniz Değer bulunamadı "); 
                        }
                        Console.WriteLine("Değeri eklemek için 'E' Tuşuna basınız");
                        string evet = Console.ReadLine();
                        if (evet.ToUpper() == "E")
                        {
                            liste.Add(a);
                            Console.WriteLine("Girdiğiniz Değer başarı ile eklendi");
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz Değer eklenemedi Lütfen Ana Listeden ekleyin");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Güncellemek istediğinzi değeri girin ");
                        string eski = Console.ReadLine();
                        Console.WriteLine("{0} Değeri hangi değer ile güncellemek istiyorsunuz?", eski);
                        string guncel = Console.ReadLine();
                        if (liste.Contains(eski))
                        {
                            int degisecekindex = liste.IndexOf(eski);
                            liste[degisecekindex] = guncel;
                            Console.WriteLine("Değer güncellendi");

                        }
                        else
                        {
                            Console.WriteLine("Değer bulunamadı");
                        }

                        break;
                     case "5":
                        Console.WriteLine("Tüm Değerleri silmek için 'E' basın Tek değer silmek için 'H'");
                        string sil = Console.ReadLine();
                        if (sil.ToUpper() == "E")
                        {
                            liste.Clear();
                            Console.WriteLine("Tüm Değerler Silindi");

                        }
                        else
                        {
                            Console.WriteLine("Liste İçinde Silmek istediğiniz değeri Girin: ");
                            string ibul = Console.ReadLine();
                            if (liste.Contains(ibul))
                            {
                                liste.RemoveAt(liste.IndexOf(ibul));
                                Console.WriteLine("Silindi");
                            }
                            else
                            {
                                Console.WriteLine("Silmek istediğiniz değer mecvut değil");
                            }
                        }
                        break;
                    default:
                        break;

        

                }
            } while (secim != "6");
        }
    }
}
