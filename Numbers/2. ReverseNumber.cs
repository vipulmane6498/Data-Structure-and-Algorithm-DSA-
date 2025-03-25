using System;

public class ReverseNumber {
    public static void Main(string[] args) {
        int reverse = 0;
        int num = 123; // We have to reverse number 12

        while (num > 0) {
            int digit = num % 10; // Extract last digit 3 2 1
            reverse = (reverse * 10) + digit; // Append digit to reversed number 32
            num = num / 10; // Remove last digit 12 2
        }

        Console.WriteLine("Reversed Number: " + reverse); //321
    }
}
