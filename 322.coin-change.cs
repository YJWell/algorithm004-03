/*
 * @lc app=leetcode id=322 lang=csharp
 *
 * [322] Coin Change
 */

// @lc code=start
//f(n) = f(n-coin)+1 coin in {coins}
using System.Collections.Generic;
public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        if (amount <= 0) return 0;
        if (coins.Length <= 0) return -1;

        var dp = new int[amount.Length] + 1;
        dp[0] = 0;

        for (int i = 1; i <= amount; i++)
        {
            dp[i] = Int32.MaxValue;
            foreach (var coin in coins) {
                if (coin <= i)
                    dp[i] = Math.Min(dp[i], dp[i-coin]);
            }
            dp[i] == Int32.MaxValue ? -1 : dp[i] + 1;
        }
        return dp[amount];
    }
}
// @lc code=end

