using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of inches: ");
        double inches = Convert.ToDouble(Console.ReadLine());
        double centimeters = inches * 2.54;
        Console.WriteLine("{0} inches is equal to {1} centimeters.", inches, centimeters);
    }
}
