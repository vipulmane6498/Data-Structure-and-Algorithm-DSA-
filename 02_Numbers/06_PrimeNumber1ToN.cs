//Write a program to display PRIME NUMBERS from 1 to n?
using System;
public class PrimeNumber1ToN
{
    public static void Main(string[] args)
    {

        System.Console.WriteLine("Please enter a Number: ");
        int a = Convert.ToInt32(System.Console.ReadLine());

        //will start loop from 1 to given number
        for (int i = 1; i < a; i++)
        {

            // Reset for each number
            bool isPrime = true;

            //check for each number if it is prime
            for (int j = 2; j < i; j++)
            {
                //Check if it is completely devisible by in given range
                if (i % j == 0)
                {
                    isPrime = false;
                    break; //if it is completely devisible by any number in the loop then will break the loop
                }
            }
            if (isPrime)
            {
                System.Console.WriteLine(i + " is prime Number !");
            }
            // else{
            //     System.Console.WriteLine(i+" is not prime Number !");
            // }

        }
    }
}
/*
Please enter a Number: 
21
1 is prime Number !
2 is prime Number !
3 is prime Number !
5 is prime Number !
7 is prime Number !
11 is prime Number !
13 is prime Number !
17 is prime Number !
19 is prime Number !
*/