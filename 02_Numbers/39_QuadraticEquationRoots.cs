/*
level : easy

Quadratic Equation root: we have to find the the roots of Quadratic Equation 

We have a formula to find out roots of given Quadratic equation:
    (Sqaure(b)+-SquareRoot(b*b-4*a*c))/2*a
    1. To find out root1 use following= (Sqaure(b)+SquareRoot(b*b-4*a*c))/2*a
    2. To find out root2 use following= (Sqaure(b)-SquareRoot(b*b-4*a*c))/2*a

Approach:
1. Find output of:    b * b - 4 * a * c  and store in a variable e.g. discriminant  so that further you can use.
2. Check if a is 0 return Not a quadratic equation (a cannot be 0).
3. If discriminant > 0 means you can use this discriminant to find root1 and root2
    3.1 use following formula to find root1: (Sqaure(b)+SquareRoot(b*b-4*a*c))/2*a
    3.2 use following formula to find root1: (Sqaure(b)-SquareRoot(b*b-4*a*c))/2*a
4. If discriminant == 0 means there is no use of discriminant so root1 and root2 will be same
    4.1. just find root using following formula: -b / (2 * a)
*/


using System;

public class QuadraticEquationRoots
{
    public static void Main(string[] args)
    {
        // Example input
        Console.WriteLine("Enter coefficients a, b and c:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        // Discriminant (b^2 - 4ac)
        double discriminant = b * b - 4 * a * c;

        //if a==0 because you are unabel to divide 0 zero to Discriminant
        if (a == 0)
        {
            Console.WriteLine("Not a quadratic equation (a cannot be 0).");
        }
        else if (discriminant > 0) 
        {
            // Two distinct real roots
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Roots are real and different:");
            Console.WriteLine("Root1 = " + root1);
            Console.WriteLine("Root2 = " + root2);
        }
        else if (discriminant == 0) //then the there is no use of discriminant and root1 and root 2 will be same hence we are return only root 1
        {
            // One real root (equal roots)
            double root = -b / (2 * a);
            Console.WriteLine("Roots are real and same:");
            Console.WriteLine("Root1 = Root2 = " + root);
        }
        else
        {
            // Complex (imaginary) roots
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine("Roots are complex and different:");
            Console.WriteLine("Root1 = " + realPart + " + " + imaginaryPart + "i");
            Console.WriteLine("Root2 = " + realPart + " - " + imaginaryPart + "i");
        }
    }
}
/*
OUTPUT

Enter coefficients a, b and c:
1
-3
2
Roots are real and different:
Root1 = 2
Root2 = 1

*/