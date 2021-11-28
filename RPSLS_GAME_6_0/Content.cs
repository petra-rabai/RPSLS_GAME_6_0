using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal class Content : IContent
    {
        private const string title = "RPSLS Game";
        private const string newLine = "\n";
        private const string welcomeMessage = "Welcome to the RPSLS Game"
                                              + newLine
                                              + "Rock, Paper, Scissor, Lizard, Spock"
                                              + newLine;
        private const string navigationMessage = "Hit the E key to start the game or hit the Q key to quit the game" + newLine;
        private const string waitForInputMessage = newLine + "Wait for user input: " + newLine;
        private const string hitValidKeyMessage = newLine + "Please hit a valid key: " + newLine;
        private const string gameMode = "Choose your game mode: " + newLine;
        private const string availableItems = "Choose an item: " + newLine + "Paper - P " + newLine + "Scissor - S" + newLine + "Rock - R" + newLine + "Lizard - L" + "Spock -V";
        private const string choosedGameModeMessage = "You choosed: " + newLine;
        private string uITitle = title;
        private string uIWelcomeMessage = welcomeMessage;
        private string uINavigationMessage = navigationMessage;
        private string uIWaitForInputMessage = waitForInputMessage;
        private string uIHitValidKeyMessage = hitValidKeyMessage;
        private string gameModeMessage = gameMode;
        private string gameAvailableItems = availableItems;
        private string choosedGameMode = choosedGameModeMessage;

        public string UITitle { get => uITitle; set => uITitle = value; }
        public string UIWelcomeMessage { get => uIWelcomeMessage; set => uIWelcomeMessage = value; }
        public string UINavigationMessage { get => uINavigationMessage; set => uINavigationMessage = value; }
        public string UIWaitForInputMessage { get => uIWaitForInputMessage; set => uIWaitForInputMessage = value; }
        public string UIHitValidKeyMessage { get => uIHitValidKeyMessage; set => uIHitValidKeyMessage = value; }
        public string GameModeMessage { get => gameModeMessage; set => gameModeMessage = value; }
        public string GameAvailableItems { get => gameAvailableItems; set => gameAvailableItems = value; }
        public string ChoosedGameModeMessage { get => choosedGameMode; set => choosedGameMode = value; }
        public void WriteToTheConsole(string content)
        {
            Console.Title = UITitle;
            Console.WriteLine(content);
        }
    }
}
