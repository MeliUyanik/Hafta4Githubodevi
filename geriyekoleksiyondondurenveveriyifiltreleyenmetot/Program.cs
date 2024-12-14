using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geriyekoleksiyondondurenveveriyifiltreleyenmetot
{
    internal class Program
    {
        static List<string> uzunolanlarıfiltrele(string[] dizi)
        {
            List<string> sonuc = new List<string>();

            foreach (string eleman in dizi)
            {
                if (eleman.Length > 5)
                {
                    sonuc.Add(eleman);
                }
            }

            return sonuc;
        }

        static void Main()
        {
            Console.Write("Kaç kelime gireceksiniz? ");
            int kelimeSayisi = Convert.ToInt32(Console.ReadLine());

            string[] dizi = new string[kelimeSayisi];

            for (int i = 0; i < kelimeSayisi; i++)
            {
                Console.Write($"Kelimeleri girin ({i + 1}/{kelimeSayisi}): ");
                dizi[i] = Console.ReadLine();
            }

            List<string> uzunluguBüyükOlanlar = uzunolanlarıfiltrele(dizi);

            // Sonuçları ekrana yazdır
            Console.WriteLine("Uzunluğu 5'ten büyük olan kelimeler:");
            foreach (string eleman in uzunluguBüyükOlanlar)
            {
                Console.WriteLine(eleman);
            }
            Console.ReadKey();
        }
    }
}
