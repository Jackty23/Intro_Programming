using System;
using System.Collections.Generic;

namespace LectureExamples {
    class Program {
        public static void Main (string[] args) {

            // instantiation -> create default object from car class
            Car car1 = new Car ();

            Car car2 = new Car ("Straight 6", 15, "Black", "Sedan", 10);

            System.Console.WriteLine ("h");
        }
    }

    public class Car {
        // attributes / variables
        public string Motor;
        public int AmountOfWheels;
        public string Colour;
        public string BodyType;
        public int CurrentSpeedKmh;

        // constructors
        public Car () {
            this.Motor = "";
            this.AmountOfWheels = 0;
            this.Colour = "White";
            this.BodyType = "";
            this.CurrentSpeedKmh = 0;
        }

        public Car (string motor, int amountOfWheels, string colour, string bodyType, int currentSpeedKmh) {
            this.Motor = motor;
            this.AmountOfWheels = amountOfWheels;
            this.Colour = colour;
            this.BodyType = bodyType;
            this.CurrentSpeedKmh = currentSpeedKmh;
        }

        // methods / functions / operations
        public void Honk () {
            System.Console.WriteLine ("Honk");
        }

        public void HonkAtBadDrivers (string badDriverRego, string choiceWords) {
            System.Console.WriteLine ("HONK HONK " + choiceWords + " at " + badDriverRego);
        }

        public void SetNewSpeed (int newSpeed) {
            this.CurrentSpeedKmh = newSpeed;
        }

    }

}