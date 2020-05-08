using System;

namespace week6 {
    class Program {

        // ======================================== main ========================================

        static void Main (string[] args) {

            reload ();

            static void reload () {

                int input = 0;

                System.Console.WriteLine ();
                System.Console.WriteLine ("Please choose the function to run, there are 12 to choose from.");
                System.Console.WriteLine ("Or, type any other number to end");
                input = int.Parse (System.Console.ReadLine ());

                if (input == 1) {
                    function1 ();
                    reload ();
                } else {
                    if (input == 2) {
                        function2 ();
                        reload ();
                    } else {
                        if (input == 3) {
                            function3 ();
                            reload ();
                        } else {
                            if (input == 4) {
                                function4 ();
                                reload ();
                            } else {
                                if (input == 5) {
                                    function5 ();
                                    reload ();
                                } else {
                                    if (input == 6) {
                                        function6 ();
                                        reload ();
                                    } else {
                                        if (input == 7) {
                                            function7 ();
                                            reload ();
                                        } else {
                                            if (input == 8) {
                                                function8 ();
                                                reload ();
                                            } else {
                                                if (input == 9) {
                                                    function9 ();
                                                    reload ();
                                                } else {
                                                    if (input == 10) {
                                                        function10 ();
                                                        reload ();
                                                    } else {
                                                        if (input == 11) {
                                                            function11 ();
                                                            reload ();
                                                        } else {
                                                            if (input == 12) {
                                                                function12 ();
                                                                reload ();
                                                            } else {
                                                                Console.WriteLine ();
                                                                Console.WriteLine ("Thanks for playing, Have a nice day!");
                                                                Console.WriteLine ();
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            // ======================================== 1 ========================================
            static void function1 () {

                System.Console.WriteLine ();
                System.Console.WriteLine ("=== Function 1: welcome ===");
                Console.WriteLine ("Welcome Friends!");
                Console.WriteLine ("Have a nice day!");

            }

            // ======================================== 2 ========================================
            static void function2 () {

                string name = "";

                System.Console.WriteLine ();
                System.Console.WriteLine ("=== Function 2: welcome friend! ===");
                Console.WriteLine ("Please enter a name:");
                name = System.Console.ReadLine ();
                Console.WriteLine ("Welcome Friend " + name + "!");
                Console.WriteLine ("Have a nice day!");

            }

            // ======================================== 3 ========================================
            static void function3 () {

                int no1 = 0;
                int no2 = 0;
                int ans = 0;

                System.Console.WriteLine ();
                System.Console.WriteLine ("=== Function 3: add 2 numbers. ===");
                Console.WriteLine ("Please enter a number");
                no1 = int.Parse (System.Console.ReadLine ());

                Console.WriteLine ("Please enter another number");
                no2 = int.Parse (System.Console.ReadLine ());

                ans = no1 + no2;
                Console.WriteLine ("The sum of two numbers is: " + ans);

            }

            // ======================================== 4 ========================================
            static void function4 () {

                string input = "";

                System.Console.WriteLine ();
                System.Console.WriteLine ("=== Function 4: how many spaces? ===");
                Console.WriteLine ("Please input a short sentence");
                input = System.Console.ReadLine ();

                int spaces = 0;
                
                for (int i = 0; i < input.Length; i++) {
                    if (input[i] == ' ') {
                        spaces++;
                    }
                }

                System.Console.WriteLine ("'" + input + "' contains " + spaces + " spaces.");

            }

            // ======================================== 5 ========================================
            static void function5 () {

                string[] elements = new string[5];
                int total = 0;

                System.Console.WriteLine ();
                System.Console.WriteLine ("=== Function 5: add 5 numbers ===");
                System.Console.WriteLine ("please enter 5 numbers");

                for (int i = 0; i < elements.Length; i++) {
                    int x = i + 1;
                    System.Console.Write ("Number " + x + ": ");
                    string input = Console.ReadLine ();
                    elements[i] = input;
                }

                for (int i = 0; i < elements.Length; i++) {
                    total = total + int.Parse (elements[i]);
                }

                System.Console.WriteLine ("The sum of the elements of the array is " + total);
            }

            // ======================================== 6 ========================================
            static void function6 () {

                int number1 = 0;
                int number2 = 0;
                int placeholder = 0;

                System.Console.WriteLine ();
                System.Console.WriteLine ("=== Function 6: swap 2 numbers ===");
                System.Console.WriteLine ("Enter a number");

                number1 = int.Parse (System.Console.ReadLine ());

                Console.WriteLine ("Enter another number");
                number2 = int.Parse (System.Console.ReadLine ());

                placeholder = number1;
                number1 = number2;
                number2 = placeholder;

                System.Console.WriteLine ("Now the 1st number is: " + number1 + ", and the 2nd number is: " + number2);
            }

            // ======================================== 7 ========================================
            static void function7 () {

                int number1 = 0;
                int number2 = 0;
                int answer = 0;

                System.Console.WriteLine ();
                System.Console.WriteLine ("=== Function 7: to the power ===");

                System.Console.WriteLine ("Input Base number");
                number1 = int.Parse (System.Console.ReadLine ());

                Console.WriteLine ("Enter the Exponent");
                number2 = int.Parse (System.Console.ReadLine ());

                answer = number1 * number1;

                if (number2 > 2) {
                    for (int i = 2; i < number2; i++) {
                        answer = answer * number1;
                    }
                }

                System.Console.WriteLine ("So, the number " + number1 + " ^ (to the power) " + number2 + " = " + answer);
            }

            // ======================================== 8 ========================================
            static void function8 () {

                int input = 0;
                int number1 = 0;
                int number2 = 0;
                int[] result = new int[1000];

                System.Console.WriteLine ();
                System.Console.WriteLine ("=== Function 8: fibonacci series ===");
                System.Console.WriteLine ("Input number of Fibonacci Series:");
                input = int.Parse (System.Console.ReadLine ());

                for (int i = 0; i < input; i++) {

                    if (i == 0) {
                        result[i] = number2;
                        number2 = number2 + 1;

                    } else if (i == 1) {
                        result[i] = number2;

                    } else if (i >= 2) {
                        result[i] = number1 + number2;
                        number1 = number2;
                        number2 = result[i];

                    }
                }

                System.Console.Write ("The Fibonacci series of " + input + " numbers is: ");
                for (int i = 0; i < input; i++) {

                    if (i == input - 1) {
                        System.Console.Write (result[i]);
                    } else {
                        System.Console.Write (result[i] + ", ");

                    }
                }

                System.Console.WriteLine ();
            }

            // ======================================== 9 ========================================
            static void function9 () {

                int input = 0;
                int notprime = 0;

                System.Console.WriteLine ();
                System.Console.WriteLine ("=== Function 9: is the number prime? ===");
                System.Console.WriteLine ("Input a prime number:");
                input = int.Parse (System.Console.ReadLine ());

                if (input == 1) {
                    notprime = 1;
                } else {

                    for (int i = 2; i < input; i++) {

                        if (input % i == 0) {
                            notprime = 1;
                        }
                    }
                }

                System.Console.WriteLine ();
                if (notprime == 0) {
                    System.Console.WriteLine (input + " is a prime number");
                } else {
                    System.Console.WriteLine (input + " is NOT a prime number");
                }
            }

            //  ======================================== 10 ========================================
            static void function10 () {

                Console.WriteLine ();
                System.Console.WriteLine ("=== Function 10: add the digits of a number ===");
                Console.WriteLine ("Enter a long number.");
                string input = System.Console.ReadLine ();
                Console.WriteLine ();

                char[] array;
                int total = 0;

                array = input.ToCharArray ();

                for (int i = 0; i < array.Length; i++) {

                    if (i == array.Length - 1) {
                        Console.Write (array[i]);
                        Console.WriteLine ();
                    } else {
                        Console.Write (array[i] + " + ");
                    }
                }

                for (int i = 0; i < array.Length; i++) {

                    int conv = Convert.ToInt32 (array[i].ToString ());
                    total = total + conv;

                }

                System.Console.WriteLine ("= " + total);

            }

            //  ======================================== 11 ========================================
            static void function11 () {

                Console.WriteLine ();
                System.Console.WriteLine ("=== Function 11: the factoral ===");
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

            }

            //  ======================================== 12 ========================================
            static void function12 () {

                int input = 0;
                int number1 = 0;
                int number2 = 0;
                int count = 0;

                System.Console.WriteLine ();
                System.Console.WriteLine ("=== Function 12: the fibonacci of n ===");
                System.Console.WriteLine ("Input a number:");

                input = int.Parse (System.Console.ReadLine ());
                count = input + 1;
                int[] result = new int[count];
                var lastItem = result.GetUpperBound (0);

                for (int i = 0; i < count; i++) {

                    if (i == 0) {
                        result[i] = number2;
                        number2 = number2 + 1;

                    } else if (i == 1) {
                        result[i] = number2;

                    } else if (i >= 2) {
                        result[i] = number1 + number2;
                        number1 = number2;
                        number2 = result[i];

                    }
                }

                // for (int i = 0; i < count; i++) {
                //     System.Console.Write (result[i] + ", ");

                // }
                for (int i = 0; i < count; i++) {
                    if (i == input) {
                        System.Console.Write (result[i]);
                    } else {
                        System.Console.Write (result[i] + ", ");
                    }
                }

                System.Console.WriteLine ();
                System.Console.WriteLine ();
                System.Console.Write ("The Fibonacci of " + input + "th term is: ");
                System.Console.Write (result[lastItem]);
                System.Console.WriteLine ();

            }
            // end
        }
    }
}