/*
Strong Number -> A number is called a Strong Number if
the sum of the factorial of its digits is equal to the number itself.

Example: 145
1! = 1
4! = 24
5! = 120
Sum = 1 + 24 + 120 = 145
Since sum == original number, 145 is a Strong Number.
*/

using System; // Import System library to use Console class for input/output

public class CheckStrongNumber
{
    public static void Main(string[] args)
    {
       int num = 145;   // Declare a number to check (here we use 145)
       int x = num;     // Save the original number in x (because num will become 0 after loop)
       
       int sum = 0;     // Variable to store the sum of factorials of digits
       
       // Loop until the number becomes 0
       while(num > 0){
           int remainder = num % 10;       // Get the last digit of number
           sum = sum + Factorial(remainder); // Add factorial of digit to sum
       
           num = num / 10;                 // Remove the last digit from number
       }
       
       // After loop, check if sum of factorials == original number
       if(x == sum){
           System.Console.WriteLine("Given number " + x + " is a Strong Number !");
       }
       else{
           System.Console.WriteLine("Given number " + x + " is NOT a Strong Number !");
       }
    }

    // Method to calculate factorial of a number
    // Example: if n=4 -> factorial = 4*3*2*1 = 24
    static int Factorial(int n){
        int fact = 1;             // Start factorial value as 1
        for(int i = 1; i <= n; i++){  // Multiply numbers from 1 to n
            fact = fact * i;
        }
        return fact;              // Return factorial value
    }
}
/*
OUTPUT:
Given number 145 is a Strong Number !

*/