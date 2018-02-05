using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class FridgeItem
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public FridgeItem(string n, int a)
        {
            Name = n;
            Amount = a;
        }
    }
}
