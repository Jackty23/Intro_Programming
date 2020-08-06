using System;
using System.Collections.Generic;

namespace Bee_Keeping {
    class Program {
        static void Main (string[] args) {

            Bee Bee1 = new Bee ("John", 3.2f);
            Bee Bee2 = new Bee ("Paul", 2.7f);
            Bee Bee3 = new Bee ("George", 1.1f);
            Bee Bee4 = new Bee ("Ringo", 2.0f);
            Bee Bee5 = new Bee ("Kurt", 2.3f);
            Bee Bee6 = new Bee ("Dave", 7.4f);
            Bee Bee7 = new Bee ("Krist", 1.5f);

            BeeHive BeeHive1 = new BeeHive (1, 4);
            BeeHive1.AddBee (Bee1);
            BeeHive1.AddBee (Bee2);
            BeeHive1.AddBee (Bee3);
            BeeHive1.AddBee (Bee4);

            BeeHive BeeHive2 = new BeeHive (2, 3);
            BeeHive2.AddBee (Bee5);
            BeeHive2.AddBee (Bee6);
            BeeHive2.AddBee (Bee7);

            BeeHive1.PrintList ();
            BeeHive1.CollectHoney (10);

            BeeHive2.PrintList ();
            BeeHive2.CollectHoney (0);
        }

    }
}