namespace Switch_WAGE
{
    public class SWITCH_WAGE
    {
        public static void switchwage(string[] args)
        {
           const int PRT_TIME = 1;
           const int FULL_TIME = 2;
           const int WRK_PER_HR = 20;
            //
            int empHrs = 0;
            int empWage = 0;
            Random random= new Random();
            int empCheck= random.Next(0,3);
            //switch
            switch (empCheck)
            {
                case PRT_TIME:
                    empHrs = 4;
                    break;
                case FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * WRK_PER_HR;
            Console.WriteLine("Emp Wage : "+ empWage);
        }
    }
}