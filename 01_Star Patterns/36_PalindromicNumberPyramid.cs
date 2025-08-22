/*
Palindromic Number Pyramid:

Approach:
1. Get the number of rows from the user.
2. For each row, print leading spaces to align the pyramid.
3. Print the first half of the row with increasing numbers from 1 to i.
4. Print the second half of the row with decreasing numbers from i-1 back to 1.
5. Move to the next line after completing each row.

E.g.: n=18

         1
        121
       12321
      1234321
     123454321
    12345654321
   1234567654321
  123456787654321
 12345678987654321
12345678910987654321


*/


using System;

public class PalindromicNumberPyramid
{
    public static void Main(string[] args)
    {

        Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine()); //rows=18


        for (int i = 1; i <= n; i++)
        {

            //Preceeding spaces
            for (int j = 1; j <= n - i; j++)
            {
                System.Console.Write(" ");
            }

            //1st half
            for (int k = 1; k <= i; k++)
            {

                System.Console.Write(k);
            }
            //2nd Half
            for (int m = i - 1; m >= 1; m--)
            {

                System.Console.Write(m);
            }

            Console.WriteLine();
        }
    }
}

/*

Enter number of rows: 10
         1
        121
       12321
      1234321
     123454321
    12345654321
   1234567654321
  123456787654321
 12345678987654321
12345678910987654321

*/