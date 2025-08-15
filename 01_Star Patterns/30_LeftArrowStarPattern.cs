/*

Left Arrow Star Pattern:

Approach:
1. Get the number of rows from the user.
2. Calculate the middle point of the arrow as n / 2.
3. First half of the arrow:
    - Outer loop iterates from 0 to less than mid for rows.
    - 1st Inner loop prints spaces(2 spaces) before the stars. spacess are reduced to 2 to form the arrow shape.
    - 2nd inner loop prints stars without space. reducing the number of stars in each row.
    - Print a new line after each row to form the first half of the arrow.
4. Second half of the arrow:
    - Outer loop iterates from mid-2 to 0 for rows.
    - 1st Inner loop prints spaces(2 spaces) before the stars. spacess are increasing to 2 to form the arrow shape.
    - 2nd inner loop prints stars without space. increasing the number of stars in each row.
    - Print a new line after each row to form the second half of the arrow.
E.g.: 10

          *****
        ****
      ***
    **
  * *  *  *  *  *  *  *  *  *  * 
    **
      ***
        ****
          *****
*/

using System;

public class LeftArrowStarPattern
{
  public static void Main(string[] args)
  {
    System.Console.Write("Enter number of rows: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int mid = n / 2;
    for (int i = 0; i < mid; i++)
    {
      for (int j = 0; j < mid - i; j++)
      {
        System.Console.Write("  ");
      }
      for (int k = 0; k < mid - i; k++)
      {
        System.Console.Write("*");
      }

      //for middle straing tail line of the arrow
      if (i == mid - 1)
      {
        for (int f = 0; f < n; f++)
        {
          System.Console.Write(" * ");
        }
      }

      System.Console.WriteLine();
    }

    for (int i = mid - 2; i >= 0; i--)
    {
      for (int j = 0; j < mid - i; j++)
      {
        System.Console.Write("  ");
      }
      for (int k = 0; k < mid - i; k++)
      {
        System.Console.Write("*");
      }
      System.Console.WriteLine();
    }
  }
}

/*
Enter number of rows: 10
          *****
        ****
      ***
    **
  * *  *  *  *  *  *  *  *  *  * 
    **
      ***
        ****
          *****
*/