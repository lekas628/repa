using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Practicum_3_1
{
    class task_1
    {
        public static void run()
        {
            return;
        }
    }
    class task_2
    {
        public static void run()
        {
            return;
        }
    }
}

namespace Practicum_3_2
{
    class task_1
    {
        public static void run()
        {
            string file = @"C:\users\admin\Documents\code\1\1.txt";
            string file_output = 
                @"C:\users\admin\Documents\code\1\1-utf7.txt";

            using(StreamReader sr = new StreamReader(file))
            {
                using(StreamWriter sw = new StreamWriter(file_output,
                    false, Encoding.UTF7))
                {
                    sw.WriteLine(sr.ReadToEnd());
                }
            }
        }
    }
}
