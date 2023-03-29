using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positiveNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            trg_class obj = new trg_class();
            string DU = "zero";
            string result = obj.NumberCheck("0"); //calling the NumberCheck unit(method)
            if (DU == result)
                Console.WriteLine("The test passed");
            else
            {
                Console.WriteLine("The test not passed");
            }
            Console.ReadKey();
        }
    }
}
