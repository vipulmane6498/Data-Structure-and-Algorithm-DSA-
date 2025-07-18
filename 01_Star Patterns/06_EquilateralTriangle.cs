/*

Equilateral Triangle

Approach:
1. Get the number of rows from the user.
2. First outer loop iterates through each row.
3. The first inner loop prints spaces to align the stars in an equilateral triangle.( j <= n - i - 1 ) => this will add max spaces in the first row and decrease by one space in each subsequent row.
4. The second inner loop prints stars for the current row. (k<i) => this will print one star in the first row and increase by one star in each subsequent row.
5. Print a new line after each row to form the triangle.

E.g. n=10
          *
         * *
        * * *
       * * * *
      * * * * *
     * * * * * *
    * * * * * * *
   * * * * * * * *
  * * * * * * * * *

*/



using System;

public class EquilateralTriangle
{
    public static void Main(string[] args)
    {


        //1. Get the number of rows from the user.
        System.Console.WriteLine("Enter a number for rows: ");
        int n = Convert.ToInt32(System.Console.ReadLine());

        //2. First outer loop iterates through each row.
        for (int i = 0; i < n; i++)
        {
            //3. The first inner loop prints preceding spaces to align the stars in an equilateral triangle.( j <= n - i - 1 ) => this will add max spaces in the first row and decrease by one space in each subsequent row.
            for (int j = 0; j <= n - i - 1; j++)
            {
                System.Console.Write(" ");
            }

            //4. The second inner loop prints stars for the current row. (k<i) => this will print one star in the first row and increase by one star in each subsequent row.
            for (int k = 0; k < i; k++)
            {
                System.Console.Write(" *");
            }
            //5. Print a new line after each row to form the triangle.
            System.Console.WriteLine();
        }
    }

}

/*
OUTPUT: 
Enter a number for rows: 
10
          
          *
         * *
        * * *
       * * * *
      * * * * *
     * * * * * *
    * * * * * * *
   * * * * * * * *
  * * * * * * * * *

  */