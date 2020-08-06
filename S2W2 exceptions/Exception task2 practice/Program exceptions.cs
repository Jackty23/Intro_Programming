using System;
using System.Collections.Generic;

namespace S2W2_exceptions {
    class Programexceptions {
        static void Main (string[] args) {

            makeinputlist ();
            // TheSumOfAllDigits ();

            //methods 
            static void TheSumOfAllDigits () {

                Console.WriteLine ("Enter a long number.");

                string input = System.Console.ReadLine ();

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

            static void makeinputlist () {

                Console.WriteLine ("Enter a long number.");

                string input = System.Console.ReadLine ();
                List<int> digitlist = new List<int> ();

                foreach (string digit in input) {
                    int convertnum = Int32.Parse(digit);
                    digitlist.Add (convertnum);
                }

                for (int i = 0; i < digitlist.Count; i++) {
                    System.Console.WriteLine (digitlist[i]);
                }

            }
        }
    }
}