// Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class SumWithAccuracy
{
    static void Main()
    {
        double sum = 1d;
        for (int n = 2; n <= 1000; n++)
        {
            if (n % 2 == 0)
            {
                sum = sum + 1d / n;
            }
            else
            {
                sum = sum - 1d / n;
            }
        }
        Console.WriteLine(sum);
     }
}

