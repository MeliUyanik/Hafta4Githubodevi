using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secmeliparametreilebelirliyastansonrakiyillarisayma
{
    internal class Program
    {
        static int yasfazlaligi(int yas = 18)
        {
            return yas - 18;
        }

        static void Main()
        {
            Console.Write("Yaşınızı girin: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            int fazlalik = yasfazlaligi(yas);
            Console.WriteLine("Yaşınız 18'den {0} fazla.", + fazlalik);
            Console.ReadKey();
        }
    }
}
