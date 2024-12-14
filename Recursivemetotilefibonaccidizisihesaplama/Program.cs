using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursivemetotilefibonaccidizisihesaplama
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            Console.Write("Fibonacci hesaplamak istediğiniz sayıyı girin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = Fibonacci(n);
            Console.WriteLine($"Fibonacci({n}) = {result}");
            Console.ReadKey();
        }
    }
}
