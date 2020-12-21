/*
 * @lc app=leetcode id=62 lang=csharp
 *
 * [62] Unique Paths
 */

// @lc code=start

//dp[m][n] =  dp[m+1][n] + dp[m][n+1];
//
public class Solution
{
    public int UniquePaths(int m, int n)
    {
        if (m <= 0 || n <= 0) return 0;
        if (m == 1 || n == 1) return 1;
        var opt = new int[m];

        for (int i = 0; i < m; i++)
            opt[i] = 1;

        for (int j = 1; j < n; j++)
        {
            for (int i = 1; i < m; i++)
            {
                opt[i] = opt[i - 1] + opt[i - 2];
            }
        }
        return opt[m - 1, n - 1];
    }

}
// @lc code=end

