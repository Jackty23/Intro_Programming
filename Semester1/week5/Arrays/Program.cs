using System;

namespace Arrays {
    class Program {
        static void Main (string[] args) {

            Console.WriteLine ();
            Console.WriteLine ("Hello World, Let's start the program!");
            Console.WriteLine ();

            //================array task 2================

            int size = 10;
            int[] numbers = new int[size];

            int total = 0;

            numbers[0] = 34;
            numbers[1] = 5;
            numbers[2] = 67;
            numbers[3] = 1;
            numbers[4] = 99;
            numbers[5] = 34;
            numbers[6] = 44;
            numbers[7] = 78;
            numbers[8] = 34;
            numbers[9] = 0;

            for (int i = 0; i < numbers.Length; i++) {
                System.Console.WriteLine ("index " + i + " = " + numbers[i]);

                total += numbers[i];

            }

            Console.WriteLine ();
            System.Console.WriteLine ("Total is: " + total);
            Console.WriteLine ();

            //================array task 1================

            string[] names = new string[5];

            System.Console.WriteLine ("Now, please enter the names of 5 of your friends,");
            System.Console.WriteLine ("in order of preference...");
            System.Console.WriteLine ();

            for (int i = 0; i < names.Length; i++) {

                string input = Console.ReadLine ();

                names[i] = input;

            }

            System.Console.WriteLine ();

            for (int i = 0; i < names.Length; i++) {

                System.Console.WriteLine ("Hello friend number " + (i + 1) + ", " + names[i]);

            }

            System.Console.WriteLine ();
            System.Console.WriteLine ("Oh... poor " + names[4]);
            System.Console.WriteLine ();

        }
    }
}