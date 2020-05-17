﻿// using System;
// using System.Collections.Generic;

// namespace task2 {

//     class Program {

//         public static void Main (string[] args) {

using System;
using System.Collections.Generic;
// Simple business object. A Yearofdelivery is used to identify the type of Subject
// but the Subject name can change.
public class Subject{
//  : IEquatable<Subject> {
    public string SubjectName { get; set; }

    public int Yearofdelivery { get; set; }

    public override string ToString () {
        return "ID: " + Yearofdelivery + "   Name: " + SubjectName;
    }
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
}
public class Example {
    public static void Main () {
        // Create a list of listofsubjects.
        List<Subject> listofsubjects = new List<Subject> ();

        // Add listofsubjects to the list.
        listofsubjects.Add (new Subject () { SubjectName = "English", Yearofdelivery = 1234 });
        listofsubjects.Add (new Subject () { SubjectName = "Math", Yearofdelivery = 1334 });
        listofsubjects.Add (new Subject () { SubjectName = "Science", Yearofdelivery = 1434 });

        // Write out the listofsubjects in the list. This will call the overridden ToString method
        // in the Subject class.
        Console.WriteLine ();
        foreach (Subject Part in listofsubjects) {
            Console.WriteLine (Part);
        }

        // Check the list for Subject #1734. This calls the IEquatable.Equals method
        // of the Subject class, which checks the Yearofdelivery for equality.
        Console.WriteLine ("\nContains(\"1734\"): {0}",
            listofsubjects.Contains (new Subject { Yearofdelivery = 1734, SubjectName = "" }));

        // Insert a new item at position 2.
        Console.WriteLine ("\nInsert(2, \"1834\")");
        listofsubjects.Insert (2, new Subject () { SubjectName = "geometry", Yearofdelivery = 1834 });

        //Console.WriteLine();
        foreach (Subject Part in listofsubjects) {
            Console.WriteLine (Part);
        }

        Console.WriteLine ("\nParts[3]: {0}", listofsubjects[3]);

        Console.WriteLine ("\nRemove(\"1534\")");

        // This will remove Subject 1534 even though the SubjectName is different,
        // because the Equals method only checks Yearofdelivery for equality.
        listofsubjects.Remove (new Subject () { Yearofdelivery = 1534, SubjectName = "cogs" });

        Console.WriteLine ();
        foreach (Subject aPart in listofsubjects) {
            Console.WriteLine (aPart);
        }
        Console.WriteLine ("\nRemoveAt(3)");
        // This will remove the Subject at index 3.
        listofsubjects.RemoveAt (3);

        Console.WriteLine ();
        foreach (Subject aPart in listofsubjects) {
            Console.WriteLine (aPart);
        }

        /*

             ID: 1234   Name: crank arm
             ID: 1334   Name: chain ring
             ID: 1434   Name: regular seat
             ID: 1444   Name: banana seat
             ID: 1534   Name: cassette
             ID: 1634   Name: shift lever

             Contains("1734"): False

             Insert(2, "1834")
             ID: 1234   Name: crank arm
             ID: 1334   Name: chain ring
             ID: 1834   Name: brake lever
             ID: 1434   Name: regular seat
             ID: 1444   Name: banana seat
             ID: 1534   Name: cassette
             ID: 1634   Name: shift lever

             listofsubjects[3]: ID: 1434   Name: regular seat

             Remove("1534")

             ID: 1234   Name: crank arm
             ID: 1334   Name: chain ring
             ID: 1834   Name: brake lever
             ID: 1434   Name: regular seat
             ID: 1444   Name: banana seat
             ID: 1634   Name: shift lever

             RemoveAt(3)

             ID: 1234   Name: crank arm
             ID: 1334   Name: chain ring
             ID: 1834   Name: brake lever
             ID: 1444   Name: banana seat
             ID: 1634   Name: shift lever


         */
    }
}