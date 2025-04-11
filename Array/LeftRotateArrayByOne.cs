//Left Rotate Array by One - Easy
// Problem: Given an array, rotate it left by one position.

//Approach:
// 1. Store the first element in a temporary variable.
// 2. Shift all elements to the left by one position (i.e., arr[i] = arr[i + 1] for i from 0 to n - 2). 
// 3. Assign the value of the temporary variable to the last position of the array (i.e., arr[n - 1] = temp).
// 4. Print the modified array.

using System;

public class LeftRotateArrayByOne{
    public static void Main(String[] args){
        
        int[] arr={1, 2, 3, 4, 5, 6};
        
        int n=arr.Length;
        
        //first element gets override with 2nd element hence add 1st element in temp and later assign it to last index.
        int temp=arr[0];
        
        for(int i=1; i<n; i++){
            arr[i-1] = arr[i];
        arr[n-1]= temp;
        }
        
        for(int j=0; j<n-1; j++){
            System.Console.Write(arr[j]);
        }
    }
}