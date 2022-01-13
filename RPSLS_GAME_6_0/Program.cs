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
            Game game;
            Logic logic;
            Player player;
            Content content;
            UINavigation navigation;
            CreateGameIdentities(out game, out logic, out player, out content, out navigation);

            game.Initialize(navigation, content, player, logic);

        }

        public static void CreateGameIdentities(out Game game, out Logic logic, out Player player, out Content content, out UINavigation navigation)
        {
            game = new Game();
            logic = new Logic();
            player = new Player();
            content = new Content();
            navigation = new UINavigation();
        }
    }
}
