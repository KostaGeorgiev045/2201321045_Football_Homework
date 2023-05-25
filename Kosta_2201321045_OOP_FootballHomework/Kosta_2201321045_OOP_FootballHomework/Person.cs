using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosta_2201321045_OOP_FootballHomework
{
    public abstract class Person
    {
        public string Name { get; private set; }

        public int Age { get; private set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
