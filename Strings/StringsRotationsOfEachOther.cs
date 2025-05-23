//Strings Rotations of Each Other OR
//Rotate String OR
//Check If One String Is A Rotation Of Another String - Easy

//e.g.1.  s1="abcde" s2="cdeab"
        //s1+s1="abcdeabcde"
        //s2="cdeab" is a substring of s1+s1
//e.g.2.  s1="abcde" s2="abced"    
        //s1+s1="abcdeabcde"
        //s2="abced" is not a substring of s1+s1

/*
Approach:
1. Check if the length of the two strings are equel if not then return true
2. Concatenate the first string with itself
3. Check if the second string is a substring of the concatenated string
//e.g.1.  s1="abcde" s2="cdeab"
        //s1+s1="abcdeabcde"
        //s2="cdeab" is a substring of s1+s1
//e.g.2.  s1="abcde" s2="abced"    
        //s1+s1="abcdeabcde"
        //s2="abced" is not a substring of s1+s1
        a. use the sliding technique for s string to confirm its final interation.(e.g. i<(combined.Length - goal.Length))
        b. This compares characters from combined (starting at index i) with characters from goal.
        d. The inner loop runs for goal.Length iterations, checking each character of goal against the corresponding character in combined.
  e. If a character doesn’t match, the inner loop breaks, and we move to the next index in combined.
        f. If all characters match, the inner loop completes fully (j == goal.Length).
        g. If it is a substring then return true else false

*/

using System;

public class StringsRotationsOfEachOther
{
    public static void Main(string[] args)
    {
        string s = "abcde";
        string goal = "cdeab";

        bool result = checkRotation(s, goal);

        System.Console.WriteLine(result ? true : false);


    }

    static bool checkRotation(string s, string goal)
    {
        // Check if the lengths of the two strings are equal
        // If not, they cannot be rotations of each other
        if (s.Length != goal.Length)
        {
            return false;
        }

        // Concatenate the first string with itself
        string combined = s + s; //abcdeabcde

        // Check if the second string is a substring of the concatenated string
        for (int i = 0; i < (combined.Length - goal.Length); i++) //tray shiting
        {
            int j;
            for (j = 0; j < goal.Length; j++)
            {
                // Compare characters from combined (starting at index i) with characters from goal
                if (combined[i + j] != goal[j])
                {
                    break;
                }
            }
            //Logic-> **********************************
            // combined="abcdeabcde"
            // goal="cdeab"

            //i = 0 => combined[0] = 'a'   vs  goal[0] = 'c'  => break

            // i = 1 => combined[1] = 'b'   vs  goal[0] = 'c'  => break

            // i = 2
            //     j = 0 => combined[2] = 'c' vs goal[0] = 'c' => match
            //     j = 1 => combined[3] = 'd' vs goal[1] = 'd' => match
            //     j = 2 => combined[4] = 'e' vs goal[2] = 'e' => match
            //     j = 3 => combined[5] = 'a' vs goal[3] = 'a' => match
            //     j = 4 => combined[6] = 'b' vs goal[4] = 'b' => match
            //     Full match → return true
            //*****************************************
                
            // If we have completed the inner loop, it means all characters of goal matched combined starting at position i
            // If j equals the length of goal, it means we found a match
            if (goal.Length == j)
            {
                return true;
            }

        }
        return false;

    }
}
//true
