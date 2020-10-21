using System;

namespace изучение_лекций
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int z;
            Sum(x, 15, out z);
            Console.WriteLine(z);
        }
        
        static void Sum(int x, int y, out int a)
        {
            a = x + y;
        }
    }
}
