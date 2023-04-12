using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Eng_Tr
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Hashtable sozluk = new Hashtable();
            do
            {
                Console.Clear();
                Console.WriteLine("Eklemek istediğiniz ingilizce söcüğü girin ");
                string sozcuk = Console.ReadLine();
                bool kontol = sozluk.Contains(sozcuk);
                if (kontol)
                {
                    Console.WriteLine("{0} Değer listede {1} olarak mevcut", sozcuk, sozluk[sozcuk]);


                }
                else
                {
                    Console.WriteLine("Türkçe karşılığını yazınız");
                    string tr = Console.ReadLine();
                    sozluk.Add(sozcuk,tr );
                    Console.WriteLine("ekleme başarılı");
                    

                }
                Console.WriteLine("yeni değer eklemek istiyor musunuz ? (E/H)");

            } while (Console.ReadLine().ToUpper() != "H");
            Console.WriteLine("Liste aşşağıdaki gibidir: ");
            foreach (var item in sozluk)
            {
                Console.WriteLine("EN : {0}  = TR : {1}", item, sozluk[item]);
            }
            Console.ReadLine();
            // Stack = girilen Son veriye ilk başta sıralayan array Oueue ise tam tersi
            // Sortedlist Tek aynı veri tipi şart olan hashtable    
        }
    }
}
