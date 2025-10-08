/*
PrimeFactors:
This program calculates the prime factors of a given number.
e.g. if given number is 12 we have 2 and 3 are prime numbers which devide 12 but also as we are checking prime factors means 4 also devide 12 but 4 is not prime number but its factors is 2*2 so 2 is prime hence again we can take 2 so all in all we get prime factors are 2, 2, 3

*/



//1. Naive solution
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = 12;

        for (int i = 2; i <= n; i++)
        {
            if (isPrime(i))
            {
                int x = i; //storing to find further powers of i           
                while (n / x == 0)
                {
                    System.Console.WriteLine("Prime Factor is: " + i);
                    x = x * i; //we are taking next power i e.g. first it 12 gets devide by 2 and if we do x=x*i means x=2*2 => 4 this also devide 12 hence we again print i as 2 also again when x=x*i => x=4*2 => 8 this dont devide 12 hence we are not printing again  i as 2.
                }
            }
        }

    }
    static bool isPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        if (n == 2 || n == 3)
        {
            return true;
        }

        if (n % 2 == 0 || n % 3 == 0)
        {
            return false;
        }

        for (int i = 5; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}

/*

OTUPUT:
12
Prieme Factor is: 2
Prime Factor is: 2
Prime Factor is: 3

*/