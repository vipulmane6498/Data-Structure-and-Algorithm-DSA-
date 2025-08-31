/*

CheckPrimePalindrome: here we find if it is palindrome and further we find if it is a prime number

*/



using System;  // Required for Console input/output

class CheckPrimePalindrome
{
    public static void Main(string[] args)
    {
        // Ask user to enter a number
        Console.WriteLine("Enter a number");
        int n = Convert.ToInt32(Console.ReadLine());  // Read input number

        int t = n;   // Save original number
        int rev = 0; // To store reversed number

        // 1. Reverse the number
        while (n != 0)
        {
            rev = rev * 10 + (n % 10);  // Extract last digit and build reversed number
            n = n / 10;                 // Remove last digit
        }

        // 2. compare reverse number with given number, if it is palindrome then check further below if it is also a prime number
        if (rev == t)
        {
            int i;
            // 3. Check if palindrome number is also prime
            for (i = 2; i < rev; i++)
            {
                if (rev % i == 0)   // If divisible by any number, not prime
                {
                    Console.WriteLine("Not a prime palindrome");
                    break;
                }
            }

            if (i == rev)   // If loop completes, number is prime
            {
                Console.WriteLine(t + " is a prime palindrome number");
            }
        }
        else
        {
            Console.WriteLine(t + " is not a palindrome");
        }
    }
}
/*
OUTPUT:
enter	a	number	
313	
313	is	a	prime	palindrome	number	
OR-----------------
enter	a	number	
103	
103	is	not	a	prime	palindrome	number	
*/
