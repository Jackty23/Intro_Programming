using System;

namespace nestedrepetitionpractice {
    class Program {
        static void Main (string[] args) {

            string name = "Jane";
            int counter = 0;

            while (counter < 10) {

                counter++;

                int counter2 = counter;

                while (counter2 < 5) {

                    System.Console.Write (counter + "|" + counter2 + " ");

                    counter2++;

                }

                System.Console.WriteLine ();

            }

            System.Console.WriteLine ("Goodbye");

            // ----------------------------

            for (int count = 0; count < 10; count++) {

                for (int count2 = count; count2 < 5; count2++) {

                    System.Console.Write (count2 + " | " + count + " ");

                }
                System.Console.WriteLine ();
            }
            System.Console.WriteLine ("Goodbye");
        }
    }
}