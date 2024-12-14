using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadedmetodilefarklıturdekiverilerintoplamınıbulma
{
    internal class Program
    {
        static int CalculateSum(int a, int b)
        {
            return a + b;
        }
        static double CalculateSum(double a, double b)
        {
            return a + b;
        }

        static int CalculateSum(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            int intSum = CalculateSum(2, 7);
            Console.WriteLine($"İki int sayının toplamı: {intSum}");

            double doubleSum = CalculateSum(6.3, 8.2);
            Console.WriteLine($"İki double sayının toplamı: {doubleSum:F2}");

            int ucIntSum = CalculateSum(4, 9, 22);
            Console.WriteLine($"Üç int sayının toplamı: {ucIntSum}");
            Console.ReadKey();
        }
    }
}
