using System;

namespace DSA
{
    static class CoinChangeWaysDP
    {
        static int CoinChangeWays(int[] coins, int amount)
        {
            int[,] dp = new int[coins.Length, amount + 1];

            // Base case: For amount 0, there is only one way to make the total - choose no coin
            for (int i = 0; i < coins.Length; i++)
            {
                dp[i, 0] = 1;
            }

            for (int i = 0; i < coins.Length; i++)
            {
                for (int j = 1; j <= amount; j++)
                {
                    // If the current coin value is greater than the amount, it can't be included and use the value above the row
                    if (coins[i] > j)
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                    else
                    {
                        // The total ways including the current coin is the sum of ways including it and excluding it
                        dp[i, j] = (i == 0 ? 0 : dp[i - 1, j]) + dp[i, j - coins[i]];
                    }
                }
            }

            // The result will be stored at dp[coins.Length - 1, amount]
            return dp[coins.Length - 1, amount];
        }

        static void Main()
        {
            int[] coins = { 1, 2, 5 }; 
            int amount = 5;

            int ways = CoinChangeWays(coins, amount);

            Console.WriteLine("Number of ways: " + ways);
        }
    }
}