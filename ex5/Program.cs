using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Age = 100;
            human.Name = "Juuso";
            Adult adult = new Adult();
            adult.Age = 40;
            adult.Weight = 80.5F;
            adult.Name = "Seppo";
            adult.Car = "Audi";
            Baby baby = new Baby();
            baby.Age = 2;
            baby.Name = "Keke";
            baby.Diaper = "Pampers";
            Console.WriteLine("Human: {0}",human.Name);
            Console.WriteLine("Age: {0}",human.Age);
            human.Move();
            Console.WriteLine("Adult: {0}", adult.Name);
            Console.WriteLine("Age: {0}", adult.Age);
            Console.WriteLine("Weight: {0}", adult.Weight);
            Console.WriteLine("Car: {0}", adult.Car);
            adult.Move();
            Console.WriteLine("Baby: {0}", baby.Name);
            Console.WriteLine("Age: {0}", baby.Age);
            Console.WriteLine("Diaper: {0}", baby.Diaper);
            baby.Move();

            Console.ReadKey(true);
        }
    }
}
