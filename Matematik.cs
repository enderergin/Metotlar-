using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    public class Matematik
    {
        public void menu() 
        {
            Console.Clear();
            Console.WriteLine("---MENÜ----");
            Console.WriteLine("Toplama işlemi için 1. basın");
            Console.WriteLine("Çıkarma işlemi için 2. basın");
            Console.WriteLine("Çapma işlemi için 3. basın");
            Console.WriteLine("Bolme işlemi için 4. basın");
            
        }
        public decimal topla (decimal say1, decimal say2) 
        {
            decimal sonuc = say1 + say2;
            return sonuc;
        }
        public decimal cikar(decimal say1, decimal say2)
        {
            decimal sonuc = say1 - say2;
            return sonuc;
        }
        public decimal carp(decimal say1, decimal say2)
        {
            decimal sonuc = say1 * say2;
            return sonuc;
        }
        public decimal bol(decimal say1, decimal say2)
        {
            decimal sonuc = say1 / say2;
            return sonuc;
        }
        public void cikti (decimal say1, decimal say2, decimal sonuc, string opterador)
        {
            Console.WriteLine("{0} {1} {2} = {3}", say1,say2,opterador,sonuc);
        }
        public void dongu()
        {

        }
    }
}
