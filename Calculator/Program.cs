using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        double myNumber1;
        double myNumber2;

        Console.WriteLine("Enter a number: ");
        myNumber1 = ReadAndParseInput();

        Console.WriteLine("Enter a second number: ");
        myNumber2 = ReadAndParseInput();

        Console.WriteLine($"{myNumber1} + {myNumber2} = {myNumber1 + myNumber2}");

    }
    public static double ReadAndParseInput()
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


