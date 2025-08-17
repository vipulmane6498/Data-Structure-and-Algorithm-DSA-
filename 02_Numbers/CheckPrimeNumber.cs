/* Level - Easy
Prime Number : A number only divisible by 1 and itself is called a prime number.
Example: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, ...

We have 2 approaches to check if a number is prime or not:
1. Basic Approach: Check divisibility from 2 to n-1.
2. Efficient Approach:  Optimized Trial Division (up to square root)

*/


//2. Efficient Solution:  Trial Division Method 
using System;

public class CheckPrimeNumber
{
    public static void Main(string[] args)
    {

        System.Console.WriteLine("Enter a number to check if it is Prime Number: ");
        int n = Convert.ToInt32(System.Console.ReadLine());

        System.Console.WriteLine("The given number: " + n + " is Prime ? -> " + isPrime(n));
    }

    static bool isPrime(int n)
    {

        //1. One or less than that are not prime Number
        if (n <= 1)
        {
            return false;
        }
        //2. 2 and 3 are prime numbers
        if (n == 2 || n == 3)
            return true;

        //3. If the given number is even then obiviously that is divisible by 2 so its not prime number
        //if the given number is divisble by 3 means its not prime number
        if (n % 2 == 0 || n % 3 == 0)
        {
            return false;
        }

        //4. as 4 is even number so that will take care above hence we will start loop from 5
        // //Since even numbers and multiples of 3 are already handled, you begin checking from 5.
        for (int i = 5; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        /* 
        //OR ELSE instead of above condition you can use below which is completely optimized*********************
        //Check only odd numbers from 5 to √n
        for (int i = 5; i * i <= n; i = i+6)
        {
            if (n % i == 0 || n % (i + 2) == 0)
                return false;
        }
        */

        return true;
    }
}


/*
OUTPUT:
Enter a number to check if it is Prime Number: 
37
The given number: 37 is Prime ? -> True



//-------------------------------------------------------------------------------------------------------

/*
//1. Basic Approach: Check divisibility from 2 to n-1.
using System;

public class CheckPrimeNumber
{
    public static void Main(string[] args)
    {

       System.Console.WriteLine("Please enter a number to chech if it is Prime number ?");
       int a = Convert.ToInt32(System.Console.ReadLine());

        bool isPrime = true;

        //1 is not prime number. but 2 is prime number. from 2 will get from numbers
        if (a < 2)
        {
            isPrime = false;
        }
        else
        {

            //try to devide from 2 to less than given number
            for (int i = 2; i < a; i++)
            {
                //if it give remainder 0 then its not prime number
                if (a % i == 0)
                {
                    isPrime = false;
                }
            }

            if (isPrime = true)
            {
                System.Console.WriteLine(a + " is Prime number !");
            }
            else
            {
                System.Console.WriteLine(a + "is not Prime number !");
            }
        }
    }
}
/*
Please enter a number to chech if it is Prime number ?
11
11 is Prime number !
*/



/*



*/