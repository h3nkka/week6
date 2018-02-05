using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        private List<Tyre> tyres;

        public List<Tyre> Tyres
        {
            get
            {
                return tyres;
            }

            set
            {
                tyres = value;
                Console.WriteLine("Tyres added to vehicle '{0}'", Name);
            }
        }

        public Vehicle(string n, string m)
        {
            Name = n;
            Model = m;
            Console.WriteLine("Created a new vehicle '{0}'", Name);
        }
    }
}
