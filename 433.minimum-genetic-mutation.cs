/*
 * @lc app=leetcode id=433 lang=csharp
 *
 * [433] Minimum Genetic Mutation
 */

// @lc code=start
using System.Collections.Generic;
public class Solution
{
    public int MinMutation(string start, string end, string[] bank)
    {
        if (start.equals(end)) return 0;

        var bankSet = new HashSet<string>();
        foreach (var gene in bank)
        {
            bankSet.Add(gene);
        }

        char[] charSet = new char[] { 'A', 'C', 'G', 'T' };
        int level = 0;

        var visited = new HashSet<String>();
        var queue = new Queue<string>();

        queue.Enqueue(start);
        visited.Add(start);

        while (queue.Count() > 0)
        {
            int size = queue.Count();
            while (size-- > 0)
            {
                string curr = queue.Dequeue();
                if (curr.Equals(end)) return level;
                var currArray = curr.toCharArray();
                for (int i = 0; i < currArray.Length; i++)
                {
                    char old = currArray[i];
                    foreach (char c in charSet)
                    {
                        currArray[i] = c;
                        String next = new tring(currArray);
                    }
                }
            }
        }
    }
// @lc code=end

