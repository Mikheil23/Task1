using System;

namespace Satestofaili4_
{
    internal class EarningsinWeek
    {
        private int onehourpaymanager = 40;
        private int onehourpaydeveloper = 30;
        private int onehourpaytester = 20;
        private int onehourpaystandard = 10;
        private int overtimepay = 5;

        public EarningsinWeek() { }

        public int CalculateEarnings(EmployeeLocal employee)
        {
            int sum = 0;
            int totalHours = 0;

            // ორშაბათი-პარასკევი
            for (int i = 0; i < 5; i++)
            {
                int hourlyRate = GetHourlyRate(employee.Role);
                sum += CalculateDailyEarnings(hourlyRate, employee.WorkingHours[i]);
                totalHours += employee.WorkingHours[i];
            }

            // ვიქენდზე ხელფასის დათვლა
            for (int i = 5; i < 7; i++)
            {
                if (employee.WorkingHours[i] > 0)
                {
                    sum += employee.WorkingHours[i] * (GetHourlyRate(employee.Role) * 2); // ვიქენდი ორმაგდება
                    totalHours += employee.WorkingHours[i];
                }
            }

            // ბონუსი მხოლოდ მაშინ თუ 50-ს სცდება საათები
            if (totalHours > 50)
            {
                int bonuspay = (int)(sum * 0.20); // ბონუსი 20%
                sum += bonuspay;
            }

            return sum;
        }

        private int GetHourlyRate(string role)
        {
            return role switch
            {
                "manager" => onehourpaymanager,
                "developer" => onehourpaydeveloper,
                "tester" => onehourpaytester,
                "standard" => onehourpaystandard,
                _ => 0
            };
        }

        private int CalculateDailyEarnings(int hourlyRate, int hoursWorked)
        {
            if (hoursWorked > 8)
            {
                return (8 * hourlyRate) + ((hoursWorked - 8) * (hourlyRate + overtimepay));
            }
            else
            {
                return hoursWorked * hourlyRate;
            }
        }
    }
}


