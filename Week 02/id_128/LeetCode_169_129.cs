//hash
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        var map = new Dictionary<int, int>(nums.Length);
        foreach (var i in nums)
        {
            if (!map.ContainsKey(i)) map[i] = 0;
            map[i]++;
        }
        foreach (var item in map)
        {
            if (item.Value > nums.Length / 2)
                return item.Key;
        }
        throw new Exception();
    }
}


//Boyor-Moore vote
public class Solution
{
    public int MajorityElement(int[] nums)
    {
        int count = 1;
        int majority = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (count <= 0)
            {
                majority = nums[i];
                count = 1;
            }
            else if (nums[i] != majority)
                count--;
            else
                count++;
        }
        return majority;
    }
}