using System;

namespace nestedrepetitiontask2 {
    class Program {
        static void Main (string[] args) {

            string x = "x";
            int counter = 0;

            while (counter <= 5) {

                counter++;

                int counter2 = counter;

                while (counter2 <= 5) {

                    System.Console.Write (x);

                    counter2++;

                }

                System.Console.WriteLine ();

            }

            // ----------------------------

            counter = 0;

            while (counter <= 5) {

                counter++;

                int counter2 = counter;

                while (counter2 > 1) {

                    System.Console.Write (x);
                    counter2--;

                }

                System.Console.WriteLine ();

            }
        }
    }
}