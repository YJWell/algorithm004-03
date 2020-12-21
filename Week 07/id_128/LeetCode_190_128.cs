public class Solution
{
    public uint reverseBits(uint n)
    {
        uint result = 0;
        for (int i = 0; i < 32; i++)
        {
            var bit = (n >> i) & 1;
            result |= bit << (31 - i);
        }
        return result;
    }
}


public class Solution
{
    public uint reverseBits(uint n)
    {
        uint result = 0;
        for (int i = 0; i < 31; i++)
        {
            result |= (n & 1);
            n >>= 1;
            result <<= 1;
        }
        return result | (n & 1);
    }
}



