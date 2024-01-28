using System;
namespace for2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for(int i = 2; i <= 9; i++)
            {
                Console.WriteLine("\n_____ " + i + " _____\n");
                for (int j = 1; j <= 9; j++)
                {   
                    Console.WriteLine($"{i} * {j} = " + (i * j));
                }
            }
            Console.ReadKey();

        }
    }
}
 