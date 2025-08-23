/*
Binary Triangle Pattern:

Approach:
1. Get the number of rows from the user.
2. For each row, determine the starting value (1 or 0) based on whether the row index is even or odd.
3. Print the current value and then flip it for the next column.
4. Continue this for all columns in the row.
5. Move to the next line after completing each row.

*/


using System;

public class BinaryTriangle
{
    public static void Main(string[] args)
    {
         Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine()); //rows=10

        for(int i=0; i<n; i++){

            //set the 1st element of the row
            //For each row, we decide the starting value:
            //If i is even (i % 2 == 0), start with 1
            //If i is odd, start with 0
            //it will keep updating as rows increase
            //This way, we alternate between starting with 1 and starting with 0
            int current = (i % 2==0) ? 1:0;
            
            for(int j=0; j<=i; j++){
                
                //Print the current value (0 or 1)
                System.Console.Write(current+" ");
                
                //Then flip it:
                //If current is 1, it becomes 0
                //If current is 0, it becomes 1
                current=1-current; // It will update for each iteration
                
            }
             System.Console.WriteLine();
            
        }
    }
}

/*

Enter number of rows: 10
1 
0 1 
1 0 1 
0 1 0 1 
1 0 1 0 1 
0 1 0 1 0 1 
1 0 1 0 1 0 1 
0 1 0 1 0 1 0 1 
1 0 1 0 1 0 1 0 1 
0 1 0 1 0 1 0 1 0 1 

*/


