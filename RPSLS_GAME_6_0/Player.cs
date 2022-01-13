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
        public Dictionary<int, char> Humans { get; set; }

        public char ReadPlayerKeyFromTheConsole()
        {
            ConsoleKeyInfo hitKey = Console.ReadKey();
            ConsoleKey numericKey;
            if ((hitKey.Key.ToString() == ConsoleKey.D1.ToString()) || (hitKey.Key.ToString() == ConsoleKey.D2.ToString()))
            {
                Key = hitKey.KeyChar;
            }
            else
            {
                Key = Char.Parse(hitKey.Key.ToString());
            }
            

            return Key;
        }
    }
}
