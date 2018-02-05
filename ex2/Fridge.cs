using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Fridge
    {
        public string Name { get; set; }
        private List<FridgeItem> contents;

        public Fridge(string n)
        {
            Name = n;
            contents = new List<FridgeItem>();
        }

        public void AddContents(FridgeItem fi)
        {
            if (fi.Amount > 0)
            {
                contents.Add(fi);
                Console.WriteLine("Added {0} {1} to {2}.", fi.Amount, fi.Name, Name);
            }
        }

        public void GetContents()
        {
            Console.WriteLine("{0} contains:", Name);
            foreach (FridgeItem fi in contents)
            {
                Console.WriteLine("{0}x {1}", fi.Amount, fi.Name);
            }
        }

    }
}
