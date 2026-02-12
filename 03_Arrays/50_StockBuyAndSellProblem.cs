/*
Stock Buy And Sell Problem -> 


E.g. 1
arr[] = {1, 5, 3, 8,12}
output -> 13 -> 1-5= 4 profit, 3-12= 9 profit hence 4+9=13 profit

E.g. 2
arr[] = {30, 20, 10}
output -> 0 -> because array is in descreasing order hence if you buy on 30 rupees you will end up with no profit

E.g. 3
arr[] = {10, 20, 30}
output -> 20 -> because array is in increasing order hence you will buy it on 1st day and sell it on last day so you will get max profit

Approach of this code:
----------------------------------
We are given an array where each element represents the price of a stock on a given day.
The goal is to calculate the maximum profit if we are allowed to buy and sell multiple times.
Rule: We can buy and sell many times, but must sell before buying again.

Idea:
- If the price of the stock goes up the next day, we consider that as profit.
- So we add (today's price - yesterday's price) to the total profit.
- This way we capture all possible upward movements in stock prices.
*/
using System;

public class StockBuyAndSellProblem
{
    public static void Main(string[] args)
    {

        // Array of stock prices for each day
        int[] price = { 1, 5, 3, 8, 12 };

        // Variable to store total profit
        int profit = 0;

        // Loop from the 2nd day (index 1) to the last day
        for (int i = 1; i < price.Length; i++)
        {
            // If today's price is greater than yesterday's price
            if (price[i] > price[i - 1])
            {
                // Add the difference to profit (this means we "buy yesterday, sell today")
                profit = profit + (price[i] - price[i - 1]);
            }
        }

        // Print the total maximum profit
        System.Console.WriteLine("Max Profit is: " + profit);


        /*
        Dry Run of the loop:
        ---------------------------------
        price = {1, 5, 3, 8, 12}
        profit = 0

        i = 1 → price[1]=5, price[0]=1 → 5 > 1 → profit = 0 + (5-1) = 4
        i = 2 → price[2]=3, price[1]=5 → 3 > 5? No → profit = 4
        i = 3 → price[3]=8, price[2]=3 → 8 > 3 → profit = 4 + (8-3) = 9
        i = 4 → price[4]=12, price[3]=8 → 12 > 8 → profit = 9 + (12-8) = 13

        Final profit = 13
        ---------------------------------
        Output:
        Max Profit is: 13
        */
    }
}
/*
Output:
        Max Profit is: 13

*/
