// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

namespace SalaryCalculationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salary Calculation System");

            Console.WriteLine("Choose Employee Type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");

            int employeeType = int.Parse(Console.ReadLine());

            switch (employeeType)
            {
                case 1: // HR
                    CalculateSalaryForHR();
                    break;

                case 2: // Admin
                    CalculateSalaryForAdmin();
                    break;

                case 3: // Software Developer
                    CalculateSalaryForSoftwareDeveloper();
                    break;

                default:
                    Console.WriteLine("Invalid employee type selected.");
                    break;
            }

            Console.ReadLine();
        }

        static void CalculateSalaryForHR()
        {
            Console.Write("Enter working hours: ");
            int workingHours = int.Parse(Console.ReadLine());

            Console.Write("Enter number of working days: ");
            int numberOfWorkingDays = int.Parse(Console.ReadLine());

            int salary = workingHours * numberOfWorkingDays * 100;

            Console.WriteLine("Monthly Salary: $" + salary);
        }

        static void CalculateSalaryForAdmin()
        {
            Console.Write("Enter working hours: ");
            int workingHours = int.Parse(Console.ReadLine());

            Console.Write("Enter number of working days: ");
            int numberOfWorkingDays = int.Parse(Console.ReadLine());

            Console.Write("Enter project handles: ");
            int projectHandles = int.Parse(Console.ReadLine());

            int salary = (workingHours * numberOfWorkingDays * 100) + (projectHandles * 3000);

            Console.WriteLine("Monthly Salary: $" + salary);
        }

        static void CalculateSalaryForSoftwareDeveloper()
        {
            Console.Write("Enter working hours: ");
            int workingHours = int.Parse(Console.ReadLine());

            Console.Write("Enter number of working days: ");
            int numberOfWorkingDays = int.Parse(Console.ReadLine());

            Console.Write("Enter project handles: ");
            int projectHandles = int.Parse(Console.ReadLine());

            Console.Write("Enter extras: ");
            int extras = int.Parse(Console.ReadLine());

            int salary = (workingHours * numberOfWorkingDays * 100) + (projectHandles * 3000) + (extras * 2000);

            Console.WriteLine("Monthly Salary: $" + salary);
        }
    }
}