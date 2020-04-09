using System;

namespace task6 {
    class Program {
        static void Main (string[] args) {

            System.Random random = new System.Random ();
            int secnum = random.Next (1, 1000);
            int counter = 1;
            int guess = 0;

            Console.WriteLine ("Guess the number between 0 and 1000!");
            Console.WriteLine ($"the number is {secnum}");

            while (counter <= 10) {

                Console.WriteLine ($"turn {counter} out of 10");
                guess = int.Parse (Console.ReadLine ());

                if (guess == secnum) {

                    Console.WriteLine ("You Got it!");
                    break;

                } else {

                    if (guess < secnum) {

                        Console.WriteLine ("The number is higher");
                        Console.WriteLine ("Guess again");
                        counter = counter + 1;

                    } else {

                        if (guess > secnum) {

                            Console.WriteLine ("The number is lower");
                            Console.WriteLine ("Guess again");
                            counter = counter + 1;
                        }

                    }

                }

            }
        }
    }
}