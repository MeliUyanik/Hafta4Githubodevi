using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematikselhesaplamayapanparametresizvegeriyedeğerdöndürenmetod
{
    internal class Program
    {
        static double ucgenalanihesaplama()
        {
            Console.WriteLine("Üçgenin taban uzunluğunu giriniz: ");
            double taban = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Üçgenin yüksekliğini giriniz: ");
            double yukseklik = Convert.ToDouble(Console.ReadLine());

            double alan = (taban * yukseklik) / 2;
            return alan;
        }
        static void Main(string[] args)
        {
            double alan = ucgenalanihesaplama();
            Console.WriteLine("Üçgenin alanı: " + alan);
            Console.ReadKey();
        }
    }
}
