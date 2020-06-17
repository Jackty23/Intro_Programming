using System;
using System.Collections.Generic;

namespace week15 {
    class Program {
        static void Main (string[] args) {

            System.Console.WriteLine ();
            System.Console.WriteLine ("=====================================================");
            System.Console.WriteLine ("||                 Welcome to the                  ||");
            System.Console.WriteLine ("||              Swinburne Bingo Club               ||");
            System.Console.WriteLine ("=====================================================");
            System.Console.WriteLine ();

            int UpperLimit = 0;
            Random random = new Random ();
            List<int> UsedNumbers;
            UsedNumbers = new List<int> ();
            int UserInput = 1;

            SetUpperLimit ();

            Menu ();

            // Methods -----------------------------------------------------------------

            // void Pause () {
            //     System.Console.WriteLine ();
            //     System.Console.WriteLine ();
            //     System.Console.Write ("press ENTER to return to menu");
            //     Console.ReadKey ();
            //     Menu ();
            // }

            void Menu () {
                System.Console.WriteLine ();
                System.Console.WriteLine ();
                System.Console.WriteLine ("====================================================");
                System.Console.WriteLine ("||     Please make a selection...                 ||");
                System.Console.WriteLine ("||                                                ||");
                System.Console.WriteLine ("||  1. Draw next number                           ||");
                System.Console.WriteLine ("||  2. View all drawn numbers                     ||");
                System.Console.WriteLine ("||  3. View all drawn numbers in numerical order  ||");
                System.Console.WriteLine ("||  4. Check specific number                      ||");
                System.Console.WriteLine ("||  5. Check a list of numbers                    ||");
                System.Console.WriteLine ("||  6. Statistics                                 ||");
                System.Console.WriteLine ("||  7. Exit                                       ||");
                System.Console.WriteLine ("====================================================");
                System.Console.WriteLine ();

                System.Console.Write ("Option: ");
                UserInput = int.Parse (Console.ReadLine ());

                switch (UserInput) {
                    case 1:
                        DrawNumber ();
                        return;
                    case 2:
                        PrintUsed ();
                        return;
                    case 3:
                        PrintUsedOrd ();
                        return;
                    case 4:
                        CheckNumber ();
                        return;
                    case 5:
                        CheckListNumbers ();
                        return;
                    case 6:
                        Statistics ();
                        return;
                    case 7:
                        System.Console.WriteLine ("Thank you for playing!");
                        System.Console.WriteLine ();
                        // CreateFile ();
                        break;
                    default:
                        System.Console.Write ("that's not an option!");
                        Menu ();
                        return;
                }
            }

            void SetUpperLimit () {
                System.Console.Write ("Please select your upper limit of numbers to draw from: ");
                UpperLimit = int.Parse (Console.ReadLine ());
                if (UpperLimit < 1) {
                    System.Console.WriteLine ("Number cannot be less than 1");
                    SetUpperLimit ();
                }
                return;
            }

            void DrawNumber () {
                int RandomNumber = random.Next (1, UpperLimit);
                var alreadyexists = UsedNumbers.Contains (RandomNumber);

                if (alreadyexists == true) {
                    System.Console.Write ("Number drawn is " + RandomNumber + ", which has already been drawn.");
                } else {
                    System.Console.Write ("Number drawn is " + RandomNumber);
                    UsedNumbers.Add (RandomNumber);
                }
                Menu ();
            }

            void PrintUsed () {
                System.Console.Write ("Numbers drawn so far are: ");
                for (int i = 0; i < UsedNumbers.Count; i++) {
                    if (i == UsedNumbers.Count - 1) {
                        System.Console.Write (UsedNumbers[i] + ".");
                    } else {
                        if (i < UsedNumbers.Count) {
                            System.Console.Write (UsedNumbers[i] + ", ");
                        }
                    }
                }
                Menu ();
            }

            void PrintUsedOrd () {

                List<int> SeqList = new List<int> ();

                // creates a copy of the list, so as not to disturb the original order.
                for (int i = 0; i < UsedNumbers.Count; i++) {
                    SeqList.Add (UsedNumbers[i]);
                }

                System.Console.Write ("Numbers drawn so far, in numerical order, are: ");

                SeqList.Sort ();

                for (int c = 0; c < SeqList.Count; c++) {
                    if (c == SeqList.Count - 1) {
                        System.Console.Write (SeqList[c] + ". ");
                    } else {
                        if (c < SeqList.Count) {
                            System.Console.Write (SeqList[c] + ", ");
                        }
                    }
                }
                Menu ();
            }

            void CheckNumber () {
                System.Console.Write ("Number to check: ");
                var checknumber = int.Parse (Console.ReadLine ());

                var alreadyexists = UsedNumbers.Contains (checknumber);
                if (alreadyexists == true) {
                    System.Console.Write (checknumber + " has already been drawn.");
                } else {
                    System.Console.Write (checknumber + " has not been drawn yet.");
                }
                Menu ();
            }

            void CheckListNumbers () {
                System.Console.WriteLine ("Please type out a list of numbers, separated by a space");
                System.Console.Write ("Numbers to check: ");

                // var numbers = int.Parse (Console.ReadLine ());

                var input = Console.ReadLine ();
                var numbers = input.Split (' ');
                int num;
                List<int> Used = new List<int> ();
                List<int> NotUsed = new List<int> ();

                foreach (var x in numbers) {

                    if (Int32.TryParse (x, out num)) {
                        // num is your number as integer
                        if (UsedNumbers.Contains (num)) {
                            Used.Add (num);
                        } else {
                            NotUsed.Add (num);
                        }
                    }
                }
                System.Console.WriteLine ();
                System.Console.Write ("These have been drawn: ");
                foreach (var x in Used) {
                    System.Console.Write (x + " ");
                }
                System.Console.WriteLine ();
                System.Console.Write ("These have not been drawn: ");
                foreach (var x in NotUsed) {
                    System.Console.Write (x + " ");
                }
                Menu ();
            }

            void Statistics () {

                System.Console.WriteLine ("There have been " + UsedNumbers.Count + " numbers drawn so far.");

                // get total
                int total = 0;

                for (int i = 0; i < UsedNumbers.Count; i++) {
                    total = total + UsedNumbers[i];
                }
                System.Console.WriteLine ("The total sum of all numbers drawn is: " + total);

                // get average
                int average = total / UsedNumbers.Count;
                System.Console.Write ("The average of all numbers drawn is: " + average);
                Menu ();
            }

            // void CreateFile (){

            // string FileName = @"C:\Users\Lachlan\Desktop\Intro_Programming\Week15\TextFileOutput.txt";

            // File.Create(FileName);
            // }

        }
    }
}