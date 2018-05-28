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

            int n = Convert.ToInt32(Console.ReadLine());
            string[] strarray = new string[n];
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string strinput = Console.ReadLine();
                var ds = (from w in strinput.Split()
                            select w);
                phoneBook.Add(ds.FirstOrDefault(), ds.ElementAt(1));
            }

            if(phoneBook.Count ==  n)
            {
                for (int i = 0; i < n; i++)
                {
                    string strinput = Console.ReadLine();
                    strarray[i] += strinput;
                }
            }


            foreach (string name in strarray)
            {                
                if (phoneBook.ContainsKey(name))
                {
                    string phonenumber = string.Empty;
                    phoneBook.TryGetValue(name, out phonenumber);
                    Console.WriteLine(name + "=" + phonenumber);
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }

            Console.ReadLine();

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
