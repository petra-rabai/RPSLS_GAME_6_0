using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal class Navigation : INavigation
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

        public void ChoosedMenuKeysValidation()
        {
            if (!MenuItems.ContainsKey(NavigationKey))
            {
                foreach (KeyValuePair<char, string> gameMenupair in MenuItems)
                {
                    Console.WriteLine(gameMenupair.Key + " - " + gameMenupair.Value + "\n");
                }
            }
        }

        public string SetChoosedMenu()
        {
            ChoosedMenu = MenuItems[NavigationKey];

            return ChoosedMenu;
        }

        public char SetNavigationKey(Player player)
        {
            NavigationKey = player.ReadPlayerKeyFromTheConsole();
            return NavigationKey;
        }

    }
}
