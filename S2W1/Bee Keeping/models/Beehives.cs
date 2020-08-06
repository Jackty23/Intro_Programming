using System.Collections.Generic;

namespace Bee_Keeping {

    public class BeeHive {

        // attributes
        public List<Bee> BeesList;
        public int MaxAmountBees;
        public int BeeHiveNumber = 0;

        // default constructor
        public BeeHive () {
            this.BeeHiveNumber = 1;
            this.MaxAmountBees = 4;
            this.BeesList = new List<Bee> ();
        }

        // custom constructor
        public BeeHive (int _BeeHiveNumber, int _MaxAmountBees) {
            this.BeeHiveNumber = _BeeHiveNumber;
            this.MaxAmountBees = _MaxAmountBees;
            this.BeesList = new List<Bee> ();
        }

        //methods
        public void AddBee (Bee newBee) {
            this.BeesList.Add (newBee);
        }

        public void PrintList () {

            System.Console.WriteLine ("===========================");
            System.Console.WriteLine ($"BeeHive {this.BeeHiveNumber} has {this.BeesList.Count}/{this.MaxAmountBees} little bees");
            System.Console.WriteLine ("===========================");

            foreach (var b in this.BeesList) {
                System.Console.WriteLine ($"{b.Name} is size {b.Size}");
            }
            System.Console.WriteLine ("===========================");
        }
        
        public void CollectHoney (int _days) {

            int days = _days;
            float total = 0;

//if no value for days input then...
// try to find out a better way of doing this than using 0

            if (days == 0) {
                System.Console.Write ("how many days would you like to wait to collect the honey? ");
                days = int.Parse (System.Console.ReadLine ());
            }

            foreach (Bee b in this.BeesList) {
                float Amount = days * b.Size * 0.2f;
                total += Amount;
            }

            System.Console.WriteLine ($"BeeHive {this.BeeHiveNumber} produced {total}mg of honey in {days} days");
            System.Console.WriteLine ("===========================");
            System.Console.WriteLine ();
        }

    }
}