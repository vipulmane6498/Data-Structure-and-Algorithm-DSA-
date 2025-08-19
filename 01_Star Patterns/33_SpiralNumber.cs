
/*
Spiral Number Star Pattern in C#
This program generates a spiral pattern of numbers in a 2D array and prints it.


Approach:
1. Initialize matrix with the desired number of rows and columns.
2. Define boundaries: top, bottom, left, and right to keep track of the spiral limits.
3. Initialize counter num to start filling the matrix from 1.
4. Start a loop that continues as long as top <= bottom and left <= right.
5. Traverse from Left to Right along the top row, then increment top boundary.
6. Traverse from Top to Bottom along the right column, then decrement right boundary.
7. If rows remain, traverse from Right to Left along the bottom row, then decrement bottom boundary.
8. If columns remain, traverse from Bottom to Top along the left column, then increment left boundary.
9. Repeat steps 5–8 until the entire matrix is filled.
10. Print the matrix row by row to display the spiral pattern.

E.g. if row=5 and cols=5, the output will be:

   1   2   3   4   5
  16  17  18  19   6
  15  24  25  20   7
  14  23  22  21   8
  13  12  11  10   9


*/


using System;

public class SpiralNumberStarPattern
{
    public static void Main(string[] args)
    {
        

        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine()); //rows=5

        Console.Write("Enter number of cols: ");
        int cols = Convert.ToInt32(Console.ReadLine()); //cols=5

        int[,] matrix = new int[rows, cols];
        int top = 0, bottom = rows - 1;
        int left = 0, right = cols - 1;
        int num = 1;

        while (top <= bottom && left <= right)
        {
            // Left to Right
            for (int i = left; i <= right; i++)
                matrix[top, i] = num++;
            top++; //move to next row
 
            // Top to Bottom
            for (int i = top; i     <= bottom; i++)
                matrix[i, right] = num++;
            right--;   //move to next inner column

            // Right to Left
            if (top <= bottom) //check if there are rows remaining
            {
                for (int i = right; i >= left; i--)
                    matrix[bottom, i] = num++;
                bottom--; // move to next inner row
            }

            // Bottom to Top
            if (left <= right) //check if there are columns remaining
            {
                for (int i = bottom; i >= top; i--)
                    matrix[i, left] = num++;
                left++;  // move to next inner column
            }
        }

        // Print the spiral matrix
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j].ToString().PadLeft(4)); //padleft() -> adds spaces from left to align numbers this method is in string hence we used ToString() method
            Console.WriteLine();
        }
    }
}


/*
Enter number of rows: 5
Enter number of cols: 5

   1   2   3   4   5
  16  17  18  19   6
  15  24  25  20   7
  14  23  22  21   8
  13  12  11  10   9

*/