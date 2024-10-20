using System;
using System.Collections.Generic;
using System.Linq; 

namespace Satestofaili4_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1
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
            //Task 2
            var student1 = new Student();
            student1.StudentName = "Gurjistan";
            Console.WriteLine("When did you start University?");
            var StartingYear = student1.UniversityStartYear = int.Parse(Console.ReadLine());
            student1.CalculateYearsLeft(StartingYear);
            Console.WriteLine("Please write numbers from 1 t 4 (Math, Chemistry, English or Other)\n");
            var ChosenSubject = student1.RandomSubject();
            var teacher1 = new Teacher();
            teacher1.Name = "Josefine";
            teacher1.Status = "Married";
            Console.WriteLine($"Teacher name {teacher1.Name} {teacher1.CheckSubject(ChosenSubject)}\n");



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








