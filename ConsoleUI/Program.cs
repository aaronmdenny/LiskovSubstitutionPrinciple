using DemoLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Liskov Substitution Principle:
             * If S is a subtype of T, then objects of type T may be replaced with objects of type S.
             * 
             * In this example, we should be able to replace the emp variable with an object of type Manager without
             * breaking the program.
             */

            Manager accountingVP = new Manager();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            Employee emp = new Employee();

            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");
            Console.ReadLine();
        }
    }
}
