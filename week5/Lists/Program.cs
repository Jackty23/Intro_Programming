using System.Collections.Generic;

namespace Lists {
    class Program {
        static void Main (string[] args) {

            // ==================== Lists task 1 ====================

            List<int> numbers = new List<int> ();
            numbers.Add (1);
            numbers.Add (2);
            numbers.Add (3);
            numbers.Add (4);
            numbers.Add (5);

            System.Console.WriteLine ("Please enter 5 numbers");

            for (int i = 0; i < numbers.Count; i++) {
                int input = int.Parse (System.Console.ReadLine ());
                numbers[i] = input;
            }

            // I wanted the program to continue until the user entered a unique number.
            // I couldn 't find a way to get a while loop to check if the number did NOT equal 
            // the users input, so that it would continue looping. do you have any suggestions?

            int finalno = 0;
            int endthis = 0;

            System.Console.WriteLine ("Please enter 1 more unique number");

            while (endthis == 0) {

                finalno = int.Parse (System.Console.ReadLine ());

                if (numbers.Contains (finalno)) {
                    System.Console.WriteLine ("that number has already been entered, try another number");
                } else {
                    System.Console.WriteLine ("You did it!");
                    endthis = 1;

                }
            }

        }
    }
}