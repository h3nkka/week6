using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fridge myFridge = new Fridge("The best fridge ever");
            FridgeItem kalja = new FridgeItem("Kalja", 50);
            FridgeItem makkara = new FridgeItem("Makkara", 5);
            myFridge.AddContents(kalja);
            myFridge.AddContents(makkara);
            myFridge.GetContents();
            Console.ReadKey(true);
        }
    }
}
