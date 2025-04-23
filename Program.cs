using System;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fname = "Ynno";
            string lname = "Plucena";
            string location = "Philippines";
            Console.WriteLine($"My name is {fname} {lname}");
            Console.WriteLine($"I am from {location}");


            DateTime currentDate = DateTime.Now;

            Console.WriteLine($"Current date: {currentDate.ToString("MM/dd/yyyy")}");
            
            DateTime christmas = new DateTime(currentDate.Year, 12, 25);
            TimeSpan daysUntilChristmas = christmas - currentDate;
            Console.WriteLine($"Number of days until Christmas: {daysUntilChristmas.Days}");


            // C# Program in Yellow Book
            Console.WriteLine("\n- WINDOW AREA CALCULATOR -");
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            
            Console.Write("\nEnter the width of the window: ");
            widthString =  Console.ReadLine();
            width = double.Parse(widthString);
            
            Console.Write("Enter the height of the window: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);


            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            
            Console.WriteLine("\nThe length of the wood is " +
            woodLength + " feet");

            Console.WriteLine("\nThe area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
