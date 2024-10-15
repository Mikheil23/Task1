using System;
using System.Collections.Generic;

namespace Satestofaili4_
{
    internal class Company
    {
        public bool IsLocal { get; private set; }

        public Company(bool isLocal)
        {
            IsLocal = isLocal;
        }

        public int CalculateNetSalary(int grossSalary)
        {
            int taxRate = IsLocal ? 18 : 5; // 18% for local, 5% for foreign
            return grossSalary - (grossSalary * taxRate / 100);
        }

        public decimal CalculateTotalExpenses(List<EmployeeLocal> employees)
        {
            decimal totalExpenses = 0;

            foreach (var employee in employees)
            {
                // Get the gross salary using the EarningsinWeek class
                EarningsinWeek earningsCalculator = new EarningsinWeek();
                int grossSalary = earningsCalculator.CalculateEarnings(employee);

                // Determine tax rate based on employee's status
                decimal percentage = employee.Whichside.ToLower() == "local" ? 0.18m : 0.05m;

                // Calculate total expense for this employee
                decimal totalExpense = grossSalary + (grossSalary * percentage);
                totalExpenses += totalExpense;
            }

            return totalExpenses;
        }
    }
}
