
public class Solution
{
    public void SelectionSort(int[] array)
    {
        if (array.Length <= 1)
            return;

        for (int i = 0; i < array.Length - 1; i++)
        {
            var min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                    min = j;
            }
            Swap(array, i, min);
        }
    }

    private void Swap(int[] array, int i, int j)
    {
        var temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

