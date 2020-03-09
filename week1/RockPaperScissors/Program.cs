using System;

namespace RockPaperScissors {
    class Program {
        static void Main (string[] args) {

            System.Random random = new System.Random ();

            //declare variables
            int RandomNumber = random.Next (0, 3);

            string[] rules = { "rock", "paper", "scissors" };
            string userinput;
            string computerguess = rules[RandomNumber];

            int MaxTurns = 3;
            int MaxRounds = 3;
            int CompTurnsWon = 0;
            int PlayerTurnsWon = 0;
            int CompRoundsWon = 0;
            int PlayerRoundsWon = 0;

            for (int turnscounter = 1; turnscounter <= MaxTurns; turnscounter++) {

                System.Console.WriteLine ("Game Start");

                // System.Console.WriteLine ($"Turn {turnscounter} of {MaxTurns} starting");
                //  System.Console.WriteLine ($"computer plays {computerguess}");
                // userinput = Console.ReadLine ();

                if (CompRoundsWon > 2) {
                    System.Console.WriteLine ("Computer wins round");
                    break;
                }
                if (PlayerRoundsWon > 2) {
                    System.Console.WriteLine ("You win round");
                    break;
                }

                CompTurnsWon = 0;
                PlayerTurnsWon = 0;

                // for (int gamescounter = 1; gamescounter <= MaxRounds; gamescounter++) {
                while (PlayerTurnsWon < 2 || CompTurnsWon < 2) {

                    computerguess = rules[random.Next (0, 3)];

                    System.Console.WriteLine (" ");
                    System.Console.WriteLine ($"comp - {CompTurnsWon} Player - {PlayerTurnsWon}");
                    System.Console.WriteLine ($"computer plays {computerguess}");
                    userinput = Console.ReadLine ();

                    //draw
                    if (userinput == computerguess) {
                        System.Console.WriteLine ("Draw");
                        System.Console.WriteLine ("try again");
                    }
                    //rocks
                    if (userinput == "rock" && computerguess == "paper") {
                        System.Console.WriteLine ("You Lose");
                        turnscounter = turnscounter + 1;
                        CompTurnsWon = CompTurnsWon + 1;
                    }
                    if (userinput == "rock" && computerguess == "scissors") {
                        System.Console.WriteLine ("You Win");
                        turnscounter = turnscounter + 1;
                        PlayerTurnsWon = PlayerTurnsWon + 1;
                    }

                    //papers
                    if (userinput == "paper" && computerguess == "scissors") {
                        System.Console.WriteLine ("You Lose");
                        turnscounter = turnscounter + 1;
                        CompTurnsWon = CompTurnsWon + 1;
                    }
                    if (userinput == "paper" && computerguess == "rock") {
                        System.Console.WriteLine ("You Win");
                        turnscounter = turnscounter + 1;
                        PlayerTurnsWon = PlayerTurnsWon + 1;
                    }

                    //scissors
                    if (userinput == "scissors" && computerguess == "rock") {
                        System.Console.WriteLine ("You Lose");
                        turnscounter = turnscounter + 1;
                        CompTurnsWon = CompTurnsWon + 1;
                    }
                    if (userinput == "scissors" && computerguess == "paper") {
                        System.Console.WriteLine ("You Win");
                        turnscounter = turnscounter + 1;
                        PlayerTurnsWon = PlayerTurnsWon + 1;
                    }

                    

                    System.Console.WriteLine ($"end turn");
                    System.Console.WriteLine ($"Turn {turnscounter} of {MaxTurns} starting");
                    
                }

            }

        }
    }
}