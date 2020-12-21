
public class Solution
{
    public void InsertionSort(int[] array)
    {
        if (array.Length < 2) return;
        for (int i = 1; i < array.Length; i++)
        {
            int curValue = array[i];
            int preIdx = i - 1;
            while (array[preIdx] > curValue && preIdx > -1)
            {
                array[preIdx + 1] = array[preIdx];
                preIdx--;
            }
            array[preIdx + 1] = curValue;
        }
    }
}

public class Solution
{
    public void InsertionSort(int[] array)
    {
        if (array.Length < 2) return;

        for (int i = 1; i < array.Length; i++)
        {

            int curVal = array[i];
            int curIdx = i;

            while (curVal < array[curIdx - 1] && curIdx > 0)
            {
                array[curIdx] = array[curIdx - 1];
                curIdx--;
            }
            array[curIdx] = curVal;
        }
    }
}