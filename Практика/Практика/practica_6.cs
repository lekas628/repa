using System;

namespace Practicum_6_1
{
    class task_1
    {
        public static void run()
        {
            Person p = new Person("Jojo", "Reference", DateTime.Now);

            
        }

        class Person
        {
            string _first_name;
            string _last_name;
            DateTime _datetime;

            public string First_name { get => _first_name; set => _first_name = value; }
            public string Last_name { get => _last_name; set => _last_name = value; }
            public DateTime Date {get => _datetime; set => _datetime = value; }
            public int Birth_year {get => _datetime.Year; }

            public string FullName => $"{_first_name} {_last_name}";

            public Person() : this("None", "None", DateTime.Now)
            {
            }

            public Person(string first_name, string last_name, DateTime datetime)
            {
                First_name = first_name;
                Last_name = last_name;
                Date = datetime;
            }

            public override string ToString()
            {
                return $"{First_name} {Last_name} {Date.Year}";
            }
            public virtual string ToShortString()
            {
                return $"{First_name} {Last_name}";
            }
        }
    }
}
