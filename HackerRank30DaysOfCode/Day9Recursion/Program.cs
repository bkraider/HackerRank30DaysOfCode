using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9Recursion
{
    class Program
    {
        static int factorial(int n)
        {
            return (n == 0 ? 1 : n * factorial(n - 1));
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = factorial(n);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
