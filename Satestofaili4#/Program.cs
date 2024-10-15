using System;
using System.Collections.Generic;
using System.Linq; 

namespace Satestofaili4_
{
    class Program
    {
        static void Main(string[] args)
        {
            // ამ ლისტში არის ჩაწერილი ობიექტები
            List<EmployeeLocal> employees = new List<EmployeeLocal>
            {
                new EmployeeLocal
                {
                    FirstName = "George",
                    LastName = "Smith",
                    YearsOld = 35,
                    Role = "developer",
                    WorkingHours = new int[] { 8, 8, 8, 8, 10, 6, 2 },
                    Whichside = "local",
                },
                new EmployeeLocal
                {
                    FirstName = "Tom",
                    LastName = "Kingston",
                    YearsOld = 28,
                    Role = "tester",
                    WorkingHours = new int[] { 8, 8, 8, 10, 10, 5, 0 },
                    Whichside = "foreign",
                }
                
            };

            
            CalculateAndDisplayEarningsAndExpenses(employees);
        }

        public static void CalculateAndDisplayEarningsAndExpenses(List<EmployeeLocal> employees)
        {
            Company company = new Company(employees.All(e => e.Whichside.ToLower() == "local")); 
            decimal totalExpenses = company.CalculateTotalExpenses(employees);

            Console.WriteLine($"Total company expenses for the week: {totalExpenses:C}");

            EarningsinWeek earningsCalculator = new EarningsinWeek();

            foreach (var employee in employees)
            {
                int totalEarnings = earningsCalculator.CalculateEarnings(employee);
                Console.WriteLine($"{employee.FirstName} {employee.LastName}, your total salary for this week is: {totalEarnings}");

                
                int averageEarnings = totalEarnings / 7; 
                Console.WriteLine($"Average earning per day for {employee.FirstName} is: {averageEarnings}");
            }
        }
    }
}








