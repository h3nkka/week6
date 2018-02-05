using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Human : Mammal
    {
        public string Name { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        public override void Move()
        {
            Console.WriteLine("I'm moving.");
        }

        public void Grow()
        {
            Age++;
        }
    }
}
