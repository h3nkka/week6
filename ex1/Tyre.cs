using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Tyre
    {
        public string Brand { get; set; }
        public string Type { get; set; }
        public string Tyresize { get; set; }

        public Tyre(string b, string t, string ts)
        {
            Brand = b;
            Type = t;
            Tyresize = ts;
            Console.WriteLine("Created a new tyre '{0}'", b);
        }
    }
}
