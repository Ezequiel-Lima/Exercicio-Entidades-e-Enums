using Exercicio_16.Entities;
using Exercicio_16.Entities.Enums;
using System;

namespace Exercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter department's name: ");
                string department = Console.ReadLine();

                Console.WriteLine("Enter worker data: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Level (Junior/MidLevel/Senior): ");
                WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());

                Console.Write("Base salary: ");
                double baseSalary = double.Parse(Console.ReadLine());

                Department dept = new Department(department);
                Worker worker = new Worker(name, level, baseSalary, dept);

                Console.Write("How many contracts to this worker? ");
                int quantityContract = int.Parse(Console.ReadLine());

                for (int i = 0; i < quantityContract; i++)
                {
                    Console.WriteLine($"Enter #{i + 1} contract data: ");
                    Console.Write("Date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    Console.Write("Value per hour: ");
                    double valueHour = double.Parse(Console.ReadLine());

                    Console.Write("Duration (hours): ");
                    int durationHour = int.Parse(Console.ReadLine());

                    HourContract contract = new HourContract(date, valueHour, durationHour);
                    worker.AddContract(contract);
                }

                Console.Write("\nEnter month and year to calculate income (MM/YYYY): ");
                string monthAndYear = Console.ReadLine();
                int month = int.Parse(monthAndYear.Substring(0, 2));
                int year = int.Parse(monthAndYear.Substring(3));

                Console.WriteLine("Name: " + worker.Name);
                Console.WriteLine("Department: " + worker.Department.Name);
                Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));

                Console.WriteLine("\nPress any key to finish");
                Console.ReadKey();
            }
            catch (Exception error)
            {
                Console.WriteLine($">{error.Message}");
            }
        }
    }
}
