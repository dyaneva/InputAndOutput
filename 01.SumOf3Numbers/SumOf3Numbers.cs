// Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 3 numbers: ");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());       
        
        Console.WriteLine("The sum of these numbers is: {0}", (a + b + c));
    }
}    

