/*
 * @lc app=leetcode id=120 lang=csharp
 *
 * [120] Triangle
 */

// @lc code=start
public class Solution
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        if (triangle is null) return 0;
        if (triangle.Count() <= 0) return 0;
        if (triangle[0].Count() <= 0) return 0;

        for (int row = 1; row <triangle.Count() - 1; row++)
        {
            for (int col = 0; col < triangle[row].Count(); col++)
            {
                if (col == 0)
                    triangle[row][col] += triangle[row-1][col];
                else if (col = triangle[row].Count()-1)
                    triangle[row][col] += triangle[row-1][col-1];
                else
                    triangle[row][col] += Math.Min(triangle[row-1][col], triangle[row-1][col-1]);
            }
        }

        var res = Int32.MinValue;
        foreach (var i in triangle[triangle.Count()-1]) {
            res = i > res ? i : res;
        }
        return res;
    }
}
// @lc code=end

