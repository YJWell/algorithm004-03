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


