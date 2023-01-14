using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_WAGE
{
    public class Switchwagepermonth
    {
       public static void Mainn()
        {
            const int PRT_TIME = 1;
            const int FULL_TIME = 2;
            const int WRK_PER_HR = 20;
            const int DAYS_PER_MONTH = 2;
            const int MAX_HRS_IN_MONTH = 100;
            //
            int empHrs = 0, totalempHrs = 0, totalWorkingDays = 0;
            //
            while (totalempHrs<=MAX_HRS_IN_MONTH && totalWorkingDays<DAYS_PER_MONTH)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case PRT_TIME:
                        empHrs = 4; break;
                    case FULL_TIME:
                        empHrs = 8; break;
                    default: empHrs = 0; break;
                }
                totalempHrs += empHrs;
                Console.WriteLine("Days"+ (totalWorkingDays+1) + "Emp Hrs :"+ empHrs);
            }
            int totalempWage = totalempHrs * WRK_PER_HR;
            Console.WriteLine("totalwage per month is : " + totalempWage);
        }

    }
}
