using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal class Content : ContentBase, IContent
    {
        public string UITitle { get; set; } = title;
        public string UIWelcomeMessage { get; set; } = welcomeMessage;
        public string UINavigationMessage { get; set; } = navigationMessage;
        public string UIWaitForInputMessage { get; set; } = waitForInputMessage;
        public string UIHitValidKeyMessage { get; set; } = hitValidKeyMessage;
        public string GameModeMessage { get; set; } = gameMode;
        public string GameAvailableItems { get; set; } = availableItems;
        public string ChoosedGameModeMessage { get; set; } = choosedGameModeMessage;
        public void WriteToTheConsole(string content)
        {
            Console.Title = UITitle;
            Console.Clear();
            Console.WriteLine(content);
        }
    }
}
