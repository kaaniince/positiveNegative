using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positiveNegative
{
    public class trg_class
    {
        public string NumberCheck(string a) // unit (method) of program
        {

            int number = int.Parse(a);

            // Use an if statement to check whether the number is positive or negative
            if (number >= 0)
            {
                // If the number is greater than or equal to 0, return "The number is positive."
                return "positive";
            }
            else if (number < 0)
            {
                // If the number is less than 0, return an error message.
                return "Error: Please enter a positive number.";
            }
            else
            {
                // If the number is equal to 0, return "zero".
                return "zero";
            }
        }
    }
}
