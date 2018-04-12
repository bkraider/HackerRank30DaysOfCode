using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int i2 = 0;
            double d2 = 0.0;
            string s2 = "";

            // Read and save an integer, double, and String to your variables.
            i2 = Convert.ToInt32(Console.ReadLine());
            // Print the sum of both integer variables on a new line.
            Console.WriteLine(i + i2);
            // Print the sum of the double variables on a new line.
            d2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(string.Format("{0:0.0}", d + d2));
            // Concatenate and print the String variables on a new line
            s2 = Console.ReadLine();
            // The 's' variable above should be printed first.
            Console.WriteLine(s + s2);

            Console.ReadLine();

            /* 
             Sample Input

            12
            4.0
            is the best place to learn and practice coding!
            
            Sample Output

            16
            8.0
            HackerRank is the best place to learn and practice coding!
             */
        }
    }
}
