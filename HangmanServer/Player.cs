using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanServer
{
    internal class Player
    {
        internal string ip;
        internal static int hp = 12;
        public Player(string ip)
        {
            this.ip = ip;
        }
    }
}
