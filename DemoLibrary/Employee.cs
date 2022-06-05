﻿namespace DemoLibrary
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Employee Manager { get; set; } = null;

        public decimal Salary { get; set; }

        // Currently, the CEO fails the 'is-a' relationship needed for inheritance to be appropriate. The CEO should
        // not be assigned any manager.
        public virtual void AssignManager(Employee manager)
        {
            // Simulate doing other tasks here - otherwise, this should be a property set statement, not a method.
            Manager = manager;
        }

        public virtual void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
}
