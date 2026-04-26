
    /*

        Problem:

        You are given a reduced fraction in the form n/d, where gcd(n, d) = 1 and n ≤ d. 
        You have to find the largest possible fraction that is strictly less than n/d, also 
        in reduced form (i.e., the numerator and denominator must be coprime), and where the 
        numerator is less than or equal to the denominator.  In case multiple such fractions exist, 
        the one with the highest possible fraction value (just below n/d) should be returned.

                Input: n = 1, d = 8
                Output: 1249 9993
                Explanation: 1/8 >= 1249/9993 and this is the largest fraction. 


            Given a fraction numerator/denominator, find the largest fraction p/q such that:

                - p/q < numerator/denominator
                - 1 <= q <= 10000
                - p and q are coprime (gcd(p, q) == 1)


        🔥 APPROACH:

        We need to find the largest fraction p/q such that p/q < n/d, gcd(p,q)=1, 1<=q<=10000.
        e.g. 1/8 > p/q
        so 1/8 = 0.125, 
        1249/9993 = 0.125000125
        0.125<=0.125000125  
        output: 1249/9993

         To find the largest fraction less than n/d, we can iterate over possible denominators q from 10000 down to 2 (since q must be at least 1 and we want to find the largest fraction, we start from the largest q). For each q, we calculate the maximum p such that p/q < n/d, which can be derived from the inequality:
        we need to find the largest fraction less than 0.125 with q <= 10000 and gcd(p,q)=1.

        From the inequality p/q < n/d, 
        cross multiply: p * d < n * q, 
        so p < (n * q) / d.      
        To get the largest valid p for each q: p = floor((n * q - 1) / d)

        Loop over q from 10000 down to 2:
        - Compute p as above
        - Check if gcd(p, q) == 1
        - To find the largest p/q, compare with current best: if p * current_deno > current_num * q, update to p/q

        This ensures we track the maximum fraction, and since we loop from large q to small, for equal values, we keep the one with smaller q.

        -------------------------------------

        🧠 EXAMPLE:

        Input:
            numerator = 1, denominator = 8
        Loop q from 10000 down to 2:
            For q = 9993:
                p = floor((1 * 9993 - 1) / 8) = floor(9992 / 8) = 1249
                Check gcd(1249, 9993) == 1 → True
                Compare with current best (0/1):
                    1249 * 1 > 0 * 9993 → True
                Update best fraction to 1249/9993
        Final Output:
            Largest Fraction less than 1/8 is:
            1249/9993

        -------------------------------------

        ⏱ TIME COMPLEXITY:
            O(N * log N)
            - Loop runs N times
            - gcd takes log N

        📦 SPACE COMPLEXITY:
            O(1)
        */

using System;
using System.Collections.Generic;

class Solution {
    public List<int> LargestFraction(int numerator, int denominator) {

        int num = 0;
        int deno = 1;

        for(int q = 10000; q > 1; q--) {

            int p = (numerator * q - 1) / denominator;

            // Check if fraction is valid and larger than current best
            if (gcd(p, q) == 1 && (num * q <= p * deno)) {
                num = p;
                deno = q;
            }
        }

        return new List<int> { num, deno };
    }

    private int gcd(int a, int b) {
        if (b == 0) return a;
        return gcd(b, a % b);
    }

    // ✅ MAIN METHOD
    public static void Main(string[] args) {

        Solution sol = new Solution();

        int numerator = 1;
        int denominator = 8;

        List<int> result = sol.LargestFraction(numerator, denominator);

        Console.WriteLine("Largest Fraction less than " + numerator + "/" + denominator + " is:");
        Console.WriteLine(result[0] + "/" + result[1]);
    }
}
/*
OUTPUT:
Largest Fraction less than 1/8 is:
1249/9993
*/
