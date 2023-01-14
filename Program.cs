namespace MonthlyWAGE
{
    public class MONTHWAGE
    {
        public static void Main(string[] args)
        {
            const int PRT_TIME = 1;
            const int FULL_TIME = 2;
            const int WRK_PER_HR = 20;
            const int DAYS_PER_MONTH = 20;
            //
            int empHrs = 0, empWage = 0, totalEarn = 0;
            //
            for (int day =0; day < DAYS_PER_MONTH; day++)
            {
                Random random= new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case PRT_TIME:
                        empHrs=4; break;
                    case FULL_TIME:
                        empWage = 8;break;
                    default:empWage = 0; break;
                }
                empWage = empHrs * WRK_PER_HR;
                totalEarn += empWage;
                Console.WriteLine("empWAage : " + empWage);
            }

            Console.WriteLine("totalwage per month is : " + totalEarn);
        }
    }
}