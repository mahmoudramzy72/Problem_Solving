using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Transactions;

namespace PS_Leetcode
{
    internal class Best_Time_To_Buy_And_Sell_Stock
    {
        // You are given an array prices where prices[i] is the price of a given stock on the ith day.
        // You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
        // Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
        public static void Run()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int result = MaxProfit(prices);
            Console.WriteLine($"Max Profit Is {result}");
        }

        public static int MaxProfit(int[] prices)
        {
            if(prices == null || prices.Length == 0) return 0;

            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for(int i = 0; i < prices.Length; i++)
            {
                if(prices[i] < minPrice)
                    minPrice = prices[i];
                else
                {
                    int profit = prices[i] - minPrice;

                    if(profit > maxProfit)
                        maxProfit = profit;
                    
                }
            }
            return maxProfit;
        }
    }
}
