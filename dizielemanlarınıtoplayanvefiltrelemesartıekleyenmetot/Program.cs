using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizielemanlarınıtoplayanvefiltrelemesartıekleyenmetot
{
    internal class Program
    {
        static int FiltreleVeTopla(int[] dizi, int filtre)
        {
            int toplam = 0;

            foreach (int eleman in dizi)
            {
                if (eleman > filtre)
                {
                    toplam += eleman;
                }
            }

            return toplam;
        }

        static void Main()
        {
            int[] dizi = { 3, 5, 2, 9, 7, 10, 11 };
            int filtre = 5;

            int toplam = FiltreleVeTopla(dizi, filtre);
            Console.WriteLine("Filtreden büyük olan elemanların toplamı: " + toplam);
            Console.ReadKey();
        }
    }
}
