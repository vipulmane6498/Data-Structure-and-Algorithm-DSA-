
//need to check optimize code**********
using System;

public class Solution
{
    static void Rotate(int[] nums, int k)
    {

        int size = nums.Length;


        k = k % size;  // Handle cases where k > size

        int[] newArr = new int[size];

        int res = 0;
        for (int i = size - k; i < size; i++)
        {
            newArr[res] = nums[i];
            res++;
        }
        for (int j = 0; j < size - k; j++)
        {
            newArr[res] = nums[j];
            res++;
        }

        for (int p = 0; p < size; p++)
        {
            nums[p] = newArr[p];
        }

        for (int y = 0; y < size; y++)
        {
            System.Console.WriteLine(nums[y] + " ");
        }
    }

    public static void Main(String[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;

        Rotate(nums, k);
    }
}