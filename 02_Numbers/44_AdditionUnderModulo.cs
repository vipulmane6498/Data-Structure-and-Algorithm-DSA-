/*
AdditionUnderModulo -> add given numbers and use mod sign to find its remainer
Note: Modular operations returns the remainder when divided by M. The result will always be an integer between 0 and M−1.

E.g. 1
Input: a = 10, b = 20, M = 3
Output: 0
Explanation: (10 + 20) mod 3 = 0

E.g. 2
Input: a = 100, b = 13, M = 107
Output: 6
Explanation: (100 + 13) mod 107 = 6


*/

using System;

public class AdditionUnderModulo
{
    public static void Main(string[] args)
    {
        int a=10;
        int b = 20;
        int M = 3;
        int mod= sumUnderModulo(a,b,M);
        System.Console.WriteLine("Addition Under Modulo is: "+mod);
        
    }
 
    // Complete this function
    static int sumUnderModulo(int a, int b, int M) {
        // code here
        //formula
        return (a+b)%M;
    }

}
/*
OUTPUT:
Addition Under Modulo is: 0
*/