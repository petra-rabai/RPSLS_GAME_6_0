using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal class UINavigation : IUINavigation
    {
        public char NavigationKey { get; set; }
        public Dictionary<char, string> MenuItems { get; set; } = new Dictionary<char, string>
        {
            ['E'] = "Start the Game",
            ['H'] = "Game Help",
            ['B'] = "Back to the Menu",
            ['C'] = "Save the Result",
            ['Q'] = "Quit the Game"
        };
        public string ChoosedMenu { get; set; }

        public void ChoosedUIMenuKeysValidation()
        {
            foreach (KeyValuePair<char, string> gameMenupair in MenuItems)
            {
                Console.WriteLine(gameMenupair.Key + " - " + gameMenupair.Value + "\n");
            }   
        }

        public char SetUINavigationKey(Player player, Content content)
        {
            NavigationKey = player.ReadPlayerKeyFromTheConsole();
            while (!MenuItems.ContainsKey(NavigationKey))
            {
                content.WriteToTheConsole(content.UIHitValidKeyMessage);
                ChoosedUIMenuKeysValidation();
                NavigationKey = player.ReadPlayerKeyFromTheConsole();
            }

            return NavigationKey;
        }

        public string SetChoosedUIMenu()
        {
            ChoosedMenu = MenuItems[NavigationKey];

            return ChoosedMenu;
        }

        public void Navigation()
        {
            SetChoosedUIMenu();
            switch (ChoosedMenu)
            {
                case "Start the Game":
                    Console.Clear();
                    break;
                case "Quit the Game":
                    Environment.Exit(0);
                    break;
                   
            }
        }
    }
}
