/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length < 2)
        {
            return nums.Length;
        }
        int i = 0;
        for (int j = 1; j < nums.Length; j++)
        {
            if (nums[i] != nums[j] && i++ < j - 1)
            {
                nums[i] = nums[j];
            }
        }
        return i + 1;
    }
}
// @lc code=end

