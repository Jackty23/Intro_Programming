using System;
using System.Collections.Generic;

namespace task2 {

    class Program {

        public static void Main (string[] args) {

            Subject Sub1 = new Subject ();
            Subject Sub2 = new Subject ("English", 2020);
            Subject Sub3 = new Subject ("Science", 2019);
            Subject Sub4 = new Subject ("P.E.", 2018);

            List<Subject> SubjectList1 = new List<Subject> ();
            SubjectList1.Add (Sub1);
            SubjectList1.Add (Sub2);
            SubjectList1.Add (Sub3);

            List<Subject> SubjectList2 = new List<Subject> ();
            SubjectList2.Add (Sub1);
            SubjectList2.Add (Sub4);

            Person p1 = new Person ();

            Person p2 = new Person ("Jason", "Momoa", "1984/08/30", 193, 4128, SubjectList1);

            Person p3 = new Person ();
            p3.Firstname = "Chopper";
            p3.Surname = "Read";
            p3.DOB = "1966/01/02";
            p3.Height = 188;
            p3.SubjectList = SubjectList2;

            // p1.PrintAllInfo ();
            p1.GetFullName ();
            if (p1.Height > p2.Height) {
                Console.WriteLine ("I am " + (p1.Height - p2.Height) + "cm's taller than " + p2.Firstname + ",");
            } else {
                Console.WriteLine ("I am " + (p2.Height - p1.Height) + "cm's shorter than " + p2.Firstname + ",");
            }
            if (p1.Height > p3.Height) {
                Console.WriteLine ("and I am " + (p1.Height - p3.Height) + "cm's taller than " + p3.Firstname);
            } else {
                Console.WriteLine ("and I am " + (p3.Height - p1.Height) + "cm's shorter than " + p3.Firstname);
            }
            // p1.PrintSubjects ();
            p1.Addnewsubject (Sub1);

            // p2.PrintAllInfo ();
            p2.GetFullName ();
            if (p2.Height > p1.Height) {
                Console.WriteLine ("I am " + (p2.Height - p1.Height) + "cm's taller than " + p1.Firstname + ",");
            } else {
                Console.WriteLine ("I am " + (p1.Height - p2.Height) + "cm's shorter than " + p1.Firstname + ",");
            }
            if (p2.Height > p3.Height) {
                Console.WriteLine ("and I am " + (p2.Height - p3.Height) + "cm's taller than " + p3.Firstname);
            } else {
                Console.WriteLine ("and I am " + (p3.Height - p2.Height) + "cm's shorter than " + p3.Firstname);
            }
            p2.PrintSubjects ();

            // p3.PrintAllInfo ();
            p3.GetFullName ();
            if (p3.Height > p1.Height) {
                Console.WriteLine ("I am " + (p3.Height - p1.Height) + "cm's taller than " + p1.Firstname + ",");
            } else {
                Console.WriteLine ("I am " + (p1.Height - p3.Height) + "cm's shorter than " + p1.Firstname + ",");
            }
            if (p3.Height > p2.Height) {
                Console.WriteLine ("and I am " + (p3.Height - p2.Height) + "cm's taller than " + p2.Firstname);
            } else {
                Console.WriteLine ("and I am " + (p2.Height - p3.Height) + "cm's shorter than " + p2.Firstname);
            }
            // p3.PrintSubjects ();
            p3.Addnewsubject (Sub2);

        }

        public class Subject {
            public string SubName;
            public int YearOfDelivery;

            public Subject (string _SubName, int _YearOfDelivery) {
                this.SubName = _SubName;
                this.YearOfDelivery = _YearOfDelivery;
            }
            public Subject () {
                this.SubName = "Maths";
                this.YearOfDelivery = 2021;
            }
        }

        public class Person {

            //class variables 
            public string Firstname;
            public string Surname;
            public string DOB;
            public int Height;
            static Random rand = new Random ();
            public int ID;
            public List<Subject> SubjectList;
            // public string input1;

            // class constructor
            public Person () {
                this.Firstname = "Jack";
                this.Surname = "Black";
                this.DOB = "1980/07/23";
                this.Height = 168;
                this.ID = rand.Next (1000, 9999);
                this.SubjectList = new List<Subject> ();
            }

            //custom constructor
            public Person (string _Firstname, string _Surname, string _DOB, int _Height, int _ID, List<Subject> _Subjects) {
                this.Firstname = _Firstname;
                this.Surname = _Surname;
                this.DOB = _DOB;
                this.Height = _Height;
                this.ID = _ID;
                this.SubjectList = _Subjects;
            }

            //class methods

            public void PrintAllInfo () {
                System.Console.WriteLine ();
                Console.WriteLine ("Firstname: " + Firstname);
                Console.WriteLine ("Surname: " + Surname);
                Console.WriteLine ("DOB: " + DOB);
                Console.WriteLine ("Height: " + Height + " cms");
                Console.WriteLine ("ID: " + ID);
            }

            public void GetFullName () {
                System.Console.WriteLine ();
                Console.WriteLine ("My name is " + Firstname + " " + Surname);
            }

            public void PrintSubjects () {
                foreach (Subject item in SubjectList) {
                    Console.WriteLine ("I'm enrolled in " + item.SubName + " in the year " + item.YearOfDelivery);
                }
            }

            public void Addnewsubject (Subject Addnewsubject) {

                this.SubjectList.Add (Addnewsubject);

                Console.WriteLine ("I have recently enrolled in new subjects, so my new enrolment list is:");
                foreach (Subject item in SubjectList) {
                    Console.WriteLine (item.SubName + " in the year " + item.YearOfDelivery);

                }

            }

        }
    }
}