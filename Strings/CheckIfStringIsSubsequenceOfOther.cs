// Check if a String is Subsequence of Other
//it should be in order
//e.g. s1="ABCDEF" s2="ADE" => true
// s1="ABCDEF" s2="AEB" => false
using System;

public class Subsequence
{

    static void Main(string[] args)
    {
        string s1 = "ABCDEF";
        string s2 = "ADE";

        int m = s1.Length;  //6
        int n = s2.Length;  //3

        bool result = CheckSubsequence(s1, s2, m, n);

        System.Console.WriteLine(result ? "True" : "False");


    }

    static bool CheckSubsequence(string s1, string s2, int m, int n)
    {

        int j = 0;
        for (int i = 0; i < m && j < n; i++)
        {
            if (s1[i] == s2[j])
            {
                j++; //when s2' char found in s1 then will move s2's pointer ahead i.e. j++

                //Logic->
                // s1="ABCDEF"    ->i
                // s2="ADE"       ->j
                // i=0=>A   j=0=A;   ==>j++ =>j=1=>D
                // i=1=>B
                // i=2=>c
                // i=3=>D  j=1=>D   ==>j++ =>j=2=>E
                // i=4=>E  j=2=>E   ==>j++ =>j=3

            }
        }

        //so when j becomes 3 and size of the string s2 is match the will return true but if j becomes 2 then will return false;
        if (n == j) //n=3 and j=3
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
//true