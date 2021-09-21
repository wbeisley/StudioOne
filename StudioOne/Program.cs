using System;


namespace StudioOne {
    class Program {
        static void Main(string[] args) {

            while(true) {

                Console.WriteLine("Enter your radius: ");

                string input = Console.ReadLine();
                if(!double.TryParse(input, out double result)) {
                    // .. error with input
                    Environment.Exit(0);
                }

                Console.WriteLine(input.GetType());

                if(double.Parse(input) > 0) {



                    Circle circle = new Circle(double.Parse(input));

                    Console.WriteLine("How many miles per gallon in your vehicle? ");
                    input = Console.ReadLine();
                    double milesPerGallon = double.Parse(input);
                    double results = circle.getCircumference() / milesPerGallon;

                    Console.WriteLine($"Area of circle: {circle.getArea()}\nCircumference of circle: {circle.getCircumference()}\nDiameter of circle: {circle.getDiameter()}" +
                            $"\nIt takes {results} gallon of gas to go around the circle");

                }
                else {

                    Console.WriteLine("Please enter number greater than zero. :)");

                }
            }
        }
    }
}
