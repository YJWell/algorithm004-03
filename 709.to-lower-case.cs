/*
 * @lc app=leetcode id=709 lang=csharp
 *
 * [709] To Lower Case
 */

// @lc code=start
public class Solution
{
    public string ToLowerCase(string str)
    {

        var ret = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 'A' && str[i] <= 'Z')
            {
                ret[i] = (char)(str[i] + 32);
            }
            else
            {
                ret[i] = str[i];
            }
        }
        return new string(ret);
    }
}


public class Solution
{
    public string ToLowerCase(string str)
    {

        var ret = new char[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 'A' && str[i] <= 'Z')
            {
                ret = str[i] | 32;
            }
            else
            {
                ret[i] = str[i];
            }
        }
        return new string(ret);
    }
}
// @lc code=end

