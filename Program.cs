namespace EmployeeProgramATTND
{
    public class Program
    {
        static void Main(string[] args)
        {
            int ATTND = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == ATTND)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}