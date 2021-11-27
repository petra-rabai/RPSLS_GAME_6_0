using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal class Game
    {
        public void Initialize(UIContent uIContent, Navigation navigation, Player player)
        {
            uIContent.WriteUIToTheConsole();
            navigation.SetNavigationKey(player);
            navigation.SetChoosedMenu();

        }
    }
}
