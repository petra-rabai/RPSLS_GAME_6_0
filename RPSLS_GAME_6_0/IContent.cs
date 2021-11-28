using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal interface IContent
    {
        string UITitle { get; set; }
        string UIWelcomeMessage { get; set; }
        string UINavigationMessage { get; set; }
        string UIWaitForInputMessage { get; set; }
        string UIHitValidKeyMessage { get; set; }
        string GameModeMessage { get; set; }
        string ChoosedGameModeMessage { get; set; }
        string GameAvailableItems { get; set; }
        void WriteToTheConsole(string content);

    }
}
