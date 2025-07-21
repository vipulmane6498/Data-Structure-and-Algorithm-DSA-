
/*
CrossMark

Approach:
1. Get the number of rows from the user.
2. First outer loop iterates through each row.
3. The first inner loop checks if the current position on the diagonals satisfy the following cindtion => (i == j or i + j == n - 1) then prints a star; otherwise, it prints a space.
4. Print a new line after each row to form the box with a cross inside it.

E.g. n=10
 *      * 
  *    *  
   *  *   
    **    
    **    
   *  *   
  *    *  
 *      * 
*        *

*/


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number of rows: ");
        int n = Convert.ToInt32(System.Console.ReadLine());

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                //Iterations for Cross(i==j || i+j=n-1)->
                //1. i==j
                //When we say i==j means we are on the main diagonal of the box, so we print a star. e.g. it will print star when i=0 and j=0, i=1 and j=1, i=2 and j=2, so on till the last row.

                //2. i+j==n-1 
                //i+j==n-1 means we are on the anti-diagonal of the box, so we print a star. e.g. it will print star when i=0 and j=9, i=1 and j=8, i=2 and j=7, so on till the last row. 
                // e.g. we used condition i+j=n-1  
                // 1st part i+j ==>when i=2 and when j=7 ==> i+j=2+7=9, and 
                // 2nd part n-1 => n=10 so n-1 => 10-1=9 
                // last => from i+j=9 and n-1=9 => 9=9 condition satisfy at position when j=7 hence star will print at j=7 column and so on for other rows.
                if (i == j || i + j == n - 1)
                {
                    System.Console.Write("*");
                }
                else
                {
                    System.Console.Write(" "); //print space if the condition is not satisfied
                }
            }
            System.Console.WriteLine();
        }
    }
}

/*
Output:
Enter number of rows:
10
 *      * 
  *    *  
   *  *   
    **    
    **    
   *  *   
  *    *  
 *      *


*/