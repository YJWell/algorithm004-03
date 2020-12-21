/*
 * @lc app=leetcode id=387 lang=csharp
 *
 * [387] First Unique Character in a String
 */

// @lc code=start
public class Solution
{
    public int FirstUniqChar(string s)
    {
        if (string.IsNullOrEmpty(s)) return -1;

        var bucket = new int[26];
        foreach (var c in s)
        {
            bucket[c - 'a']++;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (bucket[s[i] - 'a'] == 1)
                return i;
        }
        return -1;

    }
}
// @lc code=end

