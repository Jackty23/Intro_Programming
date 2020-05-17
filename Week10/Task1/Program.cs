using System;

namespace week10 {

    class Program {

        static void Main (string[] args) {

            Cookie cook1 = new Cookie ();
            Cookie.Colour col1 = new Cookie.Colour ();
            cook1.CPrint ();
            col1.RPrint ();

            var cook2 = new Cookie ("Square", 20);
            var col2 = new Cookie.Colour ("Yellow", 255, 255, 0);
            cook2.CPrint ();
            col2.RPrint ();

            Cookie cook3 = new Cookie ("Spherical", 60);
            Cookie.Colour col3 = new Cookie.Colour ("Yellow", 255, 255, 0);
            cook3.CPrint ();
            col3.RPrint ();

            var cook4 = new Cookie ("Man-shaped", 40);
            var col4 = new Cookie.Colour ();
            cook4.CPrint ();
            col4.RPrint ();

        }
    }
    public class Cookie {

        //class variables 
        public string Shape;
        public int Weight;

        // class constructor
        public Cookie () {
            Shape = "Round";
            Weight = 10;
        }

        //custom constructor
        public Cookie (string Cshape, int CWeight) {
            Shape = Cshape;
            Weight = CWeight;
        }

        //class methods
        public void CPrint () {
            Console.WriteLine ("Shape: " + Shape);
            Console.WriteLine ("Weight: " + Weight + " grams");
            
        }

        public class Colour {

            //class variables 
            public string Name;
            public int R;
            public int G;
            public int B;

            // class constructor
            public Colour () {
                Name = "Red";
                R = 255;
                G = 0;
                B = 0;
            }

            //custom constructor
            public Colour (string colname, int colR, int colG, int colB) {
                Name = colname;
                R = colR;
                G = colG;
                B = colB;
            }

            //class methods
            public void RPrint () {
                Console.WriteLine ("colour: " + Name);
                Console.WriteLine ("RGB Value: R:" + R + " G:" + G + " B:" + B);
                System.Console.WriteLine ();
            }
        }
    }
}