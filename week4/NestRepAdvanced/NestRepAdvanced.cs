using System;

namespace NestRepAdvanced {
    class Program {
        static void Main (string[] args) {

            string x = "x";
            string space = " ";
            int counter = 0;

            System.Console.WriteLine ();

            // cone shape --------------------------------

            while (counter <= 10) {

                int counter2 = counter;
                int counter3 = counter;

                while (counter3 > 0) {

                    System.Console.Write (space);
                    counter3 -= 2;

                }

                while (counter2 <= 10) {

                    System.Console.Write (x);
                    counter2++;

                }

                System.Console.WriteLine ();

                counter += 2;

            }

            // This writeline is just to break up the different sections ;) ------------
            System.Console.WriteLine ();
            // tree shape --------------------------------------------------------------

            counter = 0;

            while (counter <= 10) {

                counter += 2;

                int counter2 = counter;
                int counter3 = counter;

                while (counter3 <= 10) {

                    System.Console.Write (space);
                    counter3 += 2;

                }

                while (counter2 > 1) {

                    System.Console.Write (x);
                    counter2--;

                }

                System.Console.WriteLine ();

            }

            // user input shape --------------------------------------------------------------

            System.Console.WriteLine ();
            System.Console.WriteLine ("Cool Dude, now enter your own number!");
            int input = Convert.ToInt32 (Console.ReadLine ());
            System.Console.WriteLine ();
            int count = 0;

            // ----------user input cone--------------------

            while (count <= input) {

                int count2 = count;
                int count3 = count;

                while (count3 > 0) {

                    System.Console.Write (space);
                    count3 -= 2;

                }

                while (count2 <= input) {

                    System.Console.Write (x);
                    count2++;

                }

                System.Console.WriteLine ();

                count += 2;

            }

            System.Console.WriteLine ();
            // -----------user input tree-------------------

            count = 0;

            while (count <= input) {

                count += 2;

                int count2 = count;
                int count3 = count;

                while (count3 <= input) {

                    System.Console.Write (space);
                    count3 += 2;

                }

                while (count2 > 1) {

                    System.Console.Write (x);
                    count2--;

                }

                System.Console.WriteLine ();

            }

            System.Console.WriteLine ();

        }
    }
}