// Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 
// and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficients a, b and c of a quadratic equation ax2+bx+c=0");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        if (a != 0)
        {
            double D=b*b-(4*a*c);
            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D))/(2*a);
                double x2 = (-b - Math.Sqrt(D))/(2*a);                
                Console.WriteLine("D>0, the quadratic equation has two real roots x1 = {0} and x2 = {1}", x1, x2);
            }
            else if (D == 0)
            {
                double x = -b / 2 * a;
                Console.WriteLine("D=0, the quadratic equation ax2+bx+c=0 has one real root x = {0}", x);            
            }
            else if (D < 0)
            {
                Console.WriteLine("D<0, the quadratic equation ax2+bx+c=0 has no real roots");
            }
        }
        else
        {
            Console.WriteLine("a=0, this is not quadratic equation!");
        }
    }

}
