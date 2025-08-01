/*
Hollow Reverse Right Angle Triangle to Left Side

Approach:
1. Get the number of rows from the user.    
2. Outer loop iterates through each row.
3. The first inner loop checks if the current position is at the top edge (i == 0), on the diagonal (i + j == n - 1), or at the left edge (j == 0). If any of these conditions are true, it prints a star; otherwise, it prints a space.
4. Print a new line after each row to form the hollow reverse right angle triangle to the left side.

E.g. n=10

**********
*       * 
*      *  
*     *   
*    *    
*   *     
*  *      
* *       
**        
*         

*/

using System;

public class HollowReverseRightAngleTriangleToLeftSide
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < n; j++)
            {
                if (i == 0 || i + j == n - 1 || j == 0)
                {
                    System.Console.Write("*");
                }
                else
                {
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }
    }
}

/*

OUTPUT:

Enter number of rows: 10
**********
*       * 
*      *  
*     *   
*    *    
*   *     
*  *      
* *       
**        
*   

*/