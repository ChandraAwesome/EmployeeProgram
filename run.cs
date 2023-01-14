using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_WAGE
{
    public class runn
    {
        static void Main()
        {
            //int n = 0;
            Random random= new Random();
            int m = random.Next();
            if (m/2==0)
                Console.WriteLine("It is a even Number");
            else
                Console.WriteLine("It is an odd number");
        }
    }
}
