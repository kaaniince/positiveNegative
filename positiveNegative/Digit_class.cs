using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positiveNegative
{
    public class Digit_class
    {
        public int prime(int number) //this is the unit to test
        {
            int sum = 0, n;
            
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\n Entered number is a perfect number");
                return 1;
            }
            else
            {
                Console.WriteLine("\n Entered number is not a perfect number");
                return 0;
            }
        }
    }
}
