//brute force
public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        if (heights.Length == 0) return 0;
        if (heights.Length == 1) return heights[0];

        var maxArea = Int32.MinValue;
        var stack = new Stack<int>();
        for (int i = 0; i < heights.Length; i++)
        {
            var height = heights[i];
            for (int j = i; j < heights.Length; j++)
            {
                var width = (j - i + 1);
                height = Math.Min(heights[j], height);
                maxArea = Math.Max(width * height, maxArea);
            }
        }
        return maxArea;
    }
}

//stack  -- very tricky -- need repeat
public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {

        var maxArea = 0;
        var stack = new Stack<int>();
        stack.Push(-1);
        for (int i = 0; i < heights.Length; i++)
        {

            while (stack.Peek() != -1 && heights[i] < heights[stack.Peek()])
            {
                var height = heights[stack.Pop()];
                maxArea = Math.Max(maxArea, height * (i - stack.Peek() - 1));
            }
            stack.Push(i);

        }

        while (stack.Peek() != -1)
        {
            var height = heights[stack.Pop()];
            maxArea = Math.Max(maxArea, height * (heights.Length - stack.Peek() - 1));
        }

        return maxArea;
    }
}


