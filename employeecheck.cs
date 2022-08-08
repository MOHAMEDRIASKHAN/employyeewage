using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewage1
{
    public static class employeecheck
    {
        public static void calculatingEmployeeWage()
        {
            const int FullTime = 1;
            const int PartTime = 2;
            const int Emp_Rate_Per_Hour = 20;

            int emphrs = 0;
            int empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(2);

            //if (empcheck == FullTime)
            //{
            //    Console.WriteLine("Employee is Present");
            //    emphrs = 8;
            //}
            //else if (empcheck == PartTime)
            //{
            //    Console.WriteLine("PartTime Employee");
            //    emphrs = 4;
            //}
            //else
            //{
            //    Console.WriteLine("Employee is Absent");
            //    emphrs = 0;
            //}
            switch (empcheck)
            {
                case FullTime:
                    Console.WriteLine("Employee is Present");
                    emphrs = 8;
                    break;
                case PartTime:
                    Console.WriteLine("PartTime Employee");
                    emphrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    emphrs = 0;
                    break;

            }
            empwage = emphrs * Emp_Rate_Per_Hour;

            Console.WriteLine("Empwage :" + empwage);
        }
    }
}

