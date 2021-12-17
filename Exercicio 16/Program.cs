using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string department = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            string level = Console.ReadLine();

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Console.Write("How many contracts to this worker? ");
            int contract = int.Parse(Console.ReadLine());

            for (int i = 0; i < contract; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                int durationHour = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Press any key to finish");
            Console.ReadKey();
        }
    }
}
