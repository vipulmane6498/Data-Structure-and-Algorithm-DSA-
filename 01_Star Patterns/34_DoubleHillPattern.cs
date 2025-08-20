/*
Double Hill Pattern -> 2 pyramids

Approach:
1. The first half of the pattern consists of two pyramids that are mirrored horizontally.
2. The first pyramid is printed with decreasing spaces and increasing stars.
3. The second pyramid is printed with a gap in between, starting from the right side of the first pyramid.



*/

using System;

public class DoubleHillPattern
{
    public static void Main(string[] args)
    {

        Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine()); //rows=10

        for (int i = 0; i < n; i++)
        {
            //1st pyramid
            for (int j = 0; j < n - i; j++)
            {
                System.Console.Write(" ");
            }
            for (int k = 0; k < i; k++)
            {
                System.Console.Write("* ");
            }

            //2nd pyramid
            int size = 2 * n - i - 2;
            for (int j = 0; j < size - i; j++)
            {
                System.Console.Write(" ");
            }
            for (int k = 0; k < i; k++)
            {
                System.Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}

/*
Enter number of rows: 10
                            
         *                 * 
        * *               * * 
       * * *             * * * 
      * * * *           * * * * 
     * * * * *         * * * * * 
    * * * * * *       * * * * * * 
   * * * * * * *     * * * * * * * 
  * * * * * * * *   * * * * * * * * 
 * * * * * * * * * * * * * * * * * * 

*/