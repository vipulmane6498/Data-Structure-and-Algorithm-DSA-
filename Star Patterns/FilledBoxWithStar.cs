
/*
//1. Filled Box with Star
This program prints a filled box pattern using stars.    
The size of the box is determined by user input for 'n', which represents both the width and height of the box.
The program uses nested loops to print the stars in a grid format.

Approach:
1. fist loop iterates over the rows, and the second loop iterates over the columns.
2. first loop refer for the rows will push us over next line after printing all the stars in a row.
3. second loop will print the stars in a row.


e.g. n=5:
OUTPUT:
* * * * * 
* * * * * 
* * * * * 
* * * * * 
* * * * * 

*/

using System;

public class FilledBoxWithStar
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter value of n: ");
        int n = Convert.ToInt32(System.Console.ReadLine());

        //1st loop iterates over the rows, and the 2nd loop iterates over the columns.

        //1st loop refer for the rows will push us over next line after printing all the stars in a row.
        for (int i = 0; i < n; i++)
        {
            //2nd loop will print the stars in a row.
            for (int j = 0; j < n; j++)
            {
                System.Console.Write("* "); //print star and space after it
            }
            System.Console.WriteLine(); //next line after printing all the stars in a row
        }
    }
}

/*
OUTPUT:
Enter value of n: 5

* * * * *
* * * * *   
* * * * *
* * * * *
* * * * *
*/