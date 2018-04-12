using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            int tax_percent = Convert.ToInt32(Console.ReadLine());
            double totalCost = 0.0;
            double tip = 0.0;
            double tax = 0.0;

            tip = (meal_cost * tip_percent) / 100.0;
            tax = (meal_cost * tax_percent) / 100.0;

            totalCost = meal_cost + tip + tax;

            Console.WriteLine("The total meal cost is " + Math.Round(totalCost).ToString() + " dollars.");

            Console.ReadLine();

            /* 
             Sample Input

            12.00
            20
            8

            Sample Output

            The total meal cost is 15 dollars.
             */
        }
    }
}
