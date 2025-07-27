//Sequence numbers in Traingle format
/*
// Approach:
// 1. Prompt the user to enter the number of rows for the triangle.
// 2. Read the user input and convert it to an integer.
// 3. Initialize a variable to keep track of the current number to print.
// 4. Loop through each row from 1 to n:
//    a. For each row, loop through the number of columns equal to the current row number.
//    b. Increment and print the current number in each column.
//    c. After each row, move to the next line.
E.g. n=5

1  
2  3  
4  5  6  
7  8  9  10  
11  12  13  14  15 


*/
using System;

public class SequenceNumbersInTraingleFormat
{
    public static void Main(string[] args)
    {
        //user input
        System.Console.WriteLine("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());

        //initialize 
        int num = 0;

        //work for rows
        for (int i = 1; i <= n; i++)
        {

            //print number
            for (int k = 0; k < i; k++) //k<i -> as i increases, k will increase to print numbers in each row
            {
                num++; //increament to update number
                System.Console.Write(num + "  "); //print number
            }
            System.Console.WriteLine(); //push to next line
        }
    }
}

/*
OUTPUT:
Enter number of rows: 
5

1  
2  3  
4  5  6  
7  8  9  10  
11  12  13  14  15 

*/
