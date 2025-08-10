/*
concentric square number pattern:

Print a concentric square number pattern starting from n down to 1 toward the center. For n = 5, it looks like:
5 5 5 5 5 5 5 5 5
5 4 4 4 4 4 4 4 5
5 4 3 3 3 3 3 4 5
5 4 3 2 2 2 3 4 5
5 4 3 2 1 2 3 4 5
5 4 3 2 2 2 3 4 5
5 4 3 3 3 3 3 4 5
5 4 4 4 4 4 4 4 5
5 5 5 5 5 5 5 5 5

Approach in Points:

    1. Input value
        - n is the highest number in the pattern (outermost layer).
        - You can change n to control the size of the pattern.
    2. Calculate size of grid
        - size = 2 * n - 1    --> This gives the total number of rows and columns. e.g. n=5 then it will become 9x9 matrix
        - This ensures the pattern has a center and is symmetrical (odd-sized square).
    3. Two nested loops for rows and columns
        - Outer loop: i from 0 to size - 1 → controls rows.
        - Inner loop: j from 0 to size - 1 → controls columns.
    4. Calculate the minimum distance from edges
        - int min = Math.Min(Math.Min(i, j), Math.Min(size - 1 - i, size - 1 - j));
        - This finds the minimum distance from any edge (top, bottom, left, or right).
        - It determines which 'layer' (or square ring) the current cell is in.
    5. Determine number to print Console.Write((n - min) + " ");
        - The closer the cell is to the center, the smaller the number.
        - n - min gives the correct value based on how deep the cell is inside.
    6. Print new line after each row
        -Console.WriteLine();
E.g. n=5;

5 5 5 5 5 5 5 5 5
5 4 4 4 4 4 4 4 5
5 4 3 3 3 3 3 4 5
5 4 3 2 2 2 3 4 5
5 4 3 2 1 2 3 4 5
5 4 3 2 2 2 3 4 5
5 4 3 3 3 3 3 4 5
5 4 4 4 4 4 4 4 5
5 5 5 5 5 5 5 5 5
    */




using System;

public class ContricOrMatrix_BorderNumberPattern
{
    public static void Main(string[] args)
    {
        int n = 4; // You can change this number for a bigger pattern
        int size = 2 * n - 1; // Calculate the size of the square matrix, if n=5 then size=9 means 9x9 matrix

        for (int i = 0; i < size; i++) //rows
        {
            for (int j = 0; j < size; j++) //columns
            {
                int min = Math.Min(Math.Min(i, j), Math.Min(size - 1 - i, size - 1 - j)); //gives then minimum distance from the edges comaring from top, bottom, left or right
                Console.Write((n - min) + " "); // Print the number one by one based on the minimum distance from the edges 
            }
            Console.WriteLine(); // Print a new line after each row
        }
    }
}

/*
Output for n=5:

5 5 5 5 5 5 5 5 5   
5 4 4 4 4 4 4 4 5
5 4 3 3 3 3 3 4 5
5 4 3 2 2 2 3 4 5
5 4 3 2 1 2 3 4 5
5 4 3 2 2 2 3 4 5
5 4 3 3 3 3 3 4 5
5 4 4 4 4 4 4 4 5
5 5 5 5 5 5 5 5 5

*/
