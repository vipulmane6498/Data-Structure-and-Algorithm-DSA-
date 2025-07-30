/*
Hollow Right Angle Triangle to Left Side

Approach:
1. Get the number of rows from the user.
2. Outer loop iterates through each row.
3. The first inner loop checks if the current position is at the left edge (j==0), at the bottom edge (i == n-1), or on the diagonal (i == j). If any of these conditions are true, it prints a star; otherwise, it prints a space.
4. Print a new line after each row to form the hollow right angle triangle to the left side.
E.g. n=10
*         
**        
* *       
*  *      
*   *     
*    *    
*     *   
*      *  
*       * 
**********

*/

using System;

public class HollowRightAngleTriangleToLeftSide
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0 || i == n - 1 || i == j)
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
*         
**        
* *       
*  *      
*   *     
*    *    
*     *   
*      *  
*       * 
**********


*/