using System.Collections.Generic;

namespace Lists {
    class Program {
        static void Main (string[] args) {

            // ==================== Lists task 2 ====================

            List<int> numbers = new List<int> ();
            numbers.Add (1);
            numbers.Add (2);
            numbers.Add (3);
            numbers.Add (4);
            numbers.Add (5);

            System.Console.WriteLine ();
            System.Console.WriteLine ("Please enter 5 numbers");

            for (int i = 0; i < numbers.Count; i++) {
                int input = int.Parse (System.Console.ReadLine ());
                numbers[i] = input;
            }

            List<int> numbers2 = new List<int> ();
            numbers2.Add (1);
            numbers2.Add (2);
            numbers2.Add (3);
            numbers2.Add (4);
            numbers2.Add (5);

            System.Console.WriteLine ();
            System.Console.WriteLine ("Please enter 5 more numbers");

            int count = 0;

            for (int i = 0; i < numbers2.Count; i++) {
                int input2 = int.Parse (System.Console.ReadLine ());
                numbers2[i] = input2;

                if (numbers.Contains (input2)) {
                    count++;

                }

            }
            System.Console.WriteLine ();
            System.Console.WriteLine ("You repeated " + count + " numbers");
            System.Console.WriteLine ();
        }

    }
}