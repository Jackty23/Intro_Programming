using System;

namespace tetsting {
    class Program {
        static void Main (string[] args) {

            // System.Console.WriteLine ();
            //             System.Console.WriteLine ("$");
            //             var var = "World";
            //             Console.WriteLine ("Hello " + var);
            //             Console.WriteLine ("the dollarsign $ will make the following work - $How are you, {var}?");
            //             Console.WriteLine ($"How are you, {var}?");

            //             System.Console.WriteLine ();
            //             System.Console.WriteLine ("trim");
            //             var trimthis = "     This   is  a sentence   with   spaces     ";
            //             System.Console.WriteLine (trimthis);
            //             string trimmed = trimthis.Trim ();
            //             System.Console.WriteLine (trimmed);

            // System.Console.WriteLine ();
            //             System.Console.WriteLine ("replace");
            //             var trimthis = "     This   is  a sentence   with   spaces     ";
            //             System.Console.WriteLine (trimthis);
            //             string trimmed = trimthis.Replace ();
            //             System.Console.WriteLine (trimmed);

            int height = 1000;
            int width = 40;
            string ground = "X";
            string road = ".";
            int lastdeviation = 0;
            int dottedline = 1;

            Random randomno = new Random ();

            int RandomNumber = randomno.Next (1, width);

            for (int a = 0; a < height; a++) {

                for (int i = 0; i < RandomNumber; i++) {
                    System.Console.Write (ground);
                }
                for (int i = 0; i < 4; i++) {
                    System.Console.Write (road);
                }
                if (dottedline == 0) {
                    System.Console.Write ("[]");
                    dottedline = 1;
                } else if (dottedline == 1) {
                    System.Console.Write ("..");
                    dottedline = 0;
                }
                for (int i = 0; i < 4; i++) {
                    System.Console.Write (road);
                }
                for (int i = 0; i < (width - RandomNumber); i++) {
                    System.Console.Write (ground);
                }

                System.Console.WriteLine ();

                int deviation = randomno.Next (1, 5);

                switch (deviation) {
                    case 1:
                        if (RandomNumber <= 2 || lastdeviation == 2) {
                            //no change
                        } else {
                            RandomNumber--;
                        }
                        lastdeviation = 1;
                        break;

                    case 2:
                        if (RandomNumber >= (width - 2) || lastdeviation == 1) {
                            //no change
                        } else {
                            RandomNumber++;
                        }
                        lastdeviation = 2;
                        break;

                    default:
                        lastdeviation = 0;
                        //no change

                        break;

                }
            }
            //end
        }
    }
}