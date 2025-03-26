//Check Even or Odd Number
using System;

public class ReverseNumber {
    public static void Main(string[] args) {
       System.Console.WriteLine("Please enter a number to chech if it is Even or Odd ?");
       int a = Convert.ToInt32(System.Console.ReadLine());
       
       if(a%2==0){
           System.Console.WriteLine(a+ " is even Number !");
       }
       else{
           System.Console.WriteLine(a + "is Not even Number !");
       }
       
    }
}
/*
Please enter a number to chech if it is Even or Odd ?
10
10 is even Number !
*/
