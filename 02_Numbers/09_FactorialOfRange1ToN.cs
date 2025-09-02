/*
level easy- logic
FactorialOfRange1ToN
*/

using System;

public class FactorialOfRange1ToN
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the range: ");
        int num=Convert.ToInt32(System.Console.ReadLine());
        int b=3;
        
        for(int i=1; i<=num; i++){
            int fact=1;
            for(int j=1; j<=i; j++){
                fact=fact*j;
            }
            System.Console.WriteLine("Factorial for "+i + " is "+ fact);
        }
        
        
        
    }
}
/*
OUTPUT:
Enter the range: 
7
Factorial for 1 is 1
Factorial for 2 is 2
Factorial for 3 is 6
Factorial for 4 is 24
Factorial for 5 is 120
Factorial for 6 is 720
Factorial for 7 is 5040

*/
