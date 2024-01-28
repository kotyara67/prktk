using System;

namespace for3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите два числа от 0 до 10:");
                int number1 = Convert.ToInt32(Console.ReadLine());
                int number2 = Convert.ToInt32(Console.ReadLine());

                if (number1 < 0 || number1 > 10 || number2 < 0 || number2 > 10)
                {
                    Console.WriteLine("Введенные числа недопустимы. Попробуйте еще раз.");
                }
                else
                {
                    int result = number1 * number2;
                    Console.WriteLine($"Результат умножения: {result}");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
