using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            BasicCoreProgram prob = new BasicCoreProgram();
            Console.WriteLine("Enter value of dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());
            prob.Quotientremainder(dividend, divisor);
            Console.ReadLine();
        }
    }
}
