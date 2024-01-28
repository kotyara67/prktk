using System;

namespace if4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сумму вклада: ");
            double deposit = Convert.ToDouble(Console.ReadLine());

            double proc;
            if (deposit < 100){
                proc = 0.05;
            }
            else if (deposit <= 200){
                proc = 0.07;
            }
            else{
                proc = 0.1;
            }

            double totalDeposit = deposit + (deposit * proc);

            Console.WriteLine("Сумма вклада с начисленными процентами: " + totalDeposit);

            Console.ReadKey();
        }
    }
}
