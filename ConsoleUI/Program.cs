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
             * 
             * Also note, that you cannot perform more specific checks on the input in child class methods that override
             * base class methods. You cannot strengthen pre-conditions.
             * 
             * You also cannot weaken post-conditions. If your base virtual method returns values within a specific
             * range, you cannot go beyond that range for the returned values in any child override methods.
             * 
             * Also, do not throw new exceptions in child methods. The new exception may not be expected.
             */

            IManager accountingVP = new Manager();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            /*
             * The application is now LSP compliant. We can use sub-classes in place of base classes without breaking
             * anything.
             * 
             * We use IManaged to retain use of AssignManager() below.
             */
            IManaged emp = new Employee();

            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");
            Console.ReadLine();
        }
    }
}
