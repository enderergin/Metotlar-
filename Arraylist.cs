using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            ArrayList a = new ArrayList();
            i = a.Capacity;
            j = a.Count;
            a.Add("Ender");
            a.Add(100);
            a.Add("kemal");


            ArrayList b = new ArrayList();
            b.Add(101);
            b.Add("ergin");
            b.Add("eşref");
            a.AddRange(b);

            i = a.Capacity; // Kapasitesini Söyler
            j = a.Count; // Kaç Değer taşıdınığı söyler

            object x = a[3];

            a[2] = "hamza"; // hamzayı 2. index ile değiştirdi

            ArrayList a = new ArrayList();
            a.Add("a");
            a.Add("b");
            a.Add("c");
            a.Add("d");
            a.Add("e");
            a.Add("f");
            a.Add("g");

            ArrayList b = new ArrayList();
            b.Add("i");
            b.Add("o");
            b.Add("p");
            a.AddRange(b);

            a.Sort();// A-Z Sıralar 
            a.Reverse(); // Ters sıralar
            bool Arar = a.Contains("a"); // Değeri Arar Bulursa True döndürür
            int Indexbul = a.IndexOf("b"); // Bulursa İndex Numarasını Söyler
            Console.WriteLine(Indexbul);
            Console.ReadLine();

            #region örnek
            if (b.Contains("a"))
            {
                int kontrol = b.IndexOf("a");
                b.RemoveAt(kontrol); //siler 
            }
            #endregion
        }
    }
}
