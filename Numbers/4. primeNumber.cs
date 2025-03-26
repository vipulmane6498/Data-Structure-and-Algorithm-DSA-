using System;

public class PrimeNumber
{
    public static void Main(string[] args)
    {

       System.Console.WriteLine("Please enter a number to chech if it is Prime number ?");
       int a = Convert.ToInt32(System.Console.ReadLine());

        bool isPrime = true;

        //1 is not prime number
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