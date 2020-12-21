public class Solution
{
    public void BubbleSort(int[] array)
    {
        if (array.Length <= 1)
            return;

        for (int i = array.Length - 1; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[j] > array[j + 1])
                    Swap(array, j, j + 1);
            }
        }

    }

    private void Swap(int[] array, int i, int j)
    {
        var temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

