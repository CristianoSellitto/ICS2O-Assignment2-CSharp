// Cristiano
// ICS2O-Assignment2-CSharp
// March 11 2022

using System;

class Program
{
    public static void Main(string[] args)
    {
        int basetriangle;
        int heighttriangle;
        Console.WriteLine("The area of a triangle with a base of 5 and a height of 4 is:");
        Console.WriteLine((5 * 4 / 2) + "cm²");
        Console.WriteLine("Add the base of your triangle:");
        basetriangle = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Add the height of your triangle:");
        heighttriangle = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your triangle's area is " + (basetriangle * heighttriangle / 2) + "cm²");
        Console.WriteLine("\nFinished.");
    }
}
