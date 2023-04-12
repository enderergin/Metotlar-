using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not
{
    public class veri
    {
        public void ogrenci(string ad, string soyad, int not1, int not2, int not3, int ort)
        {
             ort = (not1 + not2 + not3)/3;

            if (ort < 45) 
            {
                Console.WriteLine("{0} kaldınız", ort);
            }
            else
            {
                Console.WriteLine("geçtiniz");
            }
            Console.ReadKey();

        }

    }
}
