using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal interface IUINavigation
    {
        char NavigationKey { get; set;}
        Dictionary<char, string> MenuItems { get; set; }
        string ChoosedMenu { get; set; }
        char SetUINavigationKey(Player player, Content content);
        void ChoosedUIMenuKeysValidation();
        string SetChoosedUIMenu();
        void Navigation();

    }
}
