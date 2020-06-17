using System;
using System.Collections.Generic;

namespace task2 {

    class Program {

        public static void Main (string[] args) {

            List<int> UsedNumbers = new List<int> { 7, 5, 3, 1, 9 };

            List<int> SeqList = new List<int> ();

            for (int i = 0; i < UsedNumbers.Count; i++) {
                SeqList.Add (UsedNumbers[i]);
            }

            SeqList.Sort ();

            System.Console.WriteLine ();

            for (int c = 0; c < SeqList.Count; c++) {
                if (c == SeqList.Count - 1) {
                    System.Console.Write (SeqList[c] + ". ");
                } else {
                    if (c < SeqList.Count) {
                        System.Console.Write (SeqList[c] + ", ");
                    }
                }
            }

            //  var checknumber = int.Parse (Console.ReadLine ());

            //                 if (SeqList.Contains (num1){
            //                     num1 = UnordList[0];
            //                 } else {
            //                     if (SeqList.Contains (num2){
            //                 }

            //                 System.Console.WriteLine ("Loop AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA: " + num1 + " vs " + num2);

            //                 for (int b = 0; b < UsedNumbers.Count; b++) {
            //                     num1 = UnordList[b];

            //                     System.Console.WriteLine ("Loop B: " + num1 + " vs " + num2);

            // //                     if (num1 == 100 || num2 == 100) {
            // // System.Console.WriteLine ("it equal 0 ");
            // // break;
            //                         if (num1 < num2) {
            //                             smaller = num1;
            //                             indextoremove = b;
            //                             System.Console.WriteLine ("index1 " + indextoremove);
            //                             // System.Console.WriteLine ("2: " + num1 + " vs " + num2);
            //                         } else {
            //                             if (num2 < num1) {
            //                                 smaller = num2;
            //                                 // indextoremove = b;
            //                                 System.Console.WriteLine ("index2 " + indextoremove);
            //                             }

            //                             // num2 = num2;

            //                             // System.Console.WriteLine ("index3 " + indextoremove);
            //                             // System.Console.WriteLine ("3: " + num1 + " vs " + num2);
            //                         }

            //                     System.Console.WriteLine ("smallest number is " + smaller);
            //                 }
            //                 UnordList[indextoremove] = 0;

            //                 System.Console.WriteLine ("unordelist  ");
            //                 for (int c = 0; c < 5; c++) {
            //                     System.Console.WriteLine (UnordList[c]);
            //                 }

            //                 SeqList.Add (smaller);
            //             }

            //             for (int c = 0; c < 5; c++) {
            //                 System.Console.WriteLine (SeqList[c]);
            //             }
            //====
        }
    }
}

//         var b1 = new Book ("Moby Dick", 666);
//         var b2 = new Book ("Happy Dogs!", 50);

//         // b1.PrintBookInfo (b2);
//         // b2.PrintBookInfo (b1);

//         b1.PrintBookInfo ();
//         System.Console.WriteLine ();
//         System.Console.WriteLine (b1.ComparePageNumbers (b2));

//         b2.PrintBookInfo ();
//         System.Console.WriteLine ();
//         System.Console.WriteLine (b2.ComparePageNumbers (b1));
//     }
// }

// public class Book {
//     public string BookTitle;
//     public int BookPageNo;

//     public Book (string _BookTitle, int _BookPageNo) {
//         this.BookTitle = _BookTitle;
//         this.BookPageNo = _BookPageNo;
//     }

//     public void PrintBookInfo () {
//         System.Console.WriteLine (this.BookTitle);
//         System.Console.WriteLine (this.BookPageNo + " pages");
//     }

//     public int ComparePageNumbers (Book other) {
//         int difference = 0;
//         if (this.BookPageNo > other.BookPageNo) {
//             difference = this.BookPageNo - other.BookPageNo;
//         } else if (other.BookPageNo > this.BookPageNo) {
//             difference = other.BookPageNo - this.BookPageNo;
//         }
//         return difference;
//     }

// public int GetHeightDifference(Person other)
//     {
//         System.Console.Write("The difference in these two peoples' heights in cm is: ");
//         int heightDiff = 0;

//         if (this.heightInCm > other.heightInCm)
//         {
//             heightDiff = this.heightInCm - other.heightInCm;
//         }
//         if (other.heightInCm > this.heightInCm)
//         {
//             heightDiff = other.heightInCm - this.heightInCm;
//         }
//         return heightDiff;
//     }

//  : IEquatable<Subject> {
// public string SubjectName { get; set; }

// public int Yearofdelivery { get; set; }

// public override string ToString () {
//     return "ID: " + Yearofdelivery + "   Name: " + SubjectName;
// }
// public override bool Equals (object obj) {
//     if (obj == null) return false;
//     Subject objAsPart = obj as Subject;
//     if (objAsPart == null) return false;
//     else return Equals (objAsPart);
// }
// public override int GetHashCode () {
//     return Yearofdelivery;
// }
// public bool Equals (Subject other) {
//     if (other == null) return false;
//     return (this.Yearofdelivery.Equals (other.Yearofdelivery));
// }
// Should also override == and != operators.
// }
// public class Example {
//     public static void Main () {
//         // Create a list of listofsubjects.
//         List<Subject> listofsubjects = new List<Subject> ();

//         // Add listofsubjects to the list.
//         listofsubjects.Add (new Subject () { SubjectName = "English", Yearofdelivery = 1234 });
//         listofsubjects.Add (new Subject () { SubjectName = "Math", Yearofdelivery = 1334 });
//         listofsubjects.Add (new Subject () { SubjectName = "Science", Yearofdelivery = 1434 });

//         // Write out the listofsubjects in the list. This will call the overridden ToString method
//         // in the Subject class.
//         Console.WriteLine ();
//         foreach (Subject Part in listofsubjects) {
//             Console.WriteLine (Part);
//         }

//         // Check the list for Subject #1734. This calls the IEquatable.Equals method
//         // of the Subject class, which checks the Yearofdelivery for equality.
//         Console.WriteLine ("\nContains(\"1734\"): {0}",
//             listofsubjects.Contains (new Subject { Yearofdelivery = 1734, SubjectName = "" }));

//         // Insert a new item at position 2.
//         Console.WriteLine ("\nInsert(2, \"1834\")");
//         listofsubjects.Insert (2, new Subject () { SubjectName = "geometry", Yearofdelivery = 1834 });

//         //Console.WriteLine();
//         foreach (Subject Part in listofsubjects) {
//             Console.WriteLine (Part);
//         }

//         Console.WriteLine ("\nParts[3]: {0}", listofsubjects[3]);

//         Console.WriteLine ("\nRemove(\"1534\")");

//         // This will remove Subject 1534 even though the SubjectName is different,
//         // because the Equals method only checks Yearofdelivery for equality.
//         listofsubjects.Remove (new Subject () { Yearofdelivery = 1534, SubjectName = "cogs" });

//         Console.WriteLine ();
//         foreach (Subject aPart in listofsubjects) {
//             Console.WriteLine (aPart);
//         }
//         Console.WriteLine ("\nRemoveAt(3)");
//         // This will remove the Subject at index 3.
//         listofsubjects.RemoveAt (3);

//         Console.WriteLine ();
//         foreach (Subject aPart in listofsubjects) {
//             Console.WriteLine (aPart);
//         }