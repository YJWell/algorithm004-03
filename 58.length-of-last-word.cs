/*
 * @lc app=leetcode id=58 lang=csharp
 *
 * [58] Length of Last Word
 */

// @lc code=start
public class Solution
{
    public int LengthOfLastWord(string s)
    {

        int len = s.Length;
        if (len <= 0)
        {
            return 0;
        }
        while (len > 0 && s[len - 1] == ' ')
            len--;

        int i = len - 1;
        int count = 0;
        while (i >= 0)
        {
            if (s[i--] != ' ')
                count++;
            else
                break;
        }
        return count;
    }
}
// @lc code=end

