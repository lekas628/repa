using System;

namespace Practicum_1
{
    public class task_1
    {
        public static void run()
        {
            Person person = new Person("Tony", "Allen", 32);
            Console.WriteLine(person);
        }

        struct Person
        {
            public Person(string _firstName, string _lastName, int _age)
            {
                firstName = _firstName;
                lastName = _lastName;
                age = _age;
            }
            public override string ToString()
            {
                //return firstName + " " + lastName + ", age " + age;
                return $"{firstName} {lastName}, age {age}";
            }

            public string firstName;
            public string lastName;
            public int age;
        }
    }

    public class task_2
    {
        public static void run()
        {
            Person person = new Person("Tony", "Allen", 32, Person.Genders.Male);
            Console.WriteLine(person);
        }

        struct Person
        {
            public Person(string _firstName, string _lastName, int _age, Genders _gender)
            {
                firstName = _firstName;
                lastName = _lastName;
                age = _age;
                gender = _gender;
            }
            public override string ToString()
            {
                //return firstName + " " + lastName + ", age " + age;
                return $"{firstName} {lastName} ({gender}), age {age}";
            }

            public enum Genders : int { Male, Female};

            public string firstName;
            public string lastName;
            public int age;
            public Genders gender;
        }
    }
}
