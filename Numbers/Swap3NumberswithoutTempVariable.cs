using System;

public class SwapTwoNumbers{
    
    public static void Main(String[] args){
        
        System.Console.WriteLine("Enter 1st Number: ");
        int a=Convert.ToInt32(System.Console.ReadLine());
        
         System.Console.WriteLine("Enter 2nd Number: ");
        int b=Convert.ToInt32(System.Console.ReadLine());
        
               System.Console.WriteLine("Enter 3rd Number: ");
        int c=Convert.ToInt32(System.Console.ReadLine());
        
        a = a +b+c;
        b = a-b-c;
        a = a - b-c;
        
        System.Console.WriteLine("your Number is swapped without 3rd variable: "+a + " : "+ b+" and "+c);
        
        
    }
}
/*
Enter 1st Number: 
1
Enter 2nd Number: 
2
Enter 3rd Number: 
3
your Number is swapped without 3rd variable: 2 : 1 and 3

*/