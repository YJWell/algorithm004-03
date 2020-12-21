
public class Solution
{
    public void MergeSort(int[] array)
    {
        if (array.Length < 2) return;
        MergeSort(array, 0, array.Length - 1);
    }

    private void MergeSort(int[] array, int start, int end)
    {
        if (start >= end) return;
        int mid = start + (end - start) / 2;

        MergeSort(array, start, mid);
        MergeSort(array, mid + 1, end);
        Merge(array, start, mid, end);
    }

    private void Merge(int[] array, int start, int mid, int end)
    {
        int[] temp = new int[end - start + 1];
        int i = start;
        int j = mid + 1;
        int k = 0;
        while (i <= mid && j <= end)
        {
            temp[k++] = array[i] < array[j] ? array[i++] : array[j++];
        }

        while (i <= mid) temp[k++] = array[i++];
        while (j <= end) temp[k++] = array[j++];
        for (int l = 0; l < temp.Length; l++)
        {
            array[start + l] = temp[l];
        }

    }
}

