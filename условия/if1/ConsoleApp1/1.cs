using System;

namespace ConsoleApp1{
    internal class Program{
        static void Main(string[] args){
            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2){
                Console.WriteLine(num1 + " больше " + num2);
            }
            else if (num1 < num2){
                Console.WriteLine(num1 + " Меньше " + num2);
            }
            else{
                Console.WriteLine(num1 + " Равно " + num2);
            }

            Console.ReadKey();
        }
    }
}
