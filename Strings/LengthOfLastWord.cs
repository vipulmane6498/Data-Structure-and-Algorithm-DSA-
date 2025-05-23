

//Length of Last Word
// Given a string s consists of upper/lower-case alphabets and empty space characters ' ', return the length of last word in the string.
using System;
using System.Text.RegularExpressions;
public class Solution {

    static int LengthOfLastWord(string s) {
     s = Regex.Replace(s.Trim(), @"\s+", " ");// Remove leading and trailing spaces and replace multiple spaces with a single space
        char[] newArr=s.ToCharArray();
        int n=newArr.Length;
        int count=0;
        //transverse the array from last to first and check if the char is space then break the loop.           
        for(int i=n-1; i>=0; i--){
               //1st check it any space it not then only increament the count.
            if(newArr[i]== ' '){
                break;
            }
             count++;
        }
        return count;
    }
    
    public static void Main(String[] args){
        
        string s="   fly me   to   the moon  ";
        
        int result=LengthOfLastWord(s);
        System.Console.WriteLine("Length of last word: "+result);
    }
}
/*
Length of last word: 4
*/

