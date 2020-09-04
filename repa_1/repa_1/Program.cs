using System;

namespace repa_1
{
  class Program
  {
    static void Main(string[] args)
    {
      //Console.WriteLine("Input ur name: ");
      //string name = Console.ReadLine();
      //Console.WriteLine($"Hello {name}");
      //Console.ReadKey();

      object text_1 = "Hello"; // хранит любого типа
      
      var text_2 = "Welcome to the club"; // неявная типизация, сразу иниц
      // Console.WriteLine(text_2.GetType().ToString()); 

      string text_3 = ":)";

      Console.WriteLine(text_1);
      {
        Console.WriteLine(text_2);
        Console.WriteLine($"okey {text_3}");
      }

      Console.ReadKey();
    }
  }
}
