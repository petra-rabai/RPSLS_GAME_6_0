using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_GAME_6_0
{
    internal class Logic : IMachine, ILogic
    {
        public char PlayerKey { get; set; }
        public char MachineKey { get; set; }
        public Dictionary<char, string> GameItems { get; set; } = new Dictionary<char, string>
        {
            ['P'] = "Paper",
            ['S'] = "Scissor",
            ['V'] = "Spock",
            ['R'] = "Rock",
            ['L'] = "Lizard"

        };
        public string[] ChoosedGameItems { get; set; } = new string[2];
        public Dictionary<Tuple<string, string>, string> RuleCheck { get; } =
          new Dictionary<Tuple<string, string>, string>()
          {
                {new Tuple<string, string>("Paper", "Scissor"), "Scissor"},
                {new Tuple<string, string>("Scissor", "Paper"), "Scissor"},
                {new Tuple<string, string>("Rock", "Scissor"), "Rock"},
                {new Tuple<string, string>("Scissor", "Rock"), "Rock"},
                {new Tuple<string, string>("Rock", "Lizard"), "Rock"},
                {new Tuple<string, string>("Lizard", "Rock"), "Rock"},
                {new Tuple<string, string>("Lizard", "Spock"), "Lizard"},
                {new Tuple<string, string>("Spock", "Lizard"), "Lizard"},
                {new Tuple<string, string>("Spock", "Scissor"), "Spock"},
                {new Tuple<string, string>("Scissor", "Spock"), "Spock"},
                {new Tuple<string, string>("Scissor", "Lizard"), "Scissor"},
                {new Tuple<string, string>("Lizard", "Scissor"), "Scissor"},
                {new Tuple<string, string>("Paper", "Lizard"), "Lizard"},
                {new Tuple<string, string>("Lizard", "Paper"), "Lizard"},
                {new Tuple<string, string>("Paper", "Spock"), "Paper"},
                {new Tuple<string, string>("Spock", "Paper"), "Paper"},
                {new Tuple<string, string>("Rock", "Spock"), "Spock"},
                {new Tuple<string, string>("Spock", "Rock"), "Spock"},
                {new Tuple<string, string>("Rock", "Paper"), "Paper"},
                {new Tuple<string, string>("Paper", "Rock"), "Paper"}
          };
        public Tuple<string, string> ComperableItems { get; set ; }
        public string Winner { get; set; }
        public Dictionary<int, string> GameMode { get; set; } = new Dictionary<int, string>
        {
            [1] = "Human Vs Machine",
            [2] = "Human Vs Human"
        };
        public string ChoosedGameMode { get; set; }

        public char GenerateRandomMachineKey()
        {
            Random choose = new Random();
            int chooseHelper = choose.Next(GameItems.Count);
            char randomKey = GameItems.Keys.ElementAt(chooseHelper);
            MachineKey = randomKey;
            return MachineKey;
        }
        public char SetPlayerKey(Player player, Content content)
        {
            PlayerKey = player.ReadPlayerKeyFromTheConsole();
            while ((!GameItems.ContainsKey(PlayerKey)) && (!!GameMode.ContainsKey(PlayerKey)))
            {
                content.WriteToTheConsole(content.UIHitValidKeyMessage);
                ChoosedItemsKeysValidation();
                PlayerKey = player.ReadPlayerKeyFromTheConsole();
            }
            return PlayerKey;
        }

        public void ChoosedItemsKeysValidation()
        {            
            foreach (KeyValuePair<char, string> gameItempair in GameItems)
            {
                Console.WriteLine(gameItempair.Key + " - " + gameItempair.Value + "\n");
            }

            foreach (KeyValuePair<int, string> gameModepair in GameMode)
            {
                Console.WriteLine(gameModepair.Key + " - " + gameModepair.Value + "\n");
            }

        }
        public Tuple<string, string> LoadCompareableItems()
        {
            ComperableItems = new Tuple<string, string>(ChoosedGameItems[0], ChoosedGameItems[1]);

            return ComperableItems;
        }

        public string[] SetChoosedGameItems()
        {
            ChoosedGameItems[0] = GameItems[PlayerKey];
            ChoosedGameItems[1] = GameItems[MachineKey];

            return ChoosedGameItems;
        }

        public string CompareableItemsValidator()
        {
            if (RuleCheck.ContainsKey(ComperableItems))
            {
                Winner = RuleCheck[ComperableItems];
            }

            return Winner;
        }

        public string ChooseGameMode(Player player,Content content)
        {
            int gameModeKey;
            SetPlayerKey(player,content);
            gameModeKey = Convert.ToInt32(PlayerKey);

            ChoosedGameMode = GameMode[gameModeKey];

            return ChoosedGameMode;
        }
    }
}
