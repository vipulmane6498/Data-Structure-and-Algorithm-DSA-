


//Factorial
//use long datatype to get the factorial for large number

//Approach
//Steps1: keep multiplying the number from 1 to given number


using System;

public class Factorial{
    public static void Main(String[] args){
        
        System.Console.WriteLine("Enter a number toFind out its Factorial Number: ");
        long num=Convert.ToInt32(System.Console.ReadLine());
        
        long fact = 1;
        
        for(int i=1; i<=num; i++){
            fact = fact * i;
        }
        System.Console.WriteLine("Factorial of "+num+" is "+fact);
    }
}
/*
Enter a number toFind out its Factorial Number: 
5
Factorial of 5 is 120
*/
