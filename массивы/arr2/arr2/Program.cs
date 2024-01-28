using System;

namespace arr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "яблоко", "лазер", "обфуксикация", "тетрагидропиранилциклопентилтетрагидропиридопиридин" };

            Console.Write("Введите строку для поиска: ");
            string input = Console.ReadLine();

            bool found = false;

            foreach (string str in strings)
            {
                if (str == input)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("Строка найдена!");
            }
            else
            {
                Console.WriteLine("Строка не найдена!");
            }

            Console.ReadKey();
        }
    }
}
