using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satestofaili4_
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Status { get; set; }

        public string CheckSubject (string subject)
        {
            String answer = string.Empty;
            if (subject == "Math")
            {
                int a = 1;
                int b = 2;
                int c = a + b;
                Console.WriteLine (c);
            }
            else if (subject == "Chemistry")
            {
                Console.WriteLine("H2O");
            }
            else if (subject == "English")
            {
                Console.WriteLine("Fuck Taylor");
            }
            else if (subject == null)
                    {
                Console.WriteLine("Not mine");
            }
           return answer;
        }



    }
}
