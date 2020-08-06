using System;

namespace Guessthenumber {
    class Program {
        static void Main (string[] args) {

            System.Random random = new System.Random ();

            //declare variables
            int RandomNumber = random.Next (1, 10);
            int guess;
            int maxcounter = 3;

            //the answer
            System.Console.WriteLine ($" ");
            System.Console.WriteLine ($"The answer is: {RandomNumber}");
            System.Console.WriteLine ($" ");
            //write question
            System.Console.WriteLine ("Hey there! Let's play a little guessing game. You get 3 guesses.");
            System.Console.WriteLine ("Guess the number between 0 and 10");

            //input answer

            guess = int.Parse (Console.ReadLine ());

            if (guess == RandomNumber) {
                System.Console.WriteLine ("You win!");
            } else {
                for (int counter = 1; counter <= maxcounter; counter++) {
                    if (counter == maxcounter) {
                        System.Console.WriteLine ($"guesses used {counter} out of 3");
                        System.Console.WriteLine ("No more guesses, You LOSER!");
                        break;
                    }

                    if (guess == RandomNumber) {
                        System.Console.WriteLine ("You win!");
                        break;
                    }

                    if (guess > RandomNumber) {
                        System.Console.WriteLine ("Nope, try again. The number is lower");
                        System.Console.WriteLine ($"guesses used {counter} out of 3");
                        guess = int.Parse (Console.ReadLine ());

                    }

                    if (guess < RandomNumber) {
                        System.Console.WriteLine ("Nope, try again. The number is higher");
                        System.Console.WriteLine ($"guesses used {counter} out of 3");
                        guess = int.Parse (Console.ReadLine ());
                    }


                }

                System.Environment.Exit (1);
            }
        }
    }
}
