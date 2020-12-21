/*
 * @lc app=leetcode id=88 lang=csharp
 *
 * [88] Merge Sorted Array
 */

// @lc code=start
public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int final = m-- + --n;
        while (m >= 0 && n >= 0)
        {
            nums1[final--] = nums1[m] < nums2[n] ? nums2[n--] : nums1[m--];
        }

        while (n >= 0)
        {
            nums1[final--] = nums2[n--];
        }
    }
}
// @lc code=end

