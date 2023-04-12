using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int not1 = 0;
            int not2 = 0;
            int not3 = 0;
            int ort = 0;

            Console.WriteLine("Öğrencinin bilgilerini giriniz ");
            Console.WriteLine("AD: ");
            string ad = Console.ReadLine();
            Console.WriteLine("SOYAD: ");
            string soyad = Console.ReadLine();
            Console.WriteLine("Not1: ");
            not1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Not2: ");
            not2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Not3: ");    
            not3 = Convert.ToInt32(Console.ReadLine());
            veri o = new veri();
            o.ogrenci(ad, soyad, not1,not2,not3,ort);
            Console.WriteLine(o);
        }
    }
}
