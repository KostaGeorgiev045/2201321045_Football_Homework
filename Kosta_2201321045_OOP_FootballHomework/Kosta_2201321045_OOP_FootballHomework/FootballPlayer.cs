using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosta_2201321045_OOP_FootballHomework
{
    public abstract class FootballPlayer : Person
    {
        public int Number { get; private set; }
        public double Height { get; private set; }

        protected FootballPlayer(string name, int age, int number, double height) 
            :base(name, age)
        {
            Number = number;
            Height = height;
        }
    }
}
