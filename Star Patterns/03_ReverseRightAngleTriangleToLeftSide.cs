/*
Reverse Right Angle Triangle To Left Side
 
Approach:
1. Take an integer input n from the user.
2. outer loop refer for shifting to the next line
3. 1st inner loop print stars("*") => (k<n-i)
   e.g. when i=3
       k=0 => "*****"
       k=1 => "****"
       k=2 => "***"
       k=3 => "**"
       k=4 => "*"
4. Print a new line after each row.
E.g. for n=10
    
    *********
    ********
    *******
    ******
    *****
    ****
    ***
    **
    *

*/
using System;

public class ReverseRightAngleTriangleToLeftSide
{
    public static void Main(string[] args)
    {
        // 1. Take an integer input n from the user.
        System.Console.WriteLine("Enter a value n: ");
        int n = Convert.ToInt32(System.Console.ReadLine());


        // 2. outer loop refer for shifting to the next line
        for (int i = 1; i < n; i++)
        {


            // 3. 1st inner loop print stars("*") => (k<n-i)
            for (int k = 0; k < n - i; k++)
            {
                System.Console.Write("*");
            }
            // 4. Print a new line after each row.
            System.Console.WriteLine();
        }
    }
}

/*
OUTPUT: 
Enter a value n:
10
*********
********    
*******
******
*****
****
***
**
*

*/





























