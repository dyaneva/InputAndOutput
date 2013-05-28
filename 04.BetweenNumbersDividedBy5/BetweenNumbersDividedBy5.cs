// Write a program that reads two positive integer numbers and prints how many numbers p exist between them 
// such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.


using System;

class BetweenNumbersDividedBy5
{
    static void Main()
    {
        Console.WriteLine("Enter two positive integer numbers:");
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int numberMin = Math.Min(firstNumber, secondNumber);
        int numberMax = Math.Max(firstNumber, secondNumber);
        int p = 0;
        for (int dividedBy5 = numberMin; dividedBy5 <= numberMax; dividedBy5++)
        {
            if (dividedBy5 % 5 == 0)
            {
                p++;
            }
        }
        Console.WriteLine("p({0},{1}) = {2}", numberMin, numberMax, p);
    }
}    

