using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal class UIContent : IUIContent
    {
        private const string Title = "RPSLS Game";
        private const string NewLine = "\n";
        private const string WelcomeMessage = "Welcome to the RPSLS Game"
                                              + NewLine
                                              + "Rock, Paper, Scissor, Lizard, Spock"
                                              + NewLine;
        private const string NavigationMessage = "Hit the E key to start the game or hit the Q key to quit the game" + NewLine;
        private const string WaitForInputMessage = NewLine + "Wait for user input: " + NewLine;
        private const string HitValidKeyMessage = NewLine + "Please hit a valid key: " + NewLine;

        private string uITitle = Title;
        private string uIWelcomeMessage = WelcomeMessage;
        private string uINavigationMessage = NavigationMessage;
        private string uIWaitForInputMessage = WaitForInputMessage;
        private string uIHitValidKeyMessage = HitValidKeyMessage;

        public string UITitle { get => uITitle; set => uITitle = value; }
        public string UIWelcomeMessage { get => uIWelcomeMessage; set => uIWelcomeMessage = value; }
        public string UINavigationMessage { get => uINavigationMessage; set => uINavigationMessage = value; }
        public string UIWaitForInputMessage { get => uIWaitForInputMessage; set => uIWaitForInputMessage = value; }
        public string UIHitValidKeyMessage { get => uIHitValidKeyMessage; set => uIHitValidKeyMessage = value; }

        public void WriteUIToTheConsole()
        {
            Console.Title = UITitle;
            Console.WriteLine(UIWelcomeMessage + UINavigationMessage + UIWaitForInputMessage);
        }
    }
}
