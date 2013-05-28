// Write a program that gets two numbers from the console and prints the greater of them. 
// Don’t use if statements.

using System;

class GreaterNumber
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("The greater of these two number is: {0}", Math.Max(firstNumber, secondNumber));
    }
}   

