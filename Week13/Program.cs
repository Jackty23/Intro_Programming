using System;
using System.Collections.Generic;

namespace week13 {
    class Program {
        static void Main (string[] args) {

            System.Console.WriteLine ();
            Console.WriteLine ("BingoCard");

            int boardsize = 5;
            int[] row = new int[boardsize];
            int[] column = new int[boardsize];
            Random random = new Random ();
            List<int> UsedNumbers;

            CreateBoard ();
            System.Console.WriteLine ();

            // print used numbers
            System.Console.WriteLine ("Numbers used in this board");
            for (int x = 0; x < UsedNumbers.Count; x++) {
                System.Console.Write (UsedNumbers[x] + ", ");
            }
            System.Console.WriteLine ();
            System.Console.WriteLine ();
            // Methods -------------------------------------------------------------------------

            void CreateBoard () {
                Line ();
                UsedNumbers = new List<int> ();

                for (int a = 0; a < boardsize; a++) {
                    row[a] = a + 1;
                    System.Console.Write ("Row " + row[a] + " -");

                    for (int i = 0; i < column.Length; i++) {
                        int RandomNumber = random.Next (1, 30);
                        UsedNumbers.Add (RandomNumber);
                        column[i] = RandomNumber;
                        if (RandomNumber <= 9) {
                            System.Console.Write (" |  " + column[i]);
                        } else {
                            System.Console.Write (" | " + column[i]);
                        }
                    }
                    System.Console.Write (" |");
                    Line ();
                }

            }

            void Line () {
                System.Console.WriteLine ();
                System.Console.Write ("        ");

                for (int o = 0; o < column.Length; o++) {
                    System.Console.Write ("=====");
                }
                System.Console.Write ("=");
                System.Console.WriteLine ();
            }
        }
    }
}