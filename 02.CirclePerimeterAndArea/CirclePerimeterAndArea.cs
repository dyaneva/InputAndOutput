// Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        double r;
        Console.Write("Enter the radius r = ");
        while (double.TryParse(Console.ReadLine(), out r) && r < 0)
        {
            Console.Write("Invalid input! Enter positive number! Please enter again: ");
        }
        Console.WriteLine("The perimeter of a circle is: {0}", 2 * Math.PI * r);
        Console.WriteLine("The area of a circle is: {0:F2}", Math.PI * r * r);
    }
}    

