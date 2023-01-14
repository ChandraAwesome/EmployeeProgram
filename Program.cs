namespace EmployeeWAGEpart_full
{
    public class PRT_FULL_WAGE
    {
        static void Main(string[] args)

        {
            int PRT_ATTND = 1;
            int FULL_ATTND = 2;
            int WRK_PER_HOUR = 20;
            // input
            int empHRs = 0;
            int empWage = 0;
            Random random = new Random();
            //logic
            int empCheck = random.Next(0, 3);
            if (empCheck == PRT_ATTND)
            {
                empHRs = 8;
            }
            else if (empCheck== FULL_ATTND)
            {
                empWage = 16;
            }
            else
            {
                empHRs = 0;
            }
            empWage = empHRs * WRK_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}