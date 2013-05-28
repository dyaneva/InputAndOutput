// Write a program to print the first 100 members of the sequence of Fibonacci: 
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class SequenceFibonacci
{
    static void Main()
    {
        ulong number1 = 0;
        ulong number2 = 1;
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(number1);
            ulong sum = number1 + number2;
            number1 = number2;
            number2 = sum;
        }                      
    }
}
