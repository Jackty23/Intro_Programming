using System;

namespace Intro_Programming {
    class Program {
        static void Main (string[] args) {

            // Console.WriteLine ();
            // Console.WriteLine ("Enter a long number.");
            // string input = System.Console.ReadLine ();
            // Console.WriteLine ();

            // char[] array;
            // int total = 0;

            // array = input.ToCharArray ();

            // for (int i = 0; i < array.Length; i++) {

            //     if (i == array.Length - 1) {
            //         Console.Write (array[i]);
            //         Console.WriteLine ();
            //     } else {
            //         Console.Write (array[i] + " + ");
            //     }
            // }

            // for (int i = 0; i < array.Length; i++) {

            //     int conv = Convert.ToInt32 (array[i].ToString ());
            //     total = total + conv;

            // }

            // System.Console.WriteLine ("= " + total);
            // Console.WriteLine ();

            // int input = int.Parse(System.Console.ReadLine ());

            // ============================================================


            Console.WriteLine ();
            Console.WriteLine ("Enter a number: ");
            int input = int.Parse (System.Console.ReadLine ());
            int[] array = new int[input];

            // place numbers into index in reverse order.
            int current = input;
            for (int i = array.Length - 1; i != -1; i--) {
                array[i] = current;
                current = current - 1;
            }

            // what number is in what index place?
            // int index = 0;
            // for (int i = 0; i < array.Length; i++) {
            //     Console.WriteLine ("arrindex " + index + "  " + array[i]);
            //     index++;
            // }

            for (int i = 0; i < array.Length; i++) {
                if (i == array.Length - 1) {
                    Console.Write (array[i] + " = ");
                    Console.WriteLine ();
                } else {
                    Console.Write (array[i] + " x ");
                }
            }

            int total = 0;
            for (int i = 0; i < array.Length; i++) {
                if (i == 0) {
                    total = 1;
                } else {
                    total = total * array[i];
                }
            }

            Console.WriteLine ("The Factoral of " + input + "! is " + total);
            Console.WriteLine ();
            // ============================================================

        }

    }
}