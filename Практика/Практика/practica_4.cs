using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;

namespace Practicum_4_1
{
    class task_1
    {
        public static void run()
        {
            ArrayList al = new ArrayList();
            al.Add("First");
            al.Add("Second");
            al.Add("Third");
            al.Add("Fourth");

            foreach (string item in al)
                Console.WriteLine("Unsorted {0}", item);

            al.Sort();

            Console.WriteLine("");
            foreach (string item in al)
                Console.WriteLine("Sorted {0}", item);

        }
    }
}
namespace Practicum_4_2
{
    class task_1
    {
        public static void run()
        {
            Queue q = new Queue();
            q.Enqueue("First");
            q.Enqueue("Second");
            q.Enqueue("Third");
            q.Enqueue("Fourth");

            while(q.Count > 0)
            {
                object obj = q.Dequeue();
                Console.WriteLine($"From Queue: {obj}");
            }
        }
    }
    class task_2
    {
        public static void run()
        {
            Stack s = new Stack();
            s.Push("First");
            s.Push("Second");
            s.Push("Third");
            s.Push("Fourth");
            while (s.Count > 0)
            {
                object obj = s.Pop();
                Console.WriteLine($"From stack: {obj}");
            }
        }
    }
}

namespace Practicum_4_3
{
    class task_1
    {
        public static void run()
        {
            Hashtable dict = new Hashtable();

            string[] ls_nums = { "Zero",
                "One",
                "Two",
                "Three",
                "Four",
                "Five",
                "Six",
                "Seven",
                "Eight",
                "Nine"};

            for (int i = 0; i < ls_nums.Length; i++)
                dict[$"{i}"] = ls_nums[i];

            string ourNumber = "888 - 555 - 1212";
            
            foreach(char c in ourNumber)
            {
                string digit = c.ToString();
                if (dict.ContainsKey(digit))
                {
                    Console.WriteLine(dict[digit]);
                }
            }
        }

    }
}

namespace Practicum_4_4
{
    class task_1
    {
        public static void run()
        {
            ListDictionary list = new ListDictionary(
                new CaseInsensitiveComparer(CultureInfo.InvariantCulture));

            list["Estados Unidos"] = "United States of America";
            list["Canada"] = "Canada";
            list["Espana"] = "Spain";

            Console.WriteLine(list["espana"]);
            Console.WriteLine(list["CAnADA"]);
        }
    }
}

namespace Practicum_4_5
{
    class task_1
    {
        public static void run()
        {
            Dictionary<int, string> countryLookup =
                new Dictionary<int, string>();

            countryLookup[44] = "United Kingdom"; 
            countryLookup[33] = "France"; 
            countryLookup[31] = "Netherlands"; 
            countryLookup[55] = "Brazil"; 
            countryLookup[64] = "New Zealand";

            foreach(KeyValuePair<int, string> item in countryLookup)
            {
                int code = item.Key;
                string country = item.Value;
                Console.WriteLine($"Code {code} = {country}");
            }
        }

    }
}