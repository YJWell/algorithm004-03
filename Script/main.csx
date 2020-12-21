
public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (s.Length <= 1) return true;

        int start = 0;
        int end = s.Length - 1;
        while (start < end)
        {
            while (!Char.IsLetterOrDigit(s[start]))
                start++;
            while (!Char.IsLetterOrDigit(s[end]))
                end--;

            if (s[start] != s[end])
                return false;
            start++;
            end--;
        }
        return true;
    }

    public bool IsPowerOfFour(int num)
    {
        if (num <= 0) return false;

        var b = Math.Sqrt(num);
        var c = (int)b;

        if (c == b)
            return (c & (-c)) == c;
        return false;

    }

    public bool IsPowerOfThree(int n)
    {

        if (n <= 0) return false;
        var cache = new List<int>(30);
        var max = Cache(cache);
        return max % n == 0;
    }

    private int Cache(IList<int> cache)
    {
        cache.Add(1);
        for (int i = 1; i < 32; i++)
        {
            var x = cache[i - 1] * 3;
            if (x > 0 && x <= Int32.MaxValue)
                cache.Add(x);
            else
                return cache[i - 1];
        }
        return cache[31];
    }

    public IList<int> FindDuplicates(int[] nums)
    {
        List<int> res = new List<int>();
        int len = nums.Length;
        if (len == 0)
        {
            return res;
        }
        for (int i = 0; i < len; i++)
        {
            while (nums[nums[i] - 1] != nums[i])
            {
                Swap(nums, i, nums[i] - 1);
            }
        }
        for (int i = 0; i < len; i++)
        {
            if (nums[i] - 1 != i)
            {
                res.Add(nums[i]);
            }
        }
        return res;
    }

    private void Swap(int[] nums, int index1, int index2)
    {
        if (index1 == index2)
        {
            return;
        }
        nums[index1] = nums[index1] ^ nums[index2];
        nums[index2] = nums[index1] ^ nums[index2];
        nums[index1] = nums[index1] ^ nums[index2];
    }

    public List<int> FindDuplicates2(int[] nums)
    {
        List<int> result = new List<int>();
        if (nums.Length == 0)
        {
            return result;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            int index;
            index = Math.Abs(nums[i]) - 1;
            if (nums[index] < 0)
            {
                result.Add(Math.Abs(nums[i]));  //为啥是绝对值？防止nums[i]的值为负数
            }
            else
            {
                nums[index] = -nums[index];
            }
        }
        return result;
    }

    public IList<int> FindDuplicates3(int[] nums)
    {
        int n = nums.Length;
        var ans = new HashSet<int>();

        if (n <= 1) return ans.ToArray();

        for (int i = 0; i < n; i++)
        {

            while (true)
            {
                var idx = nums[i] - 1;
                if (nums[idx] != nums[i])
                    Swap(nums, idx, i);
                else
                {
                    if (i + 1 != nums[i])
                        ans.Add(nums[i]);
                    break;
                }
            }

        }

        return ans.ToArray();

    }



}

public class WordDictionary
{
    public class TrieNode
    {
        public TrieNode[] children = new TrieNode[26];
        public bool isWord;
    }

    private TrieNode root = new TrieNode();

    public void AddWord(String word)
    {
        TrieNode node = root;
        foreach (char c in word.ToCharArray())
        {
            if (node.children[c - 'a'] == null)
            {
                node.children[c - 'a'] = new TrieNode();
            }
            node = node.children[c - 'a'];
        }
        node.isWord = true;
    }

    public bool Search(String word)
    {
        return Match(word.ToCharArray(), 0, root);
    }

    private bool Match(char[] chs, int k, TrieNode node)
    {
        if (k == chs.Length) return node.isWord;
        if (chs[k] != '.')
        {
            return node.children[chs[k] - 'a'] != null && Match(chs, k + 1, node.children[chs[k] - 'a']);
        }
        else
        {
            for (int i = 0; i < node.children.Length; i++)
            {
                if (node.children[i] != null)
                {
                    if (Match(chs, k + 1, node.children[i]))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}


var sol = new Solution();

// var input = new List<int> { 4, 3, 2, 7, 8, 2, 3, 1 }.ToArray();
// sol.FindDuplicates(input);
var input = new List<int> { 4, 3, 2, 7, 8, 2, 3, 1 }.ToArray();
sol.FindDuplicates3(input);
// var input = "A man a plan a ca nalP a nam a";
// var result = sol.IsPalindrome(input);

// var input = 27;
// var result = sol.IsPowerOfThree(input);

// Console.WriteLine(result);


// var addWords = new string[] { "bad", "dad", "mad" };
// var searchWords = new string[] { ".ad", "b.." };
// WordDictionary obj = new WordDictionary();
// foreach (var word in addWords)
//     obj.AddWord(word);
// foreach (var word in searchWords)
// {
//     bool param_2 = obj.Search(word);
//     Console.WriteLine(param_2);
// }