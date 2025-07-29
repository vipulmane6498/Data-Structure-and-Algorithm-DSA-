/*
Hollow Rhombus Pattern in C#

Approach:
1. Get the number of rows from the user.
2. Outer loop iterates through each row.
3. The first inner loop prints spaces to align the stars in a rhombus shape. (j<i) => this will add min spaces in the first row and increase by one space in each subsequent row.
4. The second inner loop prints stars for the current row. Stars are printed at the beginning and end of each row, with spaces in between. (i==0 || i==n-1 || k==0 || k==n-1) => print star at the start and end of the row.
5. Print a new line after each row to form the hollow rhombus.

E.g.
Enter Number: 
10
**********
 *        *
  *        *
   *        *
    *        *
     *        *
      *        *
       *        *
        *        *
         **********
*/



using System;


namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter Number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < i; j++)
                {
                    System.Console.Write(" ");

                }

                //print stars till n 
                for (int k = 0; k < n; k++)
                {
                    if (i == 0 || i == n - 1 || k == 0 || k == n - 1)
                    {
                        System.Console.Write("*");
                    }
                    else
                    {
                        System.Console.Write(" ");
                    }
                }
                System.Console.WriteLine();
            }
        }
    }
}

/*
OUTPUT:
Enter Number: 
10
**********
 *        *
  *        *
   *        *
    *        *
     *        *
      *        *
       *        *
        *        *
         **********


*/