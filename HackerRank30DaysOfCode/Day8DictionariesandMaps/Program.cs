using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8DictionariesandMaps
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<String, String> PhoneBook = new Dictionary<String, String>();
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var s = Console.ReadLine().Split(' ');
                PhoneBook.Add(s[0], s[1]);
            }

            String name;

            while ((name = Console.ReadLine()) != null)
            {
                try
                {
                    Console.WriteLine($"{name}={PhoneBook[name]}");
                }
                catch
                {
                    Console.WriteLine("Not found");
                }
            }


            /* 
            Sample Input
            3
            sam 99912222
            tom 11122222
            harry 12299933
            sam
            edward
            harry
            
            Sample Output
            sam=99912222
            Not found
            harry=12299933
             */
        }
    }
}
