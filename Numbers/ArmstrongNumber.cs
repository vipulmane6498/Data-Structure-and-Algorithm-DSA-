// Amstrong Number: It is the number that is equal to the sum of its own digits each raised to the power of the number of digits.
//  e.g. 153

//  1 cube + 5 cube + 3 cube = 1 + 125 + 9 = 153;
//  153 = 153 its Amstrong number

//below code will work for 3 digits only 
using System;

public class ArmstrongNumber{
    
    public static void Main(String[] args){
        
        
        System.Console.WriteLine("Enter number to check if it is a Amstrong number: ");
        int num = Convert.ToInt32(System.Console.ReadLine());
        
        int temp = num; //storing num into temp cause it will get change further
        int sum = 0;
        
        while(num > 0){
            
            int remainder = num % 10; //extract last digit
            sum = sum + (remainder * remainder * remainder); //add the cube with sum
            num = num / 10; //at the end remove the last number
            
        }
        if(temp == sum ){
            System.Console.WriteLine("Original Number: "+temp+ "Sum is: "+sum+" both are similar so it is a prime Number.");
        }
    }
}
/*
Enter number to check if it is a Amstrong number: 
153
Original Number: 153Sum is: 153 both are similar so it is a prime Number.*/

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------

//Below is the optmize code will work for any number:--

// Approach:
// Take input from the user – Read an integer number from the console.

// Count the number of digits – Convert the number to a string and find its length.

// Process each digit – Extract digits one by one and raise them to the power of the total number of digits.

// Calculate the sum – Sum up these powered digits.

// Compare the sum with the original number – If they are equal, the number is an Armstrong number.



using System;

public class ArmstrongNumber
{
    public static void Main(String[] args)
    {
        // Step 1: Prompt user for input
        Console.WriteLine("Enter a number to check if it is an Armstrong number: ");
        
        // Step 2: Read the input and convert it to an integer
        int num = Convert.ToInt32(Console.ReadLine());

        // Step 3: Count the number of digits in the number
        int digit = num.ToString().Length; // This determines the power to which each digit should be raised
        
        // Step 4: Store the original number for later comparison
        int temp = num; // 'temp' is used because 'num' will be modified in the loop
        int sum = 0;    // This will store the sum of each digit raised to the power of 'digit'

        // Step 5: Process each digit of the number
        while (num > 0)
        {
            int remainder = num % 10; // Extract the last digit of 'num'

            // Raise the extracted digit to the power of 'digit' and add it to 'sum'
            sum sum + (int)Math.Pow(remainder, digit);

            num = num / 10; // Remove the last digit (reduce the number)
        }

        // Step 6: Compare the computed sum with the original number
        if (temp == sum)
        {
            Console.WriteLine($"Original Number: {temp}, Sum is: {sum}. It is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"Original Number: {temp}, Sum is: {sum}. It is NOT an Armstrong number.");
        }
    }
}
