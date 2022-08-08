using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewage1
{
    public static class Employeeuc6
    {
        public static void calculatingEmployeeWage()
        {
            const int FullTime = 1;
            const int PartTime = 2;
            const int Emp_Rate_Per_Hour = 20;
            const int Num_Of_Working_Days = 20;
            const int Max_Hrs_In_Month = 10;

            int emphrs = 0;
            int empwage = 0;
            int totalEmpwage = 0;
            int totalEmphrs = 0;
            int totalWorkingDays = 0;

            while (totalEmphrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_Working_Days)
            {
                totalWorkingDays++;

                Random random = new Random();
                int empcheck = random.Next(2);

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
                totalEmphrs += emphrs;
                Console.WriteLine("Day # : " + totalWorkingDays + "Emp hrs : " + emphrs);
            }
            totalEmpwage = totalEmphrs + Emp_Rate_Per_Hour;
            Console.WriteLine("Total Emp Wage : " + totalEmpwage);
        }
    }
}
