using System;

namespace FizzBuzz {
    class Program {
        static void Main (string[] args) {

            int counter = 1;

            while (counter <= 100) {

                if (counter % 3 == 0) {
                    // AND
                    if (counter % 5 == 0) {
                        Console.WriteLine ("FizzBuzz");
                    } else {
                        Console.WriteLine ("Fizz");
                    }

                } else {

                    if (counter % 5 == 0) {
                        Console.WriteLine ("Buzz");

                    } else {
                        Console.WriteLine (counter);
                    }

                }
                counter = counter + 1;
            }
        }
    }
}