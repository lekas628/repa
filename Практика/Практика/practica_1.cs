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
            public string firstName;
            public string lastName;
            public int age;

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
            public enum Genders : int { Male, Female };
            public string firstName;
            public string lastName;
            public int age;
            public Genders gender;
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
        }
    }
}

namespace Practicum_2
{
    class task_1
    {
        public static void run()
        {
            SByte a = 0;
            Byte b = 0;
            Int16 c = 0;
            Int32 d = 0;
            Int64 e = 0;
            string s = "";
            Exception ex = new Exception();

            object[] types = { a, b, c, d, e, s, ex };
            
            foreach(object o in types)
            {
                string type = o.GetType().IsValueType == true ? "Value type" : "Reference type";
                Console.WriteLine("{0, 20} : {1}", o.GetType(), type);
            }
        }
    }
    
    class task_2
    {
        public static void run()
        {

            string s = "Microsoft .NET Framework 2 Application Development Foundation";
            string[] sa = s.Split(" ");

            Array.Sort(sa);

            s = string.Join(" ", sa);
            Console.WriteLine(s);
        }
    }

    class task_3
    {
        public static void run()
        {
            return;
        }
    }
}


namespace Practicum_3
{
    class task_1
    {
        public static void run()
        {
            Manager  manager = new Manager("Tony", "Allen", 32, Person.Genders.Male, "8-800-555-35-35", "Moscow");
            Console.WriteLine(manager);
        }

        class Person
        {
            public string firstName;
            public string lastName;
            public int age;
            public Genders gender;

            public Person(string _firstName, string _lastName, int _age, Genders _gender)
            {
                firstName = _firstName;
                lastName = _lastName;
                age = _age;
                gender = _gender;
            }

            public override string ToString()
            {
                return $"{firstName} {lastName} ({gender}), age {age}";
            }

            public enum Genders : int { Male, Female };
        }

        class Manager : Person
        {
            string phoneNumber;
            string officeLocation;

            public Manager(string _firstName, string _lastName, int _age, Genders _gender,
                string _phoneNumber, string _officeLocation) : base(_firstName, _lastName, _age, _gender)
            {
                phoneNumber = _phoneNumber;
                officeLocation = _officeLocation;
            }

            public override string ToString()
            {
                return $"{base.ToString()}, {phoneNumber}, {officeLocation}";
            }
        }
    }

    class task_2
    {
        public static void run()
        {

        }
    }
}