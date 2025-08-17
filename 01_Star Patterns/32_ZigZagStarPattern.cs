/*
 * ZigZag Star Pattern
 * This program prints a zigzag star pattern based on user input for the number of columns.
 * The pattern consists of 3 rows and is designed to work best with a number of columns that is a multiple of 4.


 Approach:
 1. Prompt the user for the number of columns.
 2. Use nested loops to iterate through rows and columns.
    3. Print stars based on specific conditions for each row.
    4. Print spaces where stars are not printed.
 5. Print each row after completing the inner loop for columns.
 
 
 E.g.: when row=0 and column = 21:

 *   *   *   *   *   *
  * * * * * * * * * * 
   *   *   *   *   *  

  
 */




using System;

public class ZigZagPattern
{
    public static void Main()
    {
        Console.Write("Enter number of columns (should be multiple of 4 for good pattern): ");
        int cols = Convert.ToInt32(Console.ReadLine());
        int rows = 3;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // Row 0: stars at j % 4 == 0 //when row =0 & J= 0, 4, 8, 12, 16 etc it will print stars on 1st row
                // Row 1: stars at j % 2 == 1 //when row = 1 & J= 1, 3, 5, 7, 9, 11 etc it will print stars on 2nd row
                // Row 2: stars at j % 4 == 2 //when row =2 & J= 2, 6, 10, 14, 18, 22  etc it will print stars on 3rd row
                if ((i == 0 && j % 4 == 0) || 
                    (i == 1 && j % 2 == 1) || 
                    (i == 2 && j % 4 == 2))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

/*
OUTPUT:
Enter number of columns (should be multiple of 4 for good pattern): 21
*   *   *   *   *   *
 * * * * * * * * * * 
  *   *   *   *   *  

  */