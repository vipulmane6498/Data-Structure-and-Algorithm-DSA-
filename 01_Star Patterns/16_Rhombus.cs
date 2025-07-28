
/*

Rhombus Star Pattern:

Approach:

1.Get the number of rows from the user.
2. Outer loop iterates through each row.
3. The first inner loop prints spaces to align the stars in a rhombus shape. (j<i) => this will add min spaces in the first row and increase by one space in each subsequent row.
4. The second inner loop prints stars for the current row. (k<n) => this will print the same number of stars in each row.
5. Print a new line after each row to form the rhombus.

E.g. 
n=5


*/



using System;


namespace Rhombus
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
                    System.Console.Write("* ");
                }
                System.Console.WriteLine();
            }


        }
    }
}

/*
OUTPUT:
Enter Number: 
5
* * * * * 
 * * * * * 
  * * * * * 
   * * * * * 
    * * * * * 

    */