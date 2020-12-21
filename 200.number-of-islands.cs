/*
 * @lc app=leetcode id=200 lang=csharp
 *
 * [200] Number of Islands
 */

// @lc code=start
public class Solution
{
    public int NumIslands(char[][] grid)
    {

        var num = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (TrySinkIsland(i, j, grid))
                    num++;
            }
        }
        return num;
    }

    private bool TrySinkIsland(int a, int b, char[][] grid)
    {
        if (grid[a][b] == '0')
            return false;
        var queue = new Queue<Tuple<int, int>>();
        queue.Enqueue(new Tuple<int, int>(a, b));
        grid[a][b] = '0';

        while (queue.Count() > 0)
        {
            var spot = queue.Dequeue();
            var i = spot.Item1;
            var j = spot.Item2;
            if (i + 1 < grid.Length)
            {
                queue.Enqueue(new Tuple<int, int>(i + 1, j));
                grid[i + 1][j] = '0';
            }
            if (i >= 1)
            {
                queue.Enqueue(new Tuple<int, int>(i - 1, j));
                grid[i - 1][j] = '0';
            }
            if (j + 1 < grid[i].Length)
            {
                queue.Enqueue(new Tuple<int, int>(i, j + 1));
                grid[i][j + 1] = '0';
            }
            if (j >= 1)
            {
                queue.Enqueue(new Tuple<int, int>(i, j - 1));
                grid[i][j - 1] = '0';
            }

        }
        return true;
    }
}
// @lc code=end

