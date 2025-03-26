
//Write a program to find SUM OF PRIME numbers?
using System;

public class PrimeNumber1ToN {
    public static void Main(string[] args) {
        System.Console.WriteLine("Please enter a Number: ");
        int num = Convert.ToInt32(System.Console.ReadLine());

        int sum = 0;

        // Start loop from 2 (1 is not prime)
        for (int i = 2; i < num; i++) {
            if (isPrime(i)) {
                sum += i;
            }
        }

        // Print sum **outside** the loop
        System.Console.WriteLine("Sum of prime numbers up to " + num + " is: " + sum);
    }

    public static bool isPrime(int num) {
        if (num < 2) return false; // 0 and 1 are not prime

        for (int i = 2; i < num; i++) {
            if (num % i == 0) {
                return false; // If divisible, it's not prime
            }
        }
        return true; // Otherwise, it's prime
    }
}
/*
Please enter a Number: 
10
Sum of prime numbers up to 10 is: 17
*/
