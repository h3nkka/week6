using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public char Handedness { get; set; }

        public Player(string fn, string ln, string p, char h)
        {
            FirstName = fn;
            LastName = ln;
            Position = p;
            Handedness = h;
        }
    }
}
