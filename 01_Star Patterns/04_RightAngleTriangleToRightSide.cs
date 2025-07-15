/*
Right Angle Triangle To Right Side

Approach:
1. Take an integer input n from the user.
// 2. outer loop refer for shifting to the next line
// 3. 1st inner loop add preceding spaces (j<n-i)
//     e.g. when i=1  n=5  n-i=4 => j=0,1,2,3 means 4 spaces
//         j=0 => "    "
//         j=1 => "   "
//         j=2 => "  "
//         j=3 => " "
// 4. 2nd inner loop print stars("*") => (k<i)
//     e.g. when i=1, 2, 3, 4
//         i=1 => k=0 =>         "*"
//         i=2 => k=0,1 =>      "**"
//         i=3 => k=0,1,2 =>   "***"
//         i=4 => k=0,1,2,3 =>"****"

// 5. Print a new line after each row.

         *
        **
       ***
      ****
     *****
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //1. Take an integer input n from the user.
        System.Console.WriteLine("Enter a value n: ");
        int n = Convert.ToInt32(System.Console.ReadLine());

        //2. outer loop refer for shifting to the next line
        for (int i = 1; i < n; i++) {

            //3. 1st inner loop add preceding spaces (j<n-i)
            for (int j = 0; j < n - i; j++)
            {
                System.Console.Write(" ");
            }
            //4. 2nd inner loop print stars("*") => (k<i)
            for (int k = 0; k < i; k++)
            {
                System.Console.Write("*");
            }
            //5. Print a new line after each row.
            System.Console.WriteLine();
        }
    }
}

/*


OUTPUT:
Enter a value n: 
10
         *
        **
       ***
      ****
     *****
    ******
   *******
  ********
 *********
 */