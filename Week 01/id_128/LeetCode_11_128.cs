
//Double pointers
public class Solution
{
    public int MaxArea(int[] height)
    {
        if (height.Length < 2) return 0;

        int left = 0;
        int right = height.Length - 1;

        int maxArea = 0;
        while (left < right)
        {
            if (height[left] < height[right])
            {
                maxArea = Math.Max(maxArea, height[left] * (right - left));
                left++;
            }
            else
            {
                maxArea = Math.Max(maxArea, height[right] * (right - left));
                right--;
            }
        }
        return maxArea;
    }
}