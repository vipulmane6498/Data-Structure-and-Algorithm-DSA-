
Frequencies in a Sorted Array - Easy -> Return the count of each element that how many times it exists in the array

Approach:
1. Traverse the element from index 1st
2. check if the current element is match with previous
3. if matches increase the count
4. if not print the count of the previous element then set the count to 1
5. If the last element is unique then last element will not print its count hence write statement n-1 and print its count;
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {

        int[] arr = { 1, 1, 1, 2, 3, 3, 5, 5, 8, 8, 8, 9, 9, 10 };

        int count = 1;

        for (int i = 1; i < arr.Length; i++) {
            if (arr[i] == arr[i - 1]) {
                count++;
            }
            else {
                System.Console.WriteLine(arr[i - 1] + " =" + count);
                count = 1;
            }
        }
        System.Console.WriteLine(arr[arr.Length - 1] + " =" + count);
    }
}

/* OTUPUT:
1 =3
2 =1
3 =2
5 =2
8 =3
9 =2
10 =1


*/