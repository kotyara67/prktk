using System;

namespace for1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада:");
            decimal sum = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Введите количество месяцев:");
            int months = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= months; i++){
                sum += sum * 0.07m;
            }

            Console.WriteLine("Сумма вклада составит: " + sum);

            Console.ReadKey();
        }
    }
}
