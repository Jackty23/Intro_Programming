
using System;

namespace Programusernameandpass {
    class Program {
        static void Main (string[] args) {
            string sysUsername = "bob";
            string sysPassword = "password";

            string username;
            string password;

            System.Console.WriteLine ("Please enter your username");
            username = Console.ReadLine ();

            if (username == sysUsername) {
                System.Console.WriteLine ("Please enter your password");
                password = Console.ReadLine ();

                if (password == sysPassword) {
                    System.Console.WriteLine ("Login Successful");
                } else {
                    System.Console.WriteLine ("Login Unsuccessful");
                }
            }
        }

    }
}
