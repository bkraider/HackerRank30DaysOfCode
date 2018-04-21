using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LetsReview
{
    class Solution
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] strarray = new string[n];
            

            for (int i = 0; i < n; i++)
            {
                string strinput = Console.ReadLine();
                strarray[i] += strinput;
            }

            Solution s = new Solution();
            for(int i = 0; i < n; i++)
            {
                //Console.WriteLine(strarray[i]);
                Console.WriteLine(s.ProcessString(strarray[i]));
            }

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

            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    streven += arr[i];
                }
                    
            }

            for (int i = 1; i < str.Length; i++)
            {
                if (i % 2 == 1)
                {
                    strodd += arr[i];
                }
            }

            return streven + " " + strodd;
        }
    }
}
