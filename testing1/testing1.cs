using System;

namespace testing1 {
    class Program {
        static void Main (string[] args) {

            int count = 0;
            int prime = 0;
            int inputnum = 0;
            int punctuation = 0;

            System.Console.WriteLine ("Input a number:");

            inputnum = int.Parse (System.Console.ReadLine ());

            count = 2;

            while (count < inputnum + 1) {

                prime = 0;

                if (count == 1) {
                    prime = 1;
                } else {

                    for (int i = 2; i < count; i++) {
                        if (count % i == 0) {
                            prime = 1;
                        }
                    } ///forloop

                }

                if (prime == 0) {
                    if (punctuation == 1) {
                        System.Console.Write (", " + count);
                    }else{
                        System.Console.Write (count);
                        punctuation = 1;
                    }
                }

                count++;

            } ///while
            System.Console.Write (".");
        }
    }
}