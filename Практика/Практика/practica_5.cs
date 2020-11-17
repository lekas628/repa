using System;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Practicum_5_1
{
    class task_1_and_2
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
namespace Practicum_5_2
{
    public class task_1
    {
        public static void run()
        {
            Person p = new Person("Jojo", DateTime.Now);
            string filename = "Person.xml";
            Serialize(p, filename);
            Person dp = Deserialie(filename);
            Console.WriteLine(dp.name);
            Del(filename);
        }

    static void Del(string filename)
    {
        if (File.Exists(filename))
            File.Delete(filename);
    }

    static void Serialize(Person sp, string file)
    {
        Del(file);
        using (FileStream fs = new FileStream(file, FileMode.Create))
        {
            XmlSerializer xs = new XmlSerializer(typeof(Person));
            xs.Serialize(fs, sp);        
        }
    }
    static Person Deserialie(string file)
    {
        Person dsp = new Person();

        using (FileStream fs = new FileStream(file, FileMode.Open))
        {
            XmlSerializer xs = new XmlSerializer(typeof(Person));

            dsp = (Person)xs.Deserialize(fs);

            return dsp;
        }
    }


    [Serializable]
    public class Person : IDeserializationCallback
    {
        public string name;
        public DateTime dateOfBirth;
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

        void IDeserializationCallback.OnDeserialization(Object sender)
        {
            // After deserialization, calculate the age
            CalculateAge();
        }
    }
    }

}