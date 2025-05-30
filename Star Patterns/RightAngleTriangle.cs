
/*
Right Angle Triangle star pattern

Apporach:
    1.Outer loop refer to the rows
    2. inner loop refer to the stars in a row
    3. j<i -> j start printing the stars e.g. i=0 -> j=0 means 0 stars, i=1 -> j=0 means 1 star, i=2 -> j=0,1 means 2 stars and i=3 means j=0,1,2 means 3 stars so on until the nth row where it prints n-1 stars.

E.g.:
Enter a value n: 
5
* 
* * 
* * * 
* * * * 
* * * * * 
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        
        System.Console.WriteLine("Enter a value n: ");
       int n=Convert.ToInt32(System.Console.ReadLine());
       
        // Outer loop for each row
        for (int i = 0; i < n; i++)
        {
            // Inner loop for printing stars in each row
            for (int j = 0; j < i; j++)    //j<i means that in the first row it will print 0 stars, in the second row it will print 1 star, and so on until the nth row where it prints n-1 stars.
            {
                System.Console.Write("* ");
            }
            System.Console.WriteLine(); // Move to the next line after printing stars in the current row
        }
    }
}
/*
OUTPUT:

Enter a value n: 
5
* 
* * 
* * * 
* * * * 
* * * * * 

*/