public class Solution
{
    public void QuickSort(int[] array)
    {
        if (array.Length <= 1)
            return;
        QuickSort(array, 0, array.Length - 1);
    }

    private void QuickSort(int[] array, int left, int right)
    {
        if (left >= right)
            return;
        int pivot = Partition(array, left, right);
        QuickSort(array, left, pivot - 1);
        QuickSort(array, pivot + 1, right);
    }
    private void Partition(int[] array, int left, int right)
    {
        var pivot = right;
        var j = left; //point to the first element larger than pivot

        for (int i = left; i < right; i++)
        {
            if (array[i] < array[pivot])
            {
                Swap(array, i, j);
                j++;
            }
        }

        Swap(array, pivot, j);
        return j;
    }

    private void Swap(int[] array, int i, int j)
    {
        var temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

