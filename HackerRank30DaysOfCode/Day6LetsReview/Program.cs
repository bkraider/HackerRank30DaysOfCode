using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LetsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Program p = new Program();
            Console.WriteLine(p.ProcessString(str1));
            Console.WriteLine(p.ProcessString(str2));

            Console.ReadLine();
            /* Sample Input
            2
            Hacker
            Rank
            
            Sample Output
            Hce akr
            Rn ak 
            */
        }

        string ProcessString(string str)
        {
            char[] arr;
            string strodd = string.Empty;
            string streven = string.Empty;

            arr = str.ToCharArray(0, str.Length);

            for (int i = 0; i <= str.Length - 2; i = i + 2)
            {
                streven += arr[i];
            }

            for (int i = 1; i <= str.Length - 1; i = i + 2)
            {
                strodd += arr[i];
            }

            return streven + " " + strodd;
        }
    }
}
