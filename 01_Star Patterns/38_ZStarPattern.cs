/*
Z Star Pattern

Approach:
1. Get the number of rows from the user.
2. Print stars for the first row, the last row, and the diagonal from the top right to the bottom left.
3. Move to the next line after completing each row.

*/

using System;

public class ZStarPattern
{
    public static void Main(string[] args)
    {
         Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine()); //rows=10


        for(int i=0; i<n; i++){
            for(int j=0; j<n; j++){
               if(i==0 || i+j==n-1 || i==n-1){
                    System.Console.Write("*");
                }
                else{
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }
    }
}

/*
Enter number of rows: 10

**********
        * 
       *  
      *   
     *    
    *     
   *      
  *       
 *        
**********

*/


