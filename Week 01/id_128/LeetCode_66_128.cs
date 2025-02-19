class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int len = digits.Length;
        for (int i = len - 1; i >= 0; i--)
        {
            digits[i]++;
            digits[i] %= 10;
            if (digits[i] != 0)
                return digits;
        }
        digits = new int[len + 1];
        digits[0] = 1;
        return digits;
    }
}

