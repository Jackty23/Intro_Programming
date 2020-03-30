using System;

namespace NestRepAdvanced {
    class Program {
        static void Main (string[] args) {

            string x = "x";
            int counter = 0;
            string space = " ";
            counter = 0;

            System.Console.WriteLine ();

            // cone shape --------------------------------

            while (counter <= 10) {

                int counter2 = counter;
                int counter3 = counter;

                while (counter3 > 0) {

                    System.Console.Write (space);
                    counter3--;
                    counter3--;

                }

                while (counter2 <= 10) {

                    System.Console.Write (x);
                    counter2++;

                }

                System.Console.WriteLine ();

                counter++;
                counter++;

            }

            // This writeline is just to break up the different sections ;) ------------
            System.Console.WriteLine ();
            // tree shape --------------------------------------------------------------

            counter = 0;

            while (counter <= 10) {

                counter++;
                counter++;

                int counter2 = counter;
                int counter3 = counter;

                while (counter3 <= 10) {

                    System.Console.Write (space);
                    counter3++;
                    counter3++;

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

            // ----------cone--------------------

            while (count <= input) {

                int count2 = count;
                int count3 = count;

                while (count3 > 0) {

                    System.Console.Write (space);
                    count3--;
                    count3--;

                }

                while (count2 <= input) {

                    System.Console.Write (x);
                    count2++;

                }

                System.Console.WriteLine ();

                count++;
                count++;

            }

            System.Console.WriteLine ();
            // -----------tree-------------------

            count = 0;

            while (count <= input) {

                count++;
                count++;

                int count2 = count;
                int count3 = count;

                while (count3 <= input) {

                    System.Console.Write (space);
                    count3++;
                    count3++;

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