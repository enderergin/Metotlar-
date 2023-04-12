using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematik m = new Matematik();
            basadon:
            m.menu();
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.degeri girin");
            decimal say1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.degeri girin");
            decimal say2 = Convert.ToInt32(Console.ReadLine());

            decimal sonuc = 0;


            switch (s)
            {
                case 1:
                   sonuc = m.topla(say1, say2);
                    m.cikti(say1, say2, sonuc, "+");
                    break;
                case 2:
                   sonuc = m.cikar(say1, say2);
                    m.cikti(say1, say2, sonuc, "-");
                    break;
                case 3:
                   sonuc = m.carp(say1, say2);
                    m.cikti(say1, say2, sonuc, "*");

                    break;
                case 4:
                   sonuc = m.bol(say1, say2);
                    m.cikti(say1,say2,sonuc,"/");
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem seçtiniz");
                    Console.WriteLine("Yeniden deneyin!");
                    goto basadon;
                    

            }
            Console.WriteLine("Başa dönmek için (E/H)");
            string d = Console.ReadLine();
            if (d.ToUpper() == "E")
            {
                goto basadon;
            }
        }
    }
}
