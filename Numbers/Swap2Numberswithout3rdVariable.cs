// SwapTwoNumbers two numbers without temporiy variable;
// //Approach
// tep 1: Add a and b and store the result in a
// Step 2: Subtract b from the new a and store the result in b
// Step 3: Subtract new b from a and store the result in a

using System;

public class SwapTwoNumbers{
    
    public static void Main(String[] args){
        
        System.Console.WriteLine("Enter 1st Number: ");
        int a=Convert.ToInt32(System.Console.ReadLine());
        
         System.Console.WriteLine("Enter 2nd Number: ");
        int b=Convert.ToInt32(System.Console.ReadLine());
        
        a = a +b;
        b = a-b;
        a = a - b;
        
        System.Console.WriteLine("your Number is swapped without 3rd variable: "+a + " : "+ b);
        
        
    }
}
/*
Enter 1st Number: 
1
Enter 2nd Number: 
2
your Number is swapped without 3rd variable: 2 : 1
*/