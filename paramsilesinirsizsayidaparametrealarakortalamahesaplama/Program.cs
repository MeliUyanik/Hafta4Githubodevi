using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paramsilesinirsizsayidaparametrealarakortalamahesaplama
{
    internal class Program
    {
        static double CalculateAverage(params double[] numbers)
        {
            if (numbers.Length == 0)
                return 0;

            double toplam = 0;
            foreach (double number in numbers)
            {
                toplam += number;
            }

            return toplam / numbers.Length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Ortalama (4, 6, 8): " + CalculateAverage(4, 6, 8));
            Console.WriteLine("Ortalama (10, 20, 30, 40): " + CalculateAverage(10, 20, 30, 40));
            Console.WriteLine("Ortalama (3.8, 7.2): " + CalculateAverage(3.8, 7.2));

            Console.Write("Kaç sayı girmek istiyorsunuz? ");
            int count = Convert.ToInt32(Console.ReadLine());

            double[] numbers = new double[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{i + 1}. sayıyı girin: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            double average = CalculateAverage(numbers);
            Console.WriteLine("Girdiğiniz sayıların ortalaması: " + average);
            Console.ReadKey();
        }
    }
}
