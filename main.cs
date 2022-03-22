// Cristiano
// ICS2O-Assignment2-CSharp
// March 11 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        int length;
        int width;
        Console.WriteLine("The area of a triangle with a length of 5 and a width of 3 is:");
        Console.WriteLine((5 * 3) + "cm²");
        Console.WriteLine("Add the length of your triangle:");
        length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Add the width of your triangle:");
        width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your triangle's area is " + (length * width / 2) + "cm²");
        Console.WriteLine("\nFinished.");
    }
}
