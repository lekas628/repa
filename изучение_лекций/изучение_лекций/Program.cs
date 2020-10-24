using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace изучение_лекций
{
    class Program
    {
        static void Main()
        {
            Person person = new Person("Joe", 21, "my_random");
            Console.WriteLine("object created");
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(@"D:\people.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);
                Console.WriteLine("объект сериализован");
            }

            using (FileStream fs = new FileStream(@"D:\people.dat", FileMode.OpenOrCreate))
            {
                Person newPerson = (Person)formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {newPerson.Name}, Возраст {newPerson.Year}");
            }
        }
    }

    [Serializable]
    class Person
    {
        public string Name { get; set; }
        public int Year { get; set; }

        [NonSerialized]
        public string accNumber;

        public Person(string _name, int _year, string _acc)
        {
            Name = _name;
            Year = _year;
            accNumber = _acc;
        }
    }
}
