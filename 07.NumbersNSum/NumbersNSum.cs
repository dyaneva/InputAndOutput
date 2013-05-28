// Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;

class NumbersNSum
{
    static void Main()
    {
        int n;
        Console.Write("Enter a number n = ");
        while (int.TryParse(Console.ReadLine(), out n) && n<0)
        {
            Console.Write("Invalid input! Enter positive number! Please try again: ");
        }
        Console.WriteLine("Please enter more n numbers:");
        int sum = 0;
        for (int i = 0; i < n; i++)
        {            
            Console.Write("number = ");
            int number = int.Parse(Console.ReadLine());
            sum = sum + number;
        }
        Console.WriteLine("The sum of n numbers is: {0}", sum);
    }
}    

