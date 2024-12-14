using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizidekienbuyukdegeribulanparametrelivegeriyedegerdondurenmetod
{
    internal class Program
    {
        static int enbuyukdegeribul(int[] dizi)
        {
            int enBuyuk = dizi[0];

            foreach (int sayi in dizi)
            {
                if (sayi > enBuyuk)
                {
                    enBuyuk = sayi;
                }
            }

            return enBuyuk;
        }

        static void Main(string[] args)
        {
            int[] sayilar = { 41, 39, 9, 54, 4 };
            int enBuyuk = enbuyukdegeribul(sayilar);
            Console.WriteLine($"Dizideki en büyük değer: {enBuyuk}");
            Console.ReadKey();
        }
    }
}
