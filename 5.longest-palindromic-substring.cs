/*
 * @lc app=leetcode id=5 lang=csharp
 *
 * [5] Longest Palindromic Substring
 */

// @lc code=start
public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (s.Length < 2) return s;

        int maxL = 0;
        int start = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int l = ExpandFromCenter(s, i, i);
            int ll = ExpandFromCenter(s, i, i + 1);
            var temp = Math.Max(l, ll);

            if (temp > maxL)
            {
                maxL = temp;
                start = i - (temp - 1) / 2;
            }
        }
        return s.Substring(start, maxL);
    }
}
// @lc code=end
// caba
// 0123
// cabba
// 01234