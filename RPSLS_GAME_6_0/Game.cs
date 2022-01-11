using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal class Game 
    {
        public void Initialize(UINavigation navigation,Content content, Player player, Logic logic)
        {
            content.WriteToTheConsole(content.UIWelcomeMessage + content.UINavigationMessage + content.UIWaitForInputMessage);
            navigation.SetUINavigationKey(player, content);
            navigation.Navigation();
            if (navigation.ChoosedMenu == "Start the Game")
            {
                content.WriteToTheConsole(content.GameModeMessage + content.UIWaitForInputMessage);
                logic.ChooseGameMode(player, content);
                if (logic.ChoosedGameMode == "Human Vs Machine")
                {
                    content.WriteToTheConsole(content.ChoosedGameModeMessage + logic.ChoosedGameMode);
                    content.WriteToTheConsole(content.GameAvailableItems + content.UIWaitForInputMessage);
                    logic.SetPlayerKey(player, content);
                    logic.GenerateRandomMachineKey();
                    logic.SetChoosedGameItems();
                    logic.LoadCompareableItems();
                    logic.CompareableItemsValidator();
                }
                else if (logic.ChoosedGameMode == "Human Vs Human")
                {
                    content.WriteToTheConsole(content.ChoosedGameModeMessage + logic.ChoosedGameMode);
                    // how many player want to play? - Content, palyer
                    // store player numbers and id - player
                    // add player id to a paramater to SetPlayerKey method - player
                    content.WriteToTheConsole(content.GameAvailableItems + content.UIWaitForInputMessage);
                    logic.SetPlayerKey(player, content);
                }
            }
        }

        
    }
}
