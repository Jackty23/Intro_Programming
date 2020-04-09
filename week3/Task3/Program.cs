using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the magic number, it's 5!");

int magicnumber = 5;
int guess = 0;

while(guess != magicnumber){

Console.WriteLine("take a guess...");
guess = int.Parse (Console.ReadLine ());

}

Console.WriteLine("You've got it.");

        }
    }
}
