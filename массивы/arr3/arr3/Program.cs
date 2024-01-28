using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 5, 8, 10, 3 };
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            double sred = (double)sum / numbers.Length;

            Console.WriteLine("Сумма элементов массива: " + sum);
            Console.WriteLine("Среднее арифметическое значение элементов массива: " + sred);

            Console.ReadKey();
        }
    }
}
