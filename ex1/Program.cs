using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Porsche", "model 911");
            List<Tyre> tyrelist = new List<Tyre>();
            for (int i = 0; i < 4; i++)
            {
                tyrelist.Add(new Tyre("Nokia", "Hakkapeliitta", "205R16"));
            }
            vehicle.Tyres = tyrelist;
            Console.ReadKey(true);
        }
    }
}
