namespace RPSLS_GAME_6_0
{
    public class ContentBase
    {
        public const string title = "RPSLS Game";
        private const string newLine = "\n";
        public const string welcomeMessage = "Welcome to the RPSLS Game"
                                              + newLine
                                              + "Rock, Paper, Scissor, Lizard, Spock"
                                              + newLine;
        public const string navigationMessage = "Hit the E key to start the game or hit the Q key to quit the game" + newLine;
        public const string waitForInputMessage = newLine + "Wait for user input: " + newLine;
        public const string hitValidKeyMessage = newLine + "Please hit a valid key: " + newLine;
        public const string gameMode = "Choose your game mode: "
                                        + newLine
                                        + "Hit the 1 key to start Human Vs Machine"
                                        + newLine
                                        + "Hit the 2 key to start Human Vs Human";
        public const string availableItems = "Choose an item: "
                                              + newLine
                                              + "Paper - P "
                                              + newLine
                                              + "Scissor - S"
                                              + newLine
                                              + "Rock - R"
                                              + newLine
                                              + "Lizard - L"
                                              + "Spock -V";
        public const string choosedGameModeMessage = "You choosed: " + newLine;
    }
}