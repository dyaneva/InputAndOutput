// Write a program that reads an integer number n from the console and 
// prints all the numbers in the interval [1..n], each on a single line.

using System;

class PrintNumbers
{
    static void Main()
    {
        int n;
        Console.Write("Enter a number n = ");
        while (int.TryParse(Console.ReadLine(), out n) && n < 0)
        {
            Console.Write("Invalid input! Enter positive number! Please try again: ");
        }
        for (int number = 1; number <= n; number++)
        {
            Console.WriteLine(number);            
        }       
    }
}    

