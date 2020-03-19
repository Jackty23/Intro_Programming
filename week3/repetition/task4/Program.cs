using System;

namespace repetition {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("enter a number, and i'll do the counting for you");

            int counter = 0;
            int input;

            input = int.Parse (Console.ReadLine ());

            Console.WriteLine ("start count");

            while (counter <= input) {

                Console.WriteLine ($"{counter}");
                counter = counter+1;

            }

            Console.WriteLine ("counting complete");

        }
    }
}