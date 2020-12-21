/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
public class Solution
{
    public int MaxProfit(int[] prices)
    {
        if (prices.Length <= 1) return 0;

        var minPrice = prices[0];
        var maxProfit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            minPrice = Math.Min(minPrice, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
        }
    }
}
// @lc code=end


public class Solution
{
    public void MergeSort(int[] array)
    {
        if (array.Length <= 1)
            return;
        MergeSort(array, 0, array.Length - 1);
    }

    private void MergeSort(int[] array, int left, int right)
    {
        if (left >= right)
            return;
        var mid = left + ((right - left) >> 1);
        MergeSort(array, left, mid);
        MergeSort(array, mid + 1, right);
        MergeSort(array, left, mid, right);
    }

    private void Merge(int[] array, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        var i = left;
        var j = mid + 1;
        var k = 0;
        while (i <= mid && j <= right)
        {
            temp[k++] = array[i] <= array[j] ? array[i++] : array[j++];
        }
        while (i <= mid)
        {
            temp[k++] = array[i++];
        }
        while (j <= right)
        {
            temp[k++] = array[j++];
        }
        for (int l = 0; l < temp.Length; l++)
        {
            array[left + l] = temp[l];
        }
    }


}
