
/*
Reverse Right angle Triangle to right side pattern

Approach:
1. Take an integer input n from the user.
2. outer loop refer for shifting to the next line
3. 1st inner loop add preceding spaces (j<i) 
    e.g. when i=3
        j=0 => " "
        j=1 => "  "
        j=2 => "   "
        j=3 => "    "
4. 2nd inner loop print stars("*") => (k<n-i)
    e.g. when i=3
        k=0 => "*******
5. Print a new line after each row.

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

public class ReverseRightAngleTriangleToRightSide
{
    public static void Main(string[] args)
    {
        // 1. Take an integer input n from the user.
        System.Console.WriteLine("Enter a value n: ");
        int n = Convert.ToInt32(System.Console.ReadLine());

        //2. outer loop refer for shifting to the next line
        for (int i = 1; i < n; i++)
        {
            //3. 1st inner loop add preceding spaces (j<i)
            for (int j = 0; j < i; j++)
            {
                System.Console.Write(" ");
            }

            //4. 2nd inner loop print stars("*") => (k<n-i)
            for (int k = 0; k < n - i; k++)
            {
                System.Console.Write("*");
            }

            //5. Print a new line after each row.
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