using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal interface IPlayer
    {
        Dictionary<int,char> Humans { get; set; }
        char Key { get; set; }
        char ReadPlayerKeyFromTheConsole();
    }
}
