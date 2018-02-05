using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class School
    {
        public List<Person> Roster { get; set; }
        public string Name;

        public void PrintRoster()
        {
            Console.WriteLine("Roster of {0}\n", Name);
            foreach (Person person in Roster)
            {
                person.PrintInfo();
            }
        }
    }
}
