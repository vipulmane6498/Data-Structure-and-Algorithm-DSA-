/*
Heart Shape Star Pattern:

Approach:
🧠 Concept Overview
    The pattern is divided into two main parts:
    Top part (two bumps of the heart)
    Bottom part (inverted triangle)

1️⃣ Top Part (Two Half-Circles)
    Loop: for (int i = 0; i < mid; i++)
    You divide the top of the heart into two symmetrical parts (left & right).
    mid = n / 2 is used to define the middle (i.e., where the heart splits into two bumps).
For each line:
    Print spaces for left alignment: for (int j = 0; j < mid - i; j++)
    Print stars on the left bump: for (int k = 0; k < i; k++)
    Print spaces between the two bumps: for (int j = 0; j < size - i; j++)
    Print stars on the right bump: for (int k = 0; k < i; k++)
    This gives the appearance of two star-filled arcs side-by-side.

2️⃣ Bottom Part (V-shape or Inverted Triangle)
Loop: for (int i = n - 1; i >= 0; i--)
For each line:
    Print increasing spaces: for (int j = 0; j < n - i - 1; j++)
    Print decreasing stars: for (int k = 0; k < i; k++)
    This creates a V-shaped base forming the lower part of the heart.
✅ Summary
    Top half: Two arcs (left & right) drawn using stars with a gap in between.
    Bottom half: An inverted triangle that connects smoothly under the arcs.

    E.g.: n=10

    *       * 
   * *     * * 
  * * *   * * * 
 * * * * * * * * 
* * * * * * * * * 
 * * * * * * * * 
  * * * * * * * 
   * * * * * * 
    * * * * * 
     * * * * 
      * * * 
       * * 
        * 

*/


using System;

public class HeartShapeStarPattern
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine()); //rows=10

        int mid = n / 2;

        for (int i = 0; i < mid; i++)
        {
            //left part
            for (int j = 0; j < mid - i; j++)
            {
                System.Console.Write(" ");
            }
            for (int k = 0; k < i; k++)
            {
                System.Console.Write("* ");
            }

            //right part
            int size = n - i - 2;
            for (int j = 0; j < size - i; j++)
            {
                System.Console.Write(" ");
            }
            for (int k = 0; k < i; k++)
            {
                System.Console.Write("* ");
            }
            System.Console.WriteLine();
        }


        //heart tail (inverted triangle)
        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                System.Console.Write(" ");
            }
            for (int k = 0; k < i; k++)
            {
                System.Console.Write("* ");
            }
            System.Console.WriteLine();
        }
    }
}
/*

Enter number of rows: 10

             
    *       * 
   * *     * * 
  * * *   * * * 
 * * * * * * * * 
* * * * * * * * * 
 * * * * * * * * 
  * * * * * * * 
   * * * * * * 
    * * * * * 
     * * * * 
      * * * 
       * * 
        * 

*/