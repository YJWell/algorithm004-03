public class Solution
{
    public int FirstUniqChar(String s)
    {
        Dictionary<char, int> count = new Dictionary<char, int>();
        int n = s.Length;
        for (int i = 0; i < n; i++)
        {
            char c = s[i];
            if (!count.ContainsKey(c))
                count[c] = 0;
            count[c]++;
        }

        for (int i = 0; i < n; i++)
        {
            if (count[s[i]] == 1)
            {
                return i;
            }
        }
        return -1;
    }
}

public class Solution
{
    public int FirstUniqChar(string s)
    {
        if (string.IsNullOrEmpty(s)) return -1;

        var bucket = new int[26];
        foreach (var c in s)
        {
            bucket[c - 'a']++;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (bucket[s[i] - 'a'] == 1)
                return i;
        }
        return -1;

    }
}