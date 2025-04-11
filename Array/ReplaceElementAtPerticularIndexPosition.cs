// Replace Element At perticular Index Position
// Apprach: 
// When index and  position gets match add new Element

using System;

public class ReplaceElementAtPerticularIndexPosition
{
    public static void Main(string[] args)
    {

        System.Console.WriteLine("Enter the size of the array: ");
        int size = Convert.ToInt32(System.Console.ReadLine());

        int[] arr = new int[size];

        System.Console.WriteLine("Enter the elements of the array: ");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(System.Console.ReadLine()); // Print each element
        }

        int pos = 2;
        int newElement = 99;


        for (int k = 0; k < size; k++)
        {

            if (k == pos)
            {
                arr[k] = newElement;
                break; //its not needed but we can add so that once the pos found and add the element we can stop further iterations
            }
        }

        for (int j = 0; j < arr.Length; j++)
        {
            Console.Write(arr[j] + " "); // Print each element
        }
    }
}
/*
1
2
3
4
5
6
*/
