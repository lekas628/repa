using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace изучение_лекций
{
    class Program
    {
        static void Main()
        {
            ObservableCollection<User> users = new ObservableCollection<User>
            {
                new User { Name = "Bill"},
                new User { Name = "Tom" },
                new User { Name = "Alice"}
            };

        }
    }




    class User
    {
        public string Name { get; set; }
    }
}
