using System;
using System.Collections.Generic;

namespace lists3 {
    class Program {
        static void Main (string[] args) {

            // ==================== Lists task 3 ====================

            string stop = "stop";
            int endloop = 0;
            int counter = -1;

            List<string> words = new List<string> ();

            System.Console.WriteLine ();
            System.Console.WriteLine ("Please enter as many words as you can. type stop to end");
            System.Console.WriteLine ();

            while (endloop == 0) {

                System.Console.WriteLine ("=== " + "word number " + words.Count + " ===");

                string input = System.Console.ReadLine ();

                if (input == stop) {

                    endloop = 1;

                } else {

                    counter++;
                    words.Add (input);

                }
            }

            System.Console.WriteLine ();
            System.Console.WriteLine ("You entered stop, Here are the words you entered from the latest to the first.");
            System.Console.WriteLine ();

            for (int i = counter; i >= 0; i--) {

                System.Console.WriteLine (words[i]);

            }
            System.Console.WriteLine ();
        }
    }
}