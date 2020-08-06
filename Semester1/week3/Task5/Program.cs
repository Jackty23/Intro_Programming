using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What happens when you throw a yellow rock into the red sea?");

string correctanswer = "it gets wet";
string guess = "noguess";

while(correctanswer != guess){

Console.WriteLine("take a guess...");
guess = (Console.ReadLine ());

}

Console.WriteLine("You've got it.");

        }
    }
}
