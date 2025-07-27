/*
Characters in Diamond Pattern:


Approach:
1. Get the number of rows from the user.
2. Calculate the middle point of the diamond using n/2.
3. For the upper half of the diamond:
    - Outer loop iterates from 0 to mid for rows.
    - First inner loop prints preceding spaces before the characters. (j < mid - i)
    - Second inner loop prints characters in increasing order from 'A' up to the current row. (k = 0 to i)
    - Third inner loop prints characters in decreasing order from the character before the current row back to 'A'. (m = i-1 down to 0)
    - Print a new line after each row.
4. For the lower half of the diamond:
    - Outer loop iterates from mid-1 down to 0 for rows.
    - First inner loop prints preceding spaces before the characters. (j < mid - i)
    - Second inner loop prints characters in increasing order from 'A' up to the current row. (k = 0 to i)
    - Third inner loop prints characters in decreasing order from the character before the current row back to 'A'. (m = i-1 down to 0)
    - Print a new line after each row.

AND (char) ('A' + k) converts the integer k to its corresponding character starting from 'A'.
    e.g. if k=1 -> 
                    = (char)('A' + 1)
                    = (char)(65 + 1)
                    = (char)66
                    = 'B'


    E.g. n=10

     A
    ABA
   ABCBA
  ABCDCBA
 ABCDEDCBA
ABCDEFEDCBA
 ABCDEDCBA
  ABCDCBA
   ABCBA
    ABA
     A
*/

using System;

public class CharactersInDiamond
{

    public static void Main(String[] args)
    {

        System.Console.WriteLine("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int mid = 10 / 2;

        //Upper part
        for (int i = 0; i <= mid; i++)
        {
            //Preceeding spaces
            for (int j = 0; j < mid - i; j++)
            {
                System.Console.Write(" ");
            }

            //left part
            for (int k = 0; k <= i; k++)
            {
                System.Console.Write((char)('A' + k));
            }

            //right part
            for (int m = i - 1; m >= 0; m--)
            {
                System.Console.Write((char)('A' + m));
            }
            System.Console.WriteLine();
        }

        //Lower part
        for (int i = mid - 1; i >= 0; i--)
        {
            //Preceeding spaces
            for (int j = 0; j < mid - i; j++)
            {
                System.Console.Write(" ");
            }

            //left part
            for (int k = 0; k <= i; k++)
            {
                System.Console.Write((char)('A' + k));
            }

            //right part
            for (int m = i - 1; m >= 0; m--)
            {
                System.Console.Write((char)('A' + m));
            }
            System.Console.WriteLine();
        }
    }
}

/*


     A
    ABA
   ABCBA
  ABCDCBA
 ABCDEDCBA
ABCDEFEDCBA
 ABCDEDCBA
  ABCDCBA
   ABCBA
    ABA
     A
     
*/