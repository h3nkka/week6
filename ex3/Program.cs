using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Association association = new Association("KEK", "Jyväskylä");
            if (File.Exists("players.txt"))
                association.LoadPlayerInfo();
            else
            {
                List<Player> playerlist = new List<Player>();
                playerlist.Add(new Player("Henri", "Mäkelä", "p", 'R'));
                playerlist.Add(new Player("Juuso", "Mäkelä", "h", 'R'));
                playerlist.Add(new Player("Nikita", "Mämmelä", "mv", 'L'));
                association.Roster = playerlist;
            }
            association.GetRoster();

            association.SavePlayerInfo();
            Console.ReadKey(true);
        }
    }
}
