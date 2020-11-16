using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Practicum_5_1
{
    class task_1
    {
        public static void run()
        {
            string filename = "Person.Dat";

            Person p = new Person("Ars", DateTime.Now);
            Serialize(p, filename);

            Person dp = Deserialie(filename);    

            Console.WriteLine($"Print char to del {filename}");
            Console.ReadKey();
            if(File.Exists(filename))
                File.Delete(filename);
        }

        private static void del_file(string file)
        {
            if (File.Exists(file))
            {
                File.Delete(file);
            }
        }
        private static void Serialize(Person sp, string file)
        {
            del_file(file);
            using (FileStream fs = new FileStream(file, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, sp);
                Console.WriteLine("end");
            }
        }
        private static Person Deserialie(string file)
        {
            Person dsp = new Person();

            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                dsp = (Person)bf.Deserialize(fs);
            }
            return dsp;
        }


        [Serializable]
        class Person
        {
            public string name;
            public DateTime dateOfBirth;

            [NonSerialized]
            public int age;
            public Person(string _name, DateTime _dateOfBirth)
            {
                name = _name;
                dateOfBirth = _dateOfBirth;
                CalculateAge();
            }

            public Person()
            {
            }

            public override string ToString()
            {
                return name + " was born on " + dateOfBirth.ToShortDateString() + " and is " + age.ToString() + " years old.";
            }

            private void CalculateAge()
            {
                age = DateTime.Now.Year - dateOfBirth.Year;

                // If they haven't had their birthday this year, 
                // subtract a year from their age
                if (dateOfBirth.AddYears(DateTime.Now.Year - dateOfBirth.Year) > DateTime.Now)
                {
                    age--;
                }
            }
        }
    }
}
