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
                    content.WriteToTheConsole(content.GameAvailableItems + content.UIWaitForInputMessage);
                }
            }
        }

        
    }
}
