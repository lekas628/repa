using System;

namespace ConsoleApp1
{
  struct Person
  {
    public string firstName;
    public string lastName;
    public int age;

    public enum Genders : int { Male, Female};

    public Person(string _firstName, string _lastName, int _age)
    {
      firstName = _firstName;
      lastName = _lastName;
      age = _age;
    }

    public override string ToString()
    {
      return firstName + " " + lastName + ", age " + age;
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Person p = new Person("Jummy", "The_Boy", 21);
      Console.WriteLine(p);
    }
  }
}
