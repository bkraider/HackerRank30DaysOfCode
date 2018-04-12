using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3IntrotoConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 1)
            {
                Console.WriteLine("Weird");
            }
            else if (N >= 2 && N < 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (N >= 6 && N <= 20)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }

            Console.ReadLine();

            /*
            Sample Input 0
            3

            Sample Output 0
            Weird

            Sample Input 1
            24

            Sample Output 1
            Not Weird
             */
        }
    }
}
