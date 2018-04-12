using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(n.ToString() + " x " + i.ToString() + " = " + (n * i).ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

            /*
             Sample Input
            2

            Sample Output
            2 x 1 = 2
            2 x 2 = 4
            2 x 3 = 6
            2 x 4 = 8
            2 x 5 = 10
            2 x 6 = 12
            2 x 7 = 14
            2 x 8 = 16
            2 x 9 = 18
            2 x 10 = 20
            */
        }
    }
}
