using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            Logic logic = new Logic();
            Player player = new Player();
            Content content = new Content();
            UINavigation navigation = new UINavigation();

            game.Initialize(navigation, content, player, logic);

        }
    }
}
