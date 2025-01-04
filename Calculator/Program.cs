using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double myNumber1 = 0;
        double myNumber2 = 0;

        Console.WriteLine("Enter a number: ");
        myNumber1 = ParseInput();

        Console.WriteLine("Enter a second number: ");
        myNumber2 = ParseInput();

        Console.WriteLine($"{myNumber1} + {myNumber2} = {myNumber1 + myNumber2}");

    }
    public static double ParseInput()
    {
        double result = 0;
        bool isParsed = double.TryParse(Console.ReadLine(), out result);

        while (!isParsed)
        {
            Console.WriteLine("You entered invalid value. Enter a number!");
            isParsed = double.TryParse(Console.ReadLine(), CultureInfo.CurrentCulture, out result);
        }

        return result;
    }
}


