/*
 * @lc app=leetcode id=1122 lang=csharp
 *
 * [1122] Relative Sort Array
 */

// @lc code=start
public class Solution
{
    public int[] RelativeSortArray(int[] arr1, int[] arr2)
    {
        int[] bucket = new int[1001];

        for (int i = 0; i < arr1.Length; i++)
        {
            bucket[arr1[i]]++;
        }

        int k = 0;
        for (int j = 0; j < arr2.Length; j++)
        {
            while (bucket[arr2[j]]-- > 0)
            {
                arr1[k++] = arr2[j];
            }
        }

        for (int l = 0; l < bucket.Length; l++)
        {
            while (bucket[l]-- > 0)
            {
                arr1[k++] = l;
            }
        }
        return arr1;
    }
}
// @lc code=end

