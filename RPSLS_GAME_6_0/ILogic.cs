using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal interface ILogic
    {
        Dictionary<char, string> GameItems { get; set; }
        char PlayerKey { get; set; }
        string[] ChoosedGameItems { get; set; }
        Tuple<string,string> ComperableItems { get; set; }
        Dictionary<Tuple<string, string>, string> RuleCheck { get; }
        string Winner { get; set; }
        Tuple<string, string> LoadCompareableItems();
        string CompareableItemsValidator();
        void ChoosedGameItemsKeysValidation();
        char SetPlayerKey(Player player);
        string[] SetChoosedGameItems();
    }
}
