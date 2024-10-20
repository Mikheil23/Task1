using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satestofaili4_
{
    public class Student
    {
        public string StudentName { get; set; }
        public int UniversityStartYear { get; set; }
        public int Age { get; set; }

        public int CalculateYearsLeft(int UniversityStartYear)
        {
            int CurrentYear = 2024;
            int RemainingYears = CurrentYear - UniversityStartYear;
            if (RemainingYears >= 4)
            {
                return 0;
            }
            else
            {
                return RemainingYears;
            }
        }
        public string RandomSubject()
        {
            string subject = string.Empty;
            int subject1 = int.Parse(Console.ReadLine());
            switch (subject1)
            {
                case 1:
                    subject = "Math";
                    break;
                case 2:
                    subject = "Chemistry";
                    break ;
                case 3:
                    subject = "English";
                    break;
                case 4:
                    subject = "Other";
                    break;
            }
            return subject;
        }

    }
}
