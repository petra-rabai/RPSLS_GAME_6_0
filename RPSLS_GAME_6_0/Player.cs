using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal class Player : IPlayer
    {
        public char Key { get; set; }

        public char ReadPlayerKeyFromTheConsole()
        {
            ConsoleKeyInfo hitKey = Console.ReadKey();
            Key = Char.Parse(hitKey.Key.ToString());

            return Key;
        }
    }
}
