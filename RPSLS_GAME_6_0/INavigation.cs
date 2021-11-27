using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal interface INavigation
    {
        char NavigationKey { get; set;}
        Dictionary<char, string> MenuItems { get; set; }
        string ChoosedMenu { get; set; }
        char SetNavigationKey(Player player);
        void ChoosedMenuKeysValidation();
        string SetChoosedMenu();

    }
}
