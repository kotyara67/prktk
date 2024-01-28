using System;

namespace arr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну массива: ");
            int lngt = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[lngt];

            for(int i = 0; i < lngt; i++)
            {
                arr[i] = i + 1;
            }

            Console.WriteLine("Нечетные числа в массиве:");

            foreach (int i in arr)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
