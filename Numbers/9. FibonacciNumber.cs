
//Find the Fibonacci number for given number
//FIBONACCI
//	a	series	of	numbers	in	which	each	number	(	Fibonacci number	)	is	the	sum	of	the	two	preceding	numbers.	The	simplest	is	the	series	1,	1,	2,	3,	5,	8,	etc.	

//Approach
//Steps1: add prevoius 2 number together to get the fibonnacci number for given number


using System;

public class Fibonacci{
    
// Function to calculate Fibonacci number recursively
    static int fib(int n) {
        // Base Case: If n is 0, return 0 (First Fibonacci number)
        if (n == 0) {
            return 0;
        }
        // Base Case: If n is 1, return 1 (Second Fibonacci number)
        if (n == 1) {
            return 1;
        }
        
        // Recursive case: Sum of the previous two Fibonacci numbers
        return fib(n - 1) + fib(n - 2);
    }

    public static void Main(String[] args) {
        // Ask user to enter a number
        System.Console.WriteLine("Please enter a number: ");
        
        // Read user input and convert it to an integer
        int n = Convert.ToInt32(System.Console.ReadLine());
     
        // Call the Fibonacci function and store the result
        int fibNumb = fib(n);
     
        // Print the Fibonacci number corresponding to the given input
        System.Console.WriteLine("Fibonacci number for given number is: " + fibNumb);
    }
}
/*
Please enter number: 
10
Fibonnacci number for given number is: 55
*/
